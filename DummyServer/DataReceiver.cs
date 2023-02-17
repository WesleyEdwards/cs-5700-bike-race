using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace DummyServer
{
    public class DataReceiver: IReceiver
    {
        private UdpClient udpClient;
        private bool keepGoing;
        private Thread myRunThread;

        public void Start()
        {
            udpClient = new UdpClient(14000);
            keepGoing = true;
            myRunThread = new Thread(new ThreadStart(Run));
            myRunThread.Start();
        }

        public void Stop()
        {
            keepGoing = false;
        }

        private void Run()
        {
            while (keepGoing)
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
                udpClient.Client.ReceiveTimeout = 1000;
                byte[] messageByes;
                try
                {
                    messageByes = udpClient.Receive(ref ep);
                    if (messageByes != null)
                    {
                        RacerStatus statusMessage = RacerStatus.Decode(messageByes);
                        if (statusMessage != null)
                        {
                            this.ReceiveInfo(statusMessage);
                        }
                    }
                }
                catch (SocketException err)
                {
                    if (err.SocketErrorCode != SocketError.Interrupted && err.SocketErrorCode != SocketError.TimedOut)
                        throw err;
                }
            }
        }
        public void ReceiveInfo(RacerStatus status)
        { 
            UpdateMessage(status);
        }

        public event Action<RacerStatus> UpdateMessage;
    }
}
