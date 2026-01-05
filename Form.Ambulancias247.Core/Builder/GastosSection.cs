using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class GastosSection
{
    public static string Render(List<GastoDto> gastos, bool estado)
    {
        var rows = string.Join("", gastos.Select(g => $"""
                                                       <tr><td>{g.Descripcion}</td><td>{g.Cantidad}</td></tr>
                                                       """));

        return $"""
                <h2>Gastos y Estado de Entrega</h2>
                <table>
                  <tr><th>Descripción</th><th>Cantidad</th></tr>
                  {rows}
                </table>
                <p><strong>Estado del paciente:</strong> {estado}</p>
                """;
    }
}
