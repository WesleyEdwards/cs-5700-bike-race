using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

using System.Windows.Forms;

using Messages;

namespace DummyServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // This dummy server receives RacerStatus Messages from the simulator
            // and simply prints them to the screen

            DataReceiver receiver = new DataReceiver();
            CheatObserver cheatObserver = new CheatObserver(receiver.dataStore);

            receiver.Start();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());


            string tmp = Console.ReadLine();
            receiver.Stop();
        }


    }
}
