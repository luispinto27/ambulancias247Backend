using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class TrasladoSection
{
    public static string Render(TrasladoDto t) => $"""
       <h2>Datos del Traslado</h2>
       <table>
         <tr><th>Fecha</th><td>{t.Fecha:dd/MM/yyyy}</td><th>Entidad</th><td>{t.Entidad}</td></tr>
         <tr><th>Autorizado por</th><td>{t.AutorizadoPor}</td><th>No. Autorización</th><td>{t.AutorizacionNumero}</td></tr>
         <tr><th>Móvil</th><td>{t.Movil}</td><th>Tipo de Traslado</th><td>{t.Tipo}</td></tr>
         <tr><th>Origen</th><td>{t.Origen}</td><th>Destino</th><td>{t.Destino}</td></tr>
         <tr><th>Hora inicio</th><td>{t.HoraInicio}</td><th>Hora fin</th><td>{t.HoraFin}</td></tr>
         <tr><th>Retorno</th><td colspan="3">{(t.Retorno ? "Sí" : "No")}</td></tr>
         <tr><th>Traslado Fallido</th><td colspan="3">{(t.TrasladoFallido ? "Sí" : "No")}</td></tr>
       </table>
       """;
}

