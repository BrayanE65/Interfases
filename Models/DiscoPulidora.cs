using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfas.Models
{
    public class DiscoPulidora : IMaterial,IHerramienta
    {
        public DateTime FechaCaducidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Costo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cantidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaCompra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

         public DiscoPulidora(int Id, int Cantidad)
         {
            
         }
        public void MaxRecomendado()
        {
            Console.WriteLine("el maxomo peritido son 2 cambios");
        }
    }
}