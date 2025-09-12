namespace Pantallas_Sistema_Facturación
{
    partial class frmListaClientes
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(312, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(180, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRAR CLIENTES";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Hint = "Buscar por cliente...";
            this.txtBuscarCliente.Location = new System.Drawing.Point(21, 108);
            this.txtBuscarCliente.MaxLength = 32767;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.SelectionLength = 0;
            this.txtBuscarCliente.SelectionStart = 0;
            this.txtBuscarCliente.Size = new System.Drawing.Size(213, 23);
            this.txtBuscarCliente.TabIndex = 1;
            this.txtBuscarCliente.TabStop = false;
            this.txtBuscarCliente.UseSystemPasswordChar = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AutoSize = true;
            this.btnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Icon = null;
            this.btnBuscarCliente.Location = new System.Drawing.Point(349, 95);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = true;
            this.btnBuscarCliente.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSize = true;
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.Icon = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(537, 95);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Primary = true;
            this.btnNuevoCliente.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(553, 369);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNombre,
            this.txtDocumento,
            this.txtTelefono,
            this.btnEditarCliente,
            this.btnBorrarCliente});
            this.dgClientes.Location = new System.Drawing.Point(37, 166);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(639, 183);
            this.dgClientes.TabIndex = 5;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.HeaderText = "NOMBRE";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Width = 200;
            // 
            // txtDocumento
            // 
            this.txtDocumento.HeaderText = "DOCUMENTO";
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Width = 70;
            // 
            // txtTelefono
            // 
            this.txtTelefono.HeaderText = "TELEFONO";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Width = 70;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.HeaderText = "EDITAR";
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseColumnTextForButtonValue = true;
            this.btnEditarCliente.Width = 70;
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.HeaderText = "BORRAR";
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Text = "Borrar";
            this.btnBorrarCliente.UseColumnTextForButtonValue = true;
            this.btnBorrarCliente.Width = 70;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmListaClientes";
            this.Text = "frmListaClientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarCliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarCliente;
        private System.Windows.Forms.Timer timer1;
    }
}