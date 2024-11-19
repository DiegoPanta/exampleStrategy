using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleStrategy
{
    public interface IDescontoStrategy
    {
        decimal AplicarDesconto(decimal precoOriginal);
    }
}