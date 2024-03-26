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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/1a6722ac-c8f1-4a84-a3f0-0278626ef730)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/afd115d4-5f80-4b3f-bd52-56159f599724)

7.อธิบายสิ่งที่พบในการทดลอง
- มีการแจ้งเตือนwarring เนื่องจากว่า ทีการประกาศ Hello ในคบาส BaseClass และ DerivedClass จะทำให้คุณสมบัติคลาสลูกทับกันoverride 
