namespace Pantallas_Sistema_Facturación
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnActualizarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(285, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(246, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(81, 160);
            this.txtNombreProducto.MaxLength = 32767;
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(203, 23);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.TabStop = false;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // txtCodigoReferencia
            // 
            this.txtCodigoReferencia.Depth = 0;
            this.txtCodigoReferencia.Hint = "Código referencia";
            this.txtCodigoReferencia.Location = new System.Drawing.Point(81, 203);
            this.txtCodigoReferencia.MaxLength = 32767;
            this.txtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoReferencia.Name = "txtCodigoReferencia";
            this.txtCodigoReferencia.PasswordChar = '\0';
            this.txtCodigoReferencia.SelectedText = "";
            this.txtCodigoReferencia.SelectionLength = 0;
            this.txtCodigoReferencia.SelectionStart = 0;
            this.txtCodigoReferencia.Size = new System.Drawing.Size(203, 23);
            this.txtCodigoReferencia.TabIndex = 2;
            this.txtCodigoReferencia.TabStop = false;
            this.txtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio de compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(81, 245);
            this.txtPrecioCompra.MaxLength = 32767;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(203, 23);
            this.txtPrecioCompra.TabIndex = 3;
            this.txtPrecioCompra.TabStop = false;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio de venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(81, 291);
            this.txtPrecioVenta.MaxLength = 32767;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(203, 23);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.TabStop = false;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Depth = 0;
            this.txtCantidadStock.Hint = "Cantidad en Stock";
            this.txtCantidadStock.Location = new System.Drawing.Point(81, 339);
            this.txtCantidadStock.MaxLength = 32767;
            this.txtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.PasswordChar = '\0';
            this.txtCantidadStock.SelectedText = "";
            this.txtCantidadStock.SelectionLength = 0;
            this.txtCantidadStock.SelectionStart = 0;
            this.txtCantidadStock.Size = new System.Drawing.Size(203, 23);
            this.txtCantidadStock.TabIndex = 5;
            this.txtCantidadStock.TabStop = false;
            this.txtCantidadStock.UseSystemPasswordChar = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 139);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(42, 20);
            this.txtBusqueda.TabIndex = 6;
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Hint = "Ruta Imagen";
            this.txtRutaImagen.Location = new System.Drawing.Point(513, 203);
            this.txtRutaImagen.MaxLength = 32767;
            this.txtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.PasswordChar = '\0';
            this.txtRutaImagen.SelectedText = "";
            this.txtRutaImagen.SelectionLength = 0;
            this.txtRutaImagen.SelectionStart = 0;
            this.txtRutaImagen.Size = new System.Drawing.Size(217, 23);
            this.txtRutaImagen.TabIndex = 8;
            this.txtRutaImagen.TabStop = false;
            this.txtRutaImagen.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(509, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Categoría";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(371, 249);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Detalles producto";
            // 
            // dgProductos
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgProductos.Location = new System.Drawing.Point(505, 249);
            this.dgProductos.Name = "dgProductos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgProductos.Size = new System.Drawing.Size(274, 113);
            this.dgProductos.TabIndex = 11;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.AutoSize = true;
            this.btnActualizarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarProducto.Depth = 0;
            this.btnActualizarProducto.Icon = null;
            this.btnActualizarProducto.Location = new System.Drawing.Point(29, 388);
            this.btnActualizarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Primary = true;
            this.btnActualizarProducto.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarProducto.TabIndex = 12;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnSalirProducto
            // 
            this.btnSalirProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirProducto.Depth = 0;
            this.btnSalirProducto.Icon = null;
            this.btnSalirProducto.Location = new System.Drawing.Point(537, 388);
            this.btnSalirProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirProducto.Name = "btnSalirProducto";
            this.btnSalirProducto.Primary = true;
            this.btnSalirProducto.Size = new System.Drawing.Size(103, 36);
            this.btnSalirProducto.TabIndex = 13;
            this.btnSalirProducto.Text = "Salir";
            this.btnSalirProducto.UseVisualStyleBackColor = true;
            this.btnSalirProducto.Click += new System.EventHandler(this.btnSalirProducto_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(609, 153);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorias.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(162, 388);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(106, 36);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(323, 388);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(99, 36);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.btnSalirProducto);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCodigoReferencia);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadStock;
        private System.Windows.Forms.TextBox txtBusqueda;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagen;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dgProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private System.Windows.Forms.Timer timer1;
    }
}