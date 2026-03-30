using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class FirmasSection
{
    public static string Render(FirmasDto f) => $"""
                                                 <h2>Firmas</h2>
                                                 <table>
                                                   <tr>
                                                     <th>Médico</th><th>Enfermería</th>
                                                   </tr>
                                                   <tr>
                                                     <td><img src="{f.Medico}" height="80"/></td>
                                                     <td><img src="{f.Enfermeria}" height="80"/></td>
                                                   </tr>
                                                   <tr>
                                                     <th>Conductor</th><th>Familiar</th>
                                                   </tr>
                                                   <tr>
                                                     <td><img src="{f.Conductor}" height="80"/></td>
                                                     <td><img src="{f.Familiar}" height="80"/></td>
                                                   </tr>
                                                   <tr>
                                                     <th>Entidad Receptora</th>
                                                   </tr>
                                                   <tr>
                                                     <td><img src="{f.EntidadReceptora}" height="80"/></td>
                                                   </tr>
                                                 </table>
                                                 """;
}
