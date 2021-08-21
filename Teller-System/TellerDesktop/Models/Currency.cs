using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellerDesktop
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }

        public Currency()
        {
            Id = -1;
            Name = "";
            BuyPrice = 0;
            SellPrice = 0;
        }
        public Currency(int id, string name, decimal buyPrice, decimal sellPrice)
        {
            Id = id;
            name = Name;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
        }
        public Currency(Currency currency)
        {
            Id = currency.Id;
            Name = currency.Name;
            BuyPrice = currency.BuyPrice;
            SellPrice = currency.SellPrice;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
        public bool EqualsByName(Currency currency)
        {
            return Name == currency.Name;
        }

        public static List<Currency> GetRandomCurrencies()
        {
            return new List<Currency> { new Currency { Id=1, Name="ليرة سورية", BuyPrice=1, SellPrice=1},
                                        new Currency { Id=2, Name="دولار", BuyPrice=3200, SellPrice=3210},
                                        new Currency { Id=3, Name="يورو", BuyPrice=3700, SellPrice=3720},
                                        new Currency { Id=4, Name="كرون", BuyPrice=560, SellPrice=600},
                                        new Currency { Id=5, Name="جنيه", BuyPrice=4000, SellPrice=4050}};
        }
    }
}
