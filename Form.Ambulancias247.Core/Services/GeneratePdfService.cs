using Form.Ambulancias247.Core.Interfaces;
using Microsoft.Playwright;

namespace Form.Ambulancias247.Core.Services;

public class GeneratePdfService: IGeneratePdfService
{   
    public async Task<byte[]> GenerarPdfAsync(string html)
    {
        try
        {
            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = true,
                    // Required to launch Chromium inside a container (runs as root,
                    // and containers have a small /dev/shm by default).
                    Args = new[] { "--no-sandbox", "--disable-dev-shm-usage" }
                });

            var page = await browser.NewPageAsync();

            await page.SetContentAsync(html);

            var pdf = await page.PdfAsync(new PagePdfOptions
            {
                Format = "A4",
                PrintBackground = true
            });

            return pdf;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}