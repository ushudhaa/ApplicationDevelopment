namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2004, 1, 1);
        DateTime currentDate = DateTime.Now;

        TimeSpan difference = currentDate - birthDate;
        int ageInYears = (int)(difference.TotalDays / 365.25);

        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current date: {currentDate:yyyy-MM-dd HH:mm}");
        Console.WriteLine($"Age: {ageInYears} years");

        DateTime tenDaysLater = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {tenDaysLater:yyyy-MM-dd}");
    }
}