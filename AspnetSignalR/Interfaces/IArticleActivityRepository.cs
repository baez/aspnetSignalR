using AspnetSignalR.Models;

namespace AspnetSignalR.Interfaces
{
    public interface IArticleActivityRepository
    {
        int GetArticleActivity(string articleId);
    }
}
