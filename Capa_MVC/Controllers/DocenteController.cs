using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_MVC.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Index()
        {
            CN_Docente capaNegocio = new CN_Docente();

            List<CE_Docente> lista = capaNegocio.Consultar_Docentes();

            return View(lista);
        }
        public ActionResult Insertar() { 
            return View();
        }
        public ActionResult InsertarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Docente doc= new CE_Docente();

            doc.Id_Docente = Request["ID_Docente"];
            doc.Nom_Docente = Request["Nom_Docente"];
            doc.Dire_Docente = Request["Dire_Docente"];
            doc.Tel_Docente = Convert.ToInt64(Request["Tel_Docente"]);


            // 2.Llamar a la capa de datos

            CN_Docente capaNegocio = new CN_Docente();

            capaNegocio.guardar_Docente(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Modificar()
        {
            // 1. Recuperar parametro Id del queryString
            String Id= Request["Id"];

            // 2. Consultar de la base de datos el decente por medio de este Id

            CN_Docente capaNegocio = new CN_Docente();
            CE_Docente x = capaNegocio.Consultar_Docente(Id);

            // 3. LLevar ese docente a la vista
              return View(x);

        }
        public ActionResult ModificarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Docente doc = new CE_Docente();

            doc.Id_Docente = Request["ID_Docente"];
            doc.Nom_Docente = Request["Nom_Docente"];
            doc.Dire_Docente = Request["Dire_Docente"];
            doc.Tel_Docente = Convert.ToInt64(Request["Tel_Docente"]);


            // 2.Llamar a la capa de datos

            CN_Docente capaNegocio = new CN_Docente();

            capaNegocio.Modificar_Docente(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Eliminar() {
            //1. 
            String Id = Request["Id"];
            CN_Docente capaNegocio = new CN_Docente();

            capaNegocio.Eliminar_Docente(Id);

            return RedirectToAction("Index");

        }


    }
}