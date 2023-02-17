using Messages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace DummyServer
{
    public partial class ListDisplay : RaceObserver
    {
        public CheatObserver CheatCalculator { get; set; }
        public List<Cheaters> cheatersList { get; set; } = new List<Cheaters>();
        public ListDisplay(DataReceiver receiver, RaceGroupInfo information)
        {
            this.CheatCalculator = new CheatObserver(information.racers);
            receiver.UpdateMessage += RefreshDisplay;
            InitializeComponent();
        }

        public void RefreshDisplay(RacerStatus status)
        {

            Cheaters cheaters = this.CheatCalculator.UpdateMessage(status);

            if (cheaters != null)
            {
                this.cheatersList.Add(cheaters);
                this.RefreshDisplay();
            }
        }
        protected override void RefreshDisplay()
        {
            SuspendLayout();

            RemoveUntrackedBalls();

            foreach (var stat in this.cheatersList)
            {

                string[] row = { stat.info1.status.RacerBibNumber.ToString(), stat.info1.name, stat.info1.status.SensorId.ToString() };
                var listViewItem = new ListViewItem(row) { Tag = stat.info1.status.RacerBibNumber };
                ballListView.Items.Add(listViewItem);


                string[] row2 = { stat.info2.status.RacerBibNumber.ToString(), stat.info2.name };
                var listViewItem2 = new ListViewItem(row2) { Tag = stat.info2.status.RacerBibNumber };
                cheater2ListView.Items.Add(listViewItem2);
            }

            ResumeLayout();
        }

        private void ListDisplay_Load(object sender, EventArgs e)
        {
            Text = Title;
            StartRefreshTimer();
        }

        private void RemoveUntrackedBalls() { ballListView.Items.Clear(); cheater2ListView.Items.Clear(); }
    }
}
