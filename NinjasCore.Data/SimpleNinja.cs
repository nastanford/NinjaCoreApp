using NinjasCore.Core;
using System;

namespace NinjasCore.Data
{
    public class SimpleNinja : INinja
    {
        public void Fight()
        {
            Console.WriteLine("FIGHT!!!");
        }

        public Ninja GetNinja()
        {
            return new Ninja() { Id = 04, Name = "Ryu", Sex = Gender.Male };
        }

        public void Hide()
        {
            Console.WriteLine("O_o");
        }
    }
}
