namespace AspnetSignalR.Repositories
{
    public static class StaticRepo
    {
        private static int _viewCount = 0;
        public static int ViewCount
        {
            get
            {
                _viewCount = _viewCount + 1;
                return _viewCount;
            }
        }
    }
}