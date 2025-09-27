using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatitaSystem.Dominio.Auth
{
    public static class Roles
    {
        
        public const int Admin = 1;
        public const int Vendedor = 2;
        public const int Estilista = 3;


        // ver si los nombres en los parametros son correctos 
        public static string ATexto(int IdRol) => IdRol switch
        {
            Admin => "Administrador",
            Estilista => "Estilista",
            Vendedor => "Vendedor",
            _ => $"Rol #{IdRol}"
        };


    }
}
