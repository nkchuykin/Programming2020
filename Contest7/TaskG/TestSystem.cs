using System.Collections.Generic;
using System.Linq;

public partial class TestSystem
{
    public delegate void Message(string message);
    public event Message Notifications;

    public void Notify(string message)
    {
        if (Notifications != null)
            Notifications(message);
    }
}