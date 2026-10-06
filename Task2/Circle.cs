namespace Task2;

class Circle
{
    /*public const double PI = 3.14;

    static void Main(string[] args)
    {
        //Circle.PI = 3.16; Since, Const value cannot be changed after initialization, this code will not run, it will provide error
        
        Console.WriteLine(Circle.PI);
    }*/
    static void Main(string[] args)
    {
        const double PI = 3.14;
        double radius = 4;
        double perimeter = 2*PI*radius;
        double area = PI*radius*radius;
        Console.WriteLine($"The area is {area}");
        Console.WriteLine($"The perimeter is {perimeter}");
    }
}
