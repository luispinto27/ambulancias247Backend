using Form.Ambulancias247.Core.Builder;
using Form.Ambulancias247.Core.Interfaces;
using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Facade;

public class GeneratePdfFacade(IGeneratePdfService generatePdfService) : IGeneratePdfFacade
{
    private readonly IGeneratePdfService _generatePdfService = generatePdfService;

    public async Task<byte[]> GeneratePdfAsync(InfoFormTransferDto infoFormTransferDto)
    {
        ValidarDto(infoFormTransferDto);
        var html = HtmlBuilder.Build(infoFormTransferDto);
        return await _generatePdfService.GenerarPdfAsync(html);
    }


    private void ValidarDto(InfoFormTransferDto infoFormTransferDto)
    {
        if (infoFormTransferDto.Traslado == null)
            throw new Exception("Debe existir la informacion de traslado");
        
        if (infoFormTransferDto.Paciente == null)
            throw new Exception("Debe existir la informacion de paciente");

        if (infoFormTransferDto.Antecedentes == null)
            throw new Exception("Debe existir la informacion de antecedentes");
        
        if (infoFormTransferDto.Signos == null)
            throw new Exception("Debe existir la informacion de signos");
        
        if (infoFormTransferDto.Gastos == null)
            throw new Exception("Debe existir la informacion de registro gastos");
        
        if (infoFormTransferDto.Conducta == null)
            throw new Exception("Debe existir la informacion de conducta");
        
        if (infoFormTransferDto.Firmas == null)
            throw new Exception("Debe existir la informacion de firmas");
    }
}