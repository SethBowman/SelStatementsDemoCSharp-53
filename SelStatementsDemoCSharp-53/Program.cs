namespace SelStatementsDemoCSharp_53;

class Program
{
    static void Main(string[] args)
    {
        //if else statement

        bool condition = false;

        if (condition == true)
        {
            Console.WriteLine("If scope");
        }
        else
        {
            Console.WriteLine("Else scope");
        }

        Console.WriteLine("Continue on..");

        int x = 900;
        int y = 20;

        if (x == y)
        {
            Console.WriteLine("If scope");
        }
        else if (x < y)
        {
            Console.WriteLine("If else scope");
        }
        else
        {
            Console.WriteLine("Else scope");
        }
        
        Console.WriteLine("Continue on..");
        
        //ternary operator (inline if statement)

        int a = -1;
        
        string message = a > 0 ? "Positive" : "Negative";

        Console.WriteLine(message);
        
        //switch case statement

        string today = "Funday";

        switch (today.ToLower())
        {
            case "sunday":
            case "sun":    
                Console.WriteLine("It is Sunday today!");
                break;
            case "monday":
                Console.WriteLine("It is Monday today!");
                break;
            case "tuesday":
                Console.WriteLine("It is Tuesday today!");
                break;
            case "wednesday":
                Console.WriteLine("It is Wednesday today!");
                break;
            case "thursday":
                Console.WriteLine("It is Thursday today!");
                break;
            case "friday":
                Console.WriteLine("It is Friday today!");
                break;
            case "saturday":
                Console.WriteLine("It is Saturday today!");
                break;
            default:
                Console.WriteLine("That was not a valid day of the week.");
                break;
        }
    }
}