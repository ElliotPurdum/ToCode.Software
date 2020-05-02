using System;

namespace HelloWorld
{
    public class ElliotBot
    {
        public void Start()
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine("What is the average velocity of a swallow?");
            var name = Console.ReadLine();
            Console.WriteLine($"Do you want to go on a quest, {name}?");
            var response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Yes();
            }
            else
            {
                No();
            }
        }

        static void Yes()
        {
            Console.WriteLine("Then we shall set forth at once!");
        }

        static void No()
        {
            Console.WriteLine("Why not?");
            var responsetwo = Console.ReadLine();
            Console.WriteLine($"You don't want to go because {responsetwo}? Are you sure?");
            responsetwo = Console.ReadLine();
            if (responsetwo.ToLower() == "no")
            {
                Console.WriteLine("Then we must leave at once!");
            }
            else
            {
                Console.WriteLine("Fine. No quests today.");
            }
        }
    }

}