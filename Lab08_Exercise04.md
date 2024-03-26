# Lab 8 Exercise 4

## Class inheritance 2

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex04
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
dotnet build  Lab08_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/500b1e65-951f-443b-a3d5-c2f361e9bb26)
### โปรแกรมสามารถ Build ได้ เพราะ สืบทอดจาก class DerivedClass : BaseClass2
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/c884a667-1618-43ca-b673-76abcded84f8)
### โปรแกรมสามารถ Run ได้ เพราะ สืบทอดได้ถูกต้อง
7.อธิบายสิ่งที่พบในการทดลอง
### โปแกรมจะแสดงผล
### This is BaseClass2
### This is DerivedClass
