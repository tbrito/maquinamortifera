using System.Collections.Generic;
using MaquinaMoritifera.Model.Entidades;
using MaquinaMoritifera.Model.Servicos;
using MaquinaMoritifera.Model.UI;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public AutenticacaoController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // POST: api/Usuario
        [HttpPost]
        public LoginViewModel Post([FromBody] LoginViewModel login)
        {
            return new LoginViewModel
            {
                Login = login.Login,
                Senha = "ssss",
                Token = "meu_token_gerado_aqui"
            };
        }
    }
}
