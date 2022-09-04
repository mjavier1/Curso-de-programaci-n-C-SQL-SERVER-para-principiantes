using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SQLconn
{
     class Class_con:Class_datos
    {
        //MJDEVELOP\SQLEXPRESS
        SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=winform;Data Source=MJDEVELOP\\SQLEXPRESS");
        public void conectar()
        {

            try
            {

                con.Open();
                MessageBox.Show("Estamos conectados");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }
        public void insertar()
        {


            try
            {
                SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=employeserver;Data Source=MJDEVELOP\\SQLEXPRESS");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ("insertar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar,50);
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@edad", SqlDbType.Int);
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@deparmento", SqlDbType.VarChar, 50);

                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@apellido"].Value = apellido;
                cmd.Parameters["@edad"].Value = edad;
                cmd.Parameters["@direccion"].Value = direccion;
                cmd.Parameters["@deparmento"].Value = deparmento;
               
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                //  MessageBox.Show("")
                con.Close();




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            } 
        }
        public void buscar(DataGridView dg)
        {
            try
            {
                SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=employeserver;Data Source=MJDEVELOP\\SQLEXPRESS");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd.Connection = con;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ("buscar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters["@codigo"].Value=codigo;
                da= new SqlDataAdapter(cmd);
                da.Fill(dt);
                dg.DataSource = dt;




            }
            catch (Exception ex)
            {

                throw;
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void view(DataGridView dg)
        {
            try
            {
                SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=employeserver;Data Source=MJDEVELOP\\SQLEXPRESS");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd.Connection = con;
                con.Open();
              
                cmd.CommandText = ("select * from datos");
             //   cmd.CommandType = CommandType.StoredProcedure;
             

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dg.DataSource = dt;




            }
            catch (Exception ex)
            {

                throw;
                MessageBox.Show(ex.ToString());
            }
        }
        public void actualizar()
        {

            try
            {
                SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=employeserver;Data Source=MJDEVELOP\\SQLEXPRESS");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = ("actualizarup");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@edad", SqlDbType.Int);
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@deparmento", SqlDbType.VarChar, 50);

              
                cmd.Parameters["@codigo"].Value = codigo;
                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@apellido"].Value = apellido;
                cmd.Parameters["@edad"].Value = edad;
                cmd.Parameters["@direccion"].Value = direccion;
                cmd.Parameters["@deparmento"].Value = deparmento;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                //  MessageBox.Show("")
                Form1 obj = new Form1();
                obj.Show();
                
                con.Close();




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                }



        }
        public void eliminar(DataGridView dg)
        {
            try
            {
                SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=employeserver;Data Source=MJDEVELOP\\SQLEXPRESS");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd.Connection = con;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ("eliminar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters["@codigo"].Value = codigo;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dg.DataSource = dt;




            }
            catch (Exception ex)
            {

                throw;
                MessageBox.Show("Error" + ex.Message);
            }
        }
























    }
}
