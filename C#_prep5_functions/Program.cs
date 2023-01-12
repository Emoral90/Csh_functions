/****************************************************************
*
*   Practice creating and calling different types of functions
*
*****************************************************************/

// First 3 functions will be static
// Or able to be called without creating a new instance of an object



class myClass{

    static void Main(){
        Console.WriteLine();
        Console.WriteLine("===================================");

        myClass.WelcomeMessage();
        myClass.PromptUsername();
        

        Console.WriteLine("===================================");
        Console.WriteLine();
        
    }

    static void WelcomeMessage(){
    // Void means there will be no parameters or a return type
    Console.WriteLine("Welcome to My New Little Repository!");
    }

    static void PromptUsername(){
        Console.WriteLine("Enter your username");
        string userName = Console.ReadLine();
    }
}