using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Persona
    {
        string nombre;
        string ciudad;
       
        public Persona(string nombre, string ciudad)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
        }

        public string Datos() => "La persona se llama " + nombre + " y vive en " + ciudad+" y not iene hijos";



        
    }
}
