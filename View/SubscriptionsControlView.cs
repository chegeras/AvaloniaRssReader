using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RSSReader.View
{
    public partial class SubscriptionsControlView : UserControl
    { 
        public SubscriptionsControlView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}