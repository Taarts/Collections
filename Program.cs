using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            //initializer list
            var names = new List<string>()
            { "Gaga", "Bey", "Lizzo" , "Bowie" };

            var firstName = names[0];
            var secondName = names[3];

            Console.WriteLine(firstName);
            Console.WriteLine(names.Count);

            names.Add("Jagger");
            Console.WriteLine(names.Count);

            names.Insert(2, "Harry");
            // Console.WriteLine(names);  - doesn't print out the contents

            var scores = new List<int>();
            //empty list of "scores as I don't know them yet
            //var listOfScores = new List<int>();
            scores.Add(12);
            scores.Add(100);
            scores.Add(55);
            scores.Add(44);
            scores.Add(55);

            var lastIndex = scores.Count - 1;
            var lastScore = scores[lastIndex];

            // list,Clear();

            var indexOfFiftyFive = scores.IndexOf(55);
            Console.WriteLine($"Found 55 at index {indexOfFiftyFive}");

            //produces  "-1" (SENTINAL VALUE)as an exception
            var indexOfFortytwo = scores.IndexOf(42);
            Console.WriteLine($"Found 42 at index {indexOfFortytwo}");

            var indexOfTwelve = scores.IndexOf(12);
            Console.WriteLine($"Found 12 at index {indexOfTwelve}");


            // Console.WriteLine($"Our list has {scores.Count} values"); // Prints 5
            // scores.Remove(55);

            // Console.WriteLine($"Our list has {scores.Count} values");
            // scores.RemoveAt(2);

            // Console.WriteLine($"Our list has {scores.Count} values");

            scores.Reverse(); //reverse the order

            scores.Add(13);
            scores.Add(102);
            scores.Add(87);

            Console.WriteLine($"Our list has {scores.Count} values");

            scores.Sort();









        }
    }
}
