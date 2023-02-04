using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyServer
{
    internal class Racer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RaceBibNumber { get; set; }
        public void Write(StreamWriter write, int groupId)
        {
            write.WriteLine("RACER: {0},{1},{2},{3}", FirstName, LastName, RaceBibNumber, groupId);
        }

    }
}