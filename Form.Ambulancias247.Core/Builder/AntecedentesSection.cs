using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class AntecedentesSection
{
    public static string Render(AntecedentesDto a) => $"""
       <h2>Antecedentes</h2>
       <table>
         <tr>
           <td>{Check(a.Acv)} ACV</td><td>{Check(a.Alergia)} Alergia</td><td>{Check(a.Artritis)} Artritis</td>
           <td>{Check(a.Asma)} Asma</td><td>{Check(a.Cancer)} Cáncer</td><td>{Check(a.Cardiacos)} Cardiacos</td>
           <td>{Check(a.Dislipidemia)} Dislipidemia</td><td>{Check(a.Epoc)} EPOC</td>
         </tr>
         <tr>
           <td>{Check(a.FallaRenal)} Falla renal</td><td>{Check(a.Diabetes)} Diabetes</td>
           <td>{Check(a.GinecoObstetricos)} Gineco-Obstétricos</td><td>{Check(a.Hipertension)} Hipertensión</td>
           <td>{Check(a.Quirurgicos)} Quirúrgicos</td><td>{Check(a.Psiquiatricos)} Psiquiátricos</td>
           <td>{Check(a.Otros)} Otros</td>
         </tr>
       </table>
       <p><strong>DX Principal:</strong> {a.DxPrincipal}</p>
       """;

    private static string Check(bool v) => v ? "✔" : "☐";
}
