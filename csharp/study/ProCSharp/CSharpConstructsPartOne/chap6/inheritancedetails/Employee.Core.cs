using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.inheritancedetails
{
    /// <summary>
    /// Core Employee Class 
    /// where field data and constructors are defined
    /// </summary>
    abstract partial class Employee
    {
		// Field Data
        protected string empName;
        protected int empAge;
        protected int empID;
        protected float currPay;
        protected string empSSN;
        protected string empdesc;
        protected BenefitPackage empBenefits = new BenefitPackage();

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
