using Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyServer
{
    internal class RaceGroup
    {
        private List<Racer> racerList;

        // The following properties characterize the group
        public int Id { get; set; }
        public string Label { get; set; }
        public int StartTime { get; set; }      // Milliseconds after race start time
        public int MinBibNumber { get; set; }
        public int MaxBibNumber { get; set; }

        // Not needed
        public List<Racer> Racers { get { return racerList; } }

        public void Write(StreamWriter groupWriter, StreamWriter racerWriter)
        {
            groupWriter.WriteLine("{0},{1},{2},{3},{4}", Id, Label, StartTime, MinBibNumber, MaxBibNumber);
            foreach (Racer racer in racerList)
                racer.Write(racerWriter, Id);
        }

        public int Count
        {
            get { return racerList.Count; }
        }

        public Racer this[int index]
        {
            get
            {
                Racer result = null;
                if (index >= 0 && index < racerList.Count)
                    result = racerList[index];
                return result;
            }
        }

        public void AddRacer(RacerStatus status)
        {
            Console.WriteLine($"Racer {status.RacerBibNumber} in group {this.Id}");
        }
    }
}
