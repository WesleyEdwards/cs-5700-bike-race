using System;
using System.Threading;

namespace DummyServer
{
    public class RaceSubject : Subject
    {
        #region Private data members
        private static readonly Random Randomizer = new Random();
        private static int _nextBallId = 1;
        private Timer _timer;
        #endregion

        public RaceSubject() { Id = GetNextId(); }

        public int Id { get; }
        // Convenient methods for working with the state and simulation
        public int DelayBetweenMovements { get; set; }

        // Supporting methods for measuring performance
        public int StateChanges { get; set; }
        
        public void Start()
        {
            SetupDefaults();
            _timer = new Timer(Move, null, DelayBetweenMovements, DelayBetweenMovements);
        }

        public void Stop()
        {
            SetupDefaults();
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private void Move(object sender)
        {
            Notify();
        }

        private void SetupDefaults()
        { }

        private static int GetNextId()
        {
            var nextId = _nextBallId;
            if (_nextBallId == Int32.MaxValue)
                _nextBallId = 1;
            else
                _nextBallId++;
            return nextId;
        }
    }
}
