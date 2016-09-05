namespace MarsRover.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceController(5, 5);
            
            service.CreateNewRover("1", "2", "N");
            service.ExecuteCommand(0, "LMLMLMLMM");

            System.Console.WriteLine(service.GetRover(0).ToString());

            service.CreateNewRover("3", "3", "E");
            service.ExecuteCommand(1, "MMRMMRMRRM");

            System.Console.WriteLine(service.GetRover(1).ToString());

        }
    }
}
