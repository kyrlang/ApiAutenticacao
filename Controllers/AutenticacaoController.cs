using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiAutenticacao.Models;

namespace ApiAutenticacao.Controllers
{
    public class AutenticacaoController : ApiController
    {

        [HttpPost]
        [Route("api/v1/autenticacao/login")]
        public IHttpActionResult Autenticar([FromBody] Usuario usuario)
        {
            //Usuario usuario = JsonConvert.DeserializeObject<Usuario>(json);

            if (usuario.senha == "123" && usuario.usuario == "kyrla")
                return Ok("Usuario autenticado");
            else
                return NotFound();

        }

        [HttpPost]
        [Route("api/v1/autenticacao/logoff")]
        public IHttpActionResult Logoff([FromBody] Usuario usuario)
        {
            if (usuario.senha == "123" && usuario.usuario == "kyrla")
                return Ok("Logoff");
            else
                return NotFound();
        }
    }
}
