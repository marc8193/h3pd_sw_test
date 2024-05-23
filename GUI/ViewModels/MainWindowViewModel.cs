namespace GUI.ViewModels;
using EFCoreExample;
using ReactiveUI;
using System.Collections.Generic;
using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using System.Linq;
// using Microsoft.Data.SqlClient;

public partial class MainWindowViewModel : ViewModelBase
{

    public MainWindowViewModel()
    {
        var db = new EFDatabase();
        // var db = new DummyDatabase();
        StockListvm = new StockViewModel(db.Stocks);
        OrderListvm = new OrderViewModel(db.Orders);
        OrderLineListvm = new OrderLineViewModel(db.OrderLines);

        Items = new ObservableCollection<ListItemTemplate>(_templates);

        SelectedListItem = Items.Last(vm => vm.ModelType == typeof(StockViewModel));

        CurrentPage = OrderLineListvm; //StockListvm;
    }

    [ObservableProperty]
    private bool _isPaneOpen;

    [ObservableProperty]
    private ViewModelBase? _currentPage = null;

    [ObservableProperty]
    private ListItemTemplate? _selectedListItem;


    public ObservableCollection<ListItemTemplate> Items { get; }

    [RelayCommand]
    private void TriggerPane()
    {
        IsPaneOpen = !IsPaneOpen;
    }

    private readonly List<ListItemTemplate> _templates =
    [
        new ListItemTemplate(typeof(StockViewModel), "building_shop_regular", "Stock"),
        new ListItemTemplate(typeof(OrderViewModel), "PollRegular", "Order"),
        new ListItemTemplate(typeof(OrderLineViewModel), "ImageRegular", "OrderLine"),
    ];


    public StockViewModel StockListvm { get; }
    public OrderViewModel OrderListvm { get; }
    public OrderLineViewModel OrderLineListvm { get; }

    partial void OnSelectedListItemChanged(ListItemTemplate? value)
    {
        if (value == null) return;

        if (value.ModelType == typeof(StockViewModel))
        {
            CurrentPage = StockListvm;
        }
        else if (value.ModelType == typeof(OrderViewModel))
        {
            CurrentPage = OrderListvm;
        }
        else if (value.ModelType == typeof(OrderLineViewModel))
        {
            CurrentPage = OrderLineListvm;
        }
    }

}
