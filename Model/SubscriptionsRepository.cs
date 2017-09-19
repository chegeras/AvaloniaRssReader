using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Serilog;

namespace RSSReader.ViewModel
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

        private string ReadRepoFile()
        {
            string result = null;
            try{
                var currentDir = Directory.GetCurrentDirectory();
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