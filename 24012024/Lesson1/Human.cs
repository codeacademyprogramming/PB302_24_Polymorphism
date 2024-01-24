using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Human
    {
        public string Fullname;

        public virtual void Display()
        {
            Console.WriteLine("Fullname: "+Fullname);
        }
    }
}
