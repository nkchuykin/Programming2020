public class MessageNetwork
{
    public long Id { get; }
    public string Content { get; }
    public ImageNetwork ImageNetwork { get; }

    public MessageNetwork(long id, string content, ImageNetwork imageNetwork)
    {
        Id = id;
        Content = content;
        ImageNetwork = imageNetwork;
    }
}