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
    class Conexion
    {
    //    private string connection = string.Empty;
    //    SqlConnection cn;
    //    SqlCommand cmd;
    //    SqlDataReader dr;
    //    SqlDataAdapter da;
    //    DataTable dt;
    //    DataSet ds;
    //    DataRow dar;

    //    public Conexion()
    //    {
    //        try
    //        {
    //            cn = new SqlConnection("Data Source=.;Initial Catalog=carpinter;Integrated Security=True");
    //            cn.Open();
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show("No se conecto con la base de datos: ",ex.ToString());
    //        }
    //    }
    //    public SqlConnection conecttod()
    //    {
    //        if (cn.State != ConnectionState.Open)
    //        {
    //            cn.Open();
    //        }
    //        return cn;
    //    }
    //    public void closeconexion()
    //    {
    //        if (cn.State != ConnectionState.Closed)
    //            cn.Close();

    //    }
    //    public bool executecomand(string query)
    //    {
    //        bool exito;
    //        try
    //        {
    //            conecttod();
    //            cmd = new SqlCommand(query, cn);
    //            cmd.ExecuteNonQuery();
    //            exito = true;
    //        }
    //        catch 
    //        {
    //            exito = false;
    //        }
    //        cn.Close();
    //        return exito;
    //    }

    //    public string Agregar(int noproveedor, string nombre, string direccion, string telefono, string rfc, string provee)
    //    {
    //        string salida = "si se inserto";
    //        try
    //        {
    //            cmd = new SqlCommand("Insert into socio(noproveedor,nombre,direccion,telefono,rfc,provee) values("+noproveedor+",'"+nombre+"','"+direccion+"','"+telefono+"','"+rfc+"','"+provee+"')",cn);
    //            cmd.ExecuteNonQuery();
    //        }
    //        catch (Exception ex)
    //        {
    //            salida = "No se inserto"+ex.ToString();
    //        }
    //        return salida;
    //    }
    //    public int ProveedoresRegistrados(int noproveedor)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            cmd = new SqlCommand("Select * from socio where noproveedor="+noproveedor+"", cn);
    //            dr = cmd.ExecuteReader();
    //            while(dr.Read())
    //            {
    //                count++;
    //            }
    //            dr.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("No se pudo consultar"+ex.ToString());
    //        }
    //        return count;
    //    }
    //    public void Registroproveedor(int id, TextBox nom, TextBox dire, TextBox tel, TextBox rfc, TextBox prove)
    //    {
    //        try
    //        {
    //            cmd = new SqlCommand("select * from socio where noproveedor=" + id+"", cn);
    //            dr = cmd.ExecuteReader();
    //            if (dr.Read())
    //            {
    //                nom.Text = dr["nombre"].ToString();
    //                dire.Text = dr["direccion"].ToString();
    //                tel.Text = dr["telefono"].ToString();
    //                rfc.Text = dr["rfc"].ToString();
    //                prove.Text = dr["provee"].ToString();
    //            }
    //            dr.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("no se pudo llenar"+ex.ToString());

    //        }
    //    }
    //    public string ModificarProveedor(int noproveedor, string nombre, string direccion, string telefono, string rfc, string provee)
    //    {
    //        string salida = "si se inserto";
    //        try
    //        {
    //            cmd = new SqlCommand("Update socio set nombre ='"+nombre+"' ,direccion='"+direccion+"',telefono='"+telefono+"',rfc='"+rfc+"',provee='"+provee+"' where noproveedor="+noproveedor+"",cn);
    //            cmd.ExecuteNonQuery();
    //        }
    //        catch (Exception ex)
    //        {
    //            salida = "No se pudo modificar" + ex.ToString();
    //        }
    //        return salida;
    //    }

    //    public DataTable SelectDataTable(string query)
    //    {
    //        dt = new DataTable();
    //        try
    //        {
    //            conecttod();
    //            da = new SqlDataAdapter(query, cn);
    //            da.Fill(dt);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //        return dt;
    //    }
    //    // termina codigo de proveedores

    //    // inicia codigo de empleados
    //    public string AgregarEmpleado(int noempleado, string nombre, string direccion, string telefono, string rfc, string area)
    //    {
    //        string salida = "si se inserto";
    //        try
    //        {
    //            cmd = new SqlCommand("Insert into empleado(noempleado,nombre,direccion,telefono,rfc,area) values(" + noempleado + ",'" + nombre + "','" + direccion + "','" + telefono + "','" + rfc + "','" + area + "')", cn);
    //            cmd.ExecuteNonQuery();
    //        }
    //        catch (Exception ex)
    //        {
    //            salida = "No se inserto" + ex.ToString();
    //        }
    //        return salida;
    //    }
    //    public int EmpleadosRegistrados(int noempleado)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            cmd = new SqlCommand("Select * from empleado where noempleado=" + noempleado + "", cn);
    //            dr = cmd.ExecuteReader();
    //            while (dr.Read())
    //            {
    //                count++;
    //            }
    //            dr.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("No se pudo consultar" + ex.ToString());
    //        }
    //        return count;
    //    }
    //    public void Registroempleado(int id, TextBox nom, TextBox dire, TextBox tel, TextBox rfc, TextBox are)
    //    {
    //        try
    //        {
    //            cmd = new SqlCommand("Select * from empleado where noempleado=" + id + "", cn);
    //            dr = cmd.ExecuteReader();
    //            if (dr.Read())
    //            {
    //                nom.Text = dr["nombre"].ToString();
    //                dire.Text = dr["direccion"].ToString();
    //                tel.Text = dr["telefono"].ToString();
    //                rfc.Text = dr["rfc"].ToString();
    //                are.Text = dr["area"].ToString();
    //            }
    //            dr.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("no se pudo llenar" + ex.ToString());

    //        }
    //    }
    //    public string ModificarEmpleado(int noempleado, string nombre, string direccion, string telefono, string rfc, string area)
    //    {
    //        string salida = "si se inserto";
    //        try
    //        {
    //            cmd = new SqlCommand("Update empleado set nombre ='" + nombre + "' ,direccion='" + direccion + "',telefono='" + telefono + "',rfc='" + rfc + "',area='" + area + "' where noempleado=" + noempleado + "", cn);
    //            cmd.ExecuteNonQuery();
    //        }
    //        catch (Exception ex)
    //        {
    //            salida = "No se pudo modificar" + ex.ToString();
    //        }
    //        return salida;
    //    }
    //    // termina codigo de empleado

    //    // inicia codigo de cliente
    //    // termina codigo de cliente

    //    // inicia codigo de producto
    //    public string InsertarImagen(int codigo, string nombre, string descripcion, int existencia, int precio, PictureBox pbfoto)
    //    {
            
    //        string mensaje = "se inserto la imagen";
            
    //        try
    //        {
    //            cmd = new SqlCommand("Insert into productos(codigo,nombre,descripcion,existencia,precio,imagen) values(@codigo,@nombre,@descripcion,@existencia,@precio,@imagen)", cn);
    //            cmd.Parameters.Add("@codigo", SqlDbType.Int);
    //            cmd.Parameters.Add("@nombre", SqlDbType.NChar);
    //            cmd.Parameters.Add("@descripcion", SqlDbType.NChar);
    //            cmd.Parameters.Add("@existencia", SqlDbType.Int);
    //            cmd.Parameters.Add("@precio", SqlDbType.Int);
    //            cmd.Parameters.Add("@imagen", SqlDbType.Image);

    //            cmd.Parameters["@codigo"].Value = codigo;
    //            cmd.Parameters["@nombre"].Value = nombre;
    //            cmd.Parameters["@descripcion"].Value = descripcion;
    //            cmd.Parameters["@existencia"].Value = existencia;
    //            cmd.Parameters["@precio"].Value = precio;
    //            System.IO.MemoryStream ms = new System.IO.MemoryStream();

    //            pbfoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
    //            cmd.Parameters["@imagen"].Value = ms.GetBuffer();
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show(mensaje);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("No se inserto la imagen"+ex.ToString());
    //        }
    //        return mensaje;
    //    }
    //    public void BuscarProducto(string nombre, TextBox codigo, TextBox descripcion, TextBox existencia, TextBox precio)
    //    {
    //        try
    //        {
    //            MessageBox.Show("Si se encontro");
    //            cmd = new SqlCommand("Select * from productos where nombre='" + nombre + "'", cn);
    //            dr = cmd.ExecuteReader();
    //            if (dr.Read())
    //            {
    //                codigo.Text = dr["codigo"].ToString();
    //                descripcion.Text = dr["descripcion"].ToString();
    //                existencia.Text = dr["existencia"].ToString();
    //                precio.Text = dr["precio"].ToString();
    //            }
    //            dr.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("no se encontro"+ ex.ToString());
    //        }
    //    }
    //    public void VerImagen(PictureBox foto, string nombre)
    //    {
    //        try
    //        {
    //            da = new SqlDataAdapter("Select imagen from productos where nombre = '" + nombre + "'", cn);
    //            ds = new DataSet();
    //            da.Fill(ds, "productos");
    //            byte[] datos = new byte[0];
    //            dar = ds.Tables["productos"].Rows[0];
    //            datos = (byte[])dar["imagen"];
    //            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
    //            foto.Image = System.Drawing.Bitmap.FromStream(ms);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("No se encontro la imagen"+ex.ToString());
    //        }
    //    }
    //    public string ModificarProducto(int codigo, string nombre, string descripcion, int existencia, int precio)
    //    {
    //        string salida = "Se modifico correctamente";
    //        try
    //        {
    //            cmd = new SqlCommand("Update productos set codigo =" + codigo + " ,descripcion='" + descripcion + "',existencia=" + existencia + ",precio=" + precio + " where nombre='" + nombre+ "'", cn);
    //            cmd.ExecuteNonQuery();

    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("No se pudo modificar"+ex.ToString());
    //        }
    //        return salida;
    //    }
    //    public string ModificarImagen(string nombre, PictureBox imagen)
    //    {
    //        string salida = "Se pudo modificar";
    //        try
    //        {
    //            cmd = new SqlCommand("Update productos set imagen=@imagen where nombre='" +nombre+ "'", cn);
    //            cmd.Parameters.Add("@imagen", SqlDbType.Image);
    //            MemoryStream ms = new MemoryStream();

    //            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
    //            cmd.Parameters["@imagen"].Value = ms.GetBuffer();
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show(salida);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("No se pudo cambiar la foto");
    //        }
    //        return salida;
    //    }
    //    public void EliminarImagen(PictureBox foto, string nombre)
    //    {
    //        try
    //        {
    //            da = new SqlDataAdapter("Delete imagen from productos where nombre = '" + nombre + "'", cn);
    //            ds = new DataSet();
    //            da.Fill(ds, "productos");
    //            byte[] datos = new byte[0];
    //            dar = ds.Tables["productos"].Rows[0];
    //            datos = (byte[])dar["imagen"];
    //            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
    //            foto.Image = System.Drawing.Bitmap.FromStream(ms);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("No se encontro la imagen" + ex.ToString());
    //        }
    //    }
    }
}
