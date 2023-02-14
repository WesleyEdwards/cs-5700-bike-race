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
        public List<RaceInformation> cachedCheats { get; set; } = new List<RaceInformation>();
        public ListDisplay(DataReceiver receiver, RaceGroupInfo information)
        {
            this.CheatCalculator = new CheatObserver(information.racers);
            this.information = information;
            receiver.UpdateMessage += RefreshDisplay;
            InitializeComponent();
        }

        public void RefreshDisplay(RacerStatus status)
        {
            this.CheatCalculator.UpdateMessage(status);
            this.RefreshDisplay();
        }
        protected override void RefreshDisplay()
        {
            SuspendLayout();

            if (cachedCheats.Count >= CheatCalculator.cheaters.Count) { return; }

            RemoveUntrackedBalls();

            foreach (var stat in this.CheatCalculator.cheaters)
            {
                RaceInformation myRacer = information.FindRacer(stat.RacerBibNumber);

                var found = cachedCheats.Contains(myRacer);
                if (!found)
                {
                    cachedCheats.Add(myRacer);
                }

                if (myRacer == null)
                {
                    Console.WriteLine("Crap");
                    cachedCheats.Add(new RaceInformation("asdf", 2));
                    continue;
                }
                string[] row = { myRacer.bib.ToString(), myRacer.name };
                var listViewItem = new ListViewItem(row) { Tag = myRacer.bib };
                //string[] row = { stat.RacerBibNumber.ToString(), $"NAME" };
                //var listViewItem = new ListViewItem(row);



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

            //var removeList = new List<int>();
            //for (var i = ballListView.Items.Count - 1; i >= 0; i--)
            //{
            //    if (IsBallBeingObserved((int)ballListView.Items[i].Tag)) continue;

            //    removeList.Add(i);
            //}

            //foreach (var index in removeList)
            //    ballListView.Items.RemoveAt(index);
        }

        //private int FindIndex(Ball ball)
        //{
        //    var index = -1;

        //    for (var i = 0; i < ballListView.Items.Count && index == -1; i++)
        //        if (ball.Id == (int) ballListView.Items[i].Tag)
        //            index = i;

        //    return index;
        //}

        //private static ListViewItem CreateListViewItem(Ball ball)
        //{
        //    var item = new ListViewItem() { Tag = ball.Id };
        //    var values = SetupColumnValues(ball, item);
        //    foreach (var columnValue in values)
        //        item.SubItems.Add(columnValue);
        //    return item;
        //}

        //private static void UpdateListViewItem(Ball ball, ListViewItem item)
        //{
        //    var values = SetupColumnValues(ball, item);
        //    for (var i = 0; i < values.Length; i++)
        //        item.SubItems[i] = values[i];
        //}

        //private static ListViewItem.ListViewSubItem[] SetupColumnValues(Ball ball, ListViewItem item)
        //{
        //    var values = new ListViewItem.ListViewSubItem[7];
        //    values[0] = new ListViewItem.ListViewSubItem(item, ball.Id.ToString());
        //    values[1] = new ListViewItem.ListViewSubItem(item, ball.X.ToString("F1"));
        //    values[2] = new ListViewItem.ListViewSubItem(item, ball.Y.ToString("F1"));
        //    values[3] = new ListViewItem.ListViewSubItem(item, ball.Radius.ToString(CultureInfo.InvariantCulture));
        //    values[4] = new ListViewItem.ListViewSubItem(item, ball.Direction.ToString(CultureInfo.InvariantCulture));
        //    values[5] = new ListViewItem.ListViewSubItem(item, ball.Speed.ToString(CultureInfo.InvariantCulture));
        //    values[6] = new ListViewItem.ListViewSubItem(item, ball.StateChanges.ToString());
        //    return values;
        //}

    }
}
