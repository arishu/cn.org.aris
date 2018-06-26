using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.eventkeyword
{
    public class CarWithGenericEventHandler
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        // Is the CarWithGenericEventHandle alive or dead
        private bool carIsDead;

        public CarWithGenericEventHandler() { }

        public CarWithGenericEventHandler(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // This delegate works in conjunction with the CarWithGenericEventHandle's events
        public delegate void CarEngineHandler<T>(object sender, CarEventArgs e);

        public event CarEngineHandler<CarEventArgs> Exploded;
        public event CarEngineHandler<CarEventArgs> AboutToBlow;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                // Also, you can do like follows using null conditional operator
                Exploded?.Invoke(this, new CarEventArgs("Sorry, this CarWithGenericEventHandle is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                // Also, you can do like follows using null conditional operator
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("CarWithGenericEventHandleeful buddy! Gonna blow!"));
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
