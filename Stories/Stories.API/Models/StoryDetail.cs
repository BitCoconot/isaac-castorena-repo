namespace Stories.API.Models
{
    public class StoryDetail
    {
        public string title { get; set; }
        public string url { get; set; }
        public string by { get; set; }
        public int time { get; set; }
        public int score { get; set; }
        public string commentCount { get; set; } = string.Empty;
        // The comment value is not being returned by the API so this will display a emtyp string value only.        

     }
}
