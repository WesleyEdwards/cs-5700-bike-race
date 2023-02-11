﻿using Messages;
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
        public Racer[] racers { get; set; }
        public RaceGroupInfo(string groupPath, string racerPath)
        {
            var groups = groupPath == "" ? @".\Groups.csv" : groupPath;
            var racers = racerPath == "" ? @".\Racers.csv" : racerPath;
            GetCSVInfo(groups, racers);
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


            Racer[] readRacers = File.ReadAllLines(racerPath)
                 .Select(line => line.Split(','))
                 .Select(racer => new Racer
                 {
                     FirstName = racer[0],
                     LastName = racer[1],
                     RaceBibNumber = Int32.Parse(racer[2]),
                     groupId = Int32.Parse(racer[3]),
                 })
                 .ToArray();

            this.raceGroups = readGroups;
            this.racers = readRacers;

            foreach (Racer racer in this.racers)
            {
                foreach (RaceGroup group in this.raceGroups)
                {
                    if (racer.groupId == group.Id)
                    {
                        group.AddRacer(racer);
                    }
                }
            }
        }

        public Racer FindRacer(RacerStatus status)
        {
            foreach (RaceGroup group in raceGroups)
            {
                foreach (Racer racer in group.Racers)
                {
                    if (racer.RaceBibNumber == status.RacerBibNumber)
                    {
                        return racer;
                    }
                }
            }
            return null;
        }
    }
}