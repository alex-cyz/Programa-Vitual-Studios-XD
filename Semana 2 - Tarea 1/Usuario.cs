using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Tarea_1
{
    internal class Usuario
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }

        public Usuario(string nombre, int edad, string cedula,string celular, string correo)
        {
            Nombre = nombre;
            Edad = edad;
            Cedula = cedula;
            Celular = celular;
            Correo = correo;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Edad} - {Cedula} - {Celular} - {Correo}";
        }
        public string ToCsv()
        {
            return $"{Nombre},{Edad},{Cedula},{Celular},{Correo}";
        }
        public static Usuario FromCsv(string linea)
        {
            string[] datos = linea.Split(',');
            return new Usuario(datos[0], int.Parse(datos[1]), datos[2], datos[3], datos[4]);
        }
    }
}
