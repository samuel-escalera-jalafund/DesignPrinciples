namespace Kiss;

public class KissExample
{
    static void Main()
    {
        List<int> numbers = new List<int>{3, -1, 2, -4, 6};
        int reulst = ProcessNumbers(numbers);
        Console.WriteLine(reulst);
    }
    static int ProcessNumbers(List<int> numbers)
    {
        List<int> positiveNumebrs = GetPositiveNumbers(numbers);
        SortNumbers(positiveNumebrs);
        return CalculateSum(positiveNumebrs);
    }

    static List<int> GetPositiveNumbers(List<int> numbers)
    {
        List<int> positiveNumbers = new List<int>();
        foreach( int number in numbers)
        {
            if (number >= 0)
            {
                positiveNumbers.Add(number);
            }
        }

        return positiveNumbers;
    }

    static void SortNumbers( List<int> numbers) 
    {
        numbers.Sort();
    }

    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}
