namespace Form.Ambulancias247.Domain.Dto;

public class InfoFormTransferDto
{
    public TrasladoDto Traslado { get; set; }
    public PacienteDto Paciente { get; set; }
    public AntecedentesDto Antecedentes { get; set; }
    public List<SignoVitalDto> Signos { get; set; }
    public ExamenFisicoDto Examen { get; set; }
    public List<GastoDto> Gastos { get; set; }
    public bool EstadoEntrega { get; set; }
    public FirmasDto Firmas { get; set; }
}