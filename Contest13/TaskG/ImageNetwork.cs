public class ImageNetwork
{
    public string Url { get; }
    public int Width { get; }
    public int Height { get; }

    public ImageNetwork(string url, int width, int height)
    {
        Url = url;
        Width = width;
        Height = height;
    }
}