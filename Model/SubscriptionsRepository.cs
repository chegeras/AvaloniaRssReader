using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Serilog;

namespace RSSReader.Model
{
    public class SubscriptionsRepository
    {
        ILogger logger;
        private string repoPath;

        public SubscriptionsRepository(string repoPath)
        {
            
            this.repoPath = repoPath;
        }

        public List<Subscription> GetAllSubscriptions()
        {
            var jsonString = this.ReadRepoFile();

            var subscriptions = JsonConvert.DeserializeObject<List<Subscription>>(jsonString);

            return subscriptions;
        }

        public void AddSubscription(Subscription subscription)
        {
            var subscriptions = this.GetAllSubscriptions();
            subscriptions.Add(subscription);
            using (StreamWriter stream = new StreamWriter(this.repoPath, false)){ 
                stream.WriteLine(JsonConvert.SerializeObject(subscriptions));
            }

        }

        private string ReadRepoFile()
        {
            string result = null;
            try{
                result = File.ReadAllText(this.repoPath);
            }
            catch(Exception e)
            {
                Log.Error(e,"Couldn't read subscriptions file.");
            }
            return result;
        }
    }
}