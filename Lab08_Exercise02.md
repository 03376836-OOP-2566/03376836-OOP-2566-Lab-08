# Lab 8 Exercise 2

## Class Inheritance การใช้งาน method และ field ของ base และ  derived class

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex02
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
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
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![2](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/17ea57fe-04da-405e-a4d3-847c74cdb95b)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![2 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/ac4059de-8608-4816-bd8f-99ad77ca73f4)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ เป็นการเรียกใช้ method ต่างๆมาแสดงผล จาก class base Class และ DerivedClass สืบทอดจาก base Class
โปรแกรมจะแสดงผล
Method1() in BaseClass, string input = Field 1 in BaseClass
Method2() in DerivedClass, string input = Field 1 in BaseClass
Method1() in BaseClass, string input = Field 2 in DerivedClass
Method2() in DerivedClass, string input = Field 2 in DerivedClass
