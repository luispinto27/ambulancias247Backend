using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class ExamenSection
{
    public static string Render(ExamenFisicoDto e) => $"""
                                                       <h2>Examen Físico</h2>
                                                       <table>
                                                         <tr>
                                                           <td>{Check(e.Cabeza)} Cabeza</td><td>{Check(e.Ojos)} Ojos</td>
                                                           <td>{Check(e.Orl)} ORL</td><td>{Check(e.Cuello)} Cuello</td>
                                                           <td>{Check(e.Cardiovascular)} Cardiovascular</td>
                                                           <td>{Check(e.Pulmonar)} Pulmonar</td>
                                                         </tr>
                                                         <tr>
                                                           <td>{Check(e.Abdomen)} Abdomen</td>
                                                           <td>{Check(e.Gastrointestinal)} Gastrointestinal</td>
                                                           <td>{Check(e.Genitourinario)} Genitourinario</td>
                                                           <td>{Check(e.Extremidades)} Extremidades</td>
                                                           <td>{Check(e.Neurologico)} Neurológico</td>
                                                           <td>{Check(e.Psiquiatrico)} Psiquiátrico</td>
                                                         </tr>
                                                       </table>
                                                       <p><strong>Observaciones:</strong> {e.Descripcion}</p>
                                                       """;

    private static string Check(bool v) => v ? "✔" : "☐";
}
