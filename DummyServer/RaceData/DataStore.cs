using Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DummyServer
{
    public class DataStore
    {
        List<RaceGroup> groups;
        List<RacerStatus> messages;

        public DataStore()
        {
            groups = new List<RaceGroup>()
            {
                new RaceGroup() { Id=1, Label="Mens Cat 1-2", MinBibNumber=1, MaxBibNumber=99, StartTime=0, },
                new RaceGroup() { Id=2, Label="Womens Cat 1-3", MinBibNumber=100, MaxBibNumber=199, StartTime=5*60*1000, },
                new RaceGroup() { Id=3, Label="Womens Cat 4", MinBibNumber=200, MaxBibNumber=299, StartTime=10*60*1000, },
                new RaceGroup() { Id=4, Label="Mens Cat 3", MinBibNumber=300, MaxBibNumber=399, StartTime=15*60*1000, },
                new RaceGroup() { Id=5, Label="Mens Cat 4", MinBibNumber=400, MaxBibNumber=499, StartTime=20*60*1000, },
                new RaceGroup() { Id=6, Label="Mens Cat 5A", MinBibNumber=5000, MaxBibNumber=5099, StartTime=25*60*1000, },
                new RaceGroup() { Id=7, Label="Mens Cat 5B", MinBibNumber=5100, MaxBibNumber=5199, StartTime=30*60*1000, },
                new RaceGroup() { Id=8, Label="Mens Cat 5C", MinBibNumber=5200, MaxBibNumber=5299, StartTime=35*60*1000, },
            };
        }

        public void ReceiveInfo(RacerStatus status)
        {
            this.CheckRacer(status);
        }

        public void CheckRacer(RacerStatus status)
        {
            foreach (RaceGroup group in this.groups)
            {
                if (status.RacerBibNumber < group.MaxBibNumber && status.RacerBibNumber > group.MinBibNumber)
                {
                    group.AddRacer(status);
                }
            }
        }
    };
}