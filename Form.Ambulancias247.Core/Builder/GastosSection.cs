using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class GastosSection
{
    public static string Render(List<GastoDto> gastos)
    {
        var rows = string.Join("", gastos.Select(g => $"""
                                                       <tr><td>{g.Descripcion}</td><td>{g.Cantidad}</td></tr>
                                                       """));

        return $"""
                <h2>Gastos</h2>
                <table>
                  <tr><th>Descripción</th><th>Cantidad</th></tr>
                  {rows}
                </table>
                """;
    }
}
