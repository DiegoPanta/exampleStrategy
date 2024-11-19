using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleStrategy
{
    public class Pedido
    {
        private readonly IDescontoStrategy _descontoStrategy;

        public Pedido(IDescontoStrategy descontoStrategy)
        {
            _descontoStrategy = descontoStrategy;
        }

        public decimal CalcularPrecoComDesconto(decimal precoOriginal)
        {
            return _descontoStrategy.AplicarDesconto(precoOriginal);
        }
    }
}