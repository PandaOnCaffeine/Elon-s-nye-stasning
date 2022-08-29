namespace Elon_s_nye_stasning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates 2 car objekts
            Car redCar = new Car();
            Car blueCar = new Car();

            //Changes the color and how long the red car drives on 1% battery
            redCar.Color = "Red";
            redCar.MeterPerBatteryProcent = 20;

            //Changes the color and how long the blue car drives on 1% battery
            blueCar.Color = "Blue";
            blueCar.MeterPerBatteryProcent = 10;
            





        }
    }
}