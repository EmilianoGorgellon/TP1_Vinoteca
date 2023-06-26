using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TP1_UTN.Clases
{
    public class Informes
    {

        public async static Task<string> ExportarProductosACsv()
        {
            try
            {
                var csvBuilder = new StringBuilder();
                csvBuilder.AppendLine("Nombre,Precio,Stock,Fecha");
                FirebaseResponse response = await Firebase.GetElement("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    csvBuilder.AppendLine($"{elemento.Value.Nombre},{elemento.Value.Precio},{elemento.Value.Stock},{elemento.Value.Fecha}");
                }
                File.WriteAllText("C:\\Users\\Gorgellon\\source\\repos\\TP1_UTN\\Resources\\productos.csv", csvBuilder.ToString());
                return "Se creo satisfactoriamente el archivo productos.csv";
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async static Task<string> ExportarProductosAJSON()
        {
            try
            {
                FirebaseResponse response = await Firebase.GetElement("productos");
                Dictionary<string, Producto> dictionaryProductos = response.ResultAs<Dictionary<string, Producto>>();
                List<Producto> listaProductos = dictionaryProductos.Values.ToList();
                string json = JsonConvert.SerializeObject(listaProductos);
                File.WriteAllText("C:\\Users\\Gorgellon\\source\\repos\\TP1_UTN\\Resources\\productos.json", json);
                return "Se creo satisfactoriamente el archivo productos.json";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async static Task<string> ExportarProductosAPDF()
        {
            try
            {
                FirebaseResponse response = await Firebase.GetElement("productos");
                Dictionary<string, Producto> lista = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

                FileStream fs = new FileStream(@"C:\Users\Gorgellon\source\repos\TP1_UTN\Resources\productos.pdf", FileMode.Create);
                Document document = new Document(PageSize.A4);
                PdfWriter pdf = PdfWriter.GetInstance(document, fs);

                document.Open();

                // Agrego author
                document.AddAuthor("Emiliano Gorgellon");

                // agrego encabezado en dpf
                document.Add(new Paragraph("Lista de productos"));
                document.Add(Chunk.NEWLINE);

                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;

                PdfPCell columnNombre = new PdfPCell(new Phrase("Nombre"));
                PdfPCell columnPrecio = new PdfPCell(new Phrase("Precio"));
                PdfPCell columnStock = new PdfPCell(new Phrase("Stock"));
                PdfPCell columnFecha = new PdfPCell(new Phrase("Fecha"));

                table.AddCell(columnNombre);
                table.AddCell(columnPrecio);
                table.AddCell(columnStock);
                table.AddCell(columnFecha);

                foreach (KeyValuePair<string, Producto> elemento in lista)
                {
                    columnNombre = new PdfPCell(new Phrase(elemento.Value.Nombre));
                    columnPrecio = new PdfPCell(new Phrase(elemento.Value.Precio.ToString()));
                    columnStock = new PdfPCell(new Phrase(elemento.Value.Stock.ToString()));
                    columnFecha = new PdfPCell(new Phrase(elemento.Value.Fecha));
                    table.AddCell(columnNombre);
                    table.AddCell(columnPrecio);
                    table.AddCell(columnStock);
                    table.AddCell(columnFecha);
                }
                document.Add(table);
                document.Close();
                pdf.Close();

                return "Se creo satisfactoriamente el archivo productos.pdf";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
