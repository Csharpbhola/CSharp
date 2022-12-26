// C# program to show the use
// of readonly variables
// without initializing it
using System;

//Variables declared with the use of ReadOnly Variable ,is called so.
class Program
{

    // instance variable
    int a = 80;

    // static variable
    static int b = 40;

    // Constant variables
    const float max = 50;

    // readonly variables
    readonly int k;

    // Main Method
    public static void Main()
    {

        // Creating object
        Program obj = new Program();

        Console.WriteLine("The value of a is = " + obj.a);
        Console.WriteLine("The value of b is = " + Program.b);
        Console.WriteLine("The value of max is = " + Program.max);
        Console.WriteLine("The value of k is = " + obj.k);
    }
}
