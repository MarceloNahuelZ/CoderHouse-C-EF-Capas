using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionData
{
    public static class ProductoData
    {
        public static Producto ObtenerProducto(int id)
        {
            using (var context = new SistemaGestionContext())
            {
                return context.Productos.FirstOrDefault(p => p.Id == id);
            }
        }
        public static List<Producto> GetProductos()
        {
            using (var context = new SistemaGestionContext())
            {
                return context.Productos.ToList();
            }
        }

        public static void CrearProducto(Producto producto)
        {
            using (var context = new SistemaGestionContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }

        public static void EliminarProducto(int id)
        {
            using (var context = new SistemaGestionContext())
            {
                var productoExistente = context.Productos.FirstOrDefault(p => p.Id == id);
                if (productoExistente != null)
                {
                    context.Productos.Remove(productoExistente);
                    context.SaveChanges();
                }
            }
        }

        public static void ModificarProducto(int id, Producto productoModificado)
        {
            using (var context = new SistemaGestionContext())
            {
                var productoExistente = context.Productos.FirstOrDefault(p => p.Id == id);
                if (productoExistente != null)
                {
                    productoExistente.Descripciones = productoModificado.Descripciones;
                    productoExistente.Costo = productoModificado.Costo;
                    productoExistente.PrecioVenta = productoModificado.PrecioVenta;
                    productoExistente.Stock = productoModificado.Stock;
                    productoExistente.IdUsuario = productoModificado.IdUsuario;
                    context.SaveChanges();
                }
            }
        }
    }
}
