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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/d8f3d2ad-8dcb-4d39-b30e-96fc89dd3e96)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/3542312b-cb84-4e2b-a9e4-ae5541b7a252)

7.อธิบายสิ่งที่พบในการทดลอง
- เป็นการเรียกใช้ PrintBaseHello() คือการแสดงค่าคุณสมบัติ Hello ที่ประกาศในคลาส BaseClass โดยผ่าน base พื่อดึงคุณสมบัติ hello จากคลาสแม่
