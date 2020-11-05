using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WsInicio.Controllers
{
    public class OperacionesController : ApiController
    {
        [HttpGet]
        [ActionName("Sumar")]
        public int OpSumar(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpGet]
        [ActionName("Restar")]
        public int OpRestar(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
