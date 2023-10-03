// create arrays of int,double and char
using GenericTest;

int[] intArray = { 1, 2, 3, 4, 5, 6, };
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

Console.WriteLine("Array intArray contains: ");
DisplayArray(intArray);
Console.WriteLine("Array doubleArray contains: ");
DisplayArray(doubleArray);
Console.WriteLine("Array charArray contains: ");
DisplayArray(charArray);

// output array of all types
void DisplayArray<T>(T[] inputArray)
{
    foreach(var item in inputArray)
    {
        Console.WriteLine($"{item}");
    }
    Console.WriteLine();
}

