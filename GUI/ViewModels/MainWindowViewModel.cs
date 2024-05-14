namespace GUI.ViewModels;
using EFCoreExample;
using System.Linq;

public class MainWindowViewModel : ViewModelBase
{

    public MainWindowViewModel()
    {
        using (var context = new AppDBContext())
        {
            var OrderVM = new OrderViewModel(context.Orders.OrderBy(a => a.Description ).ToList());
            System.Console.WriteLine(OrderVM);

            foreach (var o in OrderVM.OrderList)
            {
                System.Diagnostics.Debug.WriteLine(o);
            }
        }
    }

    public OrderViewModel? OrderList { get; }
}