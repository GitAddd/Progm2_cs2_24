namespace App1
{
    internal class Program
    {
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
    }
}
