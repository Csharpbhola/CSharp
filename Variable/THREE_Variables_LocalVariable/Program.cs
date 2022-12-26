using System;
class LocalVariable
{
    //variables declared within the code block or method or constructor 
    // remeber while you are using local variable ,simple method (no use of static )
    //use static in the main method // create the object of class //call the l
    public  void DisplayLocalVar()
    {
        string userName = "Bhola";
        int userNameAlphabet = 5;
        Console.WriteLine("UserName {0} has {1} albhabet in his name:",userName,userNameAlphabet);
    }
     public static void Main(string[]Args)
     {
        LocalVariable obj= new LocalVariable   ();
        obj.DisplayLocalVar();
       
     }


}