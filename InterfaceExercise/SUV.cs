using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public bool CarSpace { get; set; }
    public int MultipleAirBags { get; set; }

    public int NumberOfWheels { get; set; }
    public string CarHonk { get; set; }
    public int CarWheel { get; set; }
    public int NumberOfMirrors { get; set; }

    public string Logo { get; set; }
    public string CarSound { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine();
        Console.WriteLine("SUV Details:");
        Console.WriteLine($"Logo: {Logo}\nCar sound: {CarSound}\nCar space: {CarSpace}\nAir bags: {MultipleAirBags}\nNumber of wheels: {NumberOfWheels}\nCar honk: {CarHonk}\nCar wheel: {CarWheel}\nNumber of mirrors: {NumberOfMirrors}");
    }
}