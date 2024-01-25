using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH01
{
    internal class Person
    {
        protected string name, address, id, email, phone, gender;
        protected DateTime birth;
        public string Name
        {
            get { return name; }
        }
        public string Address
        {
            get { return address; }
        }
        public string Id
        {
            get { return id; }
        }
        public DateTime Birth
        {
            get { return birth; }
        }
        public string Email
        {
            get { return email; }
        }
        public string Phone
        {
            get { return phone; }
        }
        public string Gender
        {
            get { return gender; }
        }
        public Person()
        {
            
        }
        public Person(string name, string address, string id, DateTime birth,string email,string phone,string gender)
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.birth = birth;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
        }
    }
}
