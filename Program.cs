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

        string lineMiddle = $"{tokenUser}{userName}{tokenUser}";
        string frameWidth = "";

        for (int i = 0; i < lineMiddle.Length; i++)
        {
            frameWidth += tokenUser;
        }

        Console.WriteLine($"{frameWidth}\n{lineMiddle}\n{frameWidth}");
    }
}
