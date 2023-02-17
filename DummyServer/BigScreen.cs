using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DummyServer
{
    public partial class BigScreen : RaceObserver
    {
        public RaceGroupInfo information;
        public List<RaceInformation> winners { get; set; } = new List<RaceInformation>();
        public List<RaceInformation> cachedWinners { get; set; } = new List<RaceInformation>();
        public BigScreen(DataReceiver receiver, RaceGroupInfo information)
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


            var racer = this.information.FindRacer(status);
            if (racer == null) { return; }
            var found = this.winners.Contains(racer);

            if (!found)
            {
                RaceInformation newRacer = new RaceInformation(racer.name, status);
                this.SortWinners(newRacer);
            }

            if (areSame()) { return; }


            RemoveUntrackedBalls();
            foreach (var stat in this.winners)
            {
                var raceMan = this.information.FindRacer(stat.status);
                string[] row = { raceMan.status.RacerBibNumber.ToString(), raceMan.name };
                var listViewItem = new ListViewItem(row) { Tag = raceMan.status.RacerBibNumber };
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

            if (this.winners.Count < 10)
            { this.winners.Add(racer); }
            else
            {
                RaceInformation last = this.winners[winners.Count - 1];
                if (last != null)
                {
                    if (last.status.SensorId < racer.status.SensorId)
                    {
                        this.winners.Remove(last);
                        this.winners.Add(racer);
                    }
                    else
                    {
                        if (last.status.SensorId == racer.status.SensorId && last.status.Timestamp > racer.status.Timestamp)
                        {
                            this.winners.Remove(last);
                            this.winners.Add(racer);
                        }
                    }
                }
            }
            SortWinners();

            

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
                if (win.status.RacerBibNumber != this.cachedWinners[this.winners.IndexOf(win)].status.RacerBibNumber)
                { return false; }
            }
            return true;
        }


        private void SortWinners()
        {

            // List<RaceInformation> sortedRacers = new List<RaceInformation>();

            this.winners.Sort((r1, r2) =>
            {
                if (r1.status.SensorId == r2.status.SensorId)
                {
                    return r1.status.Timestamp.CompareTo(r2.status.Timestamp);
                }
                else
                {
                    return r2.status.SensorId.CompareTo(r1.status.SensorId);
                }
            });

        }

        private void Winners_Load(object sender, EventArgs e)
        {

        }
    }


}
