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
        [HttpDelete(Name = "EliminarProducto")]
        //delete 
        //pasar datos atravez del cuerpo
        public void Delete([FromBody] int id)
        {
            ProductoBussiness.EliminarProducto(id);
        }
        //put
        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto productoModificado)
        {
            ProductoBussiness.ModificarProducto(productoModificado);
        }

        //post
        [HttpPost(Name = "CrearProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }
    }
}
