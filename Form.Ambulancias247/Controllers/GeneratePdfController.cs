using Form.Ambulancias247.Core.Interfaces;
using Form.Ambulancias247.Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Form.Ambulancias247.Controllers;


[Route("api/[controller]")]
[ApiController]
public class GeneratePdfController(IGeneratePdfFacade generatePdfFacade) : ControllerBase
{
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [HttpPost]
    [Route("generatePdf")]
    public async Task<IActionResult> GeneratePdf([FromBody] InfoFormTransferDto infoFormTransferDto)
    {
        try
        {
            try
            {
                var pdfBytes = await generatePdfFacade.GeneratePdfAsync(infoFormTransferDto);
                return File(pdfBytes, "application/pdf", $"Traslado_{infoFormTransferDto!.Traslado!.AutorizacionNumero}_{DateTime.Now:yyyyMMdd}.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error ocurred.");
        }
    }
}