
namespace menu.Formuarios
{
    partial class LoginBuscarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginBuscarVenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIniciarSesion = new System.Windows.Forms.Button();
            this.txtPasswordGerente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioGerente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtIniciarSesion);
            this.groupBox1.Controls.Add(this.txtPasswordGerente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsuarioGerente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 440);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Venta";
            // 
            // txtIniciarSesion
            // 
            this.txtIniciarSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIniciarSesion.Location = new System.Drawing.Point(12, 84);
            this.txtIniciarSesion.Name = "txtIniciarSesion";
            this.txtIniciarSesion.Size = new System.Drawing.Size(189, 28);
            this.txtIniciarSesion.TabIndex = 9;
            this.txtIniciarSesion.Text = "Click para Iniciar Sesion";
            this.txtIniciarSesion.UseVisualStyleBackColor = false;
            this.txtIniciarSesion.Click += new System.EventHandler(this.txtIniciarSesion_Click);
            // 
            // txtPasswordGerente
            // 
            this.txtPasswordGerente.Location = new System.Drawing.Point(153, 54);
            this.txtPasswordGerente.Name = "txtPasswordGerente";
            this.txtPasswordGerente.PasswordChar = '*';
            this.txtPasswordGerente.Size = new System.Drawing.Size(131, 22);
            this.txtPasswordGerente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password Gerente:";
            // 
            // txtUsuarioGerente
            // 
            this.txtUsuarioGerente.Location = new System.Drawing.Point(153, 21);
            this.txtUsuarioGerente.Name = "txtUsuarioGerente";
            this.txtUsuarioGerente.Size = new System.Drawing.Size(131, 22);
            this.txtUsuarioGerente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario Gerente:";
            // 
            // LoginBuscarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginBuscarVenta";
            this.Text = "BUSCAR VENTA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtIniciarSesion;
        private System.Windows.Forms.TextBox txtPasswordGerente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioGerente;
        private System.Windows.Forms.Label label1;
    }
}