using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class AntecedentesSection
{
    public static string Render(AntecedentesDto a) => $"""
       <h2>Antecedentes</h2>
       <table>
         <tr>
           <td>{Check(a.Acv)} ACV</td><td>{Check(a.Alergia)} Alergia</td><td>{Check(a.Asma)} Asma</td>
           <td>{Check(a.Cancer)} Cáncer</td><td>{Check(a.Diabetes)} Diabetes</td>
         </tr>
         <tr>
           <td>{Check(a.Cardiacos)} Cardíacos</td><td>{Check(a.Epoc)} EPOC</td>
           <td>{Check(a.FallaRenal)} Falla renal</td><td>{Check(a.Hipertension)} HTA</td>
           <td>{Check(a.Quirurgicos)} Quirúrgicos</td>
         </tr>
       </table>
       <p><strong>DX Principal:</strong> {a.DxPrincipal}</p>
       """;

    private static string Check(bool v) => v ? "✔" : "☐";
}
