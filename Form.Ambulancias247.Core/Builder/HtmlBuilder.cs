using Form.Ambulancias247.Domain.Dto;

namespace Form.Ambulancias247.Core.Builder;

public static class HtmlBuilder
{
  public static string Build(InfoFormTransferDto dto)
  {
    return """
           <!DOCTYPE html>
           <html>
           <head>
             <meta charset="utf-8" />
             <style>
               body { font-family: Arial; font-size: 11px; }
               h1 { text-align: center; }
               h2 { background: #eee; padding: 6px; }
               table { width: 100%; border-collapse: collapse; margin-bottom: 10px; }
               th, td { border: 1px solid #ccc; padding: 4px; }
               th { background: #f7f7f7; }
               .check { font-weight: bold; }
             </style>
           </head>
           <body>
           """ +
           HeaderSection.Render() +
           TrasladoSection.Render(dto.Traslado!) +
           PacienteSection.Render(dto.Paciente!) +
           AntecedentesSection.Render(dto.Antecedentes!) +
           SignosSection.Render(dto.Signos!) +
           ExamenSection.Render(dto.Examen!) +
           GastosSection.Render(dto.Gastos!) +
           ConductaSection.Render(dto.Conducta!) +
           FirmasSection.Render(dto.Firmas!) +
           """
           </body>
           </html>
           """;
  }
}


