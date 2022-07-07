using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Data;

namespace Capa_Datos
{
    public class CD_Alumno
    {
        Conexion estudio = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public bool guardar_alumno(CE_Alumno oalumno)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = estudio.conectar("BD_Colegio");
                cmd.CommandText = "Insertar_Alumno";
                cmd.Parameters.Add("@Id_Alumno", oalumno.Id_Alumno);
                cmd.Parameters.Add("@Nom_Alumno", oalumno.Nom_Alumno);
                cmd.Parameters.Add("@Dir_Alumno", oalumno.Dir_Alumno);
                cmd.Parameters.Add("@Tel_Alumno", oalumno.Tel_Alumno);
                cmd.Parameters.Add("@Grp_Alumno", oalumno.Grp_Alumno);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool modificar_alumno(CE_Alumno oalumno)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = estudio.conectar("BD_Colegio");
                cmd.CommandText = "Modif_Alumno";
                cmd.Parameters.Add("@Id_Alumno", oalumno.Id_Alumno);
                cmd.Parameters.Add("@Nom_Alumno", oalumno.Nom_Alumno);
                cmd.Parameters.Add("@Dir_Alumno", oalumno.Dir_Alumno);
                cmd.Parameters.Add("@Tel_Alumno", oalumno.Tel_Alumno);
                cmd.Parameters.Add("@Grp_Alumno", oalumno.Grp_Alumno);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool eliminar_alumno(string Id_Alumno)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = estudio.conectar("BD_Colegio");
                cmd.CommandText = "Borrar_Alumno";
                cmd.Parameters.Add("@Id_Alumno", Id_Alumno);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*public bool anula_alumno(CE_Alumno oalumno2)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "modificar_alumno";
                avanzados.Parameters.Add("@Id_Alumno", oalumno2.Id_Alumno);
                avanzados.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }*/

        public CE_Alumno consultar_alumno(string Id_Alumno)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = estudio.conectar("BD_Colegio");
                cmd.CommandText = "consul_alumno";
                cmd.Parameters.Add("@Id_Alumno", Id_Alumno);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet consulta = new DataSet();
                da.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                CE_Alumno item = new CE_Alumno();

                DataRow row = dt.Rows[0];
                
                CE_Alumno x = new CE_Alumno();

                x.Id_Alumno = Convert.ToString(row["Id_Alumno"]);
                x.Tel_Alumno = Convert.ToInt64(row["Tel_Alumno"]);
                x.Nom_Alumno = Convert.ToString(row["Nom_Alumno"]);
                x.Dir_Alumno = Convert.ToString(row["Dir_Alumno"]);
                x.Grp_Alumno = Convert.ToString(row["Grp_Alumno"]);

                return x;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CE_Alumno> consultar_alumnos()
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = estudio.conectar("BD_Colegio");
                cmd.CommandText = "consul_alumnos";
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                DataTable dt = ds.Tables[0];

                List<CE_Alumno> lista = new List<CE_Alumno>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Alumno x = new CE_Alumno();

                    x.Id_Alumno = Convert.ToString(row["Id_Alumno"]);
                    x.Tel_Alumno = Convert.ToInt64(row["Tel_Alumno"]);
                    x.Nom_Alumno = Convert.ToString(row["Nom_Alumno"]);
                    x.Dir_Alumno = Convert.ToString(row["Dir_Alumno"]);
                    x.Grp_Alumno = Convert.ToString(row["Grp_Alumno"]);

                    lista.Add(x);
                }

                return lista;

            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
