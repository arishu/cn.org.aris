using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.sendingobjectstatenotifications
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        // Is the car alive or dead
        private bool carIsDead;

        public Car() { }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // Declare a delegate type
        public delegate void CarEngineHandler(string msgFromCaller);

        // Define a member variable of this delegate
        private CarEngineHandler listOfHandlers;

        // Add registeration function for the caller
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            // Single cast
            // listOfHandlers = methodToCall;

            // Multicast using += operator
            listOfHandlers += methodToCall;
        }

        // Remove registeration function for the caller
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                // Is this car "almost dead"
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }


    }
}
