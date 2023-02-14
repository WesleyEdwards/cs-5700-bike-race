using System.Collections.Generic;

namespace DummyServer
{
    public class Subject
    {
        private readonly object _myLock = new object();

        public List<RaceObserver> Subscribers { get; } = new List<RaceObserver>();

        public void Subscribe(RaceObserver observer)
        {
            lock (_myLock)
            {
                if (observer != null && !Subscribers.Contains(observer))
                    Subscribers.Add(observer);
            }
        }

        public void Unsubscribe(RaceObserver observer)
        {
            lock (_myLock)
            {
                if (!Subscribers.Contains(observer)) return;

                observer.Remove(this);
                Subscribers.Remove(observer);
            }
        }

        public void UnsubscribeAll()
        {
            lock (_myLock)
            {
                Subscribers.Clear();
            }
        }

        public void Notify()
        {
            lock (_myLock)
            {
                foreach (var observer in Subscribers)
                    observer.Update(Clone());
            }
        }

        public virtual Subject Clone()
        {
            return MemberwiseClone() as Subject;
        }
    }
}
