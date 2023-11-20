using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    internal class Empleado
    {
        private string v1;
        private string v2;

        public Empleado(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
