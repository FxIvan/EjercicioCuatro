using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuatro
{
    internal class Chicos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string DNI { get; set; }

        public override string ToString()
        {
            return $"Chicos: {Nombre} {Apellido}";
        }
    }
}
