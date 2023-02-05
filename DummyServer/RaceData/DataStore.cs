using Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DummyServer
{
    internal class DataStore : IDataStore
    {
        public List<RacerStatus> messages;

        public RacerStatus mostRecent;

        public DataStore()
        { }

        public void ReceiveInfo(RacerStatus status)
        {
            mostRecent = status;
            UpdateMessage(status);
        }

        public event Action<RacerStatus> UpdateMessage;

    };
}