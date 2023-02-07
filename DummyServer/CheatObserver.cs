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
        public CheatObserver(IDataStore dataStore)
        {
            dataStore.UpdateMessage += DataStore_UpdateMessage;
        }

        private void DataStore_UpdateMessage(Messages.RacerStatus status)
        {
            if (raceGroups == null) { raceGroups = new RaceGroupInfo(); }

            Racer racer = raceGroups.FindRacer(status);

            if (racer != null) { Console.WriteLine(racer.FirstName); }
            else { Console.WriteLine($"NO INFO FOR {status.RacerBibNumber}"); }

        }
    }
}
