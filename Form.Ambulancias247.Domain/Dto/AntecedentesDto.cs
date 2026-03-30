namespace Form.Ambulancias247.Domain.Dto;

public class AntecedentesDto
{
    public bool Acv { get; set; }
    public bool Alergia { get; set; }
    public bool Artritis { get; set; }
    public bool Asma { get; set; }
    public bool Cancer { get; set; }
    public bool Cardiacos { get; set; }
    public bool Dislipidemia { get; set; }
    public bool Epoc { get; set; }
    public bool FallaRenal { get; set; }
    public bool Diabetes { get; set; }
    public bool GinecoObstetricos { get; set; }
    public bool Hipertension { get; set; }
    public bool Quirurgicos { get; set; }
    public bool Psiquiatricos { get; set; }
    public bool Otros { get; set; }

    public string? DxPrincipal { get; set; }
}