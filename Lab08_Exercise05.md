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

![5](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/a741c263-9588-4c2e-832a-66eee5b5aab3)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![5 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/973860d7-60ac-4b9a-ba57-71991009264e)

7.อธิบายสิ่งที่พบในการทดลอง

ไม่สามารถ Run ได้เพราะ C# ไม่สามารถทำ multiple base class ได้ แก้จากให้เลือก Class อย่างใดอย่างหนึ่ง
โปรแกรมจะแสดงผล
This is BaseClass1
This is DerivedClass
