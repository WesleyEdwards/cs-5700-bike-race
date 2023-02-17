using System;
using System.Collections.Generic;


namespace DummyServer
{
    public class CheatObserver
    {
        List<RacerStatus> statuses;
        List<PossibleCheat> possibleCheats;
        List<Racer> listOfRacers = new List<Racer>();
        public CheatObserver(List<Racer> racers)
        {
            this.statuses = new List<RacerStatus>();
            this.possibleCheats = new List<PossibleCheat>();
            foreach (var r in racers)
            {
                listOfRacers.Add(r);

            }
        }

        public Cheaters UpdateMessage(RacerStatus newStatus)
        {
            this.statuses.Add(newStatus);

            foreach (RacerStatus inList in this.statuses)
            {
                if (inList.SensorId == newStatus.SensorId)
                {
                    if (!inSameGroup(inList, newStatus))
                    {
                        if (withinThreeSec(inList, newStatus))
                        {
                            var cheaters = checkPossibles(inList, newStatus);
                            this.possibleCheats.Add(new PossibleCheat(inList, newStatus));
                            return cheaters;
                        };
                    }
                }
            }
            return null;
        }
        private bool inSameGroup(RacerStatus stat1, RacerStatus stat2)
        {
            int s1 = (int)(stat1.RacerBibNumber * .01);
            int s2 = (int)(stat2.RacerBibNumber * .01);
            return s1 == s2;
        }
        private bool withinThreeSec(RacerStatus stat1, RacerStatus stat2)
        {
            int s1 = (int)(stat1.Timestamp * .001);
            int s2 = (int)(stat2.Timestamp * .001);
            if (s1 - s2 < 3 && s1 - s2 > 0) return true;
            if (s2 - s1 < 3 && s2 - s1 > 0) return true;
            return false;
        }
        private Cheaters checkPossibles(RacerStatus stat1, RacerStatus stat2)
        {
            foreach (var cheat in this.possibleCheats)
            {
                var bib1 = cheat.Status1.RacerBibNumber;
                var bib2 = cheat.Status2.RacerBibNumber;

                if (bib1 == stat1.RacerBibNumber || bib1 == stat2.RacerBibNumber)
                {
                    if (bib2 == stat1.RacerBibNumber || bib2 == stat2.RacerBibNumber)
                    {
                        var racer1 = listOfRacers.Find(it => it.RaceBibNumber == bib1);
                        var racer2 = listOfRacers.Find(it => it.RaceBibNumber == bib2);

                        return new Cheaters(new RaceInformation($"{racer1.FirstName} {racer1.LastName}", stat1), new RaceInformation($"{racer2.FirstName} {racer2.LastName}", stat2));
                    }
                }
            }
            return null;
        }

    }
    class PossibleCheat
    {
        public PossibleCheat(RacerStatus status1, RacerStatus status2)
        {
            this.Status1 = status1;
            this.Status2 = status2;
        }
        public RacerStatus Status1;
        public RacerStatus Status2;
    }

    public class Cheaters
    {
        public RaceInformation info1;
        public RaceInformation info2;
        public Cheaters(RaceInformation info1, RaceInformation info2)
        {
            this.info1 = info1;
            this.info2 = info2;
        }
    }
}
