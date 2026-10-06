namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize variables
        byte b = 10;
        short s = 5;
        int i = 42;
        long l = 7;
        float f = 1.5f;
        double d = 1.5;
        decimal dec = 2.5m;
        char ch = 'a';
        bool isActive = true;

        string intAsString = Convert.ToString(i);   
        double parsedDouble = double.Parse("3.14"); 

        Console.WriteLine($"byte : {b} (Type: {b.GetType().Name})");
        Console.WriteLine($"short : {s} (Type: {s.GetType().Name})");
        Console.WriteLine($"int : {i} (Type: {i.GetType().Name})");
        Console.WriteLine($"long : {l} (Type: {l.GetType().Name})");
        Console.WriteLine($"float : {f} (Type: {f.GetType().Name})");
        Console.WriteLine($"double  : {d} (Type: {d.GetType().Name})");
        Console.WriteLine($"decimal : {dec} (Type: {dec.GetType().Name})");
        Console.WriteLine($"char : {ch} (Type: {ch.GetType().Name})");
        Console.WriteLine($"bool : {isActive} (Type: {isActive.GetType().Name})");
        Console.WriteLine($"int 42 to string : {intAsString} (Type: {intAsString.GetType().Name})");
        Console.WriteLine($"string \"3.14\" to double : {parsedDouble} (Type: {parsedDouble.GetType().Name})");
    }
}