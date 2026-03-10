namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfTires)
    {
        switch (numberOfTires)
        {
            case 4:
                return new Car();
            case 2:
                return new Motorcycle();
            default:
                return null;
        }
    }
}