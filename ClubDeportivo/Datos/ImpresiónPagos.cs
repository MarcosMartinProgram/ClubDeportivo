using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Drawing;
using QuestPDF.Elements;

namespace ClubDeportivo.Datos
{
    public class ImpresionPagos
    {
        public static void GenerarPDF(DataGridView dgv, string nombreSocio, string rutaArchivo)
        {
            var tabla = new List<string[]>();

            // Cabeceras
            string[] encabezado = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Select(col => col.HeaderText)
                .ToArray();

            tabla.Add(encabezado);

            // Filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] fila = row.Cells
                        .Cast<DataGridViewCell>()
                        .Select(cell => cell.Value?.ToString() ?? "")
                        .ToArray();

                    tabla.Add(fila);
                }
            }

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);
                    page.Size(PageSizes.A4);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header()
                        .Text($"Historial de Pagos - {nombreSocio}")
                        .SemiBold().FontSize(16).FontColor(Colors.Blue.Medium);

                    page.Content()
                    .Table(table =>
                    {
                        // Suponemos que al menos hay una fila con encabezados
                        int columnas = tabla[0].Length;

                        // Definir columnas (todas iguales en este caso)
                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < columnas; i++)
                                columns.RelativeColumn();
                        });

                        // Encabezado
                        var encabezado = tabla[0];
                        table.Header(header =>
                        {
                            for (int j = 0; j < columnas; j++)
                            {
                                header.Cell().Element(CellStyle).Text(encabezado[j]).SemiBold();
                            }
                        });

                        // Filas de datos
                        for (int i = 1; i < tabla.Count; i++)
                        {
                            var fila = tabla[i];

                            for (int j = 0; j < columnas; j++)
                            {
                                table.Cell().Element(CellStyle).Text(fila[j]);
                            }
                        }

                        // Estilo de celda
                        IContainer CellStyle(IContainer container) =>
                            container.Border(1).BorderColor(Colors.Grey.Lighten2).Padding(5);
                    });

                    page.Footer()
                        .AlignCenter()
                        .Text(txt =>
                        {
                            txt.Span("Generado el ").FontSize(10);
                            txt.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm")).SemiBold().FontSize(10);
                        });
                });
            }).GeneratePdf(rutaArchivo);
        }
    }
}
