using System;
using System.Collections.Generic;
using System.Text;

namespace Sector
{
    class Consumo
    {
        public int CantidadAgua { get; set; }
        public int CantidadLuz { get; set; }
        public string Espacio { get; set; }
        public int Peso { get; set; }



        public string Consumos()//metodo 

        {
            return $"\nLo que tu lavada consumira mensualmete  en agua sera la cantidad de:  {CantidadAgua}\n y una cantidad de electricidad mensual de{CantidadLuz} y ocupara un espacio de {Espacio} \n";

        }
        public string Consum()
        {
            return $" Recuerde que su lavadora consume una gran camtidad de agua  {CantidadAgua} litros\n";
        }
        public string Luz()
        {
            return $" Y tambien consume una cantidad de luz: {CantidadLuz} Watts\n";
        }
    }
}

