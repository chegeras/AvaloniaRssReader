using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Serilog;

namespace RSSReader.View
{
    public class NewSubscriptionWindow : Window
    { 
        public NewSubscriptionWindow()
        {
            Log.Information("NewSubscriptionWindow constructor");
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}