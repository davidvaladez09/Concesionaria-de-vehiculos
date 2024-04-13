using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class OpcionMenu : Form
    {
        public OpcionMenu()
        {
            InitializeComponent();
        }

        private void pbAgregar_double_click(object sender, EventArgs e)
        {

        }

        

        MySqlConnection con = new MySqlConnection("server=localhost; database=concesionaria; Uid=root; pwd=Astro090");
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();

            if (txtAnio.Text == "" | txtMarca.Text == "" | txtNoSerieMotor.Text == "" | txtTipoVehiculo.Text == "" | txtModeloVehiculo.Text == "" | txtColorVehiculo.Text == "" | txtKilometros.Text == "" | txtPrecio.Text == "")
            {
                MessageBox.Show("NO PUEDES DEJAR NINGUN CAMPO VACIO");
            }
            else
            {
                try
                {
                    String marca = txtMarca.Text;
                    int anio = int.Parse(txtAnio.Text);
                    String noSerieMotor = txtNoSerieMotor.Text;
                    String tipoVehiculo = txtTipoVehiculo.Text;
                    String modeloVehiculo = txtModeloVehiculo.Text;
                    String colorVehiculo = txtColorVehiculo.Text;
                    int kilometros = int.Parse(txtKilometros.Text);
                    double precio = double.Parse(txtPrecio.Text);

                   // int id = int.Parse(txtId.Text);
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Autos(Numero_Serie_Motor, Marca, Año, Tipo, Modelo, Color, Kilometros, Precio, Imagen) VALUES('" + noSerieMotor + "', '" + marca + "', '" + anio + "', '" + tipoVehiculo + "', '" + modeloVehiculo + "', '" + colorVehiculo + "', '" + kilometros + "', '" + precio + "', @Imagen)", con);
                    MemoryStream ms = new MemoryStream();

                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    cmd.Parameters.AddWithValue("Imagen", aByte);

                    int i;

                    i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("VEHICULO REGISTRADO");
                        limpiar();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("VEHICULO NO REGISTRADO, IMAGEN NO AGREGADA");
                }
                finally
                {
                    con.Close();
                }
            }   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Archivo de Imagen |*.jpg| Archivo PNG|*.png| Todos los archivos|*.*";
            DialogResult resultado = ofd.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtAnio.Text = "";
            txtMarca.Text = "";
            txtNoSerieMotor.Text = "";
            txtTipoVehiculo.Text = "";
            txtModeloVehiculo.Text = "";
            txtColorVehiculo.Text = "";
            txtKilometros.Text = "";
            txtPrecio.Text = "";
        }
    }
}
