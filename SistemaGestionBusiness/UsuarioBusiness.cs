using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public static class UsuarioBusiness  {
       
       
         public static List<Usuario> DevolverUsuarios()
         {
             return UsuarioData.DevolverUsuarios();
         }
        
        public static void CrearUsuario(Usuario usuario
            )
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }

        public static void EliminarUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }

    }
}
