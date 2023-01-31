namespace RaceProject
{
    internal class Group
    {
        string Id;
        string Label;
        Racer[] Racers;
        string StartTime;
        int[] BlockNumbers;

        Group(string Id, string Label, string Description, Racer[] Racers, string StartTime, int[] BlockNumbers)
        {
            this.Id = Id;
            this.Label = Label;
            this.Racers = Racers;
            this.StartTime = StartTime;
            this.BlockNumbers = BlockNumbers;
        }
    }
}