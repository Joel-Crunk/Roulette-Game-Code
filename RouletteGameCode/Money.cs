using System;

namespace RouletteGameCode
{
    internal class Money
    {
        double money;
        public double Currency { get => money; set => money = value; }
      
        public Money()
        {
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }

        internal void Start(double money)
        {
            this.money = Currency;
            
        }
    }
}