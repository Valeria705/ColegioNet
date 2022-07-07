using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_MVC.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            CN_Aula capaNegocio = new CN_Aula();

            List<CE_Aula> lista = capaNegocio.consultar_Aulas();

            return View(lista);
        }
        public ActionResult Insertar()
        {
            return View();
        }
        public ActionResult InsertarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Aula doc = new CE_Aula();

            doc.Id_Aula = Request["Id_Aula"];
            doc.Nom_Aula = Request["Nom_Aula"];



            // 2.Llamar a la capa de datos

            CN_Aula capaNegocio = new CN_Aula();

            capaNegocio.guardar_Aula(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Modificar()
        {
            // 1. Recuperar parametro Id del queryString
            String Id = Request["Id"];

            // 2. Consultar de la base de datos el decente por medio de este Id


            CN_Aula capaNegocio = new CN_Aula();
            CE_Aula x = capaNegocio.consultar_Aula(Id);

            // 3. LLevar ese docente a la vista
            return View(x);

        }
        public ActionResult ModificarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Aula doc = new CE_Aula();

            doc.Id_Aula = Request["Id_Aula"];
            doc.Nom_Aula = Request["Nom_Aula"];



            // 2.Llamar a la capa de datos

            CN_Aula capaNegocio = new CN_Aula();

            capaNegocio.modificar_Aula(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Eliminar()
        {
            //1. 
            String Id = Request["Id"];
            CN_Aula capaNegocio = new CN_Aula();

            capaNegocio.eliminar_Aula(Id);

            return RedirectToAction("Index");

        }


    }
}
