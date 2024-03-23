# Lab 8 Exercise 3

## Class inheritance 1

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex03
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/544bf35e-88ea-4f1e-9899-b01de77768ec)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/a291316b-f75a-4d2f-a2c0-fc0d676ee7f2)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/73b0fa72-23a5-4c71-9861-aded9e3b535c)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/01ac6a48-db07-45cd-9a1d-08c27b4cc24a)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองจะเห็นว่า เป็นการสร้างคลาส BaseClass1 และ BaseClass2 และ DerivedClass โดย DerivedClass เป็นซับคลาสของ BaseClass1 ซึ่งหมายความว่า DerivedClass สืบทอดคุณสมบัติจาก BaseClass1 และสามารถมีคุณสมบัติเพิ่มเติมได้ ในที่นี้ไม่ได้มีการเพิ่มคุณสมบัติใดๆ เพิ่มเติมใน DerivedClass การสร้างอ็อบเจกต์ของ DerivedClass ด้วยตัวแปรชนิด DerivedClass ซึ่งเรียกว่า dc จะทำให้คอนสตรักเตอร์ของ DerivedClass ถูกเรียก ซึ่งในที่นี้คือการแสดงข้อความ "This is DerivedClass" ผ่านคอนโสตรักเตอร์ของ DerivedClass DerivedClass สืบทอดจาก BaseClass1 คลาสที่มีคอนสตรักเตอร์ ซึ่งในที่นี้ไม่ได้ระบุคอนสตรักเตอร์แต่เนื่องจากไม่มีการระบุคอนสตรักเตอร์ใดๆ ในคลาส BaseClass1 จึงถือว่าคอนสตรักเตอร์เริ่มต้น  ของ BaseClass1 ถูกเรียก ซึ่งจะแสดงข้อความ "This is BaseClass1"ผลลัพธ์ที่คาดหวังจากการสร้างอ็อบเจกต์ของ DerivedClass คือการแสดงข้อความตามลำดับ คือ 
This is BaseClass1"

"This is DerivedClass"

ตามภาพด้านบน
