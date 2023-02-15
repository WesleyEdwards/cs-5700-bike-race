using Messages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace DummyServer
{
    public partial class ListDisplay : RaceObserver
    {
        public RaceGroupInfo information;
        public CheatObserver CheatCalculator { get; set; }
        public List<int> cachedCheats { get; set; } = new List<int>();
        public ListDisplay(DataReceiver receiver, RaceGroupInfo information)
        {
            this.CheatCalculator = new CheatObserver(information.racers);
            this.information = information;
            receiver.UpdateMessage += RefreshDisplay;
            InitializeComponent();
        }

        public void RefreshDisplay(RacerStatus status)
        {
            var r = this.cachedCheats.Find(it => it == status.RacerBibNumber);
            if (this.cachedCheats.Contains(r)) { return; }

            this.CheatCalculator.UpdateMessage(status);
            this.RefreshDisplay();
        }
        protected override void RefreshDisplay()
        {
            SuspendLayout();

            if (cachedCheats.Count == CheatCalculator.cheaters.Count) { return; }

            RemoveUntrackedBalls();

            this.cachedCheats.Clear();
            foreach (var stat in this.CheatCalculator.cheaters)
            {
                RaceInformation myRacer = information.FindRacer(stat);

                if (myRacer == null) { continue; }
                if (this.cachedCheats.Contains(myRacer.status.RacerBibNumber)) { continue; }

                string[] row = { myRacer.status.RacerBibNumber.ToString(), myRacer.name };
                var listViewItem = new ListViewItem(row) { Tag = myRacer.status.RacerBibNumber };

                ballListView.Items.Add(listViewItem);
                this.cachedCheats.Add(myRacer.status.RacerBibNumber);
            }

            ResumeLayout();
        }

        private void ListDisplay_Load(object sender, EventArgs e)
        {
            Text = Title;
            StartRefreshTimer();
        }

        private void RemoveUntrackedBalls() { ballListView.Items.Clear(); }
    }
}
