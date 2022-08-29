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
            redCar.Color = "Røde";
            redCar.MeterPerBatteryProcent = 20;

            //Changes the color and how long the blue car drives on 1% battery
            blueCar.Color = "Blå";
            blueCar.MeterPerBatteryProcent = 10;
            
            //User inputs how much battery procent he wants to use for the red car
            Console.WriteLine("Indtast hvor mange procent batteri du ville ha den røde bil til at køre");
            redCar.TimesToDrive = int.Parse(Console.ReadLine());

            //User inputs how much battery procent he wants to use for the blue car
            Console.WriteLine("Indtast hvor mange procent batteri du ville ha den blå bil til at køre");
            blueCar.TimesToDrive = int.Parse(Console.ReadLine());

            //console.writeline used to make some spaces between the lines
            Console.WriteLine("");
            Console.WriteLine("");

            //Using the method drive() we tell the cars to drive
            redCar.Drive();
            blueCar.Drive();




        }
    }
}