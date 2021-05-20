using InstagramApiSharp.Classes.Models;

namespace bot
{
    class UserJsonConvert
    {
        public string fullName { get; set; }
        public string userName { get; set; }
        public InstaUserShortList followers { get; set; }
        public InstaUserShortList followings { get; set; }
        public InstaMediaList images { get; set; }
        public string imageProfile { get; set; }
        public string webPage { get; set; }
        public string number { get; set; }
        public string email { get; set; }
    }
}
