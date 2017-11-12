using System.Collections.ObjectModel;
using RSSReader.ViewModel;

namespace RSSReader.ViewModel
{
    public class MainWindowViewModel:NotifyingBase
    {
        public MainWindowViewModel()
        {
            SubscriptionsControl = new SubcriptionsControlViewModel();
            SubscriptionsControl.RefreshSubscriptionList();
        }

        private SubcriptionsControlViewModel subscriptionsControl;
        public SubcriptionsControlViewModel SubscriptionsControl
        {
            get { return subscriptionsControl;}
            set { 
                if(this.subscriptionsControl == value)
                    {
                        return;
                    }

                    subscriptionsControl = value;
                    RaisePropertyChanged("SubscriptionsControl");
            }
        }
        
    }
}