using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh
{
    internal class Person
    {
        protected string name;
        protected string id;
        protected string address;
        protected string mail;
        protected string phone;
        protected string gender;
        protected DateTime birthday;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Person(string name, string address, string id, string mail, string phone, string gender, DateTime birthday)
        {
            this.name = name;
            this.id = id;
            this.address = address;
            this.mail = mail;
            this.phone = phone;
            this.gender = gender;
            this.birthday = birthday;
        }
        public Person() { }
    }
}
