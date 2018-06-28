using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.indexermethod
{
    class IndexerMethodUsageExec : AChap11ExecObject
    {
        public override void Exec()
        {
            try
            {
                Simpleindexer();

                UseIndexerWithGenericListOfPeople();

                IndexDataUsingStringValues();

                MultiIndexerWithDataTable();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in IndexerMethodUsageExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Simple Indexer Usage
        /// </summary>
        private void Simpleindexer()
        {
            Console.WriteLine("=> Simple Indexer Usage: ");

            PersonCollection myPeople = new PersonCollection();

            // Add objects with indexer syntax
            myPeople[0] = new Person("Homer", "Simpson", 40);
            myPeople[1] = new Person("Marge", "Simpson", 38);
            myPeople[2] = new Person("Lisa", "Simpson", 9);
            myPeople[3] = new Person("Bart", "Simpson", 7);
            myPeople[4] = new Person("Maggie", "Simpson", 2);

            // Now obtain and display each item using indexer
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person Number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Use Indexer with Generic List of People
        /// </summary>
        private void UseIndexerWithGenericListOfPeople()
        {
            Console.WriteLine("=> Use Indexer with Generic List of People: ");

            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Lisa", "Simpson", 9));
            myPeople.Add(new Person("Bart", "Simpson", 7));


            myPeople[0] = new Person("Maggie", "Simpson", 2);

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Indexing Data Using String Values
        /// </summary>
        private void IndexDataUsingStringValues()
        {
            Console.WriteLine("=> Indexing Data Using String Values: ");

            PersonDictionary myPeople = new PersonDictionary();

            // Insert two people into the dictionary
            myPeople["Homer"] = new Person("Homer", "Simpson", 40);
            myPeople["Marge"] = new Person("Marge", "Simpson", 38);

            // Get "Homer" and print data
            Person homer = myPeople["homer"];
            Console.WriteLine(homer.ToString());

            Console.WriteLine();
        }

        /// <summary>
        /// Multiple Indexer with Datatable
        /// </summary>
        private void MultiIndexerWithDataTable()
        {
            Console.WriteLine("=> Multiple Indexer with Datatable: ");

            // Make a simple DataTable with three columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add(new DataColumn("FirstName"));
            myTable.Columns.Add(new DataColumn("LastName"));
            myTable.Columns.Add(new DataColumn("Age"));

            // Now, Add a row to the table
            myTable.Rows.Add("Mel", "Appleby", 60);

            // Use multidimention indexer to get details of first row
            Console.WriteLine("FirstName: {0}", myTable.Rows[0][0]);
            Console.WriteLine("LastName: {0}", myTable.Rows[0][1]);
            Console.WriteLine("Age: {0}", myTable.Rows[0][2]);

            Console.WriteLine();
        }

        /// <summary>
        /// Indexer Definition On Interface Type
        /// </summary>
        private void IndexerDefinitionOnInterfaceTypes()
        {
            Console.WriteLine("=> Indexer Definition On Interface Type: ");



            Console.WriteLine();
        }
    }
}