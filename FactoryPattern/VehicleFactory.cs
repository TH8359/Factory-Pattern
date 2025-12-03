namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfTires)
    {
        IVehicle vehicleType = null;
        switch (numberOfTires)
        {
            case 4:
                vehicleType = new Car();
                break;
            case 2:
                vehicleType = new Motorcycle();
                break;
        }
        
        return vehicleType;
    }
}