using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class GerenciadorDeVitor
    {
        private Dictionary<string, VitorModelo> vitors = new Dictionary<string, VitorModelo>();

        public VitorModelo this[string key]
        {
            get { return vitors[key]; }
            set { vitors.Add(key, value); }
        }
    }
}