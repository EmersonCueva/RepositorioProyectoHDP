using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuarios objcapaDatos = new CD_Usuarios();

        //método para devolver la lista de los admid de la capa cd usuarios
        public List<Usuario> Listar()
        {
            return objcapaDatos.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if(string.IsNullOrEmpty(obj.nombreUsuario) || string.IsNullOrWhiteSpace(obj.nombreUsuario))
            {
                Mensaje = "Campo Nombre debe ser completado";
            }

            //validación para apellidos
            if (string.IsNullOrEmpty(obj.apellidoUsuario) || string.IsNullOrWhiteSpace(obj.apellidoUsuario))
            {
                Mensaje = "Campo Apellido debe ser completado";
            }

            //validación para correo
            if (string.IsNullOrEmpty(obj.correo) || string.IsNullOrWhiteSpace(obj.correo))
            {
                Mensaje = "Campo Correo debe ser completado";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                //aquí enviaremos el correo al usuario

                string clave = "clave123";
                obj.clave= CN_Recursos.ConvertirSha256(clave);
                return objcapaDatos.Registrar(obj, out Mensaje);
            }
            else
            {
                return 0;
            }

        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            //validación de campos vacíos
            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.nombreUsuario) || string.IsNullOrWhiteSpace(obj.nombreUsuario))
            {
                Mensaje = "Campo Nombre debe ser completado";
            }

            //validación para apellidos
            if (string.IsNullOrEmpty(obj.apellidoUsuario) || string.IsNullOrWhiteSpace(obj.apellidoUsuario))
            {
                Mensaje = "Campo Apellido debe ser completado";
            }

            //validación para correo
            if (string.IsNullOrEmpty(obj.correo) || string.IsNullOrWhiteSpace(obj.correo))
            {
                Mensaje = "Campo Correo debe ser completado";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                return objcapaDatos.Editar(obj, out Mensaje);
            }
            else
            {
                return false;
            }
        }


        public bool Eliminar(int id, out string Mensaje)
        {
            return objcapaDatos.Eliminar(id, out Mensaje);
        }

    }
}
