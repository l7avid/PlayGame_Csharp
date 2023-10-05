namespace ChallengeIfStatement
{
    internal class Program
    {
        public static string highscorePlayer = "David";
        public static int highscore = 100;
        static void Main(string[] args)
        {
            Play(99,"Lina");
            Play(98, "Juanita");
            Play(101, "Majo");
        }

        static void Play(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"New highscore holder is {playerName}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highscore} could not be broken and " +
                    $"still held by {highscorePlayer}");
            }
        }
    }
}