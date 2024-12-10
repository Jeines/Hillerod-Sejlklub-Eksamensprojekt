using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class MembersList
    {
        public List<Members> Member = new List<Members>();


        public MembersList()
        {
            Member.Add(new Members(1, "Bob", "Hansen", 23425234, "Bobbislobbi@gmail.com", "banangade"));
            Member.Add(new Members(2, "Herold", "Fiji", 58426597, "Vandmand@hotmail.vand", "Ocean 78"));
            Member.Add(new Members(3, "Fi", "Thá", 64259718, "fitabrødelsker@ambasaden.com", "Ovngade"));
            Member.Add(new Members(4, "Neptun ", " Mamoa", 22222223, "Saveallfisk69@atlantiserikkeetaquarium.dk ","Havet 22"));
            Member.Add(new Members(5, "Jeremy ", "Bingvin ", 58264751, "Iglonyder99@gulsne.com ", "Antarktis 63"));
            Member.Add(new Members(6, "Henriki ", "Esteban ", 85475126, "bean45@hotmail.dk ", "bønnegården 847"));
            Member.Add(new Members(7, "Ludvig ", "cazino ", 10007878, "kæmpegambler69@gmail.com ", "indianergade 55 "));
            Member.Add(new Members(8, "glorp ", "zesty ", 58484747, "Fradetydrerum21@justthetwoofus.dk ", "spaceX 11 "));
            Member.Add(new Members(9, "Capn" , "Crunch", 12345678, "captain.crunch@cereal.com", "Breakfast Blvd 1"));
            Member.Add(new Members(10, "Mickey", "Mouse", 87654321, "mickey.mouse@disney.com", "Magic Kingdom 2"));
            Member.Add(new Members(11, "Harry", "Potter", 11223344, "harry.potter@hogwarts.edu", "Privet Drive 4"));
            Member.Add(new Members(12, "Sherlock", "Holmes", 44332211, "sherlock.holmes@bakerstreet.co.uk", "Baker Street 221B"));
            Member.Add(new Members(13, "Tony", "Stark", 55667788, "tony.stark@starkindustries.com", "Avengers Tower 5"));
            Member.Add(new Members(14, "Bruce", "Wayne", 99887766, "bruce.wayne@wayneenterprises.com", "Wayne Manor 6"));
            Member.Add(new Members(15, "Frodo", "Baggins", 66778899, "frodo.baggins@shire.net", "Bag End 7"));
            Member.Add(new Members(16, "Lara", "Croft", 33445566, "lara.croft@tombraider.com", "Mansion 8"));
            Member.Add(new Members(17, "Indiana", "Jones", 22334455, "indiana.jones@adventure.org", "Temple of Doom 9"));
            Member.Add(new Members(18, "James", "Bond", 44556677, "james.bond@mi6.gov", "Secret HQ 10"));
            Member.Add(new Members(19, "Homer", "Simpson", 77889900, "homer.simpson@springfield.com", "Evergreen Terrace 11"));
            Member.Add(new Members(20, "Darth", "Vader", 99001122, "darth.vader@empire.com", "Death Star 12"));

        }
        /// En metode de tilføjer et medlem til vores memberlist 
        public void Add(Members member)
        {
            Member.Add(member);
        }

        /// Fjerner et member fra vores members list. 
              
        public bool RemoveMember(int Id)
        {
            foreach (Members member in Member)
            {
                if ( member.Id == Id) 
                {
                    return Member.Remove(member);
                }
            }
            return false;
        }
       
       // Kigger gennem listen for at finde et af medlemmerne med deres ID 
        public Members GetMember(int Id)
        {
            foreach (Members member in Member)
            {
                if ( member.Id == Id)
                    return member;
            }
            return null!;
        }

        // printer medlemmerne ved kald af PrintMembersList metode 
        public void PrintMembersList()
        {
            foreach (Members members in Member)
            {
                Console.WriteLine(members);
            }
        }

        // En metode der kan opdatere vore medlemmer ved hjælp af ID. Den kan opdatere alle de nedrestående variabler.
        public Members Update(int Id, Members member)
        {
            foreach (Members m in Member)
            {
                if (m.Id == Id)
                {
                    m.Name = member.Name;
                    m.LastName = member.LastName;
                    m.PhoneNumber = member.PhoneNumber;
                    m.Address = member.Address;
                    m.Email = member.Email;
                }
            }
            return member;
        }
        
    }
}
