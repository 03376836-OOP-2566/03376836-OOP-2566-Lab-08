# Lab 8 Exercise 8

## Masking base class member with `new` keyword

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex08
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
DerivedClass dc = new DerivedClass();
System.Console.WriteLine(dc.Hello);

class BaseClass
{
    public string Hello = "Hello From BaseClass";
}
class DerivedClass : BaseClass
{
    new public string Hello = "Hello From DerivedClass";
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![8](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/ab56649e-203f-4b13-9866-d62e44dfda71)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![8 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/9a49d391-2952-4c73-b673-5f6d0b80e6e3)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ ไม่มีข้อผิดพลาดมีแค่เตือน
โปรแกรมจะแสดงผล Hello From DerivedClass
