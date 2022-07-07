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
    public class CD_Oficina
    {
        Conexion casa = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public bool guardar_oficina(CE_Oficina ofi1)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = casa.conectar("BD_Colegio");
                cmd.CommandText = "Insertar_Oficina";
                cmd.Parameters.Add("@Id_Oficina", ofi1.Id_Oficina);
                cmd.Parameters.Add("@Nom_Oficina", ofi1.Nom_Oficina);
                cmd.Parameters.Add("@Tel_Oficina", ofi1.Tel_Oficina);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CE_Oficina> Consultar_Oficinas()
        {
           
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = casa.conectar("BD_Colegio");
                cmd.CommandText = "Consul_Oficinas";
                SqlDataAdapter info = new SqlDataAdapter(cmd);
                DataSet consulta = new DataSet();
                info.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                List<CE_Oficina> lista = new List<CE_Oficina>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Oficina x = new CE_Oficina();

                    x.Id_Oficina = Convert.ToString(row["Id_Oficina"]);
                    x.Tel_Oficina = Convert.ToInt32(row["Tel_Oficina"]);
                    x.Nom_Oficina = Convert.ToString(row["Nom_Oficina"]);
                        

                    lista.Add(x);
                }

                return lista;
            }
            catch (Exception e)
            {

                throw;
            }
            
        }

        public bool eliminar_Oficina(string id_Oficina)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = casa.conectar("BD_Colegio");
                cmd.CommandText = "Borrar_Oficina";
                cmd.Parameters.Add("@Id_Oficina", id_Oficina);
                
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool guardar_oficinas(CE_Oficina oficina)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = casa.conectar("BD_Colegio");
                cmd.CommandText = "Consul_Oficinas";
                cmd.Parameters.Add("@Id_Oficina", oficina.Id_Oficina);
                cmd.Parameters.Add("@Nom_Oficina", oficina.Nom_Oficina);
                cmd.Parameters.Add("@Tel_Oficina", oficina.Tel_Oficina);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public CE_Oficina consultar_oficina(string ofi3)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = casa.conectar("BD_Colegio");
            cmd.CommandText = "Consul_Oficina";
            cmd.Parameters.Add("@Id_Oficina", ofi3);
            SqlDataAdapter info = new SqlDataAdapter(cmd);
            DataSet consulta = new DataSet();
            info.Fill(consulta);
            DataTable dt = consulta.Tables[0];
  
            DataRow row = dt.Rows[0];

            CE_Oficina x = new CE_Oficina();

            x.Id_Oficina = Convert.ToString(row["Id_Oficina"]);
            x.Tel_Oficina = Convert.ToInt32(row["Tel_Oficina"]);
            x.Nom_Oficina = Convert.ToString(row["Nom_Oficina"]);
           

            return x;
        }
        public bool Modificar_Oficina(CE_Oficina oprofesor5)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = casa.conectar("BD_Colegio");
                cmd.CommandText = "Modif_Oficina";
                cmd.Parameters.Add("@ID_Oficina", oprofesor5.Id_Oficina);
                cmd.Parameters.Add("@Nom_Oficina", oprofesor5.Nom_Oficina);
                cmd.Parameters.Add("@Tel_Oficina", oprofesor5.Tel_Oficina);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
