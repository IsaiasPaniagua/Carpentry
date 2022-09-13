using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Individual
{
    public partial class Carpinteria : Form
    {
        Form1 fr = new Form1();
        Connection c = new Connection();
        public Carpinteria()
        {
            InitializeComponent();

            Update.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void Carpinteria_Load(object sender, EventArgs e)
        {
            DTGVCarpinteria.DataSource = c.SelectDataTable("select * from carpinteria");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            c.AgregarCarpinteria(Convert.ToInt32(txtidcarpinteria.Text),txtnombre.Text, txtciudad.Text, txttelefono.Text);
            txtidcarpinteria.Clear();
            txtnombre.Clear();
            txtciudad.Clear();
            txttelefono.Clear();
            DTGVCarpinteria.DataSource = c.SelectDataTable("select * from carpinteria");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(c.CarpinteriasRegistradas(Convert.ToInt32(txtidcarpinteria.Text))>0)
            {
                c.RegistrosCarpinteria(Convert.ToInt32(txtidcarpinteria.Text), txtnombre, txtciudad, txttelefono);
                Update.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("La carpinteria que buscas no existe");
                txtidcarpinteria.Clear();
                txtnombre.Clear();
                txtciudad.Clear();
                txttelefono.Clear();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

            c.ModificarCarpinteria(Convert.ToInt32(txtidcarpinteria.Text),txtnombre.Text,txtciudad.Text,txttelefono.Text);
            DTGVCarpinteria.DataSource = c.SelectDataTable("select * from carpinteria");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar = "delete carpinteria where idcarpinteria =" + txtidcarpinteria.Text;
                c.Eliminar(eliminar);
                txtidcarpinteria.Clear();
                txtnombre.Clear();
                txtciudad.Clear();
                txttelefono.Clear();
                DTGVCarpinteria.DataSource = c.SelectDataTable("select * from carpinteria");
                MessageBox.Show("Registro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar: "+ex.ToString());
            }
            BtnEliminar.Enabled = false;
            Update.Enabled = false;
            }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            DTGVCarpinteria.DataSource = c.SelectDataTable("select * from carpinteria");
            Form PDF = new RCarpinterias();
            PDF.Show();
        }

    }
    }

