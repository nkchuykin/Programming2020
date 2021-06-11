using System;
using System.Text;

public class MessageNetworkGenerator
{
    private readonly Random random;

    public MessageNetworkGenerator(int seed)
    {
        random = new Random(seed);
    }

    public MessageNetwork GenerateMessageNetwork()
    {
        return new MessageNetwork(random.Next(0, 200), GenerateRandomContent(), GenerateNetworkImage());
    }

    private ImageNetwork GenerateNetworkImage()
    {
        return new ImageNetwork(GenerateRandomContent(), random.Next(0, 500), random.Next(0, 500));
    }

    private string GenerateRandomContent()
    {
        int length = random.Next(6, 20);
        var stringBuilder = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            int choice = random.Next(0, 4);
            if (choice == 0)
            {
                stringBuilder.Append(' ');
            }
            else
            {
                stringBuilder.Append((char) random.Next('a', 'z' + 1));
            }
        }

        return stringBuilder.ToString();
    }
}