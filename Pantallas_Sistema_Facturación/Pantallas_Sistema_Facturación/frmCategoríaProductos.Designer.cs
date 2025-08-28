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
            this.txtBusquedaCategoria = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            // txtBusquedaCategoria
            // 
            this.txtBusquedaCategoria.Location = new System.Drawing.Point(52, 142);
            this.txtBusquedaCategoria.Name = "txtBusquedaCategoria";
            this.txtBusquedaCategoria.Size = new System.Drawing.Size(53, 20);
            this.txtBusquedaCategoria.TabIndex = 1;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre categoria";
            this.txtNombreCategoria.Location = new System.Drawing.Point(52, 214);
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
            this.btnActualizarCategoria.Location = new System.Drawing.Point(179, 347);
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
            this.btnSalirCategoria.AutoSize = true;
            this.btnSalirCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCategoria.Depth = 0;
            this.btnSalirCategoria.Icon = null;
            this.btnSalirCategoria.Location = new System.Drawing.Point(512, 347);
            this.btnSalirCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Primary = true;
            this.btnSalirCategoria.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCategoria.TabIndex = 4;
            this.btnSalirCategoria.Text = "Salir";
            this.btnSalirCategoria.UseVisualStyleBackColor = true;
            this.btnSalirCategoria.Click += new System.EventHandler(this.btnSalirCategoria_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCategoríaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.txtBusquedaCategoria);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmCategoríaProductos";
            this.Text = "frmCategoríaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtBusquedaCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCategoria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}