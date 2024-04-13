using System;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.IO.Image;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class EnviarFacturaImprimir : Form
    {
        public EnviarFacturaImprimir()
        {
            InitializeComponent();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            String usuarioCliente = txtNoSerieMotor.Text;
            MySqlDataReader reader = null;
            String sql = "SELECT v.idVenta, v.Usuario_Vendedor, v.Usuario_Cliente, v.Numero_Serie_Motor, v.Precio_Monto, v.Fecha, v.Metodo_Pago, c.Nombre, c.Correo, c.RFC, c.Regimen_Fiscal, c.Codigo_Postal, a.Tipo, a.Modelo, a.Color, a.Numero_Serie_Motor FROM ventas AS v INNER JOIN cliente AS c ON v.Usuario_Cliente = c.Usuario INNER JOIN autos AS a ON a.Numero_Serie_Motor = v.Numero_Serie_Motor WHERE a.Numero_Serie_Motor='" + usuarioCliente + "'";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txtUsuarioVendedor.Text = reader.GetString(1);
                        txtUsuarioCliente.Text = reader.GetString(2);
                        txtNoSerieMotor.Text = reader.GetString(3);
                        txtMonto.Text = reader.GetString(4);
                        txtFecha.Text = reader.GetString(5);
                        txtMetodoPago.Text = reader.GetString(6);
                        txtNombre.Text = reader.GetString(7);
                        txtCorreo.Text = reader.GetString(8);
                        txtRFC.Text = reader.GetString(9);
                        txtRegimenFiscal.Text = reader.GetString(10);
                        txtCodigoPostal.Text = reader.GetString(11);
                        txtTipo.Text = reader.GetString(12);
                        txtModelo.Text = reader.GetString(13);
                        txtColor.Text = reader.GetString(14);
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON REGISTROS");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL BUSCAR " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void crearPDF()
        {
            String usuarioCliente = txtNoSerieMotor.Text;
            //String nombreArchivo = txtNombreFactura.Text;
            MySqlDataReader reader = null;

            PdfWriter pdfWrite = new PdfWriter("C:/Users/osmal/Downloads/ReporteImprimir.pdf");
            PdfDocument pdf = new PdfDocument(pdfWrite);
            PageSize tamanioH = new PageSize(1012, 492);
            //Document documento = new Document(pdf, PageSize.TABLOID.Rotate());
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Usuario Vendedor", "Usuario Cliente", "Numero Serie Motor", "Monto", "Fecha", "Metodo Pago", "Nombre Cliente", "Correo Cliente", "RFC Cliente", "Regimen Fiscal", "Codigo Postal", "Tipo Vehiculo", "Modelo Vehiculo", "Color Vehiculo" };

            float[] tamanios = { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT v.Usuario_Vendedor, v.Usuario_Cliente, v.Numero_Serie_Motor, v.Precio_Monto, v.Fecha, v.Metodo_Pago, c.Nombre, c.Correo, c.RFC, c.Regimen_Fiscal, c.Codigo_Postal, a.Tipo, a.Modelo, a.Color, a.Numero_Serie_Motor FROM ventas AS v INNER JOIN cliente AS c ON v.Usuario_Cliente = c.Usuario INNER JOIN autos AS a ON a.Numero_Serie_Motor = v.Numero_Serie_Motor WHERE a.Numero_Serie_Motor='" + usuarioCliente + "';";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //tabla.AddCell(new Cell().Add(new Paragraph(reader["idVenta"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Usuario_Vendedor"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Usuario_Cliente"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Numero_Serie_Motor"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Precio_Monto"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Fecha"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Metodo_Pago"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Nombre"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Correo"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["RFC"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Regimen_Fiscal"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Codigo_Postal"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Tipo"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Modelo"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["Color"].ToString()).SetFont(fontContenido)));
                }
            }

            documento.Add(tabla);
            documento.Close();

            iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create("mustang.png")).SetWidth(50);
            Paragraph plogo = new Paragraph("").Add(logo);
            Paragraph titulo = new Paragraph("FACTURA \nCONCESIONARIA REVOLUCION");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dFecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dHora = DateTime.Now.ToString("hh:mm:ss");
            Paragraph fecha = new Paragraph("Fecha: " + dFecha + "\nHora: " + dHora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("C:/Users/User/Downloads/ReporteImprimir.pdf"), new PdfWriter("C:/Users/osmal/Downloads/FACTURA_'" + usuarioCliente + "'.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            if (txtCodigoPostal.Text == "" || txtCorreo.Text == "" || txtNombre.Text == "" || txtColor.Text == "" || txtFecha.Text == "" || txtMetodoPago.Text == "" || txtModelo.Text == "" || txtNombre.Text == "" || txtNoSerieMotor.Text == "" || txtRFC.Text == "" || txtUsuarioCliente.Text == "" || txtUsuarioVendedor.Text == "" || txtRegimenFiscal.Text == "" || txtMonto.Text == "" || txtMetodoPago.Text == "")
            {
                MessageBox.Show("DEBES DE LLENAR TODOS LOS CAMPOS");
            }
            else
            {
                for (int i = 1; i <= numeros; i++)
                {
                    PdfPage pagina = pdfDoc.GetPage(i);

                    float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                    doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(fecha, 920, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                    doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                }
                
                MessageBox.Show("FACTURA GUARDADA EN: C:/Users/User/Downloads/FACTURA_'" + usuarioCliente + "'.pdf");
                limpiar();
                conexionBD.Close();

                string sql1 = "DELETE FROM Autos WHERE Numero_Serie_Motor='" + usuarioCliente + "'";

                conexionBD.Open();

                try
                {
                    MySqlCommand comando1 = new MySqlCommand(sql1, conexionBD);
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("VEHICULO ELIMINADO DEL CATALOGO.\nYA HA SIDO VENDIDO");
                    limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR DATO NO ELIMINADO" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

                doc.Close();
            }

        }

        private void limpiar()
        {
            txtNoSerieMotor.Text = "";
            txtUsuarioVendedor.Text = "";
            txtUsuarioCliente.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtRFC.Text = "";
            txtRegimenFiscal.Text = "";
            txtCodigoPostal.Text = "";
            txtMetodoPago.Text = "";
            txtFecha.Text = "";
            txtMetodoPago.Text = "";
            txtTipo.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtMonto.Text = "";
            txtNombreFactura.Text = "";
        }

        private void btnEnviarFacturaImprimir_Click(object sender, EventArgs e)
        {
            crearPDF();
        }

        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=concesionaria; Uid=root; pwd=Astro090");
        private string eliminar(string noSerie)
        {
            string noSerieMotor = txtNoSerieMotor.Text;

            string sql = "DELETE FROM Autos WHERE Numero_Serie_Motor='" + noSerieMotor + "'";

            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ELIMINADO");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR DATO NO ELIMINADO" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            return noSerieMotor;
        }

        private void txtNombreFactura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
