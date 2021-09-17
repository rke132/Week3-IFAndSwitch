using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai 'A', konsool kuvab "Suurepärane!";
            //'B', konsool kuvab "Väga hea!";
            //'C', konsool kuvab "Hea!";
            //'D', konsool kuvab "Rahuldav";
            //'E', konsool kuvab "Kasin";
            //'F', konsool kuvab "Puudulik".
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"

            //kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userResult == 'A')
            {

            }

        }
    }
}
