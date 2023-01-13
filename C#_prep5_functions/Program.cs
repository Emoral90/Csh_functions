/****************************************************************
*
*   Practice creating and calling different types of functions
*
*****************************************************************/




class myClass{

        // Void means there will be no parameters or a return type
        static void Main(){
        Console.WriteLine();
        Console.WriteLine("===================================");

        myClass.WelcomeMessage();
        myClass.PromptUsername();
        

        Console.WriteLine("===================================");
        Console.WriteLine();
        
    }
    // First 3 functions will be static
    // Or able to be called without creating a new instance of an object
    static void WelcomeMessage(){
    Console.WriteLine("Welcome to My New Little Repository!");
    }

    static void PromptUsername(){
        Console.WriteLine("Enter your username");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}");
    }

    static void PromptUserNum(){
        Console.WriteLine("Enter your ID number");
        string UserNum = Console.ReadLine();
        Console.WriteLine($"ID number; {UserNum}");
    }

    // Last 2 functions will not be static
    // Or will have to be called by creating a new instance of the myClass object
    int SquareNum(){
        
    }

    string DisplayRes(){

    }
}