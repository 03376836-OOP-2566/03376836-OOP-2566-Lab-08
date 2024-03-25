# Lab 8 Exercise 4

## Class inheritance 2

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex04
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
dotnet build  Lab08_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="540" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/a9ae1719-5575-4b40-9313-c94af4a00f81">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="404" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/65b53c8a-376d-46fb-840e-9e1dcc40fcc0">

7.อธิบายสิ่งที่พบในการทดลอง

โปแกรมจะแสดงผล
This is BaseClass2
This is DerivedClass
