using System.Collections.Generic;
using System.Collections.ObjectModel;
using EFCoreExample;

namespace GUI.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        public OrderViewModel(IEnumerable<Order> orders)
        {
            OrderList = new ObservableCollection<Order>(orders);
        }

        public ObservableCollection<Order> OrderList { get; }
    }
}