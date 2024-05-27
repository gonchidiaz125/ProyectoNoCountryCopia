﻿namespace webAPI.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public string Rol { get; set; } = string.Empty;

        public string Provincia { get; set; } = string.Empty;

        public string Localidad { get; set; } = string.Empty;
    }

    public class RegistroUsuarioDTO
    {
        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int IdRol { get; set; }

        public int IdProvincia { get; set; }

        public int IdLocalidad { get; set; }
    }

    public class LoginUsuarioDTO
    {
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
