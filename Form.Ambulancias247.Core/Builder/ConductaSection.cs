using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder
{
    public class ConductaSection
    {
            public static string Render(ConductaDto p) => $"""
       <h2>Conducta y Entrega Paciente</h2>
       <table>
         <tr><th>Conducta</th><td colspan="3">{p.Conducta}</td></tr>
         <tr><th>Hora Inicio Espera</th><td>{p.HoraInicioEspera}</td><th>Hora Fin Espera</th><td>{p.HoraFinEspera}</td></tr>
         <tr><th>Estado Paciente</th><td colspan="3">{(p.EstadoEntrega ? "Vivo" : "Muerto")}</td></tr>
       </table>
       """;
    }
}