using Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DummyServer
{
    [Serializable]
    internal class RaceGroup
    {
        private List<Racer> racerList;

        public int Id { get; set; }
        public string Label { get; set; }
        public int StartTime { get; set; }      // Milliseconds after race start time
        public int MinBibNumber { get; set; }
        public int MaxBibNumber { get; set; }

        // Not needed
        public List<Racer> Racers { get { return racerList; } }

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
