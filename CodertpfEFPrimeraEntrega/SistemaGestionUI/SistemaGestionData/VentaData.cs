using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaData
    {
        

        public static Venta ObtenerVentaData(int id)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    return context.Ventas.FirstOrDefault(v => v.Id == id);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null ;
            }

            
        }
        public static List<Venta> ListarVentaData()
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    return context.Ventas.ToList();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null;
            }
         
        }

        public static void CrearVentaData(Venta ventaData)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    context.Ventas.Add(ventaData);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return ;
            }


            
        }

        public static void EliminarVentaData(int id)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    var ventaDataExistente = context.Ventas.FirstOrDefault(v => v.Id == id);
                    if (ventaDataExistente != null)
                    {
                        context.Ventas.Remove(ventaDataExistente);
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

        public static void ModificarVentaData(int id, Venta ventaDataModificada)
        {
            using (var context = new SistemaGestionContext())
            {
                try
                {
                    var ventaDataExistente = (context.Ventas.FirstOrDefault(v => v.Id == id));
                    if (ventaDataExistente == null)
                    {
                        ventaDataExistente.Id = ventaDataModificada.Id;
                        ventaDataExistente.Comentarios = ventaDataModificada.Comentarios;
                        ventaDataExistente.IdUsuario = ventaDataModificada.IdUsuario;

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
}
