# Lab 8 Exercise 3

## Class inheritance 1

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex03
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
class BaseClass2
 {
    public BaseClass2()
    {
        System.Console.WriteLine("This is BaseClass2");
    }
 }

class DerivedClass : BaseClass1
{
    public DerivedClass()
    {
        System.Console.WriteLine("This is DerivedClass");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="578" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/0d175053-d970-4785-838e-14df6e7eb9fe">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="436" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/e3588f89-1745-48e5-b273-9d99021687ff">


7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล
This is BaseClass1
This is DerivedClass
