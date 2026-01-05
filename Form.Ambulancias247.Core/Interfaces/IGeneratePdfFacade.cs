using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Interfaces;

public interface IGeneratePdfFacade
{
    Task<byte[]> GeneratePdfAsync(InfoFormTransferDto infoFormTransferDto);
}