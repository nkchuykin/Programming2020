using System;

public class Download<T> : IDownload where T : Content
{
    private readonly T download;

    public Download(T download)
    {
        throw new NotImplementedException();
    }

    public bool DownloadContent()
    {
        throw new NotImplementedException();
    }
}