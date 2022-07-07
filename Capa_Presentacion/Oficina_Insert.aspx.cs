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
    public partial class Oficina_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Oficina nuevo = new CE_Oficina();
            nuevo.Id_Oficina = Id_Oficina.Text;
            nuevo.Nom_Oficina = Nom_Oficina.Text;
            nuevo.Tel_Oficina = Convert.ToInt32(Tel_Oficina.Text);

            CN_Oficina capaNegocio = new CN_Oficina();

            capaNegocio.guardar_Oficina(nuevo);

            Response.Redirect("Oficinas_Select.aspx");
        }
    }
}