using System;

namespace Sector
{
    class Program
    {
        public static string Nombre { get; private set; }

        static void Main(string[] args)
        {

            var almacen = new Almacen();
            almacen.Nombre = "El Baraton";
            almacen.Direcion = "San Bartolo";
            almacen.Celular = 099658111;
            almacen.Estado = "Abierto";


            
            Console.WriteLine("EL BARATON!");
            //Persona=Clase //Estiduante Objeto
            Cliente cliente = new Cliente();

            // instranciar un clase
            cliente.Nombre = "Jefferson";
            cliente.Apellido = "Cuello";
            cliente.Cedula = 095854545;
            cliente.Direccion = "Latacunga";



            string saludo = almacen.Saludar();
            Console.Write(saludo);

            string saludo2 = cliente.Cliente11();
            Console.Write(saludo2);



            Productos productos = new Productos();
            productos.Nombre = "Lavadora";
            productos.Marca = "Wirpool";
            productos.Modelo = "UESD-FVFV";
            productos.Color = "Blanco";

            string com = productos.Compra();
            Console.Write(com);

            var Consumo = new Consumo();

            Consumo.CantidadAgua = 8541;
            Consumo.CantidadLuz = 8542;
            Consumo.Espacio = "5 metros cubicos";
            Consumo.Peso = 52;

            string produc = Consumo.Consumos();
            Console.Write(produc);

            var OrdenFinal = new OrdenFinal();
           

            OrdenFinal.Vendedor = "Gorky Estrella";
            OrdenFinal.NumeroFactura = 564544;
            OrdenFinal.Descripcion = "Lavadora 35kg";
            OrdenFinal.Fecha = "Viernes doce de Junio del dos mil veinte\n";
            string Orden = OrdenFinal.Factura();
            Console.Write(Orden);

            
            string sal =    cliente.Cli();
            Console.Write(sal);

            string dejar = cliente.Dejar();
            Console.Write(dejar);

            string consum = Consumo.Consum();
            Console.Write(consum);

            string consum1 = Consumo.Luz();
            Console.Write(consum1);

            string des = OrdenFinal.Desp();
            Console.Write(des);





            //esperar ala conssola
            Console.ReadKey();
        }
    }
}
