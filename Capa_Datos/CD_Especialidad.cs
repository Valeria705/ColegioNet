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
    public class CD_Especialidad
    {
        Conexion titulo = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public bool guardar_especialidad(CE_Especialidad oespe1)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = titulo.conectar("BD_Colegio");
                cmd.CommandText = "insertar_especialidad";
                cmd.Parameters.Add("@Id_Especialidad", oespe1.Id_Especialidad);
                cmd.Parameters.Add("@Nom_Especialidad", oespe1.Nom_Especialidad);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool modificar_especialidad(CE_Especialidad oespe2)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = titulo.conectar("BD_Colegio");
                cmd.CommandText = "Modif_Especialidad";
                cmd.Parameters.Add("@Id_Especialidad", oespe2.Id_Especialidad);
                cmd.Parameters.Add("@Nom_Especialidad", oespe2.Nom_Especialidad);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool eliminar_especialidad(string id_Especialidad)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = titulo.conectar("BD_Colegio");
                cmd.CommandText = "Borrar_Especialidad";
                cmd.Parameters.Add("@Id_Especialidad", id_Especialidad);
       
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*public bool anular_especialidad(CE_Especialidad oespe2)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "modificar_especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", oespe2.Id_Especialidad1);
                experiencia.Parameters.Add("@Nom_Especialidad", oespe2.Id_Especialidad1);
                experiencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }*/

        public CE_Especialidad  consultar_especialidad(string  oespe3)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = titulo.conectar("BD_Colegio");
                cmd.CommandText = "Consul_Especialidad";
                cmd.Parameters.Add("@Id_Especialidad", oespe3);
                SqlDataAdapter info = new SqlDataAdapter(cmd);
                DataSet consulta = new DataSet();
                info.Fill(consulta);

                DataTable dt = consulta.Tables[0];
                DataRow row = dt.Rows[0];

                CE_Especialidad especialidad = new CE_Especialidad();

                especialidad.Id_Especialidad = Convert.ToString(row["Id_Especialidad"]);
                especialidad.Nom_Especialidad = Convert.ToString(row["Nom_Especialidad"]);

                return especialidad;
                
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<CE_Especialidad> consultar_especialidades()
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = titulo.conectar("BD_Colegio");
                cmd.CommandText = "Consul_Especialidades";
                 
                SqlDataAdapter info = new SqlDataAdapter(cmd);
                DataSet consulta = new DataSet();
                info.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                List<CE_Especialidad> lista = new List<CE_Especialidad>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Especialidad x = new CE_Especialidad();
                    x.Id_Especialidad = Convert.ToString(row["Id_Especialidad"]);
                    x.Nom_Especialidad = Convert.ToString(row["Nom_Especialidad"]);
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
