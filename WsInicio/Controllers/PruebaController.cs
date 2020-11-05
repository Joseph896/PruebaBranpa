using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WsInicio.Controllers
{
    public class PruebaController : ApiController
    {
        [HttpGet]
        [ActionName("GetSaludoWs")]
        public string getSaludo(string nombre, string apellido)
        {
            return "Hola "+ nombre + "," + apellido;
        }

        [HttpPost]
        [ActionName("GuardarNombre")]
        public void GuardarNombre(string nombre)
        {
            
        }
    }
}