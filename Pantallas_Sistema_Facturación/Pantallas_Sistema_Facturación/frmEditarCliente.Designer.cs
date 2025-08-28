namespace Pantallas_Sistema_Facturación
{
    partial class frmEditarCliente
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
            this.components = new System.ComponentModel.Container();
            this.pnlEditarCliente = new System.Windows.Forms.Panel();
            this.txtEditarCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEditarCliente = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEditarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditarCliente
            // 
            this.pnlEditarCliente.Controls.Add(this.txtEditarCorreo);
            this.pnlEditarCliente.Controls.Add(this.txtEditarDireccion);
            this.pnlEditarCliente.Controls.Add(this.txtEditarTelefono);
            this.pnlEditarCliente.Controls.Add(this.txtEditarDocumento);
            this.pnlEditarCliente.Controls.Add(this.txtEditarNombre);
            this.pnlEditarCliente.Location = new System.Drawing.Point(135, 126);
            this.pnlEditarCliente.Name = "pnlEditarCliente";
            this.pnlEditarCliente.Size = new System.Drawing.Size(464, 239);
            this.pnlEditarCliente.TabIndex = 0;
            // 
            // txtEditarCorreo
            // 
            this.txtEditarCorreo.Depth = 0;
            this.txtEditarCorreo.Hint = "Correo";
            this.txtEditarCorreo.Location = new System.Drawing.Point(109, 198);
            this.txtEditarCorreo.MaxLength = 32767;
            this.txtEditarCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarCorreo.Name = "txtEditarCorreo";
            this.txtEditarCorreo.PasswordChar = '\0';
            this.txtEditarCorreo.SelectedText = "";
            this.txtEditarCorreo.SelectionLength = 0;
            this.txtEditarCorreo.SelectionStart = 0;
            this.txtEditarCorreo.Size = new System.Drawing.Size(213, 23);
            this.txtEditarCorreo.TabIndex = 4;
            this.txtEditarCorreo.TabStop = false;
            this.txtEditarCorreo.UseSystemPasswordChar = false;
            // 
            // txtEditarDireccion
            // 
            this.txtEditarDireccion.Depth = 0;
            this.txtEditarDireccion.Hint = "Direccion";
            this.txtEditarDireccion.Location = new System.Drawing.Point(109, 156);
            this.txtEditarDireccion.MaxLength = 32767;
            this.txtEditarDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarDireccion.Name = "txtEditarDireccion";
            this.txtEditarDireccion.PasswordChar = '\0';
            this.txtEditarDireccion.SelectedText = "";
            this.txtEditarDireccion.SelectionLength = 0;
            this.txtEditarDireccion.SelectionStart = 0;
            this.txtEditarDireccion.Size = new System.Drawing.Size(213, 23);
            this.txtEditarDireccion.TabIndex = 3;
            this.txtEditarDireccion.TabStop = false;
            this.txtEditarDireccion.UseSystemPasswordChar = false;
            // 
            // txtEditarTelefono
            // 
            this.txtEditarTelefono.Depth = 0;
            this.txtEditarTelefono.Hint = "Telefono";
            this.txtEditarTelefono.Location = new System.Drawing.Point(109, 108);
            this.txtEditarTelefono.MaxLength = 32767;
            this.txtEditarTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarTelefono.Name = "txtEditarTelefono";
            this.txtEditarTelefono.PasswordChar = '\0';
            this.txtEditarTelefono.SelectedText = "";
            this.txtEditarTelefono.SelectionLength = 0;
            this.txtEditarTelefono.SelectionStart = 0;
            this.txtEditarTelefono.Size = new System.Drawing.Size(213, 23);
            this.txtEditarTelefono.TabIndex = 2;
            this.txtEditarTelefono.TabStop = false;
            this.txtEditarTelefono.UseSystemPasswordChar = false;
            // 
            // txtEditarDocumento
            // 
            this.txtEditarDocumento.Depth = 0;
            this.txtEditarDocumento.Hint = "Documento";
            this.txtEditarDocumento.Location = new System.Drawing.Point(109, 65);
            this.txtEditarDocumento.MaxLength = 32767;
            this.txtEditarDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarDocumento.Name = "txtEditarDocumento";
            this.txtEditarDocumento.PasswordChar = '\0';
            this.txtEditarDocumento.SelectedText = "";
            this.txtEditarDocumento.SelectionLength = 0;
            this.txtEditarDocumento.SelectionStart = 0;
            this.txtEditarDocumento.Size = new System.Drawing.Size(213, 23);
            this.txtEditarDocumento.TabIndex = 1;
            this.txtEditarDocumento.TabStop = false;
            this.txtEditarDocumento.UseSystemPasswordChar = false;
            // 
            // txtEditarNombre
            // 
            this.txtEditarNombre.Depth = 0;
            this.txtEditarNombre.Hint = "Nombre cliente";
            this.txtEditarNombre.Location = new System.Drawing.Point(109, 22);
            this.txtEditarNombre.MaxLength = 32767;
            this.txtEditarNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarNombre.Name = "txtEditarNombre";
            this.txtEditarNombre.PasswordChar = '\0';
            this.txtEditarNombre.SelectedText = "";
            this.txtEditarNombre.SelectionLength = 0;
            this.txtEditarNombre.SelectionStart = 0;
            this.txtEditarNombre.Size = new System.Drawing.Size(213, 23);
            this.txtEditarNombre.TabIndex = 0;
            this.txtEditarNombre.TabStop = false;
            this.txtEditarNombre.UseSystemPasswordChar = false;
            // 
            // lblEditarCliente
            // 
            this.lblEditarCliente.AutoSize = true;
            this.lblEditarCliente.Depth = 0;
            this.lblEditarCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditarCliente.Location = new System.Drawing.Point(331, 85);
            this.lblEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditarCliente.Name = "lblEditarCliente";
            this.lblEditarCliente.Size = new System.Drawing.Size(59, 19);
            this.lblEditarCliente.TabIndex = 1;
            this.lblEditarCliente.Text = "TITULO";
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.AutoSize = true;
            this.btnActualizarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCliente.Depth = 0;
            this.btnActualizarCliente.Icon = null;
            this.btnActualizarCliente.Location = new System.Drawing.Point(135, 390);
            this.btnActualizarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Primary = true;
            this.btnActualizarCliente.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarCliente.TabIndex = 2;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnEditarSalir
            // 
            this.btnEditarSalir.AutoSize = true;
            this.btnEditarSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarSalir.Depth = 0;
            this.btnEditarSalir.Icon = null;
            this.btnEditarSalir.Location = new System.Drawing.Point(505, 390);
            this.btnEditarSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarSalir.Name = "btnEditarSalir";
            this.btnEditarSalir.Primary = true;
            this.btnEditarSalir.Size = new System.Drawing.Size(58, 36);
            this.btnEditarSalir.TabIndex = 3;
            this.btnEditarSalir.Text = "Salir";
            this.btnEditarSalir.UseVisualStyleBackColor = true;
            this.btnEditarSalir.Click += new System.EventHandler(this.btnEditarSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.AutoSize = true;
            this.btnAgregarNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarNuevo.Depth = 0;
            this.btnAgregarNuevo.Icon = null;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(316, 390);
            this.btnAgregarNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Primary = true;
            this.btnAgregarNuevo.Size = new System.Drawing.Size(131, 36);
            this.btnAgregarNuevo.TabIndex = 5;
            this.btnAgregarNuevo.Text = "Agregar nuevo";
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEditarSalir);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.lblEditarCliente);
            this.Controls.Add(this.pnlEditarCliente);
            this.Name = "frmEditarCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.frmEditarCliente_Load);
            this.pnlEditarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditarCliente;
        private MaterialSkin.Controls.MaterialLabel lblEditarCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarSalir;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarNuevo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}