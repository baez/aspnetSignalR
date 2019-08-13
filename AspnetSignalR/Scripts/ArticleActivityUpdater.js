setupConnection = (hubProxy) => {

    hubProxy.on("receiveArticleUpdate", function(updateObject) 
    {
        const statusDiv = document.getElementById("status");
        statusDiv.innerHTML = updateObject.Id;

        const viewCountDiv = document.getElementById("viewCount");
        viewCountDiv.innerHTML = updateObject.ViewCount;
    });
};

$(document).ready(() => 
{

    var connection = $.hubConnection();
    var hubProxy = connection.createHubProxy("articleHub");

    setupConnection(hubProxy);
    connection.start();

    document.getElementById("submit").addEventListener("click",
        e => 
        {
            e.preventDefault();
            var statusDiv = document.getElementById("submitMessage");
            statusDiv.innerHTML = "Submitting articleId ...";

            const articleId = "ABCArtId";
            
            fetch("ArticleViewed?articleId=" + articleId,
                {
                    method: "POST",
                    headers: 
                    {
                        'content-type': 'application/json'
                    }
                })
                .then(response => response.text())
                .then(getUpdate(articleId))
                    .fail(error => console.log(error)
                );
        });

    function getUpdate(articleId)
    {
        connection.start();
        hubProxy.invoke('getArticleActivity', articleId);
    }
});
