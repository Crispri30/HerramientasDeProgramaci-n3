namespace Pantallas_Sistema_Facturación
{
    partial class frmCategoríaProductos
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
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(288, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(203, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "CATEGORÍA DE PRODUCTOS";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre categoria";
            this.txtNombreCategoria.Location = new System.Drawing.Point(72, 255);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(230, 23);
            this.txtNombreCategoria.TabIndex = 2;
            this.txtNombreCategoria.TabStop = false;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.AutoSize = true;
            this.btnActualizarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCategoria.Depth = 0;
            this.btnActualizarCategoria.Icon = null;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(530, 201);
            this.btnActualizarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Primary = true;
            this.btnActualizarCategoria.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarCategoria.TabIndex = 3;
            this.btnActualizarCategoria.Text = "Actualizar";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // btnSalirCategoria
            // 
            this.btnSalirCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCategoria.Depth = 0;
            this.btnSalirCategoria.Icon = null;
            this.btnSalirCategoria.Location = new System.Drawing.Point(115, 353);
            this.btnSalirCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Primary = true;
            this.btnSalirCategoria.Size = new System.Drawing.Size(124, 36);
            this.btnSalirCategoria.TabIndex = 4;
            this.btnSalirCategoria.Text = "Salir";
            this.btnSalirCategoria.UseVisualStyleBackColor = true;
            this.btnSalirCategoria.Click += new System.EventHandler(this.btnSalirCategoria_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "Codigo categoria";
            this.txtCodigo.Location = new System.Drawing.Point(72, 187);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(230, 23);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(530, 136);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(103, 36);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(530, 276);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(103, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCategoríaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmCategoríaProductos";
            this.Text = "frmCategoríaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCategoria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
    }
}