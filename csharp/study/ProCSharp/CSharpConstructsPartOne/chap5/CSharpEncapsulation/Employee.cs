﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class Employee
    {
        // Field Data

        private string empName;
        private int empAge;
        private int empID;
        private float currPay;
        private string empSSN;
        private string empdesc;

        // Properties
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters! ");
                else
                    empName = value;
            }
        }

        // Propertity using expression-bodied format
        public int Age
        {
            get => empAge;
            set => empAge = value;
        }

        public int ID
        {
            get => empID;
            set => empID = value;
        }

        public float Pay
        {
            get => currPay;
            set => currPay = value;
        }

        public string SocialSecurityNumber
        {
            get => empSSN;
        }

        public string PersonalDescription
        {
            set => empdesc = value;
        }

        // Accessor (get methods)
        public string GetName()
        {
            return empName;
        }

        public int GetAge()
        {
            return empAge;
        }

        // Mutator (set methods)
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment
            if (name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters! ");
            else
                empName = name;
        }

        public void SetAge(int age)
        {
            empAge = age;
        }

        // Constructors

        public Employee() {}

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "", "") { }


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

        // Methods

        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
            Console.WriteLine("Desc: {0}", empdesc);
        }
    }
}
