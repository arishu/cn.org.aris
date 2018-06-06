using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.inheritancedetails
{
    partial class Employee
    {
		// Field Data
        private string empName;
        private int empAge;
        private int empID;
        private float currPay;
        private string empSSN;
        private string empdesc;

        // Constructors
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "", "") { }

        public Employee(string name, int age, int id, float pay)
            : this(name, age, id, pay, "", "") { }

        public Employee(string name, int age, int id, float pay, string ssn)
			: this(name, age, id, pay)
        {
            empSSN = ssn;
        }

        // master constructor
        public Employee(string name, int age, int id, float pay, string ssn, string desc)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSSN = ssn;
            PersonalDescription = desc;
        }
    }
}
