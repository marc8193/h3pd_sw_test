using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EFCoreExample
{
    public class EFDatabase : IDatabase
    {
        public ObservableCollection<Order> Orders { get;}
        public ObservableCollection<OrderLine> OrderLines { get; }
        public ObservableCollection<Stock> Stocks { get;}

        private readonly AppDBContext context;
        public EFDatabase()
        {
            context = new AppDBContext();
            Orders =  new ObservableCollection<Order>(context.Orders.Include(o => o.Customer).OrderBy(a => a.Description));
            OrderLines = new ObservableCollection<OrderLine>( context.OrderLines.Include(o => o.Item).OrderBy(a => a.Id));
            Stocks = new ObservableCollection<Stock>(context.Stocks.OrderBy(a => a.Id));
        }

        void IDatabase.Save()
        {
            context.SaveChanges();
        }
    }
}
