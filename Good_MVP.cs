bool Done = false;
string userInput;
do
{
    Console.WriteLine("Welcome to the calculator. Please select an operation");
    Console.WriteLine("A: Addition");
    Console.WriteLine("B: Subtraction");
    Console.WriteLine("C: Multiplication");
    Console.WriteLine("D: Division");
    Console.WriteLine("E: Done");

    userInput = Console.ReadLine();
    userInput = userInput.ToLower();

    if ( userInput == "done" || userInput == "e" )
    {
        Done = true;
    }
    if (userInput == "a" || userInput == "addition" )
    {    
        Console.WriteLine("Please enter the first number you'd like to add");
        float x = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number you'd like to add");
        float y = Single.Parse(Console.ReadLine());
        Adding(x,y);
    }
    else if (userInput == "b" || userInput == "subtraction")
    {
        Console.WriteLine("Please enter the first number");
        float x = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number you'd like to subtract from the first");
        float y = Single.Parse(Console.ReadLine());
        Subtraction(x,y);
    }
    else if (userInput == "c" || userInput == "multiplication")
    {
        Console.WriteLine("Please enter the first number to be multiplied");
        float x = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number you'd like to multiply");
        float y = Single.Parse(Console.ReadLine());
        Multiply(x,y);
    }
    else if (userInput == "d" || userInput == "division")
    {
        Console.WriteLine("Please enter the first number");
        float x = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number you'd like to divide the first by");
        float y = Single.Parse(Console.ReadLine());
        Division(x,y);
    }
    else 
    {
        Console.WriteLine("Please enter a valid command");
    }
} while (Done != true);

static float Adding (float x, float y)
{
    float z = x + y;
    Console.WriteLine($"{x} + {y} = {z}");
    return z;
}

static float Subtraction (float x, float y)
{
    float z = x - y;
    Console.WriteLine($"{x} - {y} = {z}");
    return z;
}

static float Multiply (float x, float y)
{
    float z = x * y;
    Console.WriteLine($"{x} * {y} = {z}");
    return z;
}

static float Division (float x, float y)
{
    float z = x/y;
    Console.WriteLine($"{x} / {y} = {z}");
    return z;
}