using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ListarProductoVendido()
        {
            return ProductoVendidoData.ListarProductoVendido();
        }

        public static void EliminarProductoVendido (int id)
        {
            ProductoVendidoData.ObtenerProductoVendido(id);
        }

        public static void ObtenerProductoVendido (int id)
        {
            ProductoVendidoData.ObtenerProductoVendido(id);
        }

        public static void CrearProductoVendido (ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void ModificarProductoVendido (int id, ProductoVendido productoVendidoModificado)
        {
            ProductoVendidoData.ModificarProductoVendido(id, productoVendidoModificado);
        }
    }
}
