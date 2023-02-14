using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DummyServer
{
    public class RaceObserver : Form
    {
        private readonly Dictionary<int, RaceSubject> _ballsBeingObserved = new Dictionary<int, RaceSubject>();

        protected bool RepaintNeeded;
        private readonly Timer _refreshTester = new Timer();
        private readonly object _myLock = new object();

        public int RefreshFrequency { get; set; }
        public string Title { get; set; }

        public virtual void Update(Subject subject)
        {
            var ball = subject as RaceSubject;
            if (ball == null) return;

            lock (_myLock)
            {
                if (!_ballsBeingObserved.ContainsKey(ball.Id))
                    _ballsBeingObserved.Add(ball.Id, ball);
                else
                    _ballsBeingObserved[ball.Id] = ball;
            }

            RepaintNeeded = true;
        }

        public virtual void Remove(Subject subject)
        {
            var ball = subject as RaceSubject;
            if (ball == null) return;

            lock (_myLock)
            {
                if (_ballsBeingObserved.ContainsKey(ball.Id))
                    _ballsBeingObserved.Remove(ball.Id);
            }
            RepaintNeeded = true;
        }

        protected void StartRefreshTimer()
        {
            if (RefreshFrequency <= 0)
                RefreshFrequency = 50;

            _refreshTester.Interval = RefreshFrequency;
            _refreshTester.Tick += refreshTimer_Tick;
            _refreshTester.Start();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (!RepaintNeeded) return;

            lock (_myLock)
            {
                RefreshDisplay();
                RepaintNeeded = false;
            }
        }

        protected virtual void RefreshDisplay() { }

        protected void UnregisterFromAllSubjects()
        {
            var iterator = _ballsBeingObserved.GetEnumerator();
            while (iterator.MoveNext())
                iterator.Current.Value.Unsubscribe(this);
        }

        protected List<RaceSubject> BallsBeingObserved => _ballsBeingObserved.Values.ToList();

        protected bool IsBallBeingObserved(int id)
        {
            return _ballsBeingObserved.ContainsKey(id);
        }

        public void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RaceObserver
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "RaceObserver";
            this.Load += new System.EventHandler(this.RaceObserver_Load);
            this.ResumeLayout(false);

        }

        private void RaceObserver_Load(object sender, EventArgs e)
        {

        }
    }
}
