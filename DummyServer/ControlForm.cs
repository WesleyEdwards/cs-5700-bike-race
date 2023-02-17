using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DummyServer
{
    public partial class ControlForm : Form
    {
        private readonly List<Racer> _knownRacers = new List<Racer>();
        private readonly List<RaceObserver> _knownDisplays = new List<RaceObserver>();
        private RaceObserver _selectedObserver;
        private RaceGroupInfo racerInfo;
        public DataReceiver receiver;

        public ControlForm(RaceGroupInfo info, DataReceiver receiverArgs)
        {
            InitializeComponent();
            this.racerInfo = info;
            this.receiver = receiverArgs;
            this._knownRacers = info.racers;
        }

        private void RefreshObversersListView()
        {
            observersListView.Items.Clear();
            foreach (var observer in _knownDisplays)
                observersListView.Items.Add(new ListViewItem(observer.Title));
        }

        private void RefreshBallLists()
        {
            // observedBallsListView.Items.Clear();
            otherBallsListView.Items.Clear();
            // Load_ListView();

            if (_selectedObserver != null)
                observedBallsLabel.Text = @"Subjects of " + _selectedObserver.Title;
            else
                observedBallsLabel.Text = @"No obverser selected";

            foreach (var ball in _knownRacers)
            {
                string[] row = { ball.RaceBibNumber.ToString(), $"{ball.FirstName} {ball.LastName}" };
                var listViewItem = new ListViewItem(row) { Tag = ball };
                if (_selectedObserver != null && ball.Subscribers.Contains(_selectedObserver))
                {
                    observedBallsListView.Items.Add(listViewItem);
                }
                else
                    otherBallsListView.Items.Add(listViewItem);
            }
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
                Console.WriteLine(item.Tag + item.Text);
                var subject = item.Tag as Subject;
                // observedBallsListView.Items.Add(item);
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
                subject?.Subscribe(_selectedObserver);
            }
            RefreshBallLists();
        }

        private void createBallButton_Click(object sender, EventArgs e)
        {

        }

        private void createObserverButton_Click(object sender, EventArgs e)
        {
            var modalDialogForm = new ObserverCreationForm
            {
                Text = @"New Observer",
                ObserverTitle = $"Observer #{_knownDisplays.Count + 1}"
            };

            if (modalDialogForm.ShowDialog() != DialogResult.OK) return;

            var observer = (modalDialogForm.ObserverType == "C") ? (RaceObserver)new CheaterDisplay(this.receiver, this.racerInfo) : (RaceObserver)new BigScreen(this.receiver, this.racerInfo); //  : new GraphicalDisplay();
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
            foreach (var b in _knownRacers)
            {
                // b.UnsubscribeAll();
                // b.Stop();
            }

            _knownRacers.Clear();
        }
    }
}
