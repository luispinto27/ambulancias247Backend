namespace Form.Ambulancias247.Core.Interfaces;

public interface IGeneratePdfService
{
    Task<byte[]> GenerarPdfAsync(string html);
}