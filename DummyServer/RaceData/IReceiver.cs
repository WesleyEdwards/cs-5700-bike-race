using Messages;
using System;

namespace DummyServer
{
    public interface IReceiver
    {
        event Action<RacerStatus> UpdateMessage;
        void ReceiveInfo(RacerStatus status);
    }
}