using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using GUI.ViewModels;
using GUI.Views;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Extensions.DependencyInjection;


namespace GUI;

public partial class App : Application
{
    public override void Initialize()
    {
        
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    [Singleton(typeof(StockViewModel))]
    [Singleton(typeof(OrderViewModel))]
    [Singleton(typeof(OrderLineViewModel))]
    internal static partial void ConfigureViewModels(IServiceCollection services);
 
    //internal static partial void ConfigureViews(IServiceCollection services);

}
