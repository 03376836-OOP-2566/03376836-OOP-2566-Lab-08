# Lab 8 Exercise 6

## Multiple base class inheritance

![alt text](./Pictures/image02.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex06
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
class BaseClass2: BaseClass1
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
dotnet build  Lab08_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/d74f6585-c53a-414e-a273-d0ee08cac6b5)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/bcfc5e55-beab-4323-912d-75ccb5d77ec4)

7.อธิบายสิ่งที่พบในการทดลอง
เมื่อสร้าง DerivedClass ด้วย DerivedClass dc = new DerivedClass(); จะทำให้เกิดการเรียกใช้คอนสตรักเตอร์ของ DerivedClass ซึ่งมีผลเป็นการแสดงผลลัพธ์ดังนี้
แสดงผล
This is BaseClass1
This is BaseClass2
This is DerivedClass
