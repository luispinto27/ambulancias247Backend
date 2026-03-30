namespace Form.Ambulancias247.Domain.Dto;

public class ExamenFisicoDto
{
    public bool Cabeza { get; set; }
    public bool Ojos { get; set; }
    public bool Orl { get; set; }
    public bool Cuello { get; set; }
    public bool Cardiovascular { get; set; }
    public bool Pulmonar { get; set; }
    public bool Abdomen { get; set; }
    public bool Gastrointestinal { get; set; }
    public bool Genitourinario { get; set; }
    public bool Extremidades { get; set; }
    public bool Neurologico { get; set; }
    public bool Psiquiatrico { get; set; }
    public string? Descripcion { get; set; }
}