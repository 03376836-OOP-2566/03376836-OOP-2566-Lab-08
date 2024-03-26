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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/e2ff7f2a-e7ab-48f3-b248-7dc09718e1d1)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/289cd009-fdbe-477a-becc-7c05ae9887dd)

7.อธิบายสิ่งที่พบในการทดลอง
 เมื่อสร้าง DerivedClass ด้วย DerivedClass dc = new DerivedClass(); และแสดงค่าของ dc.Hello 
 จะได้ผลลัพธ์ดังนี้
 Hello From DerivedClass
