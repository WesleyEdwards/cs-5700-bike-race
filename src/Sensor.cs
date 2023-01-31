namespace RaceProject
{
    internal class Sensor
    {
        string Id;
        double Location;
        Sensor(string Id, double Location)
        {
            this.Id = Id;
            this.Location = Location;
        }

        public void SendSensorInfo()
        {
            /* 
            whenever a racer passes a sensor
            send to server:
                - racer’s bib number
                - time
            **/


            System.Console.WriteLine("SEND SENSOR INFO");
        }
    }
}