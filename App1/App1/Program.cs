using System.Reflection.Metadata.Ecma335;

namespace App1
{
    internal class Program
    {
        string[] vragen = new string[]
        {
         "What 1997 N64 video game, fetures james bond and is named after the 1995 film?","What arcade game was called puckman in Japan?"
        };
        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }
        static void Main(string[] args)
        {
            Program program = new Program(); //Program is de variable
            program.Run(); //De type is class
        }

        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            vraag1();
            vraag2();
            vraag3();
            vraag4();
            vraag5();
            GetVraag(7);
        }
        
        
        internal void vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag2()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag4()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal string vraag7()
        {
            Console.WriteLine("Would u like to skibidi rizz me?");
            string Antwoord = Console.ReadLine();

            return Antwoord;
        }
        internal string GetRandomVraag()
        {
            Random rnd = new Random();
            int random = (vragen.Length);
            return GetVraag(random);
        }
        internal void AskRandomQuestion()
        {
           string randomvraag = GetRandomVraag();
            Console.WriteLine(randomvraag);
           string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
            
        }
    }

    
    }
    
