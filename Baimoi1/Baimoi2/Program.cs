using System;

class Program
{
    static void Main(string[] args)
    {
        const int MAX_ATOMS = 10;
        Atom[] atoms = new Atom[MAX_ATOMS];
        int numAtoms = 0;

        Console.WriteLine("Atomic Information");
        Console.WriteLine("==================");

        while (numAtoms < MAX_ATOMS)
        {
            atoms[numAtoms] = new Atom();
            if (!atoms[numAtoms].Accept())
            {
                continue;
            }
            numAtoms++;

            Console.Write("Enter another element? (y/n) ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choice == 'n' || choice == 'N')
            {
                break;
            }
        }

        Console.WriteLine("{0,-4} {1,-2} {2,-10} {3,-8}", "No", "Sym", "Name", "Weight");
        Console.WriteLine("------------------------------------");

        for (int i = 0; i < numAtoms; i++)
        {
            atoms[i].Display();
        }
    }
}
