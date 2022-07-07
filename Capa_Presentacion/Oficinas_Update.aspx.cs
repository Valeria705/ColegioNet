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
    public partial class Oficinas_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request["Id"];

            CN_Oficina capaNegocio = new CN_Oficina();

            CE_Oficina x = capaNegocio.consultar_oficina(Id);

            Id_Oficina.Text = x.Id_Oficina;
            Nom_Oficina.Text = x.Nom_Oficina;
            Tel_Oficina.Text = Convert.ToString(x.Tel_Oficina);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Oficina existente = new CE_Oficina();
            existente.Id_Oficina = Request["Id_Oficina"];
            existente.Nom_Oficina = Request["Nom_Oficina"];
            existente.Tel_Oficina = Convert.ToInt32(Request["Tel_Oficina"]);

            CN_Oficina capaNegocio = new CN_Oficina();

            capaNegocio.Modificar_Oficina(existente);

            Response.Redirect("Oficinas_Select.aspx");
        }
    }
}