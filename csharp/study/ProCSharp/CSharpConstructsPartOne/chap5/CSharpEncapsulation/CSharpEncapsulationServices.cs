using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class CSharpEncapsulationServices : AChap5ExecObject
    {
        public override void Exec()
        {
            try
            {
                EncapsulationUsingTraditionalAccessorAndMutator();

                EncapsulationUsingDotNETProperties();

                ReadOnlyWriteOnlyProperties();

                StaticPropertiesUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CSharpEncapsulationServices: {0}\n{1}", 
                    e.Message ,e.StackTrace);
            }
        }

        /// <summary>
        /// Encapsulation Using Tradional Accessor and Mutator
        /// </summary>
        private void EncapsulationUsingTraditionalAccessorAndMutator()
        {
            Console.WriteLine("=> Encapsulation Using Tradional Accessor and Mutator: ");

            Employee emp = new Employee("Mavin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStatus();

            // Use the get/set methods to interact with the object's name
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());

            Console.WriteLine();
        }

        /// <summary>
        /// Encapsulation Using .NET Properties
        /// </summary>
        private void EncapsulationUsingDotNETProperties()
        {
            Console.WriteLine("=> Encapsulation Using .NET Properties: ");

            Employee emp = new Employee("Mavin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStatus();

            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.GetName());

            // Add Age using mutator method
            emp.SetAge(emp.GetAge() + 1);
            Console.WriteLine("Employee's age is: {0}", emp.GetAge());

            // Add Age using .NET Property
            emp.Age++;
            Console.WriteLine("Employee's age is: {0}", emp.Age);

            Console.WriteLine();
        }

        /// <summary>
        /// Read-Only/Write-Only Property Usage
        /// </summary>
        private void ReadOnlyWriteOnlyProperties()
        {
            Console.WriteLine("=> Read-Only/Write-Only Property Usage: ");

            Employee emp = new Employee("Aris", 789, 12_000);

            // Consume Read-Only Property
            Console.WriteLine("Employee's Social Security Number is: {0}", emp.SocialSecurityNumber);

            // Consume Write-Only Property
            emp.PersonalDescription = "I am who I am，excellent fireworks";

            Console.WriteLine();
        }

        /// <summary>
        /// Static Properties Usage
        /// </summary>
        private void StaticPropertiesUsage()
        {
            Console.WriteLine("=> Static Properties Usage: ");

            // Print current interest rate via property
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);

            Console.WriteLine();
        }

    }

}
