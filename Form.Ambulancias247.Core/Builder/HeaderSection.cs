using System.Reflection;

namespace Form.Ambulancias247.Core.Builder;

public static class HeaderSection
{
    private static readonly Lazy<string> _logoBase64 = new(() =>
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = assembly.GetManifestResourceNames()
            .FirstOrDefault(n => n.EndsWith("logo.png", StringComparison.OrdinalIgnoreCase));

        if (resourceName is null)
            return string.Empty;

        using var stream = assembly.GetManifestResourceStream(resourceName)!;
        using var ms = new MemoryStream();
        stream.CopyTo(ms);
        return Convert.ToBase64String(ms.ToArray());
    });

    public static string Render()
    {
        var src = _logoBase64.Value.Length > 0
            ? $"data:image/png;base64,{_logoBase64.Value}"
            : string.Empty;

        var imgTag = src.Length > 0
            ? $"""<img src="{src}" alt="Logo Ambulancias 247" style="height:80px;" />"""
            : string.Empty;

        return $"""
                <div style="display:flex; align-items:center; justify-content:center; gap:16px; margin-bottom:12px; border-bottom:2px solid #ccc; padding-bottom:12px;">
                  {imgTag}
                  <div style="text-align:center;">
                    <div style="font-size:18px; font-weight:bold; color:#1a1a2e;">Registro de Traslados</div>
                    <div style="font-size:13px; color:#555;">Ambulancias Contacto 247 S.A.S</div>
                  </div>
                </div>
                """;
    }
}
