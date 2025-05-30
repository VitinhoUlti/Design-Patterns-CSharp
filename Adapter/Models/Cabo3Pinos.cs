using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.Models
{
    public class Cabo3Pinos
    {
        public void EnergizarMaisPotente()
        {
            Console.WriteLine("Energizando com mais força");
        }
        
        public void ReceberEnergia3Pinos()
        {
            Console.WriteLine("Recebendo muitos voltz");
        }
    }
}