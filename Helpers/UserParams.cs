namespace dating_app_api.Helpers
{
    public class UserParams
    {
        private const int MAXPAGESIZE = 50;
        private int pageSize = 10;
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get { return pageSize;}
            set { pageSize = (value > MAXPAGESIZE) ? MAXPAGESIZE : value; }
        }
    }
}