using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;

namespace SistemaGestionEfApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet (Name = "GetProducto") ]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.GetProductos().ToArray();
        }
    }
}
