using System.Threading.Tasks;

using AspnetSignalR.Interfaces;
using AspnetSignalR.Models;
using AspnetSignalR.Repositories;
using Microsoft.AspNet.SignalR;

namespace AspnetSignalR.SignalRHubs
{
    public class ArticleHub : Hub<IClientArticleActivityUpdater>
    {
        public ArticleHub()
        {

        }

        public async Task GetArticleActivity(string articleId)
        {
            var articleActivity = new ArticleActivity()
            {
                Id = articleId,
                ViewCount = StaticRepo.ViewCount
            };

            await Clients.All.ReceiveArticleUpdate(articleActivity);

        }

        // override OnConnected and OnDisconnected if needed
        public override Task OnConnected()
        {
            if (Context.QueryString["group"] == "allUpdates")
                Groups.Add(Context.ConnectionId, "allUpdateReceivers");

            return base.OnConnected();
        }
    }
}