
using Microsoft.VisualBasic;

namespace Sector
{
    class OrdenFinal
    {
        public string  Vendedor { get; set; }
        public int NumeroFactura { get; set; }
        public string Descripcion { get; set; }

        public string Fecha { get; set; }



        public string Factura()//metodo 
        {
            return $"Hola soy:  {Vendedor} Tu numero de factura es {NumeroFactura} y La fecha de tu compra es: \n{Fecha}\n ";
        }

        public string Desp()//metodo 
        {
            return $"Muchas Gracias por su compra le saluda  {Vendedor}\n Esperamos verlo pronto \n";
        }

    }
}
