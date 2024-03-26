# Lab 8 Exercise 3

## Class inheritance 1

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex03
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

class DerivedClass : BaseClass1
{
    public DerivedClass()
    {
        System.Console.WriteLine("This is DerivedClass");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/2ca0b1d0-fc50-4fdb-99d6-cc113c846b14)


5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/e5322ef6-e8a3-4323-b53b-2cfb7b56d14f)

7.อธิบายสิ่งที่พบในการทดลอง
- เป็นการสร้างคลาสที่สืบทอดจากคลาสหลัก
- คลาส derivedClass สืบมาจาก Baseclass และมี constructerที่ไม่มีพารามิเตอร์
- ในconstructerของ DerivedClass มีการแสดงข้อความ "This is DerivedClass"
เมื่อสร้างวัตถุของคลาส DerivedClass จะมีการแสดงข้อความ "This is BaseClass1" ก่อนและตามด้วย "This is DerivedClass" ดังนั้นจะได้ผลลัพธ์ "This is BaseClass1" และ "This is DerivedClass"
