using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa_Presentacion
{
    public partial class Oficinas_Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string contenido = "";

            CN_Oficina capaNegocio = new CN_Oficina();

            List<CE_Oficina> lista = capaNegocio.Consultar_Oficinas();

            foreach (CE_Oficina x in lista)
            {
                contenido = contenido + "<tr>";
                contenido = contenido + "<td>" + x.Id_Oficina + "</td>";
                contenido = contenido + "<td>" + x.Nom_Oficina + "</td>";
                contenido = contenido + "<td>" + x.Tel_Oficina + "</td>";
                contenido = contenido + "<td><a href='Oficinas_Update.aspx?Id=" + x.Id_Oficina + "'>modificar</a></td>";
                contenido = contenido + "<td><a href='Oficinas_Delete.aspx?Id=" + x.Id_Oficina + "'>eliminar</a></td>";
                contenido = contenido + "</tr>";

            }

            tabla_body.InnerHtml = contenido;
        }
    }
}