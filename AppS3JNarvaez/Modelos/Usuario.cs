using System;
using System.Collections.Generic;
using System.Text;

namespace AppS3JNarvaez.Modelos
{
    public class Usuario
    {
        public string correo { get; set; }
        public string password { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public Usuario(string correo, string password, string nombre, string apellido)
        {
            this.correo = correo;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
