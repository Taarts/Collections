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

            //produces  "-1" (SENTINEL VALUE)as an exception
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

            // defining a Dictionary
            //Tracking related Data


            var playerScores = new Dictionary<string, int>();
            playerScores.Add("Mary Rose", 1_452_625); //"_" denotes space or comma

            //LookUp

            //LookUp & Change
            playerScores["Mary Rose"] = 3;

            //LookUp Pickle's score, if not present will ADD it
            playerScores["Pickle"] = 100;

            var maryPlayerScore = playerScores["Mary Rose"];
            Console.WriteLine(maryPlayerScore);


            var picklePlayerScore = playerScores["Pickle"];
            Console.WriteLine(picklePlayerScore);

            //hasKey

            var hasKey = playerScores.ContainsKey("Julius Cesar");
            if (hasKey)
            {
                var juliusScore = playerScores["Julius Cesar"];
                Console.Write(juliusScore);
            }

            //-------- Queues First In, First Out
            //FIFO
            //Not random access

            var students = new Queue<string>();

            students.Enqueue("Mary");
            students.Enqueue("Bill");
            students.Enqueue("Paul");
            students.Enqueue("Sandra");
            students.Enqueue("Thomas");

            //spits out Mary
            // var firstStudent = students.Peek();
            // Console.WriteLine(firstStudent);

            //below is not working...
            var firstStudent = students.Dequeue();
            Console.WriteLine(firstStudent);

            students.Clear();
            Console.WriteLine($"There are now {students.Count} students in the queue.");

            /* - Interfaces are collections
            IAnimal
    
             - are interfaces of things the eat, sleep and run
            IAnimal is a Generic type
            Bear, Cat, Dolphin are concrete types that exhibit the behaviors listed.
            
            Takeway
            • Different types in C# share common behaviors. 
              An Interface allows these types to share behaviors.
            • If two things share a common Interface, they work similarly, 
              and each does the things the Interface describes.
            • We'll see them a lot more than we create them.
            • When we see that some type is an ISomething, the I is a   
              convention that says, "This is an Interface".
            
            */



        }
    }
}
