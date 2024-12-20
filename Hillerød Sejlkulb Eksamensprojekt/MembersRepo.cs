using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class MembersRepo
    {
        public List<Member> memberList = new List<Member>();


        public MembersRepo()
        {
            memberList.Add(new Member(1, "Bob", "Hansen", 56, 23425234, "Bobbislobbi@gmail.com", "banangade 9"));
            memberList.Add(new Member(2, "Herold", "Fiji", 17, 58426597, "Vandmand@hotmail.vand", "Ocean 78"));
            memberList.Add(new Member(3, "Fi", "Thá", 12, 64259718, "fitabrødelsker@ambasaden.com", "Ovngade 12"));
            memberList.Add(new Member(4, "Neptun ", " Mamoa", 29, 22222223, "Saveallfisk69@atlantiserikkeetaquarium.dk ", "Havet 22"));
            memberList.Add(new Member(5, "Jeremy ", "Bingvin ", 15, 58264751, "Iglonyder99@gulsne.com ", "Antarktis 63"));
            memberList.Add(new Member(6, "Henriki ", "Esteban ", 53, 85475126, "bean45@hotmail.dk ", "bønnegården 847"));
            memberList.Add(new Member(7, "Ludvig ", "cazino ", 8, 10007878, "kæmpegambler69@gmail.com ", "indianergade 55 "));
            memberList.Add(new Member(8, "glorp ", "zesty ", 16, 58484747, "Fradetydrerum21@justthetwoofus.dk ", "spaceX 11 "));
            memberList.Add(new Member(9, "Capn", "Crunch", 24, 12345678, "captain.crunch@cereal.com", "Breakfast Blvd 1"));
            memberList.Add(new Member(10, "Mickey", "Mouse", 15, 87654321, "mickey.mouse@disney.com", "Magic Kingdom 2"));
            memberList.Add(new Member(11, "Harry", "Potter", 19, 11223344, "harry.potter@hogwarts.edu", "Privet Drive 4"));
            memberList.Add(new Member(12, "Sherlock", "Holmes", 42, 44332211, "sherlock.holmes@bakerstreet.co.uk", "Baker Street 221B"));
            memberList.Add(new Member(13, "Tony", "Stark", 99, 55667788, "tony.stark@starkindustries.com", "Avengers Tower 5"));
            memberList.Add(new Member(14, "Bruce", "Wayne", 82, 99887766, "bruce.wayne@wayneenterprises.com", "Wayne Manor 6"));
            memberList.Add(new Member(15, "Frodo", "Baggins", 36, 66778899, "frodo.baggins@shire.net", "Bag End 7"));
            memberList.Add(new Member(16, "Lara", "Croft", 26, 33445566, "lara.croft@tombraider.com", "Mansion 8"));
            memberList.Add(new Member(17, "Indiana", "Jones", 59, 22334455, "indiana.jones@adventure.org", "Temple of Doom 9"));
            memberList.Add(new Member(18, "James", "Bond", 76, 44556677, "james.bond@mi6.gov", "Secret HQ 10"));
            memberList.Add(new Member(19, "Homer", "Simpson", 36, 77889900, "homer.simpson@springfield.com", "Evergreen Terrace 11"));
            memberList.Add(new Member(20, "Darth", "Vader", 67, 99001122, "darth.vader@empire.com", "Death Star 12"));

        }
        /// En metode de tilføjer et medlem til vores memberlist 
        public void Add(Member member)
        {
            memberList.Add(member);
        }

        /// Fjerner et member fra vores members list. 

        public bool RemoveMember(int Id)
        {
            foreach (Member member in memberList)
            {
                if (member.Id == Id)
                {
                    return memberList.Remove(member);
                }
            }
            return false;
        }

        // Kigger gennem listen for at finde et af medlemmerne med deres ID 
        public Member GetMember(int Id)
        {
            foreach (Member member in memberList)
            {
                if (member.Id == Id)
                    return member;
            }
            return null!;
        }
        // her laver vi en methode som kan bruges til at hente alle members fra vores List<Member>
        public List<Member> GetAllMembers()
        {
            return memberList;
        }

        // En metode der kan opdatere vore medlemmer ved hjælp af ID. Den kan opdatere alle de nedrestående variabler.
        public Member Update(int Id, Member member)
        {
            foreach (Member m in memberList)
            {
                if (m.Id == Id)
                {
                    m.Name = member.Name;
                    m.LastName = member.LastName;
                    m.PhoneNumber = member.PhoneNumber;
                    m.Address = member.Address;
                    m.Email = member.Email;
                    m.Age = member.Age;
                }
            }
            return member;
        }

    }
}

