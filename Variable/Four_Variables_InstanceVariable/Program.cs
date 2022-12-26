// this variables is declared outside method /constructor but in the class
using System;
class InstanceVariable
{ 
    //Declaration of instance variable inside class
    int englishMarks;
    int mathMarks;
    int geographyMarks;
    int historyMarks;

    //main method
    public static void Main(string[] args)
    {
        //creation of object of class 
        InstanceVariable instance = new InstanceVariable();
        // fetching value to variables
        instance.englishMarks = 100;
        instance.mathMarks = 100;
        instance.geographyMarks = 100;
        instance.historyMarks = 100;
         // print the value of fetched variables
        Console.WriteLine(instance.englishMarks);
        Console.WriteLine(instance.mathMarks);
        Console.WriteLine(instance.geographyMarks);
        Console.WriteLine(instance.historyMarks);
        Console.ReadLine();


    }


}