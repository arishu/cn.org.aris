using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.applicationlevelexceptions
{
    class ThirdCustomExceptionCar
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool carIsDead;

        private RadioWithSThirdCustomException theMusicBox = new RadioWithSThirdCustomException();

        public ThirdCustomExceptionCar() {}

        public ThirdCustomExceptionCar(string name, int speed)
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
            if (carIsDead)
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
                    CarIsDeadThirdException ex = new CarIsDeadThirdException($"{PetName} has overheated!")
                    {
                        ErrorTimeStamp = DateTime.Now,
                        CauseOfError = "You have a lead foot"
                    };
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

    internal class RadioWithSThirdCustomException
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }
}
