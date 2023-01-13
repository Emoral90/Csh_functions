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

        // Static functions are called locally with just the class name and the method
        myClass.WelcomeMessage();
        string userName = myClass.PromptUsername();
        int userNum = myClass.PromptUserNum();

        // Instantiated a new class object and saved it to the variable MC
        myClass MC = new myClass();
        int squaredNum = MC.SquareNum(userNum);
        MC.DisplayRes(squaredNum, userName);
        

        Console.WriteLine("===================================");
        Console.WriteLine();
        
    }
    // First 3 functions will be static
    // Or able to be called without creating a new instance of an object
    static void WelcomeMessage(){
    Console.WriteLine("Welcome to My New Little Repository!");
    }

    static string PromptUsername(){
        Console.WriteLine("Enter your username");
        string userName = Console.ReadLine();
        // Console.WriteLine($"Hello {userName}");
        return userName;
    }

    static int PromptUserNum(){
        Console.WriteLine("Enter your favorite number");
        int UserNum = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Favorite number; {UserNum}");
        return UserNum;
    }

    // Last 2 functions will not be static
    // Or will have to be called by creating a new instance of the myClass object
    int SquareNum(int num){
        int square = num * num;
        return square;
    }

    void DisplayRes(int num, string name){
        // string num_str = num.ToString();
        Console.WriteLine($"{name}, your favorite number squared is {num}");
        // return result;
    }
}