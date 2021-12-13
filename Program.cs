namespace rps
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Welcome, please enter your name:");
            string playerName = Console.ReadLine();
            new Game(playerName);
        }

    }
}
