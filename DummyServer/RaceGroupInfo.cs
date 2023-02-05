using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DummyServer
{

    internal class RaceGroupInfo
    {
        public RaceGroup[] raceGroups;
        public RaceGroupInfo()
        {
            var racePath = @".\Groups.csv";

            RaceGroup[] readGroups = File.ReadAllLines(racePath)
                 .Select(line => line.Split(','))
                 .Select(x => new RaceGroup
                 {
                     Id = Int32.Parse(x[0]),
                     Label = x[1],
                     StartTime = Int32.Parse(x[2]),
                     MinBibNumber = Int32.Parse(x[3]),
                     MaxBibNumber = Int32.Parse(x[4])
                 })
                 .ToArray();

            this.raceGroups = readGroups;
            foreach (var raceGroup in raceGroups)
            {
                Console.WriteLine($"{raceGroup.Id} {raceGroup.Label}");
            }
        }
    }
}
