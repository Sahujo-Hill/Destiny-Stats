namespace DestinyProjectApp.Models
{
    public class ApiResponse
    {
        public List<UserInfo> Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public Dictionary<string, string> MessageData { get; set; }
    }

    public class UserInfo
    {
        public long membershipId { get; set; }
 
    }

}
