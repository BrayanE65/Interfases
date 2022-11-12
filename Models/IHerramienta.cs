using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfas.Models
{
    public interface IHerramienta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaCompra { get; set; }

        
    }
}