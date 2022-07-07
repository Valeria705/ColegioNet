using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Oficina
    {
        private string id_Oficina;
        private string nom_Oficina;
        private long tel_Oficina;

        public string Id_Oficina { get => id_Oficina; set => id_Oficina = value; }
        public string Nom_Oficina { get => nom_Oficina; set => nom_Oficina = value; }
        public long Tel_Oficina { get => tel_Oficina; set => tel_Oficina = value; }
    }
}
