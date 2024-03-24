using System;

class Program
{
    static void Main(string[] args)
    {
        IntermediateClass ic = new IntermediateClass();
    }
}

class BaseClass1
{
    public BaseClass1()
    {
        System.Console.WriteLine("This is BaseClass1");
    }
}

class BaseClass2
{
    public BaseClass2()
    {
        System.Console.WriteLine("This is BaseClass2");
    }
}

class IntermediateClass : BaseClass1
{
    public IntermediateClass()
    {
        System.Console.WriteLine("This is IntermediateClass");
    }
}
