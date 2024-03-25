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

<img width="686" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/457bd0b6-ab58-4704-898c-d6ff38aaefa4">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="418" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/54a3a041-5431-4113-972f-e4fe1b068864">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Hello From DerivedClass
