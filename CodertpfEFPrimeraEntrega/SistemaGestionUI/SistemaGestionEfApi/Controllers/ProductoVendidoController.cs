using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;

namespace SistemaGestionEfApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.ListarProductoVendido().ToArray();
        }
        [HttpDelete(Name = "EliminarProductoVendido")]
        //delete 
        //pasar datos atravez del cuerpo
        public void Delete([FromBody] int id)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(id);
        }
        //put
        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendidoModificado)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendidoModificado);
        }

        //post
        [HttpPost(Name = "CrearProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
        }
    } 
}
