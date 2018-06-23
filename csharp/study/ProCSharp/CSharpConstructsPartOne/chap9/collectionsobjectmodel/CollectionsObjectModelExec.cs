using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.collectionsobjectmodel
{
    class CollectionsObjectModelExec : AChap9ExecObject
    {
        public override void Exec()
        {
            try
            {
                ObservableCollectionUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CollectionsObjectModelExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        // handler for 'CollectionChanged' event
        private static void People_CollectionChanged(object sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // What was the action that caused the event?
            Console.WriteLine("Action for this event: {0}", e.Action);

            // if add something
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the NEW items: ");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }

            // if remove something
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items: ");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// ObservableCollection Usage
        /// </summary>
        private void ObservableCollectionUsage()
        {
            Console.WriteLine("=> ObservableCollection Usage: ");

            ObservableCollection<Person> people = new ObservableCollection<Person>
            {
                new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52 },
                new Person{ FirstName = "Kevin", LastName = "Key", Age = 48 },
            };

            // Wire up the CollectionChanged event
            people.CollectionChanged += People_CollectionChanged;

            // Try add a new Person
            Console.WriteLine("-> Add a new Person: ");
            people.Add(new Person { FirstName = "Hu", LastName = "Aris", Age = 27 });
            Console.WriteLine();

            // Try to remove the Person with index of 0
            Console.WriteLine("-> Remove the Person with index 0: ");
            people.RemoveAt(0);
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
