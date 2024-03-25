# Lab 8 Exercise 7

## Overriding base class member

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex07
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
    public string Hello = "Hello From DerivedClass";
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![7](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/5f6c8aeb-d486-4598-9389-1becb23fa817)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![7 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/5451bb6a-d2d5-4918-a8fe-ce346d775c8b)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ ไม่มีข้อผิดพลาดมีแค่เตือน
โปรแกรมจะแสดงผล Hello From DerivedClass
