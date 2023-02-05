using Messages;
using System;

namespace DummyServer
{
    public interface IDataStore
    {
        event Action<RacerStatus> UpdateMessage;
        void ReceiveInfo(RacerStatus status);
    }
}