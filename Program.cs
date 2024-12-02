namespace NameOutput;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your token:");
        char tokenUser = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Write your name: ");
        string userName = Console.ReadLine();

        int offsetFromEdge = 2;

        int frameHeight = 3;
        int frameLength = userName.Length + offsetFromEdge;

        for (int i = 0; i < frameHeight; i++)
        {
            if (i == frameHeight / 2)
            {
                Console.WriteLine($"{tokenUser}{userName}{tokenUser}");
            }
            else 
            {
                Console.WriteLine(new string(tokenUser, frameLength));
            }
        }
    }
}
