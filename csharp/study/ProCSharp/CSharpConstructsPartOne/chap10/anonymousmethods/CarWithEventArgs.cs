using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.anonymousmethods
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        // Is the Car alive or dead
        private bool carIsDead;

        public Car() { }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // This delegate works in conjunction with the Car's events
        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry, this Car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                // Also, you can do like follows using null conditional operator
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                }

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
