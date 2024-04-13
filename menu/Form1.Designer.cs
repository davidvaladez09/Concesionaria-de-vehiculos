
namespace menu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAutoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteEnBuroDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVehiculoEnCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorVendedorYPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCatalogoDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarFacturaPorCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarImprimirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Crimson;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(40, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.agregarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAutoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.cancelarToolStripMenuItem,
            this.enviarToolStripMenuItem});
            this.agregarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(32, 28);
            this.agregarToolStripMenuItem.Text = "|||";
            this.agregarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.agregarToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.agregarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // agregarAutoToolStripMenuItem
            // 
            this.agregarAutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAutoToolStripMenuItem1,
            this.registrarNuevoClienteToolStripMenuItem,
            this.registrarVehiculoToolStripMenuItem,
            this.registrarNuevoVendedorToolStripMenuItem});
            this.agregarAutoToolStripMenuItem.Name = "agregarAutoToolStripMenuItem";
            this.agregarAutoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.agregarAutoToolStripMenuItem.Text = "Registro";
            // 
            // agregarAutoToolStripMenuItem1
            // 
            this.agregarAutoToolStripMenuItem1.Name = "agregarAutoToolStripMenuItem1";
            this.agregarAutoToolStripMenuItem1.Size = new System.Drawing.Size(263, 24);
            this.agregarAutoToolStripMenuItem1.Text = "Registrar Venta";
            this.agregarAutoToolStripMenuItem1.Click += new System.EventHandler(this.agregarAutoToolStripMenuItem1_Click);
            // 
            // registrarNuevoClienteToolStripMenuItem
            // 
            this.registrarNuevoClienteToolStripMenuItem.Name = "registrarNuevoClienteToolStripMenuItem";
            this.registrarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.registrarNuevoClienteToolStripMenuItem.Text = "Registrar Nuevo Cliente";
            this.registrarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoClienteToolStripMenuItem_Click);
            // 
            // registrarVehiculoToolStripMenuItem
            // 
            this.registrarVehiculoToolStripMenuItem.Name = "registrarVehiculoToolStripMenuItem";
            this.registrarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.registrarVehiculoToolStripMenuItem.Text = "Registrar Vehiculo";
            this.registrarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registrarVehiculoToolStripMenuItem_Click);
            // 
            // registrarNuevoVendedorToolStripMenuItem
            // 
            this.registrarNuevoVendedorToolStripMenuItem.Name = "registrarNuevoVendedorToolStripMenuItem";
            this.registrarNuevoVendedorToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.registrarNuevoVendedorToolStripMenuItem.Text = "Registrar Nuevo Vendedor";
            this.registrarNuevoVendedorToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoVendedorToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarAutoToolStripMenuItem1,
            this.eliminarEmpleadoToolStripMenuItem,
            this.eliminarVehiculoToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarAutoToolStripMenuItem1
            // 
            this.eliminarAutoToolStripMenuItem1.Name = "eliminarAutoToolStripMenuItem1";
            this.eliminarAutoToolStripMenuItem1.Size = new System.Drawing.Size(208, 24);
            this.eliminarAutoToolStripMenuItem1.Text = "Eliminar Cliente";
            this.eliminarAutoToolStripMenuItem1.Click += new System.EventHandler(this.eliminarAutoToolStripMenuItem1_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            this.eliminarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEmpleadoToolStripMenuItem_Click);
            // 
            // eliminarVehiculoToolStripMenuItem
            // 
            this.eliminarVehiculoToolStripMenuItem.Name = "eliminarVehiculoToolStripMenuItem";
            this.eliminarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.eliminarVehiculoToolStripMenuItem.Text = "Eliminar Vehiculo";
            this.eliminarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.eliminarVehiculoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarAutoToolStripMenuItem2,
            this.buscarClienteEnBuroDeCreditoToolStripMenuItem,
            this.buscarVehiculoEnCatalogoToolStripMenuItem,
            this.buscarEmpleadoToolStripMenuItem,
            this.buscarVentaToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // buscarAutoToolStripMenuItem2
            // 
            this.buscarAutoToolStripMenuItem2.Name = "buscarAutoToolStripMenuItem2";
            this.buscarAutoToolStripMenuItem2.Size = new System.Drawing.Size(312, 24);
            this.buscarAutoToolStripMenuItem2.Text = "Buscar Cliente";
            this.buscarAutoToolStripMenuItem2.Click += new System.EventHandler(this.buscarAutoToolStripMenuItem2_Click);
            // 
            // buscarClienteEnBuroDeCreditoToolStripMenuItem
            // 
            this.buscarClienteEnBuroDeCreditoToolStripMenuItem.Name = "buscarClienteEnBuroDeCreditoToolStripMenuItem";
            this.buscarClienteEnBuroDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.buscarClienteEnBuroDeCreditoToolStripMenuItem.Text = "Buscar Cliente en Buro de Credito";
            this.buscarClienteEnBuroDeCreditoToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteEnBuroDeCreditoToolStripMenuItem_Click);
            // 
            // buscarVehiculoEnCatalogoToolStripMenuItem
            // 
            this.buscarVehiculoEnCatalogoToolStripMenuItem.Name = "buscarVehiculoEnCatalogoToolStripMenuItem";
            this.buscarVehiculoEnCatalogoToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.buscarVehiculoEnCatalogoToolStripMenuItem.Text = "Buscar Vehiculo en Catalogo";
            this.buscarVehiculoEnCatalogoToolStripMenuItem.Click += new System.EventHandler(this.buscarVehiculoEnCatalogoToolStripMenuItem_Click);
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            this.buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            this.buscarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.buscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado";
            this.buscarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.buscarEmpleadoToolStripMenuItem_Click);
            // 
            // buscarVentaToolStripMenuItem
            // 
            this.buscarVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorVendedorToolStripMenuItem,
            this.buscarPorVendedorYPeriodoToolStripMenuItem});
            this.buscarVentaToolStripMenuItem.Name = "buscarVentaToolStripMenuItem";
            this.buscarVentaToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.buscarVentaToolStripMenuItem.Text = "Buscar Venta";
            this.buscarVentaToolStripMenuItem.Click += new System.EventHandler(this.buscarVentaToolStripMenuItem_Click);
            // 
            // buscarPorVendedorToolStripMenuItem
            // 
            this.buscarPorVendedorToolStripMenuItem.Name = "buscarPorVendedorToolStripMenuItem";
            this.buscarPorVendedorToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.buscarPorVendedorToolStripMenuItem.Text = "Buscar Por Vendedor";
            this.buscarPorVendedorToolStripMenuItem.Click += new System.EventHandler(this.buscarPorVendedorToolStripMenuItem_Click);
            // 
            // buscarPorVendedorYPeriodoToolStripMenuItem
            // 
            this.buscarPorVendedorYPeriodoToolStripMenuItem.Name = "buscarPorVendedorYPeriodoToolStripMenuItem";
            this.buscarPorVendedorYPeriodoToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.buscarPorVendedorYPeriodoToolStripMenuItem.Text = "Buscar Por Vendedor y Fecha";
            this.buscarPorVendedorYPeriodoToolStripMenuItem.Click += new System.EventHandler(this.buscarPorVendedorYPeriodoToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarCatalogoDeVehiculosToolStripMenuItem,
            this.mostrarEmpleadosToolStripMenuItem,
            this.mostrarVentasToolStripMenuItem,
            this.mostrarClientesToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // mostrarCatalogoDeVehiculosToolStripMenuItem
            // 
            this.mostrarCatalogoDeVehiculosToolStripMenuItem.Name = "mostrarCatalogoDeVehiculosToolStripMenuItem";
            this.mostrarCatalogoDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.mostrarCatalogoDeVehiculosToolStripMenuItem.Text = "Mostrar Catalogo de Vehiculos";
            this.mostrarCatalogoDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.mostrarCatalogoDeVehiculosToolStripMenuItem_Click);
            // 
            // mostrarEmpleadosToolStripMenuItem
            // 
            this.mostrarEmpleadosToolStripMenuItem.Name = "mostrarEmpleadosToolStripMenuItem";
            this.mostrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.mostrarEmpleadosToolStripMenuItem.Text = "Mostrar Empleados";
            this.mostrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEmpleadosToolStripMenuItem_Click);
            // 
            // mostrarVentasToolStripMenuItem
            // 
            this.mostrarVentasToolStripMenuItem.Name = "mostrarVentasToolStripMenuItem";
            this.mostrarVentasToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.mostrarVentasToolStripMenuItem.Text = "Mostrar Ventas";
            this.mostrarVentasToolStripMenuItem.Click += new System.EventHandler(this.mostrarVentasToolStripMenuItem_Click);
            // 
            // mostrarClientesToolStripMenuItem
            // 
            this.mostrarClientesToolStripMenuItem.Name = "mostrarClientesToolStripMenuItem";
            this.mostrarClientesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.mostrarClientesToolStripMenuItem.Text = "Mostrar Clientes";
            this.mostrarClientesToolStripMenuItem.Click += new System.EventHandler(this.mostrarClientesToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarVentaToolStripMenuItem});
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // cancelarVentaToolStripMenuItem
            // 
            this.cancelarVentaToolStripMenuItem.Name = "cancelarVentaToolStripMenuItem";
            this.cancelarVentaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.cancelarVentaToolStripMenuItem.Text = "Cancelar Venta";
            this.cancelarVentaToolStripMenuItem.Click += new System.EventHandler(this.cancelarVentaToolStripMenuItem_Click);
            // 
            // enviarToolStripMenuItem
            // 
            this.enviarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarFacturaPorCorreoToolStripMenuItem,
            this.enviarImprimirFacturaToolStripMenuItem});
            this.enviarToolStripMenuItem.Name = "enviarToolStripMenuItem";
            this.enviarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.enviarToolStripMenuItem.Text = "Enviar";
            // 
            // enviarFacturaPorCorreoToolStripMenuItem
            // 
            this.enviarFacturaPorCorreoToolStripMenuItem.Name = "enviarFacturaPorCorreoToolStripMenuItem";
            this.enviarFacturaPorCorreoToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.enviarFacturaPorCorreoToolStripMenuItem.Text = "Enviar Factura por Correo";
            this.enviarFacturaPorCorreoToolStripMenuItem.Click += new System.EventHandler(this.enviarFacturaPorCorreoToolStripMenuItem_Click);
            // 
            // enviarImprimirFacturaToolStripMenuItem
            // 
            this.enviarImprimirFacturaToolStripMenuItem.Name = "enviarImprimirFacturaToolStripMenuItem";
            this.enviarImprimirFacturaToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.enviarImprimirFacturaToolStripMenuItem.Text = "Enviar Imprimir Factura";
            this.enviarImprimirFacturaToolStripMenuItem.Click += new System.EventHandler(this.enviarImprimirFacturaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(288, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO!";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CONCESIONARIA REVOLUCION";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAutoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAutoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAutoToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteEnBuroDeCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVehiculoEnCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCatalogoDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarFacturaPorCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarImprimirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorVendedorYPeriodoToolStripMenuItem;
    }
}

