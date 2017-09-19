using System.Collections.ObjectModel;
using System.Windows.Input;
using RSSReader.View;

namespace RSSReader.ViewModel
{
    public class SubcriptionsControlViewModel: NotifyingBase
    {
        private SubscriptionsRepository subscriptionsRepository;
        private string subscriptionsPath = "Subscriptions.json";

        public SubcriptionsControlViewModel()
        {
            this.subscriptionsRepository = new SubscriptionsRepository(subscriptionsPath);
            AddNewSubscriptionCmd = new Command((param)=> ShowAddSubscriptionWindow());
        }
        private ObservableCollection<Subscription> subscriptionList;
        public ObservableCollection<Subscription> SubscriptionList
        {
            get { 
                    return subscriptionList;
                }

            set { 
                    if(this.subscriptionList == value)
                    {
                        return;
                    }

                    subscriptionList = value;
                    RaisePropertyChanged("SubscriptionList");
                }
        }

        private ICommand addNewSubscriptionCmd;
        public ICommand AddNewSubscriptionCmd
        {
            get { return addNewSubscriptionCmd;}
            set { 
                if(addNewSubscriptionCmd == value)
                    return;

                addNewSubscriptionCmd = value;
                RaisePropertyChanged("AddNewSubscriptionCmd");
                }
        }
        

        public void RefreshSubscriptionList()
        {
            var subscriptions = new ObservableCollection<Subscription>(this.subscriptionsRepository.GetAllSubscriptions());
            SubscriptionList = subscriptions;
        }

        private void ShowAddSubscriptionWindow()
        {
            var newWindow = new NewSubscriptionWindow();
            newWindow.ShowDialog();
        }
    }
}