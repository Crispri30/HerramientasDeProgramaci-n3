using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Datos;

namespace Presentacion
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form abrirForm)
        {
            if(this.pnlContenedor.Controls.Count > 0) //Verificar si ya había un formulario abierto
                this.pnlContenedor.Controls.RemoveAt(0); //Cerrar el formulario que ya estaba abierto, lo quita en la posición 0
            abrirForm.TopLevel = false; //Indicar que no es un formulario de nivel superior
            abrirForm.Dock = DockStyle.Fill; //llenar todo el panel
            this.pnlContenedor.Controls.Add(abrirForm); //Agregar el forms al panel
            abrirForm.Show(); //Mostrar el formulario
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes listaClientes = new frmListaClientes();
            AbrirForm(listaClientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            AbrirForm(productos);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoríaProductos categoriaProductos = new frmCategoríaProductos();
            AbrirForm(categoriaProductos);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas facturas = new FrmFacturas();
            AbrirForm(facturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            AbrirForm(informes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            AbrirForm(frmEmpleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRolEmpleado frmRolEmpleado = new frmRolEmpleado();
            AbrirForm(frmRolEmpleado);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad frmAdminSeguridad = new frmAdminSeguridad();
            AbrirForm(frmAdminSeguridad);
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda frmAyuda = new frmAyuda();
            AbrirForm(frmAyuda);
        }
        private void btnAcercade_Click(object sender, EventArgs e)
        {
            frmAcercade frmAcercade = new frmAcercade();
            AbrirForm(frmAcercade);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}