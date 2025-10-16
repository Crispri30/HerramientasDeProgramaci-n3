namespace Presentacion
{
    partial class FrmFacturas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgDetalleFactura = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(282, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(235, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRACION DE FACTURAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEmpleado);
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.cmbEstadoFactura);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.txtTotalFactura);
            this.panel1.Controls.Add(this.txtTotalIVA);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.txtNroFactura);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 151);
            this.panel1.TabIndex = 1;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(122, 64);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(100, 21);
            this.cmbEmpleado.TabIndex = 14;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(122, 32);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(100, 21);
            this.cmbCliente.TabIndex = 13;
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Location = new System.Drawing.Point(442, 43);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(90, 21);
            this.cmbEstadoFactura.TabIndex = 12;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(324, 43);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(110, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Estado Factura";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(358, 8);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(49, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Fecha";
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(442, 7);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(87, 20);
            this.dateTime.TabIndex = 9;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "Total Factura";
            this.txtTotalFactura.Location = new System.Drawing.Point(328, 108);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(201, 23);
            this.txtTotalFactura.TabIndex = 8;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // txtTotalIVA
            // 
            this.txtTotalIVA.Depth = 0;
            this.txtTotalIVA.Hint = "Total IVA";
            this.txtTotalIVA.Location = new System.Drawing.Point(328, 79);
            this.txtTotalIVA.MaxLength = 32767;
            this.txtTotalIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.PasswordChar = '\0';
            this.txtTotalIVA.SelectedText = "";
            this.txtTotalIVA.SelectionLength = 0;
            this.txtTotalIVA.SelectionStart = 0;
            this.txtTotalIVA.Size = new System.Drawing.Size(201, 23);
            this.txtTotalIVA.TabIndex = 7;
            this.txtTotalIVA.TabStop = false;
            this.txtTotalIVA.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(3, 91);
            this.txtDescuento.MaxLength = 32767;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(201, 23);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 66);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Empleado";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 34);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Cliente";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(122, 6);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNroFactura.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 5);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 21);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Nro Factura";
            // 
            // btnActualizarFactura
            // 
            this.btnActualizarFactura.AutoSize = true;
            this.btnActualizarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarFactura.Depth = 0;
            this.btnActualizarFactura.Icon = null;
            this.btnActualizarFactura.Location = new System.Drawing.Point(623, 182);
            this.btnActualizarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarFactura.Name = "btnActualizarFactura";
            this.btnActualizarFactura.Primary = true;
            this.btnActualizarFactura.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarFactura.TabIndex = 2;
            this.btnActualizarFactura.Text = "Actualizar";
            this.btnActualizarFactura.UseVisualStyleBackColor = true;
            this.btnActualizarFactura.Click += new System.EventHandler(this.btnActualizarFactura_Click);
            // 
            // dgDetalleFactura
            // 
            this.dgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleFactura.Location = new System.Drawing.Point(15, 309);
            this.dgDetalleFactura.Name = "dgDetalleFactura";
            this.dgDetalleFactura.Size = new System.Drawing.Size(545, 129);
            this.dgDetalleFactura.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(623, 366);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(15, 287);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(110, 19);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "Detalle Factura";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgDetalleFactura);
            this.Controls.Add(this.btnActualizarFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txtNroFactura;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker dateTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalIVA;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarFactura;
        private System.Windows.Forms.DataGridView dgDetalleFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}