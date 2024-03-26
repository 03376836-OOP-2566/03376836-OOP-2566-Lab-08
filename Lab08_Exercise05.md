# Lab 8 Exercise 5

## Multiple base class inheritance

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex05
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

class DerivedClass : BaseClass1, BaseClass2
{
    public DerivedClass()
    {
        System.Console.WriteLine("This is DerivedClass");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/e2d70747-c60e-4258-8289-8b7cf8e70d81)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/c9c148a5-1535-4e43-95b7-3b9808192316)

7.อธิบายสิ่งที่พบในการทดลอง
- ไม่สามารถใช้baseclassพร้อมกันำด้ต้องเลือกมาใช้อย่างใดอย่างหนึ่ง
```
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
  ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/24574e29-c529-488e-b55f-2cf193281fa2)
  ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/12abe130-925e-4511-9b48-fec252a719da)
```

- จากรูปเลือกใช้ Baseclass 2 จะเห็นได้ว่าสามารถรันโปรแกรมได้
