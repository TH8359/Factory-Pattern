namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Will the vehicle have 2 wheels or 4?");

            int answer = int.Parse(Console.ReadLine());
            
            IVehicle newVehicle = VehicleFactory.GetVehicle(answer);
            newVehicle.Drive();
        }
    }
}
