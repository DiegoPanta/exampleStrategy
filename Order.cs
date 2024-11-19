using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleStrategy
{
    public class Order
    {
        private readonly IDiscountStrategy _discountStrategy;

        public Order(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculatePriceWithDiscount(decimal originalPrice)
        {
            return _discountStrategy.ApplyDiscount(originalPrice);
        }
    }
}