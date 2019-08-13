using System.Threading.Tasks;

namespace AspnetSignalR.Interfaces
{
    public interface IArticleHub
    {
        Task GetArticleActivity(string articleId);
    }
}
