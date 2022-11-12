// See https://aka.ms/new-console-template for more information
using Interfas.Models;

Console.WriteLine("Hello, World!");
   

    var Herramienta = new DiscoPulidora(12,1234);
    MostrarRecomendacion(Herramienta);


   static void MostrarRecomendacion(IMaterial Cosa){
      Cosa.MaxRecomendado();
   }