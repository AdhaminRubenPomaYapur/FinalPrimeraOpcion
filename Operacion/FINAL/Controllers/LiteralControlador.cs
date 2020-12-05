using Microsoft.AspNetCore.Mvc;
using System;

namespace FINAL.Controllers
{
    public class LiteralControlador
    {
        [Route("api/[controller]")]
        [ApiController]
        public class LiteralController : ControllerBase
        {
            [HttpGet]
            public string LiteralGet(int numero)
            {
                return OperacionesFinal.NumeroALetras(numero);
            }

            public int LiteralGet()
            {
                throw new NotImplementedException();
            }

            [HttpPost]
            public string LiteralPost([FromHeader] int numero)
            {
                return OperacionesFinal.NumeroALetras(numero);
            }
        }
    }
}
