using Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyServer
{
    internal class CheatObserver
    {
        RaceGroupInfo raceGroups;
        List<RacerStatus> cheaters;
        List<RacerStatus> statuses;
        List<PossibleCheat> possibleCheats;
        public CheatObserver(IReceiver receiver)
        {
            this.statuses = new List<RacerStatus>();
            this.cheaters = new List<RacerStatus>();
            this.possibleCheats = new List<PossibleCheat>();
            receiver.UpdateMessage += DataStore_UpdateMessage;
        }

        private void DataStore_UpdateMessage(RacerStatus newStatus)
        {
            if (raceGroups == null) { raceGroups = new RaceGroupInfo("", ""); }

            this.statuses.Add(newStatus);

            foreach (RacerStatus inList in this.statuses)
            {
                if (inList.SensorId == newStatus.SensorId)
                {
                    if (!inSameGroup(inList, newStatus))
                    {
                        if (withinThreeSec(inList, newStatus))
                        {
                            checkPossibles(inList, newStatus);
                            this.possibleCheats.Add(new PossibleCheat(inList, newStatus));
                        };
                    }
                }
            }
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
        private void checkPossibles(RacerStatus stat1, RacerStatus stat2)
        {
            if (inCheaterList(stat1) && inCheaterList(stat2)) { return; }

            foreach (var cheat in this.possibleCheats)
            {
                var bib1 = cheat.Status1.RacerBibNumber;
                var bib2 = cheat.Status2.RacerBibNumber;

                if (bib1 == stat1.RacerBibNumber || bib1 == stat2.RacerBibNumber)
                {
                    if (bib2 == stat1.RacerBibNumber || bib2 == stat2.RacerBibNumber)
                    {
                        this.cheaters.Add(stat1);
                        this.cheaters.Add(stat2);

                        Console.WriteLine($"{bib1} and {bib2} Flagged for cheating");
                    }
                }
            }
        }
        private bool inCheaterList(RacerStatus racer)
        {
            foreach (var cheater in this.cheaters)
            {
                if (cheater.RacerBibNumber == racer.RacerBibNumber)
                {
                    return true;
                }
            }
            return false;
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
}
