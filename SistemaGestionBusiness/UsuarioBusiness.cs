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
        // estructura de un metodo
        // modificador {static /abstract} tipo de dato de retorno nombre de metodo (parametros)
        //(
        // codigo
        //}
        // ejemplo
        // public static void algun_metodo ()
        //otro ejemplo 
        //public static string algun metodo el metodo que voy a traer
        //public static List<Usuario> DevolverUsuarios()

       
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
