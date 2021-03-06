using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Serilog;

namespace RSSReader
{
    public class MainWindow : Window
    { 
        public MainWindow()
        {
            Log.Information("MainWindow constructor");
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}