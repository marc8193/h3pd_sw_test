using System.Collections.Generic;
using System.Collections.ObjectModel;
using EFCoreExample;
using ReactiveUI;
using System.Reactive;

namespace GUI.ViewModels
{
    public class StockViewModel : ViewModelBase
    {
        public StockViewModel(IEnumerable<Stock> stock)
        {
            StockList = new ObservableCollection<Stock>(stock);
            AddCommand = ReactiveCommand.Create(Add);
        }

        public ObservableCollection<Stock> StockList { get; }


        public ReactiveCommand<Unit, Unit> AddCommand { get; }


        void Add()
        {
            StockList.Add(new Stock(){ Description = "<new>"});
        }
    }
}