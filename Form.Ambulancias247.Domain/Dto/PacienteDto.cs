namespace Form.Ambulancias247.Domain.Dto;

public class PacienteDto
{
    public string? NombreCompleto { get; set; }
    public string? TipoDocumento { get; set; }
    public string? NumeroDocumento { get; set; }
    public string? Sexo { get; set; }
    public int? Edad { get; set; }
    public string? Direccion { get; set; }
    public string? Barrio { get; set; }
    public string? Ciudad { get; set; }
    public string? Telefono { get; set; }
    public string? MotivoTraslado { get; set; }
    public string? Tratamiento { get; set; }
}