namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 7, 3, 9, 1, 5 };

        Array.Sort(numbers);
        Array.Reverse(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element {i}: {numbers[i]}");
        }

        int searchNumber = 9;
        int position = Array.IndexOf(numbers, searchNumber);

        Console.WriteLine($"Number {searchNumber} is at index {position}");
    }
}