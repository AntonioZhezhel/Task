using System;

namespace Lesson2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Currency dota = new Dota2Coin(10);
            Currency kekCoin = new KekCoin(20);
            Currency maxCoin = new MaxCoin(31.25f);
            
            Console.WriteLine("Value= "+dota.Value+"       "+"BaseValue= "+dota.exchangeRates());
            Console.WriteLine("Value= "+kekCoin.Value+"       "+"BaseValue= "+kekCoin.exchangeRates());
            Console.WriteLine("Value= "+maxCoin.Value+"    "+"BaseValue= "+maxCoin.exchangeRates());
            
            Currency[] currencies = {dota,kekCoin,maxCoin};
            foreach (var v  in currencies)
            {
                Console.WriteLine(v.Value);
            }
        }
        
    abstract class Currency
    {
        //public string NameCurrency { get; set; }
        protected float BaseValue{ get; set; }
        public float Value { get; set; }
        protected float ExchangeRates;

        public Currency( float Value )
        {
            //NameCurrency = NameCurrency;
            //BaseValue = BaseValue;
            ExchangeRates = exchangeRates();
            this.Value = Value;
        }
        public abstract float exchangeRates();
    }

    class Dota2Coin : Currency
    {
        public Dota2Coin( float Value) : base(Value)
        {
            
        }
        public override float exchangeRates()
        {
            BaseValue = Value * 0.5f ;
            return BaseValue;

        }
    }
    
    class KekCoin : Currency
    {
        public KekCoin( float Value) : base(Value)
        {
            
        }
        public override float exchangeRates()
        {
            BaseValue = Value * 0.25f ;
            return BaseValue;
        }
    }
    
    class MaxCoin : Currency
    {
        public MaxCoin( float Value) : base(Value)
        {
            
        }
        public override float exchangeRates()
        {
            BaseValue = Value * 0.16f ;
            return BaseValue;
        }
    }
    
    }
}
