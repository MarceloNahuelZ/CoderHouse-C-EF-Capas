using Microsoft.EntityFrameworkCore;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{


    public class UsuarioData
    {
        
        public static Usuario ObtenerUsuario(int id)
        {
            using (var context = new SistemaGestionContext())
            {
                return context.Usuarios.FirstOrDefault(us => us.Id == id);
            }
        }

        public static List<Usuario> ListarUsuario()
        {
            using (var context = new SistemaGestionContext())
            {
                return context.Usuarios.ToList();
            }
        }

        public static void CrearUsuario(Usuario usuario)
        {
            using (var context = new SistemaGestionContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public static void EliminarUsuario(int id)
        {
            using (var context = new SistemaGestionContext())
            {
                var usuarioExistente = context.Usuarios.FirstOrDefault(us => us.Id == id);
                if (usuarioExistente != null)
                {
                    context.Usuarios.Remove(usuarioExistente);
                    context.SaveChanges();
                }
            }
        }

        public static void ModificarUsuario(int id, Usuario usuarioModificado)
        {
            using (var context = new SistemaGestionContext())
            {
                var usuarioExistente = context.Usuarios.FirstOrDefault(us => us.Id == id);
                if (usuarioExistente != null)
                {
                    usuarioExistente.Id = usuarioModificado.Id;
                    usuarioExistente.Nombre = usuarioModificado.Nombre;
                    usuarioExistente.Apellido = usuarioModificado.Apellido;
                    usuarioExistente.NombreUsuario = usuarioModificado.NombreUsuario;
                    usuarioExistente.Contraseña = usuarioModificado.Contraseña;
                    usuarioExistente.Mail = usuarioModificado.Mail;
                    context.SaveChanges();
                }
            }
        }

    }   
   
}
