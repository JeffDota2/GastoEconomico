using System;
using System.Collections.Generic;
using System.Text;

namespace Sector
{
    class Almacen
    {
        
        //propiedades:datos
        public string Nombre { get; set; }
        public string Direcion { get; set; }
        public int Celular { get; set; }
        public string Estado { get; set; }


        //defino metodos:conportamientos


        //constructor
        public Almacen()
        { }

        public string Saludar()//metodo 
        {
            return $"Hola, Bienvenido a tu almacen: {Nombre} es un placer poder atenderte\n";



        }
        
        
    }
}
