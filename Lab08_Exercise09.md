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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/cb088a8d-fdf6-4f18-80e0-06e849a84359)
### สามารถ Build ได้ พราะ ได้ใช้ base keyword จาก class ที่กำหนดมา คือ PrintBaseHello()
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/bcad728b-45d8-461d-be06-d83a824ebd6e)
### สามารถ Run ได้ เพราะ เป็นการเรียกใช้ base keyword กำหนด base.Hello มาแสดงผล
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล Hello From BaseClass
