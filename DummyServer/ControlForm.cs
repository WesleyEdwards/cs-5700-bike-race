using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DummyServer
{
    public partial class ControlForm : Form
    {
        // Data members to track known balls and obversers for UI. These are outside the observer pattern
        private readonly List<Racer> _knownRacers = new List<Racer>();
        private readonly List<RaceObserver> _knownDisplays = new List<RaceObserver>();
        private RaceObserver _selectedObserver;
        private RaceGroupInfo racerInfo;
        public DataReceiver receiver;

        public ControlForm(RaceGroupInfo info, DataReceiver receiverArgs)
        {
            InitializeComponent();
            this.racerInfo = info;
            this.Load_ListView();
            this.receiver = receiverArgs;
        }

        private void RefreshObversersListView()
        {
            observersListView.Items.Clear();
            foreach (var observer in _knownDisplays)
            {
                var item = new ListViewItem(observer.Title);
                observersListView.Items.Add(item);
            }
        }

        private void RefreshBallLists()
        {
            observedBallsListView.Items.Clear();
            // otherBallsListView.Items.Clear();

            if (_selectedObserver != null)
                observedBallsLabel.Text = @"Subjects of " + _selectedObserver.Title;
            else
                observedBallsLabel.Text = @"No obverser selected";

            //foreach (var ball in _knownBalls)
            //{
            //    var item = new ListViewItem(new[]
            //    {
            //        ball.Id.ToString(),
            //        ball.Radius.ToString(CultureInfo.InvariantCulture),
            //        ball.Speed.ToString(CultureInfo.InvariantCulture)
            //    }) {Tag = ball};
            //    if (_selectedObserver != null && ball.Subscribers.Contains(_selectedObserver))
            //        observedBallsListView.Items.Add(item);
            //    else
            //        otherBallsListView.Items.Add(item);
            //}
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void observersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (observersListView.SelectedIndices.Count == 1)
            {
                _selectedObserver = _knownDisplays[observersListView.SelectedIndices[0]];
                unscribeButton.Enabled = true;
                subscribeButton.Enabled = true;
            }
            else
            {
                _selectedObserver = null;
                unscribeButton.Enabled = true;
                subscribeButton.Enabled = true;
            }

            RefreshBallLists();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            RefreshObversersListView();
            RefreshBallLists();
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            if (_selectedObserver == null) return;

            foreach (ListViewItem item in otherBallsListView.SelectedItems)
            {
                var subject = item.Tag as Subject;
                subject?.Subscribe(_selectedObserver);
            }
            RefreshBallLists();
        }

        private void unscribeButton_Click(object sender, EventArgs e)
        {
            if (_selectedObserver == null) return;

            foreach (ListViewItem item in observedBallsListView.SelectedItems)
            {
                var subject = item.Tag as Subject;
                subject?.Unsubscribe(_selectedObserver);
            }
            RefreshBallLists();
        }

        private void createBallButton_Click(object sender, EventArgs e)
        {
            //var ball = new RaceSubject();
            //ball.Start();
            //_knownBalls.Add(ball);

            //RefreshBallLists();
        }

        private void createObserverButton_Click(object sender, EventArgs e)
        {
            var modalDialogForm = new ObserverCreationForm
            {
                Text = @"New Observer",
                ObserverTitle = $"Observer #{_knownDisplays.Count + 1}"
            };

            if (modalDialogForm.ShowDialog() != DialogResult.OK) return;

            var observer = (modalDialogForm.ObserverType == "B") ? (RaceObserver)new ListDisplay(this.receiver) : (RaceObserver)new ListDisplay(this.receiver); //  : new GraphicalDisplay();
            observer.Title = modalDialogForm.ObserverTitle;
            _knownDisplays.Add(observer);
            observer.Show();

            _selectedObserver = null;
            observersListView.SelectedIndices.Clear();
            RefreshObversersListView();
            RefreshBallLists();
        }


        private void ControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnsubscribeObserversAndDeleteBalls();
        }

        private void UnsubscribeObserversAndDeleteBalls()
        {
            //foreach (var b in _knownBalls)
            //{
            //    b.UnsubscribeAll();
            //    b.Stop();
            //}

            _knownRacers.Clear();
        }
        private void Load_ListView()
        {
            foreach (var racer in this.racerInfo.racers)
            {
                string[] row = { racer.RaceBibNumber.ToString(), $"{racer.FirstName} {racer.LastName}" };
                var listViewItem = new ListViewItem(row);
                otherBallsListView.Items.Add(listViewItem);
            }
        }
    }
}
