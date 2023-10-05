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
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    return context.Productos.FirstOrDefault(p => p.Id == id);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);
                
                return null;
            }

        }
        public static List<Producto> GetProductos()
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    return context.Productos.ToList();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null;
            }


        }

        public static void CrearProducto(Producto producto)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    context.Productos.Add(producto);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return; 
            }

            
        }

        public static void EliminarProducto(int id)
        {
            try
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
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }

            
        }

        public static void ModificarProducto(int id, Producto productoModificado)
        {
            try
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
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }
 
        }
    }
}
