using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Student:Human
    {
        public string GroupNo;

        public override void Display()
        {
            Console.WriteLine("Fullname: " + Fullname+" - "+"GroupNo: "+GroupNo);
        }
    }
}
