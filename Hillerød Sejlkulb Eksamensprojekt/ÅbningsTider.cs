using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class ÅbningsTider
    {
        public  void Start()
        {
            Dictionary<string, (TimeSpan, TimeSpan)> ÅbningsTider = new Dictionary<string, (TimeSpan, TimeSpan)>
            {
                { "Mandag",(new TimeSpan(8, 0, 0),new TimeSpan (19, 0, 0)) },
                { "Tirsdag",(new TimeSpan(8, 0, 0),new TimeSpan (19, 0, 0)) },
                { "Onsdag",(new TimeSpan(8, 0, 0),new TimeSpan (18, 0, 0)) },
                { "Torsdag",(new TimeSpan(8, 0, 0),new TimeSpan (19, 0, 0)) },
                { "Fredag",(new TimeSpan(8, 0, 0),new TimeSpan (19, 0, 0)) },
                { "Lørdag",(new TimeSpan(8, 0, 0),new TimeSpan (18, 0, 0)) },
                { "Søndag",(new TimeSpan(8, 0, 0),new TimeSpan (18, 0, 0)) },
            };

            Console.WriteLine("Hillerød Sejlklub Åbningstider:");
            foreach (var dag in ÅbningsTider)
            {
                Console.WriteLine($"{dag.Key} \n{dag.Value.Item1} - {dag.Value.Item2} \n");
            }


        }

       
    }
}
