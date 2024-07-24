using System;

namespace InterfaceExercise;

public class Car: ICompany, IVehicle
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public bool HasTrunk { get; set; }
    public int NumberOfDoors { get; set; }
    public string Logo { get; set; } 
    public string CarSound { get; set; }
    public int NumberOfWheels { get; set; }
    public string CarHonk { get; set; }
    public int CarWheel { get; set; }
    public int NumberOfMirrors { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Car Details: ");
        Console.WriteLine($"Logo: {Logo}\nCar sound: {CarSound}\nHas trunk: {HasTrunk}\nNumber of doors: {NumberOfDoors}\nNumber of wheels: {NumberOfWheels}\nCar honk: {CarHonk}\nCar wheel: {CarWheel}\nNumber of mirrors {NumberOfMirrors}");
    }
}