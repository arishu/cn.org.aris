using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.indexermethod
{
    public class PersonDictionary : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        // This indexer returns a person based on a string index
        public Person this[string name]
        {
            get => (Person)listPeople[name];
            set => listPeople[name] = value;
        }

        public int Count { get => listPeople.Count; }

        public void ClearPeople()
        {
            listPeople.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();
    }
}
