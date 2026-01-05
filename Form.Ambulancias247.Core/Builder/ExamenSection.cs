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
                                                         </tr>
                                                         <tr>
                                                           <td>{Check(e.Cardiovascular)} Cardiovascular</td>
                                                           <td>{Check(e.Pulmonar)} Pulmonar</td>
                                                           <td>{Check(e.Abdomen)} Abdomen</td>
                                                           <td>{Check(e.Extremidades)} Extremidades</td>
                                                         </tr>
                                                       </table>
                                                       <p><strong>Observaciones:</strong> {e.Descripcion}</p>
                                                       """;

    private static string Check(bool v) => v ? "✔" : "☐";
}
