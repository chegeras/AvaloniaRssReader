using RSSReader.ViewModel;

namespace RSSReader.Locators
{
    public class Locator
    {
        public static MainWindowViewModel MainWindowViewModel {
            get {
                return new MainWindowViewModel();
            }
        }

        public static NewSubscriptionViewModel NewSubscriptionViewModel {
            get {
                return new NewSubscriptionViewModel();
            }
        }
    }
}