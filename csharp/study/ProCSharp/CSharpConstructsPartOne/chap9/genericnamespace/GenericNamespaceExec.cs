using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.genericnamespace
{
    class GenericNamespaceExec : AChap9ExecObject
    {
        public override void Exec()
        {
            try
            {
                CollectionInitialization();

                UseGenericList();

                UseGenericStack();

                UseGenericQueue();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in GenericNamespaceExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Collection Initialization Usage
        /// </summary>
        private void CollectionInitialization()
        {
            Console.WriteLine("=> Collection Initialization Usage: ");

            // Init a standard array
            int[] myArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Init a generic List<> of ints
            List<int> myGenericList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Init an ArrayList with numeric data
            ArrayList myList = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Init an generic List<> of Points
            List<Point> myListofPoints = new List<Point>
            {
                new Point{ X = 2, Y = 3 },
                new Point{ X = 3, Y = 3 },
                new Point(PointColor.BloodRed) { X = 4, Y = 4 }
            };

            // print each point
            foreach (var pt in myListofPoints)
            {
                Console.WriteLine(pt);
            }

            List<Rectangle> myListOfRects = new List<Rectangle>
            {
                new Rectangle
                {
                    TopLeft = new Point { X = 10, Y = 10 },
                    BottomRight = new Point { X = 200, Y = 200 }
                },
                new Rectangle
                {
                    TopLeft = new Point { X = 2, Y = 2 },
                    BottomRight = new Point { X = 100, Y = 100 }
                },
                new Rectangle
                {
                    TopLeft = new Point { X = 5, Y = 5 },
                    BottomRight = new Point { X = 90, Y = 75 }
                }
            };
            foreach (var r in myListOfRects)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Use Generic List
        /// </summary>
        private void UseGenericList()
        {
            Console.WriteLine("=> Use Generic List: ");

            // Make a List of Person objects, filled with
            // collection/object init syntax
            List<Person> people = new List<Person>
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
                new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
            };

            // Print out #of items in list
            Console.WriteLine("Item in list: {0}", people.Count);

            // Enumerate over list
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            // Insert a new Person
            Console.WriteLine("\n->Inserting new person:");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);

            // Copy data into a new array
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("First Names: {0}", p.FirstName);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Use Generic Stack
        /// </summary>
        private void UseGenericStack()
        {
            Console.WriteLine("=> Use Generic Stack: ");

            Stack<Person> stackOfPeople = new Stack<Person>();
            
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Now look at the top item, pop it, and look again
            Console.WriteLine("First Person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("First Person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("First Person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("First Person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("\nError! {0}", e.Message);
            }

            Console.WriteLine();
        }

        private static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        /// <summary>
        /// Use Generic Queue
        /// </summary>
        private void UseGenericQueue()
        {
            Console.WriteLine("=> Use Generic Queue: ");

            // Make a Q with three people
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Look at first person in Q
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);

            // Remove each person from Q
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            // Try to de-Q again?
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }

            Console.WriteLine();
        }
    }
}
