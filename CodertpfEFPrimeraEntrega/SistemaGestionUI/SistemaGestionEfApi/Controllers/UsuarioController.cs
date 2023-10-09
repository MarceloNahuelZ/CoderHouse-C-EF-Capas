using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;

namespace SistemaGestionEfApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios") ]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.ListarUsuario().ToArray();
        }
        
    }
}
