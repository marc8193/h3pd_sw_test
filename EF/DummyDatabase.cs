using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample
{
    public class DummyDatabase : IDatabase
    {
        public ObservableCollection<Order> Orders { get; }
        public ObservableCollection<OrderLine> OrderLines { get; }
        public ObservableCollection<Stock> Stocks { get; }

        public DummyDatabase()
        {

            Orders = [];
            OrderLines = [];
            Stocks = [];

            var s1 = new Stock() { Id = 1, Description = "Netto" };
            var s2 = new Stock() { Id = 2, Description = "Fakta" };
            Stocks.Add(s1);
            Stocks.Add(s2);
        }

        void IDatabase.Save()
        {
            //;
        }
    }
}
