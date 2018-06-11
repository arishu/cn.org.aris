using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.multiexceptionhandling
{
    class MultiExceptionCar
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool carIsDead;

        private MultiExceptionRadio theMusicBox = new MultiExceptionRadio();

        public MultiExceptionCar() {}

        public MultiExceptionCar(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
            else if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    // Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;

                    // Create a new local variable before throwing the Exception Object
                    SerializedCarIsDeadException ex = new SerializedCarIsDeadException($"{PetName} has overheated!",
                        "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.baidu.com";

                    throw ex;
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }

    internal class MultiExceptionRadio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }
}
