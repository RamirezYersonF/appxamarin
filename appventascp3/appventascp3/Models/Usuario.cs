using System;

namespace appventascp3.Models
{
    public class Usuario
    {
        public int idregistros { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }

        public string correo { get; set; }
        public string contraseña { get; set; }
    }
}