namespace Rijles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Program = new Program();
            Program.Run();
            Console.WriteLine("Hello, World!");
        }
        internal void Run()
        {
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerstand = 20567,
                merk = "volkswagen"

            };
            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerstand = 65739,
                merk = "volvo"
            };

            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };
            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,

                tijd = 1130,

            };
            LesPakket lesPakket = new LesPakket()
            {
                urenGekocht = 30,
                urenVerbruikt = 30,
                examenPogingen = 30,
                automaat = true
            };
            TheorieTest theorieTest = new TheorieTest()
            {
                aantalFouten = 3,
                gehaald = true
            };
            RijTest rijTest = new RijTest()
            {
                gehaald = false,
            };

            Student student = new Student()
            {
                naam = "Gitcommiter",
                intleeftijd = 64,
                lesPakket = lesPakket,
                theorieTest = theorieTest,
                RijTest = rijTest
            };

            Student Student2 = new Student()
            {
                naam = "Shandel",
                intleeftijd = 45,
                lesPakket = lesPakket,
                theorieTest = theorieTest,
                RijTest = rijTest
            };
            

            
            
        }
    }
}
