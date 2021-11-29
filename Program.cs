using System;

namespace Bastu
{
    class Program
    {
        public static double fahrToCels(double fahr)// tar in fahr som en parameter och retunerar celius som en double
        {
            double celsius = (fahr - 32) * 5 / 9;// formeln för att räkna ut celsius från fahr
            return celsius;
        }
        static void Main(string[] args)
        {
            int minValue = 73; //min värde för att basta
            int maxValue = 77;//max värde för att basta
            int opTemp = 75;//bästa värde för att basta
            double fahrenheitInput = 0;//startvärde
            double celsius = 0;//startvärde
            bool isCorrectValue = false; //vilkor för loopen

            do //loop
            {
                Console.WriteLine("Ange ett värde bastuaggregatet:");
                try
                {
                    fahrenheitInput = Convert.ToDouble(Console.ReadLine()); //fångar upp användarens input
                }
                catch (FormatException e)//Kör om formateringen inte lyckas.
                {
                    Console.WriteLine("Du har angett fel format. Programmet stängs nu av.");
                    Environment.Exit(0); // stänger ner programmet ifall användaren har skrivit in fel
                }

                celsius = fahrToCels(fahrenheitInput); //Anropar metod som omvandlar fahr till celsius.

                if (celsius >= minValue && celsius <= maxValue)//testar om celsius är inom intervallet.
                {
                isCorrectValue = true; // Värdet är korrekt så kan loopen avslutas.
                Console.WriteLine("Det går bra att basta nu, tempen är " + celsius + " grader");
                }
                else if (celsius < minValue)
                        Console.WriteLine("Det är för kallt skruva upp temperaturen lite");
                else if (celsius > maxValue)
                        Console.WriteLine("Det är för varmt skruva ner temperaturen lite");

            } while (isCorrectValue == false);

            if (celsius == opTemp) //perfekta graden
                Console.WriteLine("Nu är det exakt 75 celsius!");//167 f

            Console.WriteLine("Programmet avslutas");
        }
    }
}
