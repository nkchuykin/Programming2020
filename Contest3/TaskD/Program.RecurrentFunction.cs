partial class Program
{
    private static bool Validate(string input, out int num)
    {
        if (!int.TryParse(input, out num) || num < 0)
        {
            return false;
        }
        return true;
    }

    private static int RecurrentFunction(int n)
    {
        if (n == 0)
        {
            return 3;
        }
        return 2 * RecurrentFunction(n - 1) + 2;
    }
}