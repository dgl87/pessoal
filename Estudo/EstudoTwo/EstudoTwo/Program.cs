using System;

namespace EstudoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            Console.Write("Level(Junior / MidLevel / Senior): ");
            Console.Write("Base salary: ");
            Console.Write("How many contracts to this worker ? ");

3
Enter #1 contract data:
Date(DD / MM / YYYY): 20 / 08 / 2018
Value per hour: 50.00
Duration(hours): 20
Enter #2 contract data:
Date(DD/ MM / YYYY): 13 / 06 / 2018
Value per hour: 30.00
Duration(hours): 18
Enter #3 contract data:
Date(DD/ MM / YYYY): 25 / 08 / 2018
Value per hour: 80.00
Duration(hours): 10
Enter month and year to calculate income(MM / YYYY): 08 / 2018
Name: Alex
Department: Design
Income for 08 / 2018: 3000.00
        }
    }
}
