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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/ccf1f51f-3827-48b4-9f96-674836368f1e)
### สามารถ Build ได้ เพราะ ใช้คำสำคัญ new เพื่อระบุว่าการซ่อนสมาชิกในคลาสที่สืบทอดเป็นเจตนา
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/b0af33aa-8d03-44c7-8141-aea70ca184b2)
### สามารถ Run ได้ เพราะ ไม่มีข้อผิดพลาดอะไรหรือเตือนอะไร
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล Hello From DerivedClass
