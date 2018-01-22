using DatingApp.API.Models;

namespace dating_app_api.Models
{
    public class Like
    {
        public int LikerId {get; set;}
        public int LikeeId {get; set;}
        public User Liker {get; set;}
        public User Likee {get; set;}
    
    }
}