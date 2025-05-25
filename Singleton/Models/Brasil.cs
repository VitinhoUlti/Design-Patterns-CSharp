using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton.Models
{
    public sealed class Brasil
    {
        private static Brasil instancia = null;
        public static Brasil GetInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Brasil();
                    Console.WriteLine("Brasil foi renderizado no mapa");
                }
                return instancia;
            }
        }

        public void ViajarParaBrasil(string pessoa)
        {
            Console.WriteLine($"{pessoa} viajou para o Brasil");
        }
    }
}