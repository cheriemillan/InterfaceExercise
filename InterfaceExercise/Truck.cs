using System;

namespace InterfaceExercise;

public class Truck: IVehicle, ICompany
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public bool HeavyCar { get; set; }
    public bool CarHauler { get; set; }
    public int NumberOfWheels { get; set; }
    public string CarHonk { get; set; }
    public int CarWheel { get; set; }
    public int NumberOfMirrors { get; set; }

    public string Logo { get; set; }
    public string CarSound { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Truck Details: ");
        Console.WriteLine($"Logo: {Logo}\nCar sound: {CarSound}\nHeavy car: {HeavyCar}\nCar hauler: {CarHauler}\nNumber of wheels: {NumberOfWheels}\nCar honk: {CarHonk}\nCar wheel: {CarWheel}\nNumber of mirrors {NumberOfMirrors}");
    }
}