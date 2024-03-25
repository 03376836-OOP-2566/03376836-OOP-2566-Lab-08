# Lab 8 Exercise 6

## Multiple base class inheritance

![alt text](./Pictures/image02.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex06
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
DerivedClass dc = new DerivedClass();
class BaseClass1
 {
    public BaseClass1()
    {
        System.Console.WriteLine("This is BaseClass1");
    }
 }
class BaseClass2: BaseClass1
 {
    public BaseClass2()
    {
        System.Console.WriteLine("This is BaseClass2");
    }
 }

class DerivedClass : BaseClass2
{
    public DerivedClass()
    {
        System.Console.WriteLine("This is DerivedClass");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![6](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/06904fc1-ab55-4d1b-ae8d-1f180e0c6142)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![6 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/0f619d19-1247-4536-a4f4-7369c4bcc3a5)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะสืบทอด Class อย่างถูกต้อง
โปรแกรมจะแสดงผล
This is BaseClass1
This is BaseClass2
This is DerivedClass
