using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Human
    {
        public string Name;
        public string Surname;

        public override string ToString()
        {
            return "Fullname: " + Name + " " + Surname;
        }

        public override bool Equals(object? obj)
        {
            return this.GetHashCode()==obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }


    }
}
