using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Individual
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void BtnClientes_Click(object sender, EventArgs e)
        //{
        //    AbrirFormProveedor(new Cliente());
        //}

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (f1.Width == 40)
            {
                f1.Visible = false;
                f1.Width = 215;
                PanelTransition.ShowSync(f1);
                LogoTransition.ShowSync(Logo);
            }
            else
            {
                LogoTransition.Hide(Logo);
                f1.Visible = false;
                f1.Width = 40;
                PanelTransition.ShowSync(f1);
            }
        }
        //private void AbrirFormProveedor(object FormProveedor)
        //{
        //    if (this.Contenedor.Controls.Count > 0)
        //        this.Contenedor.Controls.RemoveAt(0);
        //    Form fp = FormProveedor as Form;
        //    fp.TopLevel = false;
        //    fp.Dock = DockStyle.Fill;
        //    this.Contenedor.Controls.Add(fp);
        //    this.Contenedor.Tag = fp;
        //    fp.Show();
        //}
    
        //private void BtnProveedor_Click(object sender, EventArgs e)
        //{
        //    AbrirFormProveedor(new Proveedor());
        //}

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void BtnEmpleados_Click(object sender, EventArgs e)
        //{
        //    AbrirFormProveedor(new Empleado());
        //}

        private void Logo_Click(object sender, EventArgs e)
        {
            AbrirFormsHijas(new Fondo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Logo_Click(null, e);
            Conexion c = new Conexion();
            Connection cn = new Connection();
        }

        //private void BtnProductos_Click(object sender, EventArgs e)
        //{
        //    AbrirFormProveedor(new Producto());
        //}
        public void AbrirFormsHijas(object FormHijas)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fp = FormHijas as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fp);
            this.Contenedor.Tag = fp;
            fp.Show();
        }

        private void BtnCarpinteria_Click(object sender, EventArgs e)
        {
            AbrirFormsHijas(new Carpinteria());
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            AbrirFormsHijas(new Area());
        }

        private void BtnEmpleadoc_Click(object sender, EventArgs e)
        {
            AbrirFormsHijas(new Employee());
        }

        private void BtnProductoc_Click(object sender, EventArgs e)
        {
            AbrirFormsHijas(new Product());
        }

        private void BtnClientec_Click(object sender, EventArgs e)
        {
            AbrirFormsHijas(new Client());
        }


        //private void bunifuFlatButton1_Click(object sender, EventArgs e)
        //{
        //    if (this.Contenedor.Controls.Count > 0)
        //        this.Contenedor.Controls.RemoveAt(0);
        //}
    }
}
