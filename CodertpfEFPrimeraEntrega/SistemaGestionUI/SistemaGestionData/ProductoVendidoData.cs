using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            using (var context = new SistemaGestionContext())
            {
                return context.ProductosVendidos.FirstOrDefault(x => x.Id == id);

            }
        }

        public static List<ProductoVendido> ListarProductoVendido()
        {
            using (var context = new SistemaGestionContext())
            {
                return context.ProductosVendidos.ToList();
            }
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (var context = new SistemaGestionContext())
            {
                context.ProductosVendidos.Add(productoVendido);
                context.SaveChanges();
            }
        }

        public static void EliminarProducToVendido(int id)
        {
            using (var context = new SistemaGestionContext())
            {
                var productoVendidoExistente = context.ProductosVendidos.FirstOrDefault(x => x.Id == id);
                if (productoVendidoExistente == null)
                {
                    context.ProductosVendidos.Remove(productoVendidoExistente);
                    context.SaveChanges();
                }
            }
        }
        public static void ModificarProductoVendido(int id, ProductoVendido productoVendidoModificado)
        {
            using (var context = new SistemaGestionContext())
            {
                var productoVendidoExistente = context.ProductosVendidos.FirstOrDefault(x => x.Id == id);
                if (productoVendidoExistente == null)
                {
                    productoVendidoExistente.Id = productoVendidoModificado.Id;
                    productoVendidoExistente.IdProducto = productoVendidoModificado.IdProducto;
                    productoVendidoExistente.Stock = productoVendidoModificado.Stock;
                    productoVendidoExistente.IdVenta = productoVendidoModificado.IdVenta;

                    context.SaveChanges();
                }
            }
        }
    }
}
