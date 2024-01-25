using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH01
{
    internal class Student : Person
    {
        public Student(string name, string address, string id, DateTime birth, string email, string phone, string gender) : base(name,address,id,birth,email,phone,gender)
        {

        }
        public Student() : base()
        {

        }
    }
}
