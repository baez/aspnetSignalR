using System.Threading.Tasks;
using AspnetSignalR.Models;
using Microsoft.AspNet.SignalR;
using System.Collections.Concurrent;

namespace AspnetSignalR.SignalRHubs
{
    public class ArticleHub : Hub
    {
        private static readonly ConcurrentDictionary<string, ArticleActivity> articleActivities = new ConcurrentDictionary<string, ArticleActivity>();

        public async Task GetArticlePageViews(string articleId)
        {
            ArticleActivity articleActivity;
            var result = articleActivities.TryGetValue(articleId, out articleActivity);
            if (result && articleActivity != null)
            {
                articleActivity.ViewCount++;
            }
            else
            {
                articleActivity = new ArticleActivity() { Id = articleId, ViewCount = 1 };
            }

            articleActivities.AddOrUpdate(articleId, articleActivity, (key, activity) => activity);

            await Clients.Others.Update();
        }
    }
}