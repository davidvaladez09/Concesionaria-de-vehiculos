using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.IO.Image;


namespace menu.Formuarios
{
    public partial class Enviar_Factura_Correo : Form
    {
        public Enviar_Factura_Correo()
        {
            InitializeComponent();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            String usuarioCliente = txtUsuarioCliente.Text;
            MySqlDataReader reader = null;

            String sql = "SELECT * FROM cliente WHERE Usuario LIKE '" + usuarioCliente + "' LIMIT 1";

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
                        txtIdCliente.Text = reader.GetString(0);
                        txtUsuarioCliente.Text = reader.GetString(1);
                        txtNombre.Text = reader.GetString(2);
                        txtCorreo.Text = reader.GetString(3);
                        txtRFC.Text = reader.GetString(4);
                        txtRegimenFiscal.Text = reader.GetString(5);
                        txtCodigoPostal.Text = reader.GetString(6);
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON VENTAS DE ESTE VEHICULO");
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
        }//COMPLETO

        private void btnCompletarAuto_Click(object sender, EventArgs e)
        {
            
        }//NO SIRVE


        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=concesionaria; Uid=root; pwd=Astro090");
        private void btnEnviarCorreo_Click(object sender, EventArgs e)//NO SIRVE
        {
            
        }
      

        private void btnCompletar_Click_1(object sender, EventArgs e)
        {
            String usuarioCliente = txtNoSerieMotor.Text;
            MySqlDataReader reader = null;
            String sql = "SELECT v.idVenta, v.idVendedor, v.Usuario_Vendedor, v.idCliente, v.Usuario_Cliente, v.Numero_Serie_Motor, v.Precio_Monto, v.Fecha, v.Metodo_Pago,c.Nombre, c.Correo, c.RFC, c.Regimen_Fiscal, c.Codigo_Postal, a.Tipo, a.Modelo, a.Color, a.Numero_Serie_Motor, a.Año, a.Marca, e.Nombre, e.Tipo_Usuario, e.Telefono, e.Correo FROM ventas AS v INNER JOIN cliente AS c ON v.idCliente = c.idCliente INNER JOIN autos AS a ON a.Numero_Serie_Motor = v.Numero_Serie_Motor INNER JOIN empleado_vendedor_usuario AS e ON e.idEmpleado_Vendedor_Usuario = v.idVendedor WHERE a.Numero_Serie_Motor='" + usuarioCliente + "'";

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
                        txtIdVendedor.Text = reader.GetString(1);
                        txtUsuarioVendedor.Text = reader.GetString(2);
                        txtIdCliente.Text = reader.GetString(3);
                        txtUsuarioCliente.Text = reader.GetString(4);
                        txtNoSerieMotor.Text = reader.GetString(5);
                        txtMonto.Text = reader.GetString(6);
                        txtFecha.Text = reader.GetString(7);
                        txtMetodoPago.Text = reader.GetString(8);
                        txtNombre.Text = reader.GetString(9);
                        txtCorreo.Text = reader.GetString(10);
                        txtRFC.Text = reader.GetString(11);
                        txtRegimenFiscal.Text = reader.GetString(12);
                        txtCodigoPostal.Text = reader.GetString(13);
                        txtTipo.Text = reader.GetString(14);
                        txtModelo.Text = reader.GetString(15);
                        txtColor.Text = reader.GetString(16);
                        txtAnio.Text = reader.GetString(18);
                        txtMarca.Text = reader.GetString(19);
                        txtNombreVendedor.Text = reader.GetString(20);
                        txtTipoUsuario.Text = reader.GetString(21);
                        txtTelefono.Text = reader.GetString(22);
                        txtCorreoVendedor.Text = reader.GetString(23);
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

        private void btnEnviarCorreo_Click_1(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(txtCorreo.Text);
            mmsg.Subject = txtAsunto.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.Body = "\nCONCESIONARIA REVOLUCION\n           \nQuerid@ '" + txtNombre.Text + "' le adjunto su factura de compra. \nConcesionaria Revolucion agradece su preferencia.";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;

            mmsg.From = new System.Net.Mail.MailAddress("consecionari@gmail.com");

            if(txtArchivo.Text == "")
            {
                MessageBox.Show("DEBES ADJUNTAR LA FACTURA");
            }
            else
            {
                System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(txtArchivo.Text);
                mmsg.Attachments.Add(archivo);

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("concesionari@gmail.com", "217450107");

                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";

                string noSerieMotor = txtNoSerieMotor.Text;

                string sql = "DELETE FROM Autos WHERE Numero_Serie_Motor='" + noSerieMotor + "'";

                conexionBD.Open();

                try
                {
                    cliente.Send(mmsg);

                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("FACTURA ENVIADA AL CORREO: " + txtCorreo.Text + "\nAUTO ELIMINADO DE LA BASE DE DATOS");
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL ENVIAR FACTURA AL CORREO" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
            
        }

       

        private void crearPDF()
        {
            String usuarioCliente = txtNoSerieMotor.Text;
            MySqlDataReader reader = null;

            PdfWriter pdfWrite = new PdfWriter("C:/Users/User/Downloads/ReporteCorreo.pdf");
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

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("C:/Users/User/Downloads/ReporteCorreo.pdf"), new PdfWriter("C:/Users/User/Downloads/FACTURA_'" + usuarioCliente + "'.pdf"));
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
                conexionBD.Close();

                doc.Close();
            }

        }//COMPLETO

        private void btnEnviarFacturaImprimir_Click(object sender, EventArgs e) // COMPLETO
        {
            crearPDF();
        }

        private void btnAdjuntarFactura_Click(object sender, EventArgs e)
        {
            String usuarioCliente = txtNoSerieMotor.Text;
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtArchivo.Text = this.openFileDialog1.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR AL CARAGAR FACTURA: " + ex.ToString());
            }
        }//COMPLETO
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
            txtArchivo.Text = "";
        }//COMPLETO
    }
}
