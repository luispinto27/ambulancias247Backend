namespace Form.Ambulancias247.Domain.Dto;

public class SignoVitalDto
{
    public string Hora { get; set; }
    public string Ta { get; set; }
    public int Fc { get; set; }
    public int Fr { get; set; }
    public decimal? Temperatura { get; set; }
    public int Glicemia { get; set; }
    public int Spo2 { get; set; }
    public int Glasgow { get; set; }
    public string DxSecundario { get; set; }
}