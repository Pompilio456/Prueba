using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Animal
    {
        string nombre;
        string habitad;
        string piel;
        
        //Constructor
        public Animal(string nombre,string habitad,string piel)
        {
            this.nombre = nombre;
            this.habitad = habitad;
            this.piel = piel;

        }

        public string Datos() => "Este animal es un " + nombre + " vive en " + habitad + " y su piel es ";


    }
}
