namespace Library
{
    public abstract class Message
    {

        public string Text { get; set; }

        public string From { get; }

        public string To { get; }
    }
}