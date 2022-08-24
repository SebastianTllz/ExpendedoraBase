using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        string Marca;
        byte Temperatura;
        string Codigo;
        float Precio;

        public Expendedora()
        { 
            Saludar();
            Marca = "AMS";
            Console.WriteLine("Marca: " +Marca);
            ControlarTiempoDisplay();
            Temperatura = 14;
            Console.WriteLine("La temperatura es : "  + Temperatura + "°C");
            ControlarTiempoDisplay();
            MostrarCodigodeProductos();
            Codigo = MostrarCodigodeProductos();
            ControlarTiempoDisplay();
            MostrarPrecio(Codigo);
        }

        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        void Saludar()
        {
            Console.WriteLine("Bienvenido :D");
        }

        
          string MostrarCodigodeProductos()
        {
            Console.WriteLine("A1: Kinder Delice \t A2 Takis \t A3: Donitas");
            Console.WriteLine("Ingresa el codigo del producto que deseas");
            string codigo = Console.ReadLine(); // "Codigo" es una variable local
            return codigo;
        }

        void MostrarPrecio(string codigo)
        {
            switch (Codigo)
            {
                case "A1":
                    Console.WriteLine("El precio es: {0} ", Precio); 
                    break;

                case "A2":
                    Console.WriteLine("El precio es: {0} ", Precio);
                    break;
                case "A3":
                    Console.WriteLine("El precio es: {0} ", Precio);
                    break;
                default:
                    Console.WriteLine("Producto no disponible");
                    break;

            }

        }

    
    }

}
