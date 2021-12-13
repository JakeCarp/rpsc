namespace rps
{
    class Game
    {
        public int Score { get; private set; }
        public string PlayerName { get; private set; }
        public bool Playing { get; private set; }
        public Game(string name)
        {
            PlayerName = name;
            Score = 0;
            Console.WriteLine("Starting Game");
            Playing = true;
            Console.Clear();
            while (Playing)
            {
                Play();
            }

        }
        private void Play()
        {
            Console.WriteLine("Choose your weapon:");
            string playerChoice = Console.ReadLine();
            string CPUChoice = "";
            Random rand = new Random();
            int ChoiceNum = rand.Next(1, 3);
            if (ChoiceNum == 1)
            {
                CPUChoice = "rock";
            }
            else if (ChoiceNum == 2)
            {
                CPUChoice = "paper";
            }
            else
            {
                CPUChoice = "scissors";
            }



        }
        private bool checkWin(string playerChoice, string cpuChoice)
        {
            bool playerWin = false;

        }
    }
}