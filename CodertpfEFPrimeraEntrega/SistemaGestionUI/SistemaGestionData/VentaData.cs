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
            using (var context = new SistemaGestionContext())
            {
                return context.Ventas.FirstOrDefault(v => v.Id == id);
            }
        }
        public static List<Venta> ListarVentaData()
        {
            using (var context = new SistemaGestionContext())
            {
                return context.Ventas.ToList();
            }
        }

        public static void CrearVentaData(Venta ventaData)
        {
            using (var context = new SistemaGestionContext())
            {
                context.Ventas.Add(ventaData);
                context.SaveChanges();
            }
        }

        public static void EliminarVentaData(int id)
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

        public static void ModificarVentaData(int id, Venta ventaDataModificada)
        {
            using (var context = new SistemaGestionContext())
            {
                var ventaDataExistente = (context.Ventas.FirstOrDefault(v => v.Id == id));
                if (ventaDataExistente == null)
                {
                    ventaDataExistente.Id = ventaDataModificada.Id;
                    ventaDataExistente.Comentarios = ventaDataModificada.Comentarios;
                    ventaDataExistente.IdUsuario = ventaDataModificada.IdUsuario;

                }
            }
        }
    }
}
