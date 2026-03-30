using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class PacienteSection
{
    public static string Render(PacienteDto p) => $"""
       <h2>Datos del Paciente</h2>
       <table>
         <tr><th>Nombre Completo</th><td colspan="3">{p.NombreCompleto}</td></tr>
         <tr><th>Documento</th><td>{p.TipoDocumento} {p.NumeroDocumento}</td><th>Sexo</th><td>{p.Sexo}</td></tr>
         <tr><th>Edad</th><td>{p.Edad}</td><th>Fecha nacimiento</th><td>{p.FechaNacimiento:dd/MM/yyyy}</td></tr>
         <tr><th>Dirección</th><td colspan="3">{p.Direccion}, {p.Barrio}, {p.Ciudad}</td></tr>
         <tr><th>Teléfono</th><td colspan="3">{p.Telefono}</td></tr>
         <tr><th>Motivo de Traslado</th><td colspan="3">{p.MotivoTraslado}</td></tr>
         <tr><th>Tratamiento</th><td colspan="3">{p.Tratamiento}</td></tr>
       </table>
       """;
}
