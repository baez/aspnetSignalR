using System.Threading.Tasks;

using AspnetSignalR.Models;

namespace AspnetSignalR.Interfaces
{
    public interface IClientArticleActivityUpdater
    {
        Task ReceiveArticleUpdate(ArticleActivity articleActivity);
    }
}
