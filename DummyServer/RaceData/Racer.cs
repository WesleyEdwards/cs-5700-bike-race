using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyServer
{
    public class Racer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RaceBibNumber { get; set; }
        public int groupId { get; set; }
        public void Write(StreamWriter write)
        {
            write.WriteLine("RACER: {0},{1},{2},{3}", FirstName, LastName, RaceBibNumber, groupId);
        }

    }
}