using System;

namespace UserInputAlexGodinez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, This is Alex Godinez");
            Console.WriteLine("Type your first and last name, when you are done, hit enter.");
            string name = Console.ReadLine();
            Console.WriteLine("Good Job,You typed: " + name);

        }
    }
}
