namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string coffeeName = "Marilyn Laucata";
            string coffeeCountry = "Peru";
            int weekAmt = 3;
            char coffeeRank = 'A';
            bool coffeeNerd = true;
            double coffeeScore = 9.4;
            decimal coffeeCost = 24.50m;

            Console.WriteLine($"My favorite coffee in the past {weekAmt} weeks has been {coffeeName} from {coffeeCountry}. I would rank it a {coffeeScore} out of 10. That comes out to rank {coffeeRank}. You may think I am a coffee nerd. {coffeeNerd}. Only weird coffee people pay ${coffeeCost} for a bag of coffee.");
        }
    }
}
