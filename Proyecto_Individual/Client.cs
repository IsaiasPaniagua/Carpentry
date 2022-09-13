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
    public partial class Client : Form
    {
        SqlConnection con;
        Connection c = new Connection();
        public Client()
        {
            InitializeComponent();
            Update.Enabled = false;
            BtnEliminar.Enabled = false;
            con = new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
        }

        private void Client_Load(object sender, EventArgs e)
        {
            c.llenarcbidcarpinteria(cbidcarpinteria);
            DTGVCliente.DataSource = c.SelectDataTable("select * from cliente");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            c.AgregarCliente(Convert.ToInt32(txtidcliente.Text),Convert.ToInt32(cbidcarpinteria.Text),txtnombre.Text,txtdireccion.Text,txttelefono.Text);
            txtidcliente.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            DTGVCliente.DataSource = c.SelectDataTable("select * from cliente");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
            con.Open();
            SqlCommand cn = new SqlCommand("Select * from cliente where idcliente = @idcliente", con);
            cn.Parameters.AddWithValue("@idcliente", txtidcliente.Text);

            SqlDataReader dr = cn.ExecuteReader();
            if (dr.Read())
            {
                cbidcarpinteria.Text = dr["idcarpinteria"].ToString();
                txtnombre.Text = dr["nombre"].ToString();
                txtdireccion.Text = dr["direccion"].ToString();
                txttelefono.Text = dr["telefono"].ToString();
            }
            else
            {
                MessageBox.Show("El id no se encuentra en la BD");
            }
            con.Close();
            Update.Enabled = true;
            BtnEliminar.Enabled = true;
            DTGVCliente.DataSource = c.SelectDataTable("select * from cliente");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            c.ModificarCliente(Convert.ToInt32(txtidcliente.Text),Convert.ToInt32(cbidcarpinteria.Text),txtnombre.Text,txtdireccion.Text,txttelefono.Text);
            DTGVCliente.DataSource = c.SelectDataTable("select * from cliente");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar = "delete cliente where idcliente =" +txtidcliente.Text;
                c.Eliminar(eliminar);
                txtidcliente.Clear();
                txtnombre.Clear();
                txtdireccion.Clear();
                txttelefono.Clear();
                MessageBox.Show("Registro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar: " + ex.ToString());
            }
            BtnEliminar.Enabled = false;
            Update.Enabled = false;
            DTGVCliente.DataSource = c.SelectDataTable("select * from cliente");
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            DTGVCliente.DataSource = c.SelectDataTable("select * from cliente");
            Form fr = new RtosClientes();
            fr.Show();
        }
    }
    
}
