using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.eventkeyword
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

        // This delegate works in conjunction with the Car's events
        public delegate void CarEngineHandler(string msg);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded("Sorry, this car is dead...");

                // Also, you can do like follows using null conditional operator
                // Exploded?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && AboutToBlow != null)
                {
                    AboutToBlow("Careful buddy! Gonna blow!");
                }

                // Also, you can do like follows using null conditional operator
                //if (10 == (MaxSpeed - CurrentSpeed))
                //{
                //    AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
                //}

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
