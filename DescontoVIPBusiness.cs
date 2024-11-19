using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleStrategy
{
    public class DescontoVIPBusiness : IDescontoStrategy
    {
        private readonly decimal percentualAPagar = 0.8m;

        public decimal AplicarDesconto(decimal precoOriginal)
        {
            return precoOriginal * percentualAPagar;
        }
    }
}