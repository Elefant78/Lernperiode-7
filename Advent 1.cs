using System.Data;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inPath = @"C:\Users\Tafol\OneDrive - Kantonsschule Baden\Projekte\AdventOfCode\input.txt";
            string nummbers = File.ReadAllText(inPath);
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            int count = 0;
            int resultat = 0;
            int similarityScore = 0;

            string[] split = nummbers.Split(new[] { " ", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in split)
            {
                count++;
                int zahl = int.Parse(i);
                if (count % 2 == 0)
                {
                    list2.Add(zahl);
                }
                else
                {
                    list1.Add(zahl);
                }
            }
                list2.Sort();
                list1.Sort();
            foreach (int number in list1)
            {
                int occurrences = list2.Count(n => n == number);  // Zählt, wie oft 'number' in list2 vorkommt
                similarityScore += number * occurrences;  // Ähnlichkeitswert erhöhen
            }

            // Ausgabe des Ähnlichkeitswerts
            Console.WriteLine($"Similarity Score: {similarityScore}");

            /*for(int i  = 0; i < list1.Count; i++) 
            {
                int differenz = list1[i]- list2[i];
                if (differenz < 0)
                {
                    differenz = differenz * -1;
                }
                resultat += differenz;                
            }
            Console.WriteLine(resultat)*/


        }
    }
}

