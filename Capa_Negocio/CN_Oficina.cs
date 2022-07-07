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
    public class CN_Oficina
    {
        CD_Oficina capaDatos = new CD_Oficina();

        public bool guardar_oficina(CE_Oficina ofi4)
        {
            return capaDatos.guardar_oficina(ofi4);
        }

        public List<CE_Oficina> Consultar_Oficinas()
        {
            return capaDatos.Consultar_Oficinas();
        }

        /*public bool anular_oficina(CE_Oficina ofi5)
        {
            return nuevaoficina.anular_oficina(ofi5);
        }*/

        public CE_Oficina consultar_oficina(string id)
        {
            return capaDatos.consultar_oficina(id);
        }

        public bool guardar_Oficina(CE_Oficina nuevo)
        {
            return capaDatos.guardar_oficina(nuevo);
        }

        public bool eliminar_Oficina(string id_Oficina)
        {
            return capaDatos.eliminar_Oficina(id_Oficina);
        }

        public bool Modificar_Oficina(CE_Oficina existente)
        {
            return capaDatos.Modificar_Oficina(existente);
        }
    }
}
