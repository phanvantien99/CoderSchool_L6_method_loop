namespace Method_and_Loops_q4;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 60, 70, 80 };
        int number = IsGreaterThan50(numbers);
    }

    // part 1
    public static int IsGreaterThan50(int[] numbers)
    {

        int result = Array.Find(numbers, (current) => current > 50);

        if (result != 0)
        {
            Console.WriteLine("The first element greater than 50 is: " + result);
        }
        else
        {
            Console.WriteLine("No element greater than 50 found.");
        }
        return result;
    }

    // part 2
    public static int IsGreaterThan10(int[] numbers)
    {

        int result = Array.Find(numbers, (current) => current > 10);

        if (result != 0)
        {
            Console.WriteLine("The first element greater than 10 is: " + result);
        }
        else
        {
            Console.WriteLine("No element greater than 10 found.");
        }
        return result;
    }

    // part 3
    public static int IsNegativeNumber(int[] numbers)
    {

        int result = Array.Find(numbers, (current) => current < 0);

        if (result != 0)
        {
            Console.WriteLine("The first element negative is: " + result);
        }
        else
        {
            Console.WriteLine("No element negative found.");
        }
        return result;
    }
}
