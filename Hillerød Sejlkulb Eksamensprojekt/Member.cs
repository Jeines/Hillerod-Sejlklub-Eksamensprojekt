using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool Senior
        {
            get { return Age > 17; }
        }
        public bool junior 
        { 
            get { return Age < 17; }
        }

        public Member()
        {

        }

        public Member(int id, string name, string lastname,int age, int phonenumber, string email, string address)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Age = age;
            PhoneNumber = phonenumber;
            Email = email;
            Address = address;

        }

        public override string ToString()
        {
            //return "Memberid " + Id + "Name " + Name + " " + LastName + " " + PhoneNumber + " " + Email + " " + Address;

           return $"Members Id: ({Id}) | Navn: {Name} | Last Name: {LastName} | Alder: {Age} \nAddress: {Address} \nPhone Number: {PhoneNumber} \nEmail: {Email}  \n  ";
        }
    }
    
}
