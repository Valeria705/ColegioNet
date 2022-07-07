using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_MVC.Controllers
{
    public class OficinaController : Controller
    {
        // GET: Oficina
        public ActionResult Index()
        {
            CN_Oficina capaNegocio = new CN_Oficina();

            List<CE_Oficina> lista = capaNegocio.Consultar_Oficinas();

            return View(lista);
        }
        public ActionResult Insertar()
        {
            return View();
        }
        public ActionResult InsertarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Oficina doc = new CE_Oficina();

            doc.Id_Oficina = Request["Id_Oficina"];
            doc.Nom_Oficina = Request["Nom_Oficina"];
            doc.Tel_Oficina = Convert.ToInt64(Request["Tel_Oficina"]);


            // 2.Llamar a la capa de datos

            CN_Oficina capaNegocio = new CN_Oficina();

            capaNegocio.guardar_Oficina(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Modificar()
        {
            // 1. Recuperar parametro Id del queryString
            String Id = Request["Id"];

            // 2. Consultar de la base de datos el decente por medio de este Id


            CN_Oficina capaNegocio = new CN_Oficina();
            CE_Oficina x = capaNegocio.consultar_oficina(Id);

            // 3. LLevar ese docente a la vista
            return View(x);

        }
        public ActionResult ModificarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Oficina doc = new CE_Oficina();

            doc.Id_Oficina = Request["Id_Oficina"];
            doc.Nom_Oficina = Request["Nom_Oficina"];
            doc.Tel_Oficina = Convert.ToInt64(Request["Tel_Oficina"]);



            // 2.Llamar a la capa de datos

            CN_Oficina capaNegocio = new CN_Oficina();

            capaNegocio.Modificar_Oficina(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Eliminar()
        {
            //1. 
            String Id = Request["Id"];
            CN_Oficina capaNegocio = new CN_Oficina();

            capaNegocio.eliminar_Oficina(Id);

            return RedirectToAction("Index");

        }
    }
}