namespace SWE1_opgave
{

    class Player
    {
        private string Name;
        private Die Rolls;
        private DiceGame Plays;
    }
    class Die
    {
        private int Facevalue;
        private int[] dice = {0,1}; 
    }
    class DiceGame
    {
        private Die[] Includes = { };

        int value;
        bool isRunning = true;
        

        public int RollDice()
        {
            Random r = new Random();
            int cast1 = r.Next(1, 7);
            int cast2 = r.Next(1, 7);
            return cast1 + cast2;
        }
        public bool Result()
        {
            int x = RollDice();
            int attempts = 0;
            while (isRunning == true)
            {
                if (x != 7)
                {
                    attempts += 1;
                    return false;
                }
                isRunning = false;
                return true;
            }
            return true;
 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DiceGame Plays = new DiceGame();
            if (Plays.Result() == true)
            {
                Console.WriteLine("COngrats, you win!");
            }
            else
            {
                Console.WriteLine("You Fucking Lose!");
                
            }
            //Console.WriteLine(Plays.Result());

        }
    }
}
