using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Student Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Marks to check grades");
                int marks;
                marks = Convert.ToInt32(Console.ReadLine());
                if (marks <= 0 || marks > 100)
                {
                    Console.WriteLine("Enter valid marks Greater then 0 and Less then equal to 100 for Gardes Calculation");
                }
                else
                {
                    switch (marks)
                    {
                        case >= 90:
                            Console.WriteLine(name + " Got 'A' Grade");
                            Console.WriteLine("Excelnet!");
                            break;
                        case >= 80:
                            Console.WriteLine(name + " Got 'B' Grade");
                            break;
                        case >= 70:
                            Console.WriteLine(name + " Got 'C' Grade");
                            break;
                        case >= 60:
                            Console.WriteLine(name + " Got 'D' Grade");
                            break;
                        case >= 0:
                            Console.WriteLine(name + " Got 'F' Grade");
                            Console.WriteLine("Better Luck Next time!");
                            break;

                    }
                }
            }
        }
    }
}