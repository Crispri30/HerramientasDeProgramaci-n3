namespace Pantallas_Sistema_Facturación
{
    partial class frmPrincipal
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenú = new System.Windows.Forms.Panel();
            this.tabMenú = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.Facturacion = new System.Windows.Forms.TabPage();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.Ayuda = new System.Windows.Forms.TabPage();
            this.tabSelectorMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal.SuspendLayout();
            this.pnlMenú.SuspendLayout();
            this.tabMenú.SuspendLayout();
            this.Principal.SuspendLayout();
            this.Tablas.SuspendLayout();
            this.Facturacion.SuspendLayout();
            this.Seguridad.SuspendLayout();
            this.Ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlContenedor);
            this.pnlPrincipal.Controls.Add(this.pnlMenú);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 60);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1125, 541);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlMenú
            // 
            this.pnlMenú.Controls.Add(this.tabMenú);
            this.pnlMenú.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenú.Location = new System.Drawing.Point(0, 0);
            this.pnlMenú.Name = "pnlMenú";
            this.pnlMenú.Size = new System.Drawing.Size(200, 541);
            this.pnlMenú.TabIndex = 0;
            // 
            // tabMenú
            // 
            this.tabMenú.Controls.Add(this.Principal);
            this.tabMenú.Controls.Add(this.Tablas);
            this.tabMenú.Controls.Add(this.Facturacion);
            this.tabMenú.Controls.Add(this.Seguridad);
            this.tabMenú.Controls.Add(this.Ayuda);
            this.tabMenú.Depth = 0;
            this.tabMenú.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenú.Location = new System.Drawing.Point(0, 0);
            this.tabMenú.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenú.Name = "tabMenú";
            this.tabMenú.SelectedIndex = 0;
            this.tabMenú.Size = new System.Drawing.Size(200, 541);
            this.tabMenú.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 515);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // Tablas
            // 
            this.Tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.Tablas.Controls.Add(this.btnCategoria);
            this.Tablas.Controls.Add(this.btnProductos);
            this.Tablas.Controls.Add(this.btnClientes);
            this.Tablas.Controls.Add(this.pictureBox2);
            this.Tablas.Location = new System.Drawing.Point(4, 22);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(192, 515);
            this.Tablas.TabIndex = 1;
            this.Tablas.Text = "Tablas";
            // 
            // Facturacion
            // 
            this.Facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.Facturacion.Controls.Add(this.btnInformes);
            this.Facturacion.Controls.Add(this.btnFacturas);
            this.Facturacion.Controls.Add(this.pictureBox3);
            this.Facturacion.Location = new System.Drawing.Point(4, 22);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(192, 515);
            this.Facturacion.TabIndex = 2;
            this.Facturacion.Text = "Facturacion";
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.Seguridad.Controls.Add(this.btnSeguridad);
            this.Seguridad.Controls.Add(this.btnRoles);
            this.Seguridad.Controls.Add(this.btnEmpleados);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 515);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // Ayuda
            // 
            this.Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.Ayuda.Controls.Add(this.btnAcercade);
            this.Ayuda.Controls.Add(this.btnAyuda);
            this.Ayuda.Controls.Add(this.pictureBox5);
            this.Ayuda.Location = new System.Drawing.Point(4, 22);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(192, 515);
            this.Ayuda.TabIndex = 4;
            this.Ayuda.Text = "Ayuda";
            // 
            // tabSelectorMenu
            // 
            this.tabSelectorMenu.BaseTabControl = this.tabMenú;
            this.tabSelectorMenu.Depth = 0;
            this.tabSelectorMenu.Location = new System.Drawing.Point(144, 31);
            this.tabSelectorMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMenu.Name = "tabSelectorMenu";
            this.tabSelectorMenu.Size = new System.Drawing.Size(528, 23);
            this.tabSelectorMenu.TabIndex = 1;
            this.tabSelectorMenu.Text = "materialTabSelector1";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(203, 3);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1000, 538);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.ChatGPT_Image_26_ago_2025__11_45_17_a_m_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.salida__2_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(-4, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(197, 48);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategoria.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.lista;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(-4, 358);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(197, 48);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.TabStop = false;
            this.btnCategoria.Text = "Categorías";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductos.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.agregar_producto;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(-4, 292);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(196, 48);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.TabStop = false;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-1, 221);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(193, 48);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.TabStop = false;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.ChatGPT_Image_26_ago_2025__11_45_17_a_m_;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInformes.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(-1, 287);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(193, 48);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.TabStop = false;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFacturas.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 233);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(193, 48);
            this.btnFacturas.TabIndex = 4;
            this.btnFacturas.TabStop = false;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.ChatGPT_Image_26_ago_2025__11_45_17_a_m_;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeguridad.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(-1, 334);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(193, 48);
            this.btnSeguridad.TabIndex = 7;
            this.btnSeguridad.TabStop = false;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRoles.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 280);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(193, 48);
            this.btnRoles.TabIndex = 6;
            this.btnRoles.TabStop = false;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpleados.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(-1, 214);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(193, 48);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.TabStop = false;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.ChatGPT_Image_26_ago_2025__11_45_17_a_m_;
            this.pictureBox4.Location = new System.Drawing.Point(-4, -10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // btnAcercade
            // 
            this.btnAcercade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAcercade.FlatAppearance.BorderSize = 0;
            this.btnAcercade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAcercade.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnAcercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercade.Location = new System.Drawing.Point(-1, 310);
            this.btnAcercade.Name = "btnAcercade";
            this.btnAcercade.Size = new System.Drawing.Size(193, 48);
            this.btnAcercade.TabIndex = 7;
            this.btnAcercade.TabStop = false;
            this.btnAcercade.Text = "Acerca de...";
            this.btnAcercade.UseVisualStyleBackColor = false;
            this.btnAcercade.Click += new System.EventHandler(this.btnAcercade_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAyuda.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.nueva_cuenta;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 233);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(193, 48);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.TabStop = false;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.ChatGPT_Image_26_ago_2025__11_45_17_a_m_;
            this.pictureBox5.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabSelectorMenu);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlMenú.ResumeLayout(false);
            this.tabMenú.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.Tablas.ResumeLayout(false);
            this.Facturacion.ResumeLayout(false);
            this.Seguridad.ResumeLayout(false);
            this.Ayuda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlMenú;
        private MaterialSkin.Controls.MaterialTabControl tabMenú;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.TabPage Facturacion;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Ayuda;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnAcercade;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}