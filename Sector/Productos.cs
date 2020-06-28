using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Sector
{
    class Productos
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Compra()//metodo 
        {
            return $"Estas a punto de comprar una  {Nombre} {Marca} {Modelo} \n";
        }
        
    }
    }
