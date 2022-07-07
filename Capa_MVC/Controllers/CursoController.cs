using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_MVC.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            CN_Curso capaNegocio = new CN_Curso();

            List<CE_Curso> lista = capaNegocio.consultar_cursos();

            return View(lista);
        }
        public ActionResult Insertar()
        {
            return View();
        }
        public ActionResult InsertarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Curso doc = new CE_Curso();

            doc.Id_Curso = Request["Id_Curso"];
            doc.Nom_Curso = Request["Nom_Curso"];
          


            // 2.Llamar a la capa de datos

            CN_Curso capaNegocio = new CN_Curso();

            capaNegocio.guardar_curso(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Modificar()
        {
            // 1. Recuperar parametro Id del queryString
            String Id = Request["Id"];

            // 2. Consultar de la base de datos el decente por medio de este Id


            CN_Curso capaNegocio = new CN_Curso();
            CE_Curso x = capaNegocio.consultar_curso(Id);

            // 3. LLevar ese docente a la vista
            return View(x);

        }
        public ActionResult ModificarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Curso doc = new CE_Curso();

            doc.Id_Curso = Request["Id_Curso"];
            doc.Nom_Curso = Request["Nom_Curso"];
    


            // 2.Llamar a la capa de datos

            CN_Curso capaNegocio = new CN_Curso();

            capaNegocio.modificar_curso(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Eliminar()
        {
            //1. 
            String Id = Request["Id"];
            CN_Curso capaNegocio = new CN_Curso();

            capaNegocio.eliminar_curso(Id);

            return RedirectToAction("Index");

        }


    }
}
