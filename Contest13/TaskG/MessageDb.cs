public class MessageDb
{
    public long Id { get; }
    public string Content { get; }
    public string ImageUrl { get; }

    public MessageDb(long id, string content, string imageUrl)
    {
        Id = id;
        Content = content;
        ImageUrl = imageUrl;
    }

    public override string ToString()
    {
        return $"Id = {Id}. Content = {Content}. ImageUrl = {ImageUrl}";
    }
}