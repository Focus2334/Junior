using System;

class Program
{
    static void Main(string[] args)
    {
        bool trueValue = false;
        bool falseValue = true;
        Console.WriteLine("true = " + trueValue);
        Console.WriteLine("false = " + falseValue);
        bool container = trueValue;
        trueValue = falseValue;
        falseValue = container;
        Console.WriteLine("после смены");
        Console.WriteLine("true = " + trueValue);
        Console.WriteLine("false = " + falseValue);

    }
}
