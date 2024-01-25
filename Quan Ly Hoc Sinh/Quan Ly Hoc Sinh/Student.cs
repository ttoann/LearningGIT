using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh
{
    internal class Student : Person
    {
        public Student() { }
        public Student(string name, string address, string id, string mail, string phone, string gender, DateTime birthday) : base(name, address, id, mail, phone, gender, birthday) { }
    }
}
