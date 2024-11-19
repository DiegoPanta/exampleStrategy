using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleStrategy
{
    public class DefaultDiscountBusiness : IDiscountStrategy
    {
        private readonly decimal percentageToPay = 0.9m;

        public decimal ApplyDiscount(decimal originalPrice)
        {
            return originalPrice * percentageToPay;
        }
    }
}