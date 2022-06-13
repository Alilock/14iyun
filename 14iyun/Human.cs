using System;
using System.Collections.Generic;
using System.Text;

namespace _14iyun
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public Human(byte age, string name = null, string surname = null)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }
    }
}
