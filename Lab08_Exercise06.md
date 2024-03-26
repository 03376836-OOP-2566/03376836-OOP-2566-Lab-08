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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/9df4d635-dcdf-4794-85cb-e1824e26835f)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5 
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/38649569-9e76-4892-ae78-1cfee29cda73)


7.อธิบายสิ่งที่พบในการทดลอง
- เป็นการสืบทอด แบบ muultilevel สร้างobjectคลาส DerivedClass จะมีการเรียคอนสตรักเตอร์ของ BaseClass1 ก่อน แล้วไปคอนสตรักเตอร์ของ BaseClass2 และสุดท้ายคอนสตรักเตอร์ของ DerivedClass ดังนั้นผลลัพธ์ที่ได้คือ "This is BaseClass1", "This is BaseClass2" และ "This is DerivedClass" ตามลำดับ
