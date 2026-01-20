using DesafioPOO.Models;
using System;


namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {   

            Nokia nokia = new Nokia("123456", "Nokia Lumia", "Microsoft", "64");
            Console.WriteLine(nokia.Numero);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine();

            Iphone iphone = new Iphone("654321", "iPhone 12", "Apple", "128");
            Console.WriteLine(iphone.Numero);
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");

        }
    }
}
// TODO: Realizar os testes com as classes Nokia e Iphone