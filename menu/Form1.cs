using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buscarAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarAutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Es registrar venta
            Formuarios.Registrar_Venta opcion_registrar_Venta = new Formuarios.Registrar_Venta();
            opcion_registrar_Venta.Show();

        }

        private void registrarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginRegistrarVehiculo opcion_agregar_vehiculo = new Formuarios.LoginRegistrarVehiculo();
            opcion_agregar_vehiculo.Show();
        }

        private void eliminarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginEliminarVehiculo opcion_loginEliminarVehiculo = new Formuarios.LoginEliminarVehiculo();
            opcion_loginEliminarVehiculo.Show();
        }

        private void registrarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.Registrar_Cliente opcion_registrar_Cliente = new Formuarios.Registrar_Cliente();
            opcion_registrar_Cliente.Show();
        }

        private void registrarNuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginRegistrarVendedor opcion_loginRegistrarVendedor = new Formuarios.LoginRegistrarVendedor();
            opcion_loginRegistrarVendedor.Show();
        }

        private void eliminarAutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formuarios.Eliminar_Cliente opcion_eliminar_Cliente = new Formuarios.Eliminar_Cliente();
            opcion_eliminar_Cliente.Show();
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginEliminarEmpleado opcion_loginEliminarEmpleado = new Formuarios.LoginEliminarEmpleado();
            opcion_loginEliminarEmpleado.Show();
        }

        private void mostrarCatalogoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.Mostrar_Catalogo_Vehiculos opcion_mostrar_Catalogo_Vehiculos = new Formuarios.Mostrar_Catalogo_Vehiculos();
            opcion_mostrar_Catalogo_Vehiculos.Show();
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.loginMostrarEmpleados opcion_loginMostrarEmpleados = new Formuarios.loginMostrarEmpleados();
            opcion_loginMostrarEmpleados.Show();
        }

        private void mostrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Formuarios.Mostrar_Ventas opcion_mostrar_Ventas = new Formuarios.Mostrar_Ventas();
            opcion_mostrar_Ventas.Show();*/
            Formuarios.LoginMostrarVentas opcion_loginMostrarVentas = new Formuarios.LoginMostrarVentas();
            opcion_loginMostrarVentas.Show();
        }

        private void buscarAutoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Formuarios.Buscar_Cliente opcion_buscar_Cliente = new Formuarios.Buscar_Cliente();
            opcion_buscar_Cliente.Show();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.Mostrar_Clientes opcion_mostrar_Clientes = new Formuarios.Mostrar_Clientes();
            opcion_mostrar_Clientes.Show();
        }

        private void buscarClienteEnBuroDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.Buscar_Cliente_Buro_Credito opcion_buscar_Cliente_Buro_Credito = new Formuarios.Buscar_Cliente_Buro_Credito();
            opcion_buscar_Cliente_Buro_Credito.Show();
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginBuscarEmpleado opcion_loginBuscarEmpleado = new Formuarios.LoginBuscarEmpleado();
            opcion_loginBuscarEmpleado.Show();
        }

        private void buscarVehiculoEnCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.Buscar_Vehiculo opcion_buscar_Vehiculo = new Formuarios.Buscar_Vehiculo();
            opcion_buscar_Vehiculo.Show();
        }

        private void enviarFacturaPorCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.Enviar_Factura_Correo opcion_enviar_Factura_Correo = new Formuarios.Enviar_Factura_Correo();
            opcion_enviar_Factura_Correo.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formuarios.LoginBuscarVenta opcion_loginBuscarVenta = new Formuarios.LoginBuscarVenta();
            //opcion_loginBuscarVenta.Show();
        }

        private void cancelarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginCancelarVenta opcion_loginCancelarVenta = new Formuarios.LoginCancelarVenta();
            opcion_loginCancelarVenta.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enviarImprimirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.EnviarFacturaImprimir opcion_enviarFacturaImprimir = new Formuarios.EnviarFacturaImprimir();
            opcion_enviarFacturaImprimir.Show();
        }

        private void buscarPorVendedorYPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginBuscarVenta opcion_loginBuscarVenta = new Formuarios.LoginBuscarVenta();
            opcion_loginBuscarVenta.Show();
        }

        private void buscarPorVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formuarios.LoginBuscarVentaEmpleado opcion_buscarVentaEmpleado = new Formuarios.LoginBuscarVentaEmpleado();
            opcion_buscarVentaEmpleado.Show();
        }

        
    }
}
