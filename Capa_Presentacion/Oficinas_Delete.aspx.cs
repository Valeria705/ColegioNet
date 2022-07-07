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
    public partial class Oficinas_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CN_Oficina capaNegocio = new CN_Oficina();

            CE_Oficina x = capaNegocio.consultar_oficina(Request["Id"]);

            Id_Oculto.Value = x.Id_Oficina;
            Id_Oficina.Text = x.Id_Oficina;

            Nom_Oficina.Text = x.Nom_Oficina;
            Tel_Oficina.Text = Convert.ToString(x.Tel_Oficina);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id_Oficina = Request["Id_Oculto"];

            CN_Oficina capaNegocio = new CN_Oficina();

            capaNegocio.eliminar_Oficina(Id_Oficina);

            Response.Redirect("Oficinas_Select.aspx");

        }
    }
}