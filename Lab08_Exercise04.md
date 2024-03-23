# Lab 8 Exercise 4

## Class inheritance 2

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex04
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/114dfd83-96f2-485f-9736-06e29dcf276d)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/6763cb0c-e098-491a-b7a3-4bfcdc1897b0)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/6b632af7-0612-4c05-88cc-a70dac25554f)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/78e2cfc8-4f08-4313-9d38-878f02eb8687)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองเป็นการ สร้างอ็อบเจกต์ของ DerivedClass ด้วยตัวแปรชนิด DerivedClass ซึ่งเรียกว่า dc จะเรียกใช้คอนสตรักเตอร์ของ DerivedClass ซึ่งจะแสดงข้อความ "This is DerivedClass" ผ่านคอนโสตรักเตอร์ของ DerivedClass เป็นการสร้างคลาส BaseClass1, BaseClass2, และ DerivedClass  โดยที่ DerivedClass เป็นซับคลาสของ BaseClass2 ซึ่งหมายความว่า DerivedClass สืบทอดคุณสมบัติจาก BaseClass2 และสามารถมีคุณสมบัติเพิ่มเติมได้ ในที่นี้ไม่ได้มีการเพิ่มคุณสมบัติใดๆ เพิ่มเติมใน DerivedClass

เนื่องจาก DerivedClass สืบทอดจาก BaseClass2 คลาสที่มีคอนสตรักเตอร์ แต่ไม่ได้ระบุคอนสตรักเตอร์ใดๆ จึงถือว่าใช้คอนสตรักเตอร์เริ่มต้น ของ BaseClass2 ซึ่งจะแสดงข้อความ "This is BaseClass2"  ดังนั้นผลลัพธ์ที่คาดหวังจากการสร้างอ็อบเจกต์ของ DerivedClass คือการแสดงข้อความตามลำดับดังนี้

"This is BaseClass2"

"This is DerivedClass"

การแสดงผลดังภาพด้านบน
