using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] scores = { 97, 92, 81, 60 };

        var query = from score in scores
                    where score > 80
                    select score;

        foreach (var result in query)
        {
            Console.WriteLine(result);
        }
    }
}