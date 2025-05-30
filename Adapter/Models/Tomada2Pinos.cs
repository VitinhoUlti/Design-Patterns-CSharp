using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.Models
{
    public class Tomada2Pinos : IEnergia
    {
        public void Energizar()
        {
            Console.WriteLine("Passando Energia");
        }

        public void ReceberEnergia()
        {
            Console.WriteLine("Pegando Energia");
        }
    }
}