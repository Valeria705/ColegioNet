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
    public class CD_Aula
    {
        Conexion materias = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public bool guardar_Aula(CE_Aula conect1)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = materias.conectar("BD_Colegio");
                cmd.CommandText = "Insertar_Aula";
                cmd.Parameters.Add("@Id_Aula", conect1.Id_Aula);
                cmd.Parameters.Add("@Nom_Aula", conect1.Nom_Aula);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool modificar_Aula(CE_Aula Aula)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = materias.conectar("BD_Colegio");
                cmd.CommandText = "Modif_Aula";
                cmd.Parameters.Add("@Id_Aula", Aula.Id_Aula);
                cmd.Parameters.Add("@Nom_Aula", Aula.Nom_Aula);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        
        public bool eliminar_Aula(string Id)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = materias.conectar("BD_Colegio");
                cmd.CommandText = "Borrar_Aula";
                cmd.Parameters.Add("@Id_Aula", Id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*public bool anula_Aulas(CE_Aula conect2)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "modificar_Aula";
                estudios.Parameters.Add("@Id_Aula", conect2.Id_Aula);
                estudios.Parameters.Add("@Nom_Aula", conect2.Nom_Aula);
                estudios.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }*/

        public CE_Aula consultar_Aula(string Id_Aula)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = materias.conectar("BD_Colegio");
                cmd.CommandText = "Consul_Aula";
                cmd.Parameters.Add("@Id_Aula", Id_Aula);
                SqlDataAdapter informe = new SqlDataAdapter(cmd);
                DataSet consulta = new DataSet();
                informe.Fill(consulta);

                DataTable dt = consulta.Tables[0];
                DataRow row = dt.Rows[0];

                CE_Aula Aula = new CE_Aula();

                Aula.Id_Aula = Convert.ToString(row["Id_Aula"]);
                Aula.Nom_Aula = Convert.ToString(row["Nom_Aula"]);

                return Aula;

            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public List<CE_Aula> consultar_Aulas()
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = materias.conectar("BD_Colegio");
                cmd.CommandText = "Consul_Aulas";

                SqlDataAdapter informe = new SqlDataAdapter(cmd);
                DataSet consulta = new DataSet();
                informe.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                List<CE_Aula> lista = new List<CE_Aula>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Aula x = new CE_Aula();
                    x.Id_Aula = Convert.ToString(row["Id_Aula"]);
                    x.Nom_Aula = Convert.ToString(row["Nom_Aula"]);
                    lista.Add(x);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
