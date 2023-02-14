﻿using Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyServer
{
    internal class RacerObserver
    {
        RaceGroupInfo raceGroups;
        int[] BibNumbers;

        public RacerObserver(IReceiver receiver, int[] bibNumbers)
        {
            receiver.UpdateMessage += DataStore_UpdateMessage;
            this.BibNumbers = bibNumbers;
        }

        private void DataStore_UpdateMessage(Messages.RacerStatus status)
        {
            if (raceGroups == null) { raceGroups = new RaceGroupInfo("", ""); }

            foreach (var bib in this.BibNumbers)
            {
                if (status.RacerBibNumber == bib)
                {
                    RaceInformation racer = raceGroups.FindRacer(status.RacerBibNumber);
                    if (racer != null)
                    {
                        Console.WriteLine(racer.name);
                    }
                }
            }
        }
    }
}
