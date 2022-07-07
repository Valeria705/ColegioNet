using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_MVC.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            CN_Alumno capaNegocio = new CN_Alumno();

            List<CE_Alumno> lista = capaNegocio.consultar_alumnos();

            return View(lista);
        }
        public ActionResult Insertar()
        {
            return View();
        }
        public ActionResult InsertarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Alumno doc = new CE_Alumno();

            doc.Id_Alumno = Request["Id_Alumno"];
            doc.Nom_Alumno = Request["Nom_Alumno"];
            doc.Dir_Alumno = Request["Dir_Alumno"];
            doc.Tel_Alumno = Convert.ToInt64(Request["Tel_Alumno"]);
            doc.Grp_Alumno = Request["Grp_Alumno"];


            // 2.Llamar a la capa de datos

            CN_Alumno capaNegocio = new CN_Alumno();

            capaNegocio.guardar_alumno(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Modificar()
        {
            // 1. Recuperar parametro Id del queryString
            String Id = Request["Id"];

            // 2. Consultar de la base de datos el decente por medio de este Id


            CN_Alumno capaNegocio = new CN_Alumno();
            CE_Alumno x = capaNegocio.consultar_alumno(Id);

            // 3. LLevar ese docente a la vista
            return View(x);

        }
        public ActionResult ModificarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Alumno doc = new CE_Alumno();

            doc.Id_Alumno = Request["Id_Alumno"];
            doc.Nom_Alumno = Request["Nom_Alumno"];
            doc.Dir_Alumno = Request["Dir_Alumno"];
            doc.Tel_Alumno = Convert.ToInt64(Request["Tel_Alumno"]);
            doc.Grp_Alumno = Request["Grp_Alumno"];


            // 2.Llamar a la capa de datos

            CN_Alumno capaNegocio = new CN_Alumno();

            capaNegocio.modificar_alumno(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Eliminar()
        {
            //1. 
            String Id = Request["Id"];
            CN_Alumno capaNegocio = new CN_Alumno();

            capaNegocio.eliminar_alumno(Id);

            return RedirectToAction("Index");

        }

    }
}