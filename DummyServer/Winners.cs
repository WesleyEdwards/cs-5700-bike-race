using Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyServer
{
    public partial class Winners : RaceObserver
    {
        public RaceGroupInfo information;
        public List<RaceInformation> winners { get; set; } = new List<RaceInformation>();
        public List<RaceInformation> cachedWinners { get; set; } = new List<RaceInformation>();
        public Winners(DataReceiver receiver, RaceGroupInfo information)
        {
            this.information = information;
            receiver.UpdateMessage += RefreshDisplay;
            InitializeComponent();
        }

        public void RefreshDisplay(RacerStatus status)
        {
            SuspendLayout();
            this.cachedWinners.Clear();

            foreach (var win in this.winners)
            { this.cachedWinners.Add(win); }


            var racer = this.information.FindRacer(status.RacerBibNumber);
            if (racer == null) { return; }
            var found = this.winners.Contains(racer);

            if (!found)
            {
                RaceInformation newRacer = new RaceInformation(racer.name, racer.bib, status);
                this.SortWinners(newRacer);
            }

            if (areSame()) { return; }

            //this.winners.ForEach(win =>
            //{ Console.Write(win.status.SensorId.ToString() + " (" + ((int)win.status.Timestamp / 1000).ToString() + "), "); });
            //Console.WriteLine();

            RemoveUntrackedBalls();
            foreach (var stat in this.winners)
            {
                var raceMan = this.information.FindRacer(stat.bib);
                string[] row = { raceMan.bib.ToString(), raceMan.name };
                var listViewItem = new ListViewItem(row) { Tag = raceMan.bib };
                ballListView.Items.Add(listViewItem);
            }

            ResumeLayout();
        }

        private void ListDisplay_Load(object sender, EventArgs e)
        {
            Text = Title;
            StartRefreshTimer();
        }

        private void RemoveUntrackedBalls()
        {
            ballListView.Items.Clear();
        }

        private void ballListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SortWinners(RaceInformation racer)
        {
            this.winners.Add(racer);
            this.winners.Sort((a, b) =>
            {
                if (a.status.SensorId > b.status.SensorId)
                { return -1; }
                return a.status.Timestamp.CompareTo(b.status.Timestamp);
            });

            if (this.winners.Count > 10)
            { this.winners.RemoveAt(10); }
        }

        private bool areSame()
        {
            if (this.winners.Count == 0) { return false; }
            if (this.winners.Count != this.cachedWinners.Count)
            { return false; }
            foreach (var win in this.winners)
            {
                if (win.bib != this.cachedWinners[this.winners.IndexOf(win)].bib)
                { return false; }
            }
            return true;
        }
    }


}
