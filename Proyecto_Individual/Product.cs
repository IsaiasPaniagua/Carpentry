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
    public partial class Product : Form
    {
        SqlConnection con;
        Connection c = new Connection();
        public Product()
        {
            InitializeComponent();
            Update.Enabled = false;
            BtnEliminar.Enabled = false;
            con = new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
        }
        private void Product_Load(object sender, EventArgs e)
        {
            c.llenarcbidempleado(cbidempleado);
            DTGVProducto.DataSource = c.SelectDataTable("select * from producto");
            
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            c.AgregarProducto(Convert.ToInt32(txtidproducto.Text),Convert.ToInt32(cbidempleado.Text),txtnombre.Text,
                              txtdescripcion.Text,Convert.ToInt32(txtexistencia.Text),pbfoto);
            txtidproducto.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtexistencia.Clear();
            pbfoto.Image.Dispose();
            pbfoto.Image = null;
            DTGVProducto.DataSource = c.SelectDataTable("select * from producto");
        }
        private void BtnAddImagen_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pbfoto.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=carpentry;Integrated Security=True");
            con.Open();
            SqlCommand cn = new SqlCommand("Select * from producto where idproducto = @idproducto", con);
            cn.Parameters.AddWithValue("@idproducto", txtidproducto.Text);

            SqlDataReader dr = cn.ExecuteReader();
            if (dr.Read())
            {
                cbidempleado.Text = dr["idempleado"].ToString();
                txtnombre.Text = dr["nombre"].ToString();
                txtdescripcion.Text = dr["descripcion"].ToString();
                txtexistencia.Text = dr["existencia"].ToString();
            }
            else
            {
                MessageBox.Show("El id no se encuentra en la BD");
            }
            c.VerImagen(pbfoto,Convert.ToInt32(txtidproducto.Text));
            Update.Enabled = true;
            BtnEliminar.Enabled = true;
            DTGVProducto.DataSource = c.SelectDataTable("select * from producto");
            con.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            c.ModificarProducto(Convert.ToInt32(txtidproducto.Text),Convert.ToInt32(cbidempleado.Text),txtnombre.Text,txtdescripcion.Text,Convert.ToInt32(txtexistencia.Text));
            c.ModificarImagen(Convert.ToInt32(txtidproducto.Text),pbfoto);
            DTGVProducto.DataSource = c.SelectDataTable("select * from producto");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar = "delete producto where idproducto =" + txtidproducto.Text;
                c.Eliminar(eliminar);
                txtidproducto.Clear();
                txtnombre.Clear();
                txtdescripcion.Clear();
                txtexistencia.Clear();
                pbfoto.Image.Dispose();
                pbfoto.Image = null;
                DTGVProducto.DataSource = c.SelectDataTable("select * from producto");
                MessageBox.Show("Registro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar: " + ex.ToString());
            }
            BtnEliminar.Enabled = false;
            Update.Enabled = false;
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            DTGVProducto.DataSource = c.SelectDataTable("select * from producto");
            Form fr = new RtosProductos();
            fr.Show();
        }
    }
}
