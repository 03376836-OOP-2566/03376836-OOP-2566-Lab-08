var dc = new DerivedClass();
dc.Method1(dc.Field1);  // call with method and field of base class
dc.Method2(dc.Field1);  // call with method of derived class and field of base class
dc.Method1(dc.Field2);  // call with method of base class and field of derived class
dc.Method2(dc.Field2);  // call with method and field of derived class

class BaseClass
{
    public string Field1 = "Field 1 in BaseClass";
    public void Method1(string value)
    {
        System.Console.WriteLine($"Method1() in BaseClass, string input = {value} ");
    }
}
class DerivedClass: BaseClass
{
    public string Field2 = "Field 2 in DerivedClass";
    public void Method2(string value)
    {
        System.Console.WriteLine($"Method2() in DerivedClass, string input = {value} ");
    }

}