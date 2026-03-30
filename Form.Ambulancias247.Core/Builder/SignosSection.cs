using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class SignosSection
{
    public static string Render(List<SignoVitalDto> list)
    {
        var rows = string.Join("", list.Select(s => $"""
                                                     <tr>
                                                       <td>{s.Hora}</td><td>{s.Ta}</td><td>{s.Fc}</td><td>{s.Fr}</td>
                                                       <td>{s.Temperatura}</td><td>{s.Spo2}</td><td>{s.Glasgow}</td><td>{s.DxSecundario}</td>
                                                     </tr>
                                                     """));

        return $"""
                <h2>Signos Vitales</h2>
                <table>
                  <tr>
                    <th>Hora</th><th>TA</th><th>FC</th><th>FR</th>
                    <th>T°</th><th>SpO2</th><th>Glasgow</th><th>Dx Secundario</th>
                  </tr>
                  {rows}
                </table>
                """;
    }
}
