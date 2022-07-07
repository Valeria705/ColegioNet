using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Aula
    {
        CD_Aula capaDatos = new CD_Aula();

        public bool guardar_Aula(CE_Aula Aula)
        {
            return capaDatos.guardar_Aula(Aula);
        }

        public bool modificar_Aula(CE_Aula Aula)
        {
            return capaDatos.modificar_Aula(Aula);
        }

        public bool eliminar_Aula(string Id)
        {
            return capaDatos.eliminar_Aula(Id);
        }

        /*public bool anula_Aulas(CE_Aula conect5)
        {
            return nuevoAula.anula_Aulas(conect5);
        }*/

        public CE_Aula consultar_Aula(string Id)
        {
            return capaDatos.consultar_Aula(Id);
        }

        public List<CE_Aula> consultar_Aulas()
        {
            return capaDatos.consultar_Aulas();
        }
    }
}
