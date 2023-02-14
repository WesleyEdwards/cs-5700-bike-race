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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataReceiver receiver = new DataReceiver();
            Form1 form1 = new Form1();

            Form1Observer form1Observer = new Form1Observer(form1, receiver);

            receiver.Start();

            Application.Run(form1);

            // CheatObserver cheatObserver = new CheatObserver(receiver);
            // RacerObserver racerObserver = new RacerObserver(receiver, racerArray)



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());


            string tmp = Console.ReadLine();
            receiver.Stop();
        }


    }
}
