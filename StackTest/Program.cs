// crate arrays of doubles and ints
double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
double[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

StackTest.Stack<int> doublestack = new(5); // stack of doubles
StackTest.Stack<int> intstack = new(10); // stack of ints

TestPushDouble(); // push double onto doubleStack

// test Push method with doubleStack

void TestPushDouble()
{
    Console.WriteLine("\nPushing elements onto doubleStack");

    foreach(var element in doubleElements)
    {
        Console.WriteLine($"{element: F1}");
        doublestack.Push(element);
    }
}