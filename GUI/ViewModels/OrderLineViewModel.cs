using System.Collections.Generic;
using System.Collections.ObjectModel;
using EFCoreExample;

namespace GUI.ViewModels
{
    public class OrderLineViewModel : ViewModelBase
    {
        public OrderLineViewModel(IEnumerable<OrderLine> orderlines)
        {
            OrderLineList = new ObservableCollection<OrderLine>(orderlines);
        }
        
        public ObservableCollection<OrderLine> OrderLineList { get; }
    }
}