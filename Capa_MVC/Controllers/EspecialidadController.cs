using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_MVC.Controllers
{
    public class EspecialidadController : Controller
    {
        // GET: Especialidad
        public ActionResult Index()
        {
            CN_Especialidad  capaNegocio = new CN_Especialidad();

            List<CE_Especialidad> lista = capaNegocio.consultar_especialidades();

            return View(lista);
        }
        public ActionResult Insertar()
        {
            return View();
        }
        public ActionResult InsertarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Especialidad doc = new CE_Especialidad();

            doc.Id_Especialidad = Request["Id_Especialidad"];
            doc.Nom_Especialidad = Request["Nom_Especialidad"];



            // 2.Llamar a la capa de datos

            CN_Especialidad capaNegocio = new CN_Especialidad();

            capaNegocio.guardar_especialidad(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Modificar()
        {
            // 1. Recuperar parametro Id del queryString
            String Id = Request["Id"];

            // 2. Consultar de la base de datos el decente por medio de este Id


            CN_Especialidad capaNegocio = new CN_Especialidad();
            CE_Especialidad x = capaNegocio.consultar_especialidad(Id);

            // 3. LLevar ese docente a la vista
            return View(x);

        }
        public ActionResult ModificarFormlario()
        {
            // 1. Recuperar los campos del formulario
            CE_Especialidad doc = new CE_Especialidad();

            doc.Id_Especialidad = Request["Id_Especialidad"];
            doc.Nom_Especialidad = Request["Nom_Especialidad"];



            // 2.Llamar a la capa de datos

            CN_Especialidad capaNegocio = new CN_Especialidad();

            capaNegocio.modificar_especialidad(doc);


            return RedirectToAction("Index");

        }
        public ActionResult Eliminar()
        {
            //1. 
            String Id = Request["Id"];
            CN_Especialidad capaNegocio = new CN_Especialidad();

            capaNegocio.eliminar_especialidad(Id);

            return RedirectToAction("Index");

        }
    }
}