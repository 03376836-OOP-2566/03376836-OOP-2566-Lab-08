# Lab 8 Exercise 9

## Access base member by `base` keyword

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex09
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
DerivedClass dc = new DerivedClass();
dc.PrintBaseHello();

class BaseClass
{
    public string Hello = "Hello From BaseClass";
}
class DerivedClass : BaseClass
{
    new public string Hello = "Hello From DerivedClass";

    public void PrintBaseHello()
    {
        string BaseHello = base.Hello;
        System.Console.WriteLine(BaseHello);
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex09
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![9](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/4551fe5e-5411-41f8-aa7c-0369e641b10b)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![9 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/5a3281a3-3738-4940-a325-50f00480fd0c)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ เป็นการเรียกใช้ base keyword กำหนด base.Hello มาแสดงผล
โปรแกรมจะแสดงผล Hello From BaseClass
