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

        private void DataStore_UpdateMessage(Messages.RacerStatus obj)
        {
            if (raceGroups == null) { raceGroups = new RaceGroupInfo(); }
            else { Console.WriteLine(raceGroups.raceGroups[0].ToString()); }

            Console.WriteLine($"UPDATED MESSAGE {obj.RacerBibNumber}");
        }
    }
}
