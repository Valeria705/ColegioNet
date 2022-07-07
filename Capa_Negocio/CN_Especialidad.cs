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
    public class CN_Especialidad
    {
        CD_Especialidad capaDatos = new CD_Especialidad();

        public bool guardar_especialidad(CE_Especialidad oespe4)
        {
            return capaDatos.guardar_especialidad(oespe4);
        }

        /*public bool anular_especialidad(CE_Especialidad oespe5)
        {
            return capaDatos.anular_especialidad(oespe5);
        }*/

        public CE_Especialidad consultar_especialidad(string oespe6)
        {
            return capaDatos.consultar_especialidad(oespe6);
        }
        public List<CE_Especialidad> consultar_especialidades()
        {
            return capaDatos.consultar_especialidades();
        }

        public bool modificar_especialidad(CE_Especialidad existente)
        {
            return capaDatos.modificar_especialidad(existente);

        }

        public bool eliminar_especialidad(string id_Especialidad)
        {
            return capaDatos.eliminar_especialidad(id_Especialidad);
        }
    }
}
