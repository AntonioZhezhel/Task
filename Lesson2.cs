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

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Value= "+dota.Value+"       "+"BaseValue= "+dota.exchangeRates());
            Console.WriteLine("Value= "+kekCoin.Value+"       "+"BaseValue= "+kekCoin.exchangeRates());
            Console.WriteLine("Value= "+maxCoin.Value+"    "+"BaseValue= "+maxCoin.exchangeRates());
            
            Currency[] currencies = {dota,kekCoin,maxCoin};
            foreach (var v  in currencies)
            {
                Console.WriteLine(v.Value);
            }
            Console.WriteLine("-----------------------------------------------------------");
            
            Currency sum = kekCoin + dota;
            Console.WriteLine("Sum="+sum.Value);
            Console.WriteLine("-----------------------------------------------------------");
          
            Currency dota2 = new Dota2Coin(10);
            KekCoin kekConvert = (KekCoin)dota2.Value;//10*0.25
            Console.WriteLine(kekConvert.Value);
            MaxCoin maxConvert = (MaxCoin) dota2.Value;//10*0.16
            Console.WriteLine(maxConvert.Value);

        }
        
    abstract class Currency
    {
        //public string NameCurrency { get; set; }
        protected float BaseValue{ get; set; }
        public  float Value;


        public static Currency operator +(Currency bV, Currency v)
        {
            bV.Value += (bV.BaseValue/bV.Value)*v.Value ;
            return bV;
        }
        
        public Currency( float Value)
        {
            //NameCurrency = NameCurrency;
            exchangeRates();
            this.Value = Value;
        }
        public abstract float exchangeRates();
    }

    class Dota2Coin : Currency
    {
        public Dota2Coin( float Value) : base(Value) {}
        public override float exchangeRates()
        {
            BaseValue = Value * 0.5f ;
            return BaseValue;
        }
        public static explicit operator Dota2Coin(float x)
        {
            x *= 0.5f;
            return  new Dota2Coin(x);
        }
    }

    class KekCoin : Currency
    {
        public KekCoin( float Value) : base(Value) {}
        public override float exchangeRates()
        {
            BaseValue = Value * 0.25f ;
            return BaseValue;
        } 
        public static explicit operator KekCoin(float x)
        {
             x *= 0.25f;
            return  new KekCoin(x);
        }
        
    }

    class MaxCoin : Currency
    {
        public MaxCoin( float Value) : base(Value) {}
        public override float exchangeRates()
        {
            BaseValue = Value * 0.16f ;
            return BaseValue;
        }
        public static explicit operator MaxCoin(float x)
        {
            x *= 0.16f;
            return  new MaxCoin(x);
        }
    }
    }
}
