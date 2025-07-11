namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// calling Question 3
            //Console.Write("Enter num1 : ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter num2 : ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Enter num3 : ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("Enter num4 : ");
            //int d = int.Parse(Console.ReadLine());
            //Sum(a, b, c, d, out int summation, out int subtract);
            //Console.WriteLine($"Sum: {summation}, Subtract: {subtract}");

            /// calling Question 4
            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result = AddDigitsOfNumber(number);
            //Console.WriteLine($"sum of digits of number: {result}");

            /// calling Question 5
            //int number = 29;
            //Console.WriteLine($"Is {number} prime? {isPrime(number)}");

            /// calling Question 6
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int min = 0, max = 0;
            //MinMax(numbers, ref min, ref max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}");

            /// calling Question 7
            //Console.Write("Enter a number to calculate its factorial: ");
            //int number = int.Parse(Console.ReadLine());
            //int factorial = Factorial(number);
            //Console.WriteLine($"Factorial of {number} is: {factorial}");

            /// calling Question 8
            //Console.Write("Enter string: ");
            //string str = Console.ReadLine();
            //Console.WriteLine(str);
            //Console.Write("Enter index of char to change: ");
            //int index = int.Parse(Console.ReadLine());
            //Console.Write("Enter new char: ");
            //char charToChange = char.Parse(Console.ReadLine()); 
            //ChangeChar( ref str, index, charToChange);
            //Console.WriteLine($"string after modifying : {str}");


        }
        #region Question 1
        // passing value type by value => the function takes only a copy of the paramter
        // variable and do not affect the original variable
        static int PassByValue(int number)
        {
            int sum = number + 10;
            return sum;
        }
        // passing value type by reference => the function takes a reference to the original variable
        // and can modify the original variable
        static void PassByReference(ref int number)
        {
            number += 10; // modifies the original variable
        }
        #endregion

        #region Question 2
        // passing reference type by value => the function takes a copy of the reference
        // to the object, but not the object itself, so changes to the object will affect
        // the original object, but reassigning the reference will not affect the original reference
        static void PassByValueReferenceType(string[] names)
        {
            names[0] = "amr"; // modifies the original object
            names = new string[] { "amr", "ayman" }; // this would not affect the original reference
        }
        // passing reference type by reference => the function takes a reference to the original reference
        // and can modify the original reference, so changes to the reference will affect
        // the original reference
        static void PassByReferenceReferenceType(ref string[] names)
        {
            names[0] = "amr"; // modifies the original object
            names = new string[] { "amr", "ayman" }; // this will affect the original reference

        }
        #endregion

        #region Question 3
        static void Sum(int a, int b,int c , int d, out int summation , out int subtract)
        {
            summation = a + b + c + d;
            subtract = a - b - c - d;

        }
        #endregion

        #region Question 4
        static int AddDigitsOfNumber(int number)
        {
            int sum = 0;
            int tempNum = number;
            while (tempNum > 0)
            {
                sum += tempNum % 10; 
                tempNum /= 10; 
            }
            return sum;
        }

        #endregion

        #region Question 5
        static bool isPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Question 6
        static void MinMax(int[] numbers, ref int min, ref int max)
        {

            min = numbers[0];
            max = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
        }
        #endregion

        #region Question 7
        static int Factorial(int number)
        {
            int factorial = number;
            if (number == 0 || number == 1)
            {
                factorial =  1;
            }
            for (int i = number; i >= 2; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        #endregion

        #region Question 8
        static void ChangeChar(ref string str , int index , char repChar)
        {
            char[] chars = str.ToCharArray();
            chars[index] = repChar;
            str = new string(chars);
        }
        #endregion
    }
}
