using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IBasketItem
    {
        private string _name;
        private int _price;

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }
        public Game(string name, int price)
        {
            _name = name;
            _price = price;
        }
    }
}
