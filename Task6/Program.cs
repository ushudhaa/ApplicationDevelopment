namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

        fruits.Add("Orange");
        fruits.Remove("Apple");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Banana" }
        };

        fruitDict.Add(4, "Orange");

        foreach (KeyValuePair<int, string> pair in fruitDict)
        {
            Console.WriteLine($"ID: {pair.Key}, Fruit: {pair.Value}");
        }
    }
}