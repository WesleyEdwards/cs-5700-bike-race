using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyServer
{
    internal class Form1Observer
    {
        RaceGroupInfo raceGroups { get; set; }
        DataReceiver receiver;
        public Form1Observer(Form1 form1, DataReceiver receiver)
        {
            this.receiver = receiver;
            form1.SubmitRacerPaths += GetInfo;
        }
        public void GetInfo(string[] list)
        {
            RaceGroupInfo newRaceGroups = new RaceGroupInfo(list[0], list[1]);

            //Form2 form2 = new Form2(newRaceGroups);
            //form2.Show();

            ControlForm ctrlForm = new ControlForm(newRaceGroups, receiver);
            ctrlForm.Show();

            // if (modalDialogForm.ShowDialog() != DialogResult.OK) return;

            // var observer = (modalDialogForm.ObserverType == "L") ? (BallObserver)new ListDisplay() : new GraphicalDisplay();
            // observer.Title = modalDialogForm.ObserverTitle;
            // _knownDisplays.Add(observer);
            // observer.Show();

            // _selectedObserver = null;
            // observersListView.SelectedIndices.Clear();
            // RefreshObversersListView();
            // RefreshBallLists();
        }
    }
}
