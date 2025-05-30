using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Profiling is starting. Press any key to continue..");
        Console.ReadKey();

        // StringTest(); // Uncomment this line to run the string test
        StringBuilderTest(); // Uncomment this line to run the StringBuilder test

        Console.WriteLine("Profiling completed. You can now analyze memory usage.");
        Console.ReadKey();
    }

    static void StringTest()
    {
        string str = "milk";
        str = "hot water";
        for (int i = 0; i < 10000; i++)
        {
            str += "coffee";
        }
    }

    static void StringBuilderTest()
    {
        StringBuilder sb = new StringBuilder("milk");
        sb = new StringBuilder("hot water");
        for (int i = 0; i < 10000; i++)
        {
            sb.Append("coffee");
        }
    }
}