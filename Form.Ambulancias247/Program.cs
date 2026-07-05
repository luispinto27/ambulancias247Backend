using Form.Ambulancias247.Application;
using Microsoft.AspNetCore.HttpOverrides;
using PuppeteerSharp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Honor X-Forwarded-Proto/For from Fly's TLS-terminating edge proxy.
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownNetworks.Clear();
    options.KnownProxies.Clear();
});

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularPolicy", policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:4200",                    // Angular (local dev)
                "https://trasladosambulancias247.lat",      // Production (apex)
                "https://www.trasladosambulancias247.lat")  // Production (www)
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();

var app = builder.Build();

app.UseForwardedHeaders();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Note: no UseHttpsRedirection() here. Fly terminates TLS at its edge and
// forwards to the container over plain HTTP (force_https = true in fly.toml),
// so an in-container HTTPS redirect only 307s the CORS preflight and breaks it.

app.UseCors("AngularPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();