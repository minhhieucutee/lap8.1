using System;

class Atom
{
    private int atomicNumber; // integer holding the atomic number
    private string symbol; // string holding the atomic symbol
    private string name; // string holding the full name of the atom
    private double weight; // floating-point value holding the atomic weight

    public bool Accept()
    {
        Console.Write("Enter atomic number: ");
        if (!int.TryParse(Console.ReadLine(), out atomicNumber))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return false;
        }

        Console.Write("Enter symbol: ");
        symbol = Console.ReadLine();

        Console.Write("Enter full name: ");
        name = Console.ReadLine();

        Console.Write("Enter atomic weight: ");
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid input. Please enter a floating-point number.");
            return false;
        }

        return true;
    }

    public void Display()
    {
        Console.WriteLine("{0,-4} {1,-2} {2,-10} {3,-8}", atomicNumber, symbol, name, weight);
    }
}
