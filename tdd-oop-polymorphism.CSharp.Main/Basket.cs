using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IBasketItem> basketItems = new List<IBasketItem>();

        public void add(IBasketItem basketItem)
        {
            this.basketItems.Add(basketItem);
        }

        public int getTotal()
        {
            return basketItems.Sum(basketItem => basketItem.Price);
        }

        public bool isInBasket(string name)
        {
            foreach (IBasketItem item in basketItems)
            {
                if (item.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
