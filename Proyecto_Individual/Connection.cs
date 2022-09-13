using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Individual
{
    class Connection
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        DataRow dar;
        public Connection()
        {
            try
            {
                cn = new SqlConnection("Data Source =.; Initial Catalog = carpentry; Integrated Security = True");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: ", ex.ToString());
            }
        }
        //metodo para abrir conexion
        public SqlConnection Conexion()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            return cn;
        }
        //metodo para cerrar conexion
        public void Closeconexion()
        {
            if (cn.State != ConnectionState.Closed)
                cn.Close();
        }
        // metodo para jalar a mi datagriedview la tabla con todos los datos
        public DataTable SelectDataTable(string query)
        {
            dt = new DataTable();
            try
            {
                Conexion();
                da = new SqlDataAdapter(query, cn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Closeconexion();
            return dt;
        }
        // metodo para llenar el combobox de mi idcarpinteria
        public void llenarcbidcarpinteria(ComboBox cbidcarpinteria)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select idcarpinteria from carpinteria", cn);
            da.Fill(ds,"carpinteria");
            cbidcarpinteria.DataSource = ds.Tables[0].DefaultView;
            cbidcarpinteria.ValueMember = "idcarpinteria";
        }
        // metodo para llenar el combobox de mi idarea
        public void llenarcbidarea(ComboBox cbidarea)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select idarea from area", cn);
            da.Fill(ds, "area");
            cbidarea.DataSource = ds.Tables[0].DefaultView;
            cbidarea.ValueMember = "idarea";
        }
        // metodo para llenar el combobox de mi idempleado
        public void llenarcbidempleado(ComboBox cbidempleado)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select idempleado from empleado", cn);
            da.Fill(ds, "empleado");
            cbidempleado.DataSource = ds.Tables[0].DefaultView;
            cbidempleado.ValueMember = "idempleado";
        }
        // metodo general para la eliminacion de los datos
        public bool Eliminar(string query)
        {
            bool salida;
            try
            {
                Conexion();
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                salida = true;
            }
            catch
            {
                salida = false;
            }
            Closeconexion();
            return salida;
        }
        // comienza codigo de mi clase carpinteria
        public string AgregarCarpinteria(int idcarpinteria, string nombre, string ciudad, string telefono)
        {
            string salida = "Datos insertados";
            try
            {
                Conexion();
                cmd = new SqlCommand("Insert into carpinteria(idcarpinteria,nombre,ciudad,telefono) " +
                                     "values(" + idcarpinteria + ",'" + nombre + "','" + ciudad + "','" + telefono + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron insertar los datos: "+ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        public int CarpinteriasRegistradas(int idcarpinteria)
        {
            int count = 0;
            try
            {
                Conexion();
                cmd = new SqlCommand("Select * from carpinteria where idcarpinteria=" + idcarpinteria + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
            }
            Closeconexion();
            return count;
        }
        public void RegistrosCarpinteria(int idcarpinteria, TextBox nombre, TextBox ciudad, TextBox telefono)
        {
            try
            {
                Conexion();
                cmd = new SqlCommand("select * from carpinteria where idcarpinteria=" + idcarpinteria + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nombre.Text = dr["nombre"].ToString();
                    ciudad.Text = dr["ciudad"].ToString();
                    telefono.Text = dr["telefono"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            Closeconexion();
        }
        public string ModificarCarpinteria(int idcarpinteria, string nombre, string ciudad, string telefono)
        {
            string salida = "Datos modificados" +
                "";
            try
            {
                Conexion();
                cmd = new SqlCommand("Update carpinteria set nombre ='" + nombre + "' ,ciudad='" + ciudad + "',telefono='" + telefono + "' where idcarpinteria=" +idcarpinteria+ "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        // comienza codigo de mi clase area
        public string AgregarArea(int idarea, int idcarpinteria, string nombre, string funcion)
        {
            string salida = "Datos insertados";
            try
            {
                Conexion();
                cmd = new SqlCommand("Insert into area(idarea,idcarpinteria,nombre,funcion) " +
                                     "values("+idarea+","+idcarpinteria+",'"+nombre+"','"+funcion+"')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron insertar los datos: " + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        public string ModificarArea(int idarea, int idcarpinteria, string nombre, string funcion)
        {
            string salida = "Datos modificados" +
                "";
            try
            {
                Conexion();
                cmd = new SqlCommand("Update area set idcarpinteria =" + idcarpinteria + " ,nombre='" + nombre + "',funcion='" + funcion + "' where idarea=" + idarea + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        // comienza codigo de mi clase empleado
        public string AgregarEmpleado(int idempleado, int idcarpinteria, int idarea, string nombre, string direccion, string telefono, string rfc)
        {
            string salida = "Datos insertados";
            try
            {
                Conexion();
                cmd = new SqlCommand("Insert into empleado(idempleado,idcarpinteria,idarea,nombre,direccion,telefono,rfc) " +
                      "values(" + idempleado + "," + idcarpinteria + ","+idarea+",'" + nombre + "','" + direccion + "','"+telefono+"','"+rfc+"')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron insertar los datos: " + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        public string ModificarEmpleado(int idempleado, int idcarpinteria, int idarea, string nombre, string direccion, string telefono, string rfc)
        {
            string salida = "Datos modificados" +
                "";
            try
            {
                Conexion();
                cmd = new SqlCommand("Update empleado set idcarpinteria =" + idcarpinteria + " ,idarea="+idarea+",nombre='" + nombre + "',direccion='" + direccion + "',telefono='"+telefono+"',rfc='"+rfc+"' where idempleado=" + idempleado + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        // comienza codigo de mi clase producto
        public string AgregarProducto(int idproducto, int idempleado, string nombre, string descripcion, int existencia, PictureBox pbfoto)
        {
            string salida = "Datos insertados";

            try
            {
                Conexion();
                cmd = new SqlCommand("Insert into producto(idproducto,idempleado,nombre,descripcion,existencia,imagen) " +
                    "                 values(@idproducto,@idempleado,@nombre,@descripcion,@existencia,@imagen)", cn);
                cmd.Parameters.Add("@idproducto", SqlDbType.Int);
                cmd.Parameters.Add("@idempleado", SqlDbType.Int);
                cmd.Parameters.Add("@nombre", SqlDbType.NChar);
                cmd.Parameters.Add("@descripcion", SqlDbType.NChar);
                cmd.Parameters.Add("@existencia", SqlDbType.Int);
                cmd.Parameters.Add("@imagen", SqlDbType.Image);

                cmd.Parameters["@idproducto"].Value = idproducto;
                cmd.Parameters["@idempleado"].Value = idempleado;
                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@descripcion"].Value = descripcion;
                cmd.Parameters["@existencia"].Value = existencia;

                MemoryStream ms = new MemoryStream();

                pbfoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron insertar los datos: " + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        public void VerImagen(PictureBox foto, int idproducto)
        {
            try
            {
                da = new SqlDataAdapter("Select imagen from producto where idproducto = " + idproducto + "", cn);
                ds = new DataSet();
                da.Fill(ds, "producto");
                byte[] datos = new byte[0];
                dar = ds.Tables["producto"].Rows[0];
                datos = (byte[])dar["imagen"];
                MemoryStream ms = new MemoryStream(datos);
                foto.Image = System.Drawing.Bitmap.FromStream(ms);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la imagen" + ex.ToString());
            }
        }
        public string ModificarProducto(int idproducto, int idempleado, string nombre, string descripcion, int existencia)
        {
            string salida = "Datos modificados" +
                "";
            try
            {
                Conexion();
                cmd = new SqlCommand("Update producto set idempleado =" + idempleado + " ,nombre='" + nombre + "',descripcion='" + descripcion + "',existencia=" +existencia+ " where idproducto=" + idproducto + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        public string ModificarImagen(int idproducto, PictureBox imagen)
        {
            string salida = "Se pudo modificar";
            try
            {
                Conexion();
                cmd = new SqlCommand("Update producto set imagen=@imagen where idproducto=" + idproducto + "", cn);
                cmd.Parameters.Add("@imagen", SqlDbType.Image);
                MemoryStream ms = new MemoryStream();

                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cambiar la foto");
            }
            Closeconexion();
            return salida;
        }
        // comienza codigo de mi clase cliente
        public string AgregarCliente(int idcliente, int idcarpinteria, string nombre, string direccion, string telefono)
        {
            string salida = "Datos insertados";
            try
            {
                Conexion();
                cmd = new SqlCommand("Insert into cliente(idcliente,idcarpinteria,nombre,direccion,telefono) " +
                                     "values(" + idcliente + "," + idcarpinteria + ",'" + nombre + "','" + direccion + "','"+telefono+"')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron insertar los datos: " + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
        public string ModificarCliente(int idcliente, int idcarpinteria, string nombre, string direccion, string telefono)
        {
            string salida = "Datos modificados" +
                "";
            try
            {
                Conexion();
                cmd = new SqlCommand("Update cliente set idcarpinteria =" + idcarpinteria + " ,nombre='" + nombre + "',direccion='" + direccion + "',telefono='"+telefono+"' where idcliente=" + idcliente + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
            Closeconexion();
            return salida;
        }
    }
}
