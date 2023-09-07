using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] scores = { 90, 71, 82, 93, 75, 82 };

        var consulta = from score in scores
                       where score > 80
                       orderby score descending
                       select score;

        Console.WriteLine("Resultados de la consulta:");

        foreach (var score in consulta)
        {
            Console.WriteLine(score);
        }
    }
}