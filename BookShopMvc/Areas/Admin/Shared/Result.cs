namespace BookShopMvc.Areas.Admin.Shared
{
    public class Result
    {
        public Result()
        {
            this.MessageType = MessageType.Success;
        }
        public string Message { get; set; }
        public MessageType MessageType { get; set; }
    }
    public enum MessageType
    {
        Success,
        Error,
        Info,
        Warning,
        InvalidPassword
    }
}

