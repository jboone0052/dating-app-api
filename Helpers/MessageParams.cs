namespace dating_app_api.Helpers
{
    public class MessageParams
    {
        private const int MAXPAGESIZE = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize;}
            set { pageSize = (value > MAXPAGESIZE) ? MAXPAGESIZE : value; }
        }

        public int UserId { get; set; }
        public string MessageContainer {get; set;} = "unread";
    }
}