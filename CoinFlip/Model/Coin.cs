using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CoinFlip.Model
{
    internal class Coin
    {
        private Random random;
        public Coin()
        {
            random = new Random();
        }

        public object Lado { get; internal set; }

        public string Jogar(string ladoEscolhido)
        {
            int resultado = random.Next(2);
            return resultado == 0 ? "Cara" : "Coroa";
        }
    }
}

