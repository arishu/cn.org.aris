using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap4.test
{
    internal class Dog
    {
        public Dog(string name)
        {
            this.Name = name;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return "Dog [name: \"" + Name + "\"]";
        }
    }

    internal struct Poodle
    {
        public string Name { get; set; }

        public Poodle(string name)
        {
            Name = name;
        }

        //public override string ToString()
        //{
        //    return "Poodle [name: \"" + Name + "\"]";
        //}
    }

    class ClassAndStruct
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Apple");
            Dog dog2 = dog1;
            Dog dog3 = dog1;
            Dog dog4 = dog1;

            Console.WriteLine("Original Dog Info: {0}", dog1.ToString());
            dog1.Name = "Honey";
            Console.WriteLine("Modified Dog Info: {0}", dog1.ToString());

            Console.WriteLine("Second Dog Info: {0}", dog2.ToString());
            Console.WriteLine("Third Dog Info: {0}", dog3.ToString());
            Console.WriteLine("Fourth Dog Info: {0}", dog4.ToString());

            Poodle poodle1 = new Poodle("Lovely");
            Poodle poodle2 = poodle1;
            Poodle poodle3 = poodle1;
            Poodle poodle4 = poodle1;

            Console.WriteLine("Original Poodle Info: {0}", poodle1);
            poodle1.Name = "Come on";
            Console.WriteLine("Modified Poodle Info: {0}", poodle1);

            Console.WriteLine("Second Poodle Info: {0}", poodle2);
            Console.WriteLine("Third Poodle Info: {0}", poodle3);
            Console.WriteLine("Fourth Poodle Info: {0}", poodle4);
        }

    }
}
