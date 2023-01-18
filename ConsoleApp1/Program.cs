using System;

namespace uppg
{
    class Uppgift
    {
        static void Main(string[] args)
        {
            int[] years = { 5, 1648, 1939, 1648, 420, 2001, 2022 };
            List<int> SameYear = new List<int>();
            Console.WriteLine("Skriv in året du vill jämföra ");
            int SelectedYear = int.Parse(Console.ReadLine());

            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] == SelectedYear)
                {
                    SameYear.Add(i);
                }
            }
            if (SameYear.Count < 0)
            {
                foreach(int year in SameYear)
                {
                    Console.WriteLine(year);
                }
            }
            else
            {
                Console.WriteLine("Nummret kunde inte hittas");
            }

        }
    }
}