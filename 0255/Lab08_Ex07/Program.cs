DerivedClass dc = new DerivedClass();
System.Console.WriteLine(dc.Hello);

class BaseClass
{
    public string HelloBase = "Hello From BaseClass";
}
class DerivedClass : BaseClass
{
    public string Hello = "Hello From DerivedClass";
}