using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample
{
    public interface IDatabase
    {
        public void Save();
        public ObservableCollection<Stock> Stocks { get; }
        public ObservableCollection<OrderLine> OrderLines { get;}
        public ObservableCollection<Order> Orders { get; }

    }
}
