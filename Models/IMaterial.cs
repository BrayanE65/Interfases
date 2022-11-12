using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfas.Models
{
    public interface IMaterial
    {
        public DateTime FechaCaducidad { get; set; }
        public decimal Costo { get; set; }

        public void MaxRecomendado();

    }
}