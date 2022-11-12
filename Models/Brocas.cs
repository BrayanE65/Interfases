using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfas.Models
{
    public class Brocas : IMaterial, IHerramienta
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cantidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaCompra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaCaducidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Costo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MaxRecomendado()
        {
            Console.WriteLine("el maximo de cambios es 3");
        }

        public Brocas(int Cantidad, int Id)
        {
            
        }
    }
}