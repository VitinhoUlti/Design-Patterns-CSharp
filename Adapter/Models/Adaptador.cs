using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.Models
{
    public class Adaptador : IEnergia
    {
        private Cabo3Pinos Cabo3Pinos;

        public Adaptador(Cabo3Pinos cabo3Pinos)
        {
            Cabo3Pinos = cabo3Pinos;
        }

        public void Energizar()
        {
            Cabo3Pinos.EnergizarMaisPotente();
        }

        public void ReceberEnergia()
        {
            Cabo3Pinos.ReceberEnergia3Pinos();
        }
    }
}