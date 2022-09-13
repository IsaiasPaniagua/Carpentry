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
    public partial class Area : Form
    {
        SqlConnection con;
        Connection c = new Connection();
        public Area()
        {
            InitializeComponent();
            Update.Enabled = false;
            BtnEliminar.Enabled = false;
            con= new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
        }

        private void Area_Load(object sender, EventArgs e)
        {
            c.llenarcbidcarpinteria(cbidcarpinteria);
            DTGVArea.DataSource = c.SelectDataTable("select * from area");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            c.AgregarArea(Convert.ToInt32(txtidarea.Text),Convert.ToInt32(cbidcarpinteria.Text),txtnombre.Text, txtfuncion.Text);
            txtidarea.Clear();
            txtnombre.Clear();
            txtfuncion.Clear();
            DTGVArea.DataSource = c.SelectDataTable("select * from area");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
            con.Open();
            SqlCommand cn = new SqlCommand("Select * from area where idarea = @idarea",con);
            cn.Parameters.AddWithValue("@idarea", txtidarea.Text);
            
            SqlDataReader dr = cn.ExecuteReader();
            if(dr.Read())
            {
                cbidcarpinteria.Text = dr["idcarpinteria"].ToString();
                txtnombre.Text = dr["nombre"].ToString();
                txtfuncion.Text = dr["funcion"].ToString();
            }
            else
            {
                MessageBox.Show("El id no se encuentra en la BD");
            }
            con.Close();
            Update.Enabled = true;
            BtnEliminar.Enabled = true;
            DTGVArea.DataSource = c.SelectDataTable("select * from area");

        }

        private void Update_Click(object sender, EventArgs e)
        {
            c.ModificarArea(Convert.ToInt32(txtidarea.Text),Convert.ToInt32(cbidcarpinteria.Text),txtnombre.Text,txtfuncion.Text);
            DTGVArea.DataSource = c.SelectDataTable("select * from area");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar = "delete area where idarea =" + txtidarea.Text;
                c.Eliminar(eliminar);
                txtidarea.Clear();
                txtnombre.Clear();
                txtfuncion.Clear();
                DTGVArea.DataSource = c.SelectDataTable("select * from area");
                MessageBox.Show("Registro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar: " + ex.ToString());
            }
            BtnEliminar.Enabled = false;
            Update.Enabled = false;
            DTGVArea.DataSource = c.SelectDataTable("select * from area");
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            DTGVArea.DataSource = c.SelectDataTable("select * from area");
            Form fr = new RtosAreas();
            fr.Show();
        }
    }
    
}
