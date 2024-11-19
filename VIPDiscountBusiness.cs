using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleStrategy
{
    public class VIPDiscountBusiness : IDiscountStrategy
    {
        private readonly decimal percentageToPay = 0.8m;

        public decimal ApplyDiscount(decimal originalPrice)
        {
            return originalPrice * percentageToPay;
        }
    }
}