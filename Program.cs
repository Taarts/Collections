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
            if (hasKey) //boolean if "TRUE"
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

         /* -----------Control the Flow
              Boolean
              && = AND
              || = OR

            _____IF - ELSE IF______

            if (name == "Paul") {
              Console.WriteLine("Here");
              } else if (name == "Dorothy") {
                Console.WriteLine("Also here");
              } else if (name == "Sam") {
                Console.WriteLine("Here again");
              } else {
                Console.WriteLine("Didn't find anything");
              }

              ----------- SWITCH ---------
              **** Works as if railway signaling ****
              switch (name)
                {
                 case "Paul":
                 Console.WriteLine("Here");
                 break;

                 case "Dorothy":
                 Console.WriteLine("Also Here");
                 break;

                 case "Sam":
                 Console.WriteLine("Here Again");
                 break;

                 default:
                 Console.WriteLine("Didn't find anything");
                 break;
                }
              ****Below the first three work like an OR statement
              switch (name)
              {
                case "Paul":
                case "Peter":
                case "Mary":
                Console.WriteLine("Here");
                break;

                case "Dorothy":
                Console.WriteLine("Also Here");
                break;

                case "Sam":
                Console.WriteLine("Here Again");
                break;

                default:
                Console.WriteLine("Didn't find anything");
                break; 
                }
                **Conditionals 
                Below is assigning grades to each, given the top grade score "=95"
                var score = 95;
                switch (score)
                {
                 case < 65:
                 Console.WriteLine("F");
                 break;

                case < 70:
                Console.WriteLine("D");
                break;

                case < 80:
                Console.WriteLine("C");
                break;

                case < 90:
                Console.WriteLine("B");
                break;

                case >= 90:
                Console.WriteLine("A");
                break;

                default:
                Console.WriteLine("Hmmm, I don't recognize this score");
                break;
                }
            */
            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            while (name != "quit") // as long as user doesn't type "quit" it will 
                                   // keep asking the question
                                   //only declare a VAR once
                                   //var is shorthand
            {
                Console.WriteLine($"Hello {name}");

                Console.Write("What is your name? ");
                name = Console.ReadLine();

            }

        }
    }
}
