namespace RSSReader.Locators
{
    using RSSReader.Model;
    public class RepositoryLocator
    {
        private static string subscriptionsPath = "Subscriptions.json";
        public static SubscriptionsRepository GetSubscriptionsRepository()
        {
            var repo = new SubscriptionsRepository(subscriptionsPath);
            return repo;
        }
    }
}