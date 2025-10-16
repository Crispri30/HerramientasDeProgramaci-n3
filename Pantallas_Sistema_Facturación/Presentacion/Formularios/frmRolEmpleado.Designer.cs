namespace Presentacion
{
    partial class frmRolEmpleado
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
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBusquedaRol = new System.Windows.Forms.TextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(344, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Rol de Empleados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescripcionRol);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.txtNombreRol);
            this.panel1.Controls.Add(this.txtBusquedaRol);
            this.panel1.Location = new System.Drawing.Point(81, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 221);
            this.panel1.TabIndex = 1;
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Location = new System.Drawing.Point(94, 110);
            this.txtDescripcionRol.Multiline = true;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(415, 92);
            this.txtDescripcionRol.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(79, 71);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(204, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Descripción detallada del Rol";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre de Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(83, 32);
            this.txtNombreRol.MaxLength = 32767;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(241, 23);
            this.txtNombreRol.TabIndex = 1;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // txtBusquedaRol
            // 
            this.txtBusquedaRol.Location = new System.Drawing.Point(18, 13);
            this.txtBusquedaRol.Name = "txtBusquedaRol";
            this.txtBusquedaRol.Size = new System.Drawing.Size(45, 20);
            this.txtBusquedaRol.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(210, 378);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(455, 378);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(104, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRolEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmRolEmpleado";
            this.Text = "frmRolEmpleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private System.Windows.Forms.TextBox txtBusquedaRol;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}