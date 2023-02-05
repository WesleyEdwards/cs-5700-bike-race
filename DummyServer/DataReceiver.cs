using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

using Messages;


namespace DummyServer
{
    internal class DataReceiver
    {
        private UdpClient udpClient;
        private bool keepGoing;
        private Thread myRunThread;
        public DataStore dataStore;

        public DataReceiver()
        {
            dataStore = new DataStore();
        }
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
                            dataStore.ReceiveInfo(statusMessage);
                            // A non-dummy server would do something intelligent with the message,
                            // like lookup the racer and update the last sensor and time
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
    }
}
