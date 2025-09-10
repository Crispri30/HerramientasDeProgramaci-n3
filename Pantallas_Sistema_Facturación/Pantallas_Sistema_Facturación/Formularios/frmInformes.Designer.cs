namespace Pantallas_Sistema_Facturación
{
    partial class frmInformes
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.radbtnEnpantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.radbtnPDF = new MaterialSkin.Controls.MaterialRadioButton();
            this.radbtnExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbSeleccionarinforme = new System.Windows.Forms.ComboBox();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgInformes = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgInformes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(252, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(324, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "GENERADOR DE INFORMES DE FACTURACION";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(176, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "SELECCIONAR INFORME";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(459, 138);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Ordenar por...";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 176);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(90, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Fecha inicio";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(21, 211);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(82, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Fecha final";
            // 
            // radbtnEnpantalla
            // 
            this.radbtnEnpantalla.AutoSize = true;
            this.radbtnEnpantalla.Depth = 0;
            this.radbtnEnpantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.radbtnEnpantalla.Location = new System.Drawing.Point(254, 190);
            this.radbtnEnpantalla.Margin = new System.Windows.Forms.Padding(0);
            this.radbtnEnpantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radbtnEnpantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.radbtnEnpantalla.Name = "radbtnEnpantalla";
            this.radbtnEnpantalla.Ripple = true;
            this.radbtnEnpantalla.Size = new System.Drawing.Size(97, 30);
            this.radbtnEnpantalla.TabIndex = 5;
            this.radbtnEnpantalla.TabStop = true;
            this.radbtnEnpantalla.Text = "En pantalla";
            this.radbtnEnpantalla.UseVisualStyleBackColor = true;
            // 
            // radbtnPDF
            // 
            this.radbtnPDF.AutoSize = true;
            this.radbtnPDF.Depth = 0;
            this.radbtnPDF.Font = new System.Drawing.Font("Roboto", 10F);
            this.radbtnPDF.Location = new System.Drawing.Point(389, 190);
            this.radbtnPDF.Margin = new System.Windows.Forms.Padding(0);
            this.radbtnPDF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radbtnPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.radbtnPDF.Name = "radbtnPDF";
            this.radbtnPDF.Ripple = true;
            this.radbtnPDF.Size = new System.Drawing.Size(73, 30);
            this.radbtnPDF.TabIndex = 6;
            this.radbtnPDF.TabStop = true;
            this.radbtnPDF.Text = "En PDF";
            this.radbtnPDF.UseVisualStyleBackColor = true;
            // 
            // radbtnExcel
            // 
            this.radbtnExcel.AutoSize = true;
            this.radbtnExcel.Depth = 0;
            this.radbtnExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.radbtnExcel.Location = new System.Drawing.Point(525, 190);
            this.radbtnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.radbtnExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radbtnExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.radbtnExcel.Name = "radbtnExcel";
            this.radbtnExcel.Ripple = true;
            this.radbtnExcel.Size = new System.Drawing.Size(81, 30);
            this.radbtnExcel.TabIndex = 7;
            this.radbtnExcel.TabStop = true;
            this.radbtnExcel.Text = "En Excel";
            this.radbtnExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerar.Depth = 0;
            this.btnGenerar.Icon = null;
            this.btnGenerar.Location = new System.Drawing.Point(230, 237);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Primary = true;
            this.btnGenerar.Size = new System.Drawing.Size(144, 36);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbSeleccionarinforme
            // 
            this.cmbSeleccionarinforme.FormattingEnabled = true;
            this.cmbSeleccionarinforme.Location = new System.Drawing.Point(230, 139);
            this.cmbSeleccionarinforme.Name = "cmbSeleccionarinforme";
            this.cmbSeleccionarinforme.Size = new System.Drawing.Size(121, 21);
            this.cmbSeleccionarinforme.TabIndex = 9;
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(590, 136);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 10;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(130, 176);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(80, 20);
            this.dtFechaInicio.TabIndex = 11;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(130, 211);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(80, 20);
            this.dtFechaFinal.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(462, 237);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(124, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgInformes
            // 
            this.dgInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInformes.Location = new System.Drawing.Point(72, 289);
            this.dgInformes.Name = "dgInformes";
            this.dgInformes.Size = new System.Drawing.Size(639, 149);
            this.dgInformes.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgInformes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.cmbOrdenar);
            this.Controls.Add(this.cmbSeleccionarinforme);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.radbtnExcel);
            this.Controls.Add(this.radbtnPDF);
            this.Controls.Add(this.radbtnEnpantalla);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            ((System.ComponentModel.ISupportInitialize)(this.dgInformes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton radbtnEnpantalla;
        private MaterialSkin.Controls.MaterialRadioButton radbtnPDF;
        private MaterialSkin.Controls.MaterialRadioButton radbtnExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerar;
        private System.Windows.Forms.ComboBox cmbSeleccionarinforme;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgInformes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}