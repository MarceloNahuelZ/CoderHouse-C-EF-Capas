using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;
using Microsoft.AspNetCore.Mvc.Routing;

namespace SistemaGestionEfApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //get 
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.ListarUsuario().ToArray();
        }
        //delete
        [HttpDelete(Name = "EliminarUsuario")]

        //delete 
        //pasar datos atravez del cuerpo
        public void Delete([FromBody]int id)
        {
           UsuarioBussiness.EliminarUsuario(id);
        }
        //put
        [HttpPut(Name = "ModificarUsuario")]
        public void Put( [FromBody] Usuario usuarioModificado)
        {
            UsuarioBussiness.ModificarUsuario(usuarioModificado);
        }

        //post
        [HttpPost(Name = "CrearUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.CrearUsuario(usuario);
        }

    }
}
