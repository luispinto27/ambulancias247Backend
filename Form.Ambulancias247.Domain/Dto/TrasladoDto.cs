namespace Form.Ambulancias247.Domain.Dto;

public class TrasladoDto
{
    public DateTime Fecha { get; set; }
    public string? Entidad { get; set; }
    public string? AutorizadoPor { get; set; }
    public string? AutorizacionNumero { get; set; }
    public string? Movil { get; set; }
    public string? Tipo { get; set; }
    public string? Origen { get; set; }
    public string? HoraInicio { get; set; }
    public string? Destino { get; set; }
    public string? HoraFin { get; set; }
    public bool Retorno { get; set; }
    public bool TrasladoFallido { get; set; }
}