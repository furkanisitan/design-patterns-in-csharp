using ScoringAlgorithmExample.Abstract;
using ScoringAlgorithmExample.Concrete;
using System;

namespace ScoringAlgorithmExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int hits = 100;
            TimeSpan time = new TimeSpan(0, 2, 21);

            Console.WriteLine($"Men => {Score(new MenScoringAlgorithm(), hits, time)}");
            Console.WriteLine($"Woman => {Score(new WomanScoringAlgorithm(), 100, time)}");
            Console.WriteLine($"Children => {Score(new ChildrenScoringAlgorithm(), hits, time)}");

            Console.ReadKey();
        }

        static int Score(ScoringAlgorithm algorithm, int hits, TimeSpan time) => algorithm.GenerateScore(hits, time);
    }
}
