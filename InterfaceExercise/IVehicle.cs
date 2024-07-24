namespace InterfaceExercise;

public interface IVehicle
{
    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
    public int NumberOfWheels { get; set; }
    public string CarHonk { get; set; }
    public int CarWheel { get; set; }
    public int NumberOfMirrors { get; set; }

    public void DisplayDetails();

}