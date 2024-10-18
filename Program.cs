
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        //tests
        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(0);

        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);

        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);

        IsDivibleBy5(5);
        IsDivibleBy5(6);

        CheckOddOrEven(2);
        CheckOddOrEven(3);

        CheckVowelOrConsonent('e');
        CheckVowelOrConsonent('E');
        CheckVowelOrConsonent('s');
        CheckVowelOrConsonent('S');

        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Your number is negative");
        }
        else if (number > 0)
        {
            Console.WriteLine("Your number is positive");
        }
        else
        {
            Console.WriteLine("Your number is zero");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine($"The minimum value is {num1}");
        }
        else if (num2 < num1 && num2 < num3)
        {
            Console.WriteLine($"The minimum value is {num2}");
        }
        else if (num3 < num1 && num3 < num2)
        {
            Console.WriteLine($"The minimum value is {num3}");
        }
        else if (num1 == num2 || num2 == num3 || num3 == num1)
        {
            Console.WriteLine("Passed in two of the same integers");
        }
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"The maximum value is {num1}");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine($"The maximum value is {num2}");
        }
        else if (num3 > num1 && num3 > num2)
        {
            Console.WriteLine($"The maximum value is {num3}");
        }
        else if (num1 == num2 || num2 == num3 || num3 == num1)
        {
            Console.WriteLine("Passed in two of the same integers");
        }
    }

    public static void IsDivibleBy5(int number)
    {
        if (number % 5 == 0)
        {
            Console.WriteLine($"{number} is divisible by 5");
        }
        else
        {
            Console.WriteLine($"{number} is not divisible by 5");
        }
    }

    public static void CheckOddOrEven(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number");
        }
    }

    public static void CheckVowelOrConsonent(char letter)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        if (vowels.Contains(char.Parse(char.ToString(letter).ToLower())))
        {
            Console.WriteLine($"{letter} is a vowel");
        }
        else
        {
            Console.WriteLine($"{letter} is a consonant");
        }
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        switch (dayCode)
        {
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid Code");
                break;
        }
    }

}
