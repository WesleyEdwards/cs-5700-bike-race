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

        #region Public properties
        public int Id { get; }
        // Convenient methods for working with the state and simulation
        public int DelayBetweenMovements { get; set; }

        // Supporting methods for measuring performance
        public int StateChanges { get; set; }
        #endregion

        #region Public Methods
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

        #endregion

        #region Private Methods
        private void Move(object sender)
        {
            Notify();
        }

        private static double DegreeToRadian(double degrees)
        {
            return Math.PI * degrees / 180.0;
        }

        private static double ReboundOnXAxis(double degrees)
        {
            var result = degrees % 360;
            if (result > 0 && result <= 180) result = 180 - result;
            else result = -180 - result;
            return result;
        }

        private static double ReboundOnYAxis(double degrees)
        {
            return -(degrees % 360);
        }

        private static int ChooseRandomInteger(int min, int exclusiveMax)
        {
            return Randomizer.Next(min, exclusiveMax);
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
        #endregion
    }
}
