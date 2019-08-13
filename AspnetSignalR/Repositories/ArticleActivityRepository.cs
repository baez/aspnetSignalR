using System.Collections.Concurrent;

using AspnetSignalR.Interfaces;
using AspnetSignalR.Models;

namespace AspnetSignalR.Repositories
{
    public class ArticleActivityRepository : IArticleActivityRepository
    {
        private static readonly ConcurrentDictionary<string, int> _articleActivities = new ConcurrentDictionary<string, int>();
        private static int _viewCount = 0; 
        
        public int GetArticleActivity(string articleId)
        {
        //    ArticleActivity articleActivity = new ArticleActivity() { Id = articleId, ViewCount = 1 };

        //    //var result = _articleActivities.TryGetValue(articleId, out articleActivity);
        //    //if (result && articleActivity != null)
        //    //{
        //    //    articleActivity.ViewCount++;
        //    //}
        //    //else
        //    //{
        //    //    articleActivity = new ArticleActivity() { Id = articleId, ViewCount = 1 };
        //    //}

        //    //articleActivities.AddOrUpdate(articleId, articleActivity, (key, activity) => activity);

            return StaticRepo.ViewCount;
        }

        
    }
}