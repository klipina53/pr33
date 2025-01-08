namespace pr33_ChatStudents_Lipina.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public int UserFrom { get; set; }
        public int UserTo { get; set; }
        public string Message { get; set; }
        public Messages(int UserFrom, int UserTo, string Message)
        {
            this.UserFrom = UserFrom;
            this.UserTo = UserTo;
            this.Message = Message;
        }
    }
}
