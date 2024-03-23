# Lab 8 Exercise 5

## Multiple base class inheritance

![alt text](./Pictures/image01.png)

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex05
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/d2ecb73d-47f4-4ec8-a7c2-471740a243cb)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/92a1175d-d6ef-466c-a030-21ed88c8bfc3)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/29c07ab3-ee9b-47bc-9dfc-eadc15079ce5)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/2e54a478-e638-4301-a7f6-8c266f72117c)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/8f5940f5-d44b-4546-988f-b0e9569140c4)

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/ec4e0c17-5b67-409e-bd15-4f6795b027d2)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/87de3fcf-6c56-465e-a799-a57efcefddd6)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/fd51aa1e-38ff-4d2c-ad3c-938a1e8d3367)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/c33f86a0-63e8-40a0-ac7a-14974e225d6d)

7.อธิบายสิ่งที่พบในการทดลอง

จากโค้ดมีข้อผิดพลาดที่เกิดขึ้นเป็นเพราะภาษา C# ไม่รองรับการสืบทอดจากหลายคลาสโดยตรง (multiple inheritance) ดังนั้นไม่สามารถประกาศคลาส DerivedClass ที่สืบทอดจาก BaseClass1 และ BaseClass2 พร้อมกันได้ ดังนั้นทำการแก้ไขโค้ด ก็จะได้ผลลัพการแสดงผลทางหน้าจออกมา โดย การทดลองนี้มีการสร้างคลาส Program, BaseClass1, BaseClass2, และ DerivedClass ในภาษา C# เมื่อโปรแกรมถูกเรียกใช้ จะมีการสร้างอ็อบเจกต์ของ DerivedClass ซึ่งจะทำให้เรียกใช้คอนสตรักเตอร์ของ DerivedClass ซึ่งจะแสดงข้อความ "This is DerivedClass" ผ่านทางคอนโสตรักเตอร์ของ DerivedClass และเมื่อสร้างอ็อบเจกต์ DerivedClass ก็จะสืบทอดคุณสมบัติจาก BaseClass1 ด้วย ซึ่งทำให้เรียกใช้คอนสตรักเตอร์ของ BaseClass1 และแสดงข้อความ "This is BaseClass1" ผ่านทางคอนโสตรักเตอร์ของ BaseClass1 อีกทีด้วย การแสดงผลจะออกมาดังนี้คือ

This is BaseClass1

This is DerivedClass

จากผลลัพด้านบน
