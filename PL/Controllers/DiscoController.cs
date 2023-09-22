using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class DiscoController : Controller
    {
        // GET: Disco
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Disco disco =new ML.Disco();

            ML.Result result =BL.Disco.GetAll();
            disco.Discos = new List<object>();
            if (result.Correct)
            {
                //imprimir lista 
                disco.Discos = result.Objects;
            }
            else
            {
                ViewBag.Message = "No hay registros por mostrar";
            }
            return View(disco);
        }
        [HttpGet]
        public ActionResult Delete(int IdDisco)
        {
            ML.Disco disco = new ML.Disco();
            ML.Result result = BL.Disco.Delete(IdDisco);
            if (result.Correct)
            {
                //disco.Discos=result.Object(IdDisco);
                ViewBag.Message = "Registro eliminado ";
            }
            else
            {
                ViewBag.Message = "No hay registros para eliminar";

            }
            return PartialView("Modal");
        }
        [HttpGet]
    }
}