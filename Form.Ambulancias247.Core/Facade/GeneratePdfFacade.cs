using Form.Ambulancias247.Core.Builder;
using Form.Ambulancias247.Core.Interfaces;
using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Facade;

public class GeneratePdfFacade(IGeneratePdfService generatePdfService) : IGeneratePdfFacade
{
    private readonly IGeneratePdfService _generatePdfService = generatePdfService;

    public async Task<byte[]> GeneratePdfAsync(InfoFormTransferDto infoFormTransferDto)
    {
        var html = HtmlBuilder.Build(infoFormTransferDto);
        return await _generatePdfService.GenerarPdfAsync(html);
    }
}