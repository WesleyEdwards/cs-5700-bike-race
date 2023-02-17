namespace DummyServer
{
    internal class Form1Observer
    {
        RaceGroupInfo raceGroups { get; set; }
        DataReceiver receiver;
        public Form1Observer(Form1 form1, DataReceiver receiver)
        {
            this.receiver = receiver;
            form1.SubmitRacerPaths += GetInfo;
        }
        public void GetInfo(string[] list)
        {
            RaceGroupInfo newRaceGroups = new RaceGroupInfo(list[0], list[1]);
            ControlForm ctrlForm = new ControlForm(newRaceGroups, receiver);
            ctrlForm.Show();
        }
    }
}
