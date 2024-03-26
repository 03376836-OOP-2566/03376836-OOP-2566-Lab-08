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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/39a02b6d-66e4-48b3-b869-769cf67766fb)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/dbc42c95-99d3-4e56-a463-89cff9822485)

7.อธิบายสิ่งที่พบในการทดลอง
- เป็นการประกาศคุณสมบัติ hello ใหม่ในคลาส DerivedClass ทำให้คุณสมบัติ Hello ในคลาส Derived แสดลงงแทน Hello ในคลาส BaseClass มีลักษณะการทำงานของ new และ การใช้ new เป็นการประกาศคุณสมบัติใหม่เพื่อระบุว่าการประกาศเป็นการทับ override คุณสมบัติในคลาสแม่ไม่ใช่การประกาศคุณสมบัติใหม่
