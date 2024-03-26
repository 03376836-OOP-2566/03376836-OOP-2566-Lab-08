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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/8297a5e8-00f4-44c4-9813-f47fed7db993)

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/8a1159d8-c6a1-4220-9c38-921a5e20183b)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/41e96dd2-5286-469a-aff5-9d0d61019af6)

7.อธิบายสิ่งที่พบในการทดลอง
เมื่อสร้าง DerivedClass ด้วย DerivedClass dc = new DerivedClass(); จะทำให้เกิดการเรียกใช้คอนสตรักเตอร์ของ DerivedClass ซึ่งมีผลเป็นการแสดงผลลัพธ์ดังนี้:
เเสดงผล
This is BaseClass1
This is DerivedClass
