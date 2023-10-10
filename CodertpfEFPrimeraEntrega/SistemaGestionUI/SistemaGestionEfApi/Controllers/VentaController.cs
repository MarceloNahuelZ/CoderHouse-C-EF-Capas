using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;

namespace SistemaGestionEfApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.ListarVentaData().ToArray();
        }
        
        [HttpDelete(Name = "EliminarVenta")]
        //delete 
        //pasar datos atravez del cuerpo
        public void Delete([FromBody] int id)
        {
            VentaBussiness.EliminarVenta(id);
        }
        //put
        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta ventaModificada)
        {
            VentaBussiness.ModificarVentaData(ventaModificada);
        }

        //post
        [HttpPost(Name = "CrearVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }
    }
}
