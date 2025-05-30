using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.Models
{
    public interface IEnergia
    {
        void Energizar();
        void ReceberEnergia();
    }
}