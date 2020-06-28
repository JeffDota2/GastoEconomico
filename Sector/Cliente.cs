using System;
using System.Collections.Generic;
using System.Text;

namespace Sector
{
    class Cliente
    {
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }

        public string Saludar()//metodo 
        {
            return $"Hola, Bienvenido  {Nombre} es un placer poder atenderte ";

          



        }
        public string Cliente11()//metodo
        {

            return $"{Nombre} { Apellido}\n";

        }
        public string Cli()
        {
            return $"Gracias por tu compra Sr. {Nombre} {Apellido} con numero de cedula {Cedula}\n";
        }

        public string Dejar()
        {
            return $" Sr. su lavadora sera entregada en la direccion: {Direccion}\n";
        }


    }
}
