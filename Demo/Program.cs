namespace Demo
{
    internal class Program
    {
        #region Methods
        //public static void PrintShape(int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("$_");
        //    }
        //}

        //public static void PrintShape(string shape, int? count = null)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine($"{shape}");
        //    }
        //}

        //public static void Swap(ref int A , ref int B)
        //{
        //    Console.WriteLine("=============== Before Swapping [inside] ==========");
        //    Console.WriteLine($"A: {A}, B: {B}");
        //    int temp = A;
        //    A = B;
        //    B = temp;
        //    Console.WriteLine("=============== After Swapping [inside] ==========");
        //    Console.WriteLine($"A: {A}, B: {B}");
        //}

        //public static int SumArray(ref int[] array)
        //{
        //    Console.WriteLine($"Before Hashcode [inside] => {array.GetHashCode()}");
        //    //array[0] = 100; 
        //    array = [50, 60, 70, 80];
        //    int sum = 0;
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }
        //    Console.WriteLine($"After Hashcode [inside] => {array.GetHashCode()}");
        //    Console.WriteLine($"result [inside] =>  {sum}");
        //    Console.WriteLine($"Item [Inside] =>  {array[0]}");
        //    return sum;

        //}

        //public static void SumMulti(int X, int Y, out int sum, out int multi)
        //{
        //    sum = X + Y;
        //    multi = X * Y;
        //}

        //public static int SumArray(  int X ,params int[] array)
        //{
 
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }
        //    return sum;
        //}

            #endregion
         static void Main(string[] args)
        {

            #region Functions
            //PrintShape(shape: "%", count: 30);
            //PrintShape("$");

            //int X = 10, Y = 20;
            //Console.WriteLine("=============== Before Swapping [outside] ==========");
            //Console.WriteLine($"X: {X}, Y: {Y}");
            //Swap(ref X, ref Y);
            //Console.WriteLine("=============== After Swapping [outside]  ==========");
            //Console.WriteLine($"X: {X}, Y: {Y}");

            //int[] numbers = [5, 7, 8];
            //Console.WriteLine($"Before Hashcode [outside] => {numbers.GetHashCode()}");
            //int result = SumArray(ref numbers);
            //Console.WriteLine($"After Hashcode [outside] => {numbers.GetHashCode()}");
            //Console.WriteLine($"result [outside] =>  {result}");
            //Console.WriteLine($"Item [outside] =>  {numbers[0]}");

            //int X = 10, Y = 20, sum, multi;
            //SumMulti(X, Y, out _, out multi);
            //Console.WriteLine($"sum: {sum}, multi: {multi}");

            //int[] numbers = [10,50,60,70,80,30];
            //int result = SumArray(10,50,60,70,80,30);
            //Console.WriteLine($"Sum of array elements: {result}");


            #endregion

            #region Boxing & Unboxing
            //int X = 10;
            //object obj = X; // Boxing  - parent = child - safe casting

            //obj = new Person();
            //X = (int)obj; // unboxing - child = parent - unsafe casting
            //Console.WriteLine($"X: {X}");
            #endregion

            #region Nullable Value Types
            //int? X = 10;
            //int? Z = 10;
            //int W = 0;

            //int Y;
            //if(X.HasValue)
            //    Y = (int)X; 
            //else
            //    Y = 0; 

            //Y = X.HasValue ? X.Value : 0;
            //Y = X ?? Z ?? W;
            //Console.WriteLine($"Y: {Y}");   


            //Person person = new Person();
            //Console.WriteLine(person.Age);

            #endregion

            #region Nullable Reference Types
            //string? name = null; 

            //int[] numbers = default; // put null with reference type, 0 with numeric type
            //int length = numbers?.Length ?? 0; 
            //for (int i =0; i < numbers?.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

        }
    }
}
