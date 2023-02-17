using Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DummyServer
{



    public class RaceGroupInfo
    {
        public RaceGroup[] raceGroups { get; set; }
        public List<Racer> racers { get; set; }
        public RaceGroupInfo(string groupPath, string racerPath)
        {
            GetCSVInfo(groupPath, racerPath);
        }
        private void GetCSVInfo(string groupPath, string racerPath)
        {
            RaceGroup[] readGroups = File.ReadAllLines(groupPath)
                 .Select(line => line.Split(','))
                 .Select(group => new RaceGroup
                 {
                     Id = Int32.Parse(group[0]),
                     Label = group[1],
                     StartTime = Int32.Parse(group[2]),
                     MinBibNumber = Int32.Parse(group[3]),
                     MaxBibNumber = Int32.Parse(group[4])
                 })
                 .ToArray();


            List<Racer> readRacers = File.ReadAllLines(racerPath)
                 .Select(line => line.Split(','))
                 .Select(racer => new Racer
                 {
                     FirstName = racer[0],
                     LastName = racer[1],
                     RaceBibNumber = Int32.Parse(racer[2]),
                     groupId = Int32.Parse(racer[3]),
                 }).ToList();

            this.raceGroups = readGroups;
            this.racers = readRacers;
        }

        public RaceInformation FindRacer(RacerStatus status)
        {
            Racer racer = this.racers.Find(it => it.RaceBibNumber == status.RacerBibNumber);
            return new RaceInformation($"{racer.FirstName} {racer.LastName}", status);
        }
    }
    public class RaceInformation
    {
        public string name;
        public RacerStatus status;
        public RaceInformation(string name, RacerStatus status)
        {
            this.name = name;
            this.status = status;
        }
        public void Write(StreamWriter write)
        {
            write.WriteLine("RACER Info: {0},{1},{2},{3}", name, status.RacerBibNumber, status.Timestamp, status.SensorId);
        }
    }

}
