using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
namespace Proyecto_Individual
{
    public partial class Employee : Form
    {
        SqlConnection con;
        Connection c = new Connection();

        public Employee()
        {
            InitializeComponent();
            Update.Enabled = false;
            BtnEliminar.Enabled = false;
            con = new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            c.llenarcbidcarpinteria(cbidcarpinteria);
            c.llenarcbidarea(cbidarea);
            DTGVEmpleado.DataSource = c.SelectDataTable("select * from empleado");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            c.AgregarEmpleado(Convert.ToInt32(txtidempleado.Text),Convert.ToInt32(cbidcarpinteria.Text),Convert.ToInt32(cbidarea.Text),
                               txtnombre.Text, txtdireccion.Text, txttelefono.Text, txtrfc.Text);
            txtnombre.Clear();
            txtidempleado.Clear();
            txtdireccion.Clear();
            txtrfc.Clear();
            txttelefono.Clear();
            DTGVEmpleado.DataSource = c.SelectDataTable("select * from empleado");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
            con.Open();
            SqlCommand cn = new SqlCommand("Select * from empleado where idempleado = @idempleado", con);
            cn.Parameters.AddWithValue("@idempleado", txtidempleado.Text);

            SqlDataReader dr = cn.ExecuteReader();
            if (dr.Read())
            {
                cbidcarpinteria.Text = dr["idcarpinteria"].ToString();
                cbidarea.Text = dr["idarea"].ToString();
                txtnombre.Text = dr["nombre"].ToString();
                txtdireccion.Text = dr["direccion"].ToString();
                txttelefono.Text = dr["telefono"].ToString();
                txtrfc.Text = dr["rfc"].ToString();
            }
            else
            {
                MessageBox.Show("El id no se encuentra en la BD");
            }
            con.Close();
            Update.Enabled = true;
            BtnEliminar.Enabled = true;
            DTGVEmpleado.DataSource = c.SelectDataTable("select * from empleado");
            

        }

        private void Update_Click(object sender, EventArgs e)
        {
            c.ModificarEmpleado(Convert.ToInt32(txtidempleado.Text),Convert.ToInt32(cbidcarpinteria.Text),Convert.ToInt32(cbidarea.Text),txtnombre.Text,txtdireccion.Text,txttelefono.Text,txtrfc.Text);
            DTGVEmpleado.DataSource = c.SelectDataTable("select * from empleado");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar = "delete empleado where idempleado =" + txtidempleado.Text;
                c.Eliminar(eliminar);
                txtnombre.Clear();
                txtidempleado.Clear();
                txtdireccion.Clear();
                txttelefono.Clear();
                txtrfc.Clear();
                MessageBox.Show("Registro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar: " + ex.ToString());
            }
            BtnEliminar.Enabled = false;
            Update.Enabled = false;
            DTGVEmpleado.DataSource = c.SelectDataTable("select * from empleado");
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            DTGVEmpleado.DataSource = c.SelectDataTable("select * from empleado");
            Form fr = new RtosEmpleados();
            fr.Show();
        }
    }
}
