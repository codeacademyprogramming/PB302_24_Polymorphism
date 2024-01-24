using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Student:Human
    {
        public string GroupNo;

        public override string ToString()
        {
            return base.ToString() +" GroupNo: "+GroupNo;
        }
    }
}
