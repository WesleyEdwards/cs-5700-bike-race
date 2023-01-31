namespace RaceProject
{
    internal class Racer
    {
        string Id;
        string Name;
        string DateOfBirth;
        string GroupId;
        string? EndTime;
        Racer(string Id, string Name, string DateOfBirth, string GroupId, string EndTime)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.GroupId = GroupId;
            this.EndTime = EndTime;
        }
    }
}