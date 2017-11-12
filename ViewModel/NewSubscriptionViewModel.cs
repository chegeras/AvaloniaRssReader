using System.Windows.Input;
using Avalonia;

namespace RSSReader.ViewModel
{
    public class NewSubscriptionViewModel: NotifyingBase
    {
        public NewSubscriptionViewModel()
        {
            AddCmd = new Command((args)=>this.AddSubscription());
        }
        private string name;
        public string Name
        {
            get { return this.name;}
            set { 
                if(this.name == value)
                    return;
                this.name = value;
                RaisePropertyChanged("Name");
                }
        }
        
        private string url;
        public string Url
        {
            get { return this.url;}
            set { 
                if(this.url == value)
                    return;
                this.url = value;
                RaisePropertyChanged("Url");
                }
        }

        private ICommand addCmd;
        public ICommand AddCmd
        {
            get { return this.addCmd;}
            set { 
                if(this.addCmd == value)
                    return;
                this.addCmd = value;
                RaisePropertyChanged("AddCmd");
                }
        }

        private void AddSubscription()
        {
            
        }
        
    }
}