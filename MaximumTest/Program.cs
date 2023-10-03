Console.WriteLine($"Maximum of 3, 4 and 5 is {Maximum(3, 4, 5)}\n");
Console.WriteLine($"Maximum of 6.6, 8.8 and 7.7 is {Maximum(6.6, 7.7, 8.8)}\n");
Console.WriteLine($"Maximum of pear, apple and orange is {Maximum("pear", "apple", "orange")}\n");

// generic function determins the
// largest of the Icomparable<T> objects

T Maximum<T>(T v1, T v2, T v3) where T : IComparable<T>
{
    var max = v1; // assume v1 is the Maximum

    // compare the max with v2
    // max= Mximum
    if(v2.CompareTo(max) > 0)
    {
        max= v2; // rigth now the v2 is max
    }

    // compare v3 with max
    if(v3.CompareTo(max) > 0)
    {
        max= v3; // rigth now the v3 is max
    }

    return max; // return the max object
}