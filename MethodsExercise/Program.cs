using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your quest?");
            string quest = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"Well {name}, {quest} is noble indeed. " +
                $"I once had a quest to find a {color} whale myself." +
                $" By the way, what is your favorite animal?.");
            string animal = Console.ReadLine();
            Console.WriteLine($"I love a good {animal} as well. Now, that is all of the time I have. Farewell");

        }
    }
}
