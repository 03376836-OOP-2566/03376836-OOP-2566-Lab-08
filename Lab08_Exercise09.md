# Lab 8 Exercise 9

## Access base member by `base` keyword

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex09
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/7b144fba-8f22-4689-bfa1-6ae6d85e9148)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
DerivedClass dc = new DerivedClass();
dc.PrintBaseHello();

class BaseClass
{
    public string Hello = "Hello From BaseClass";
}
class DerivedClass : BaseClass
{
    new public string Hello = "Hello From DerivedClass";

    public void PrintBaseHello()
    {
        string BaseHello = base.Hello;
        System.Console.WriteLine(BaseHello);
    }
}
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/665efcc0-b73a-4833-ad9b-23042523d930)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex09
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/255857b1-ab9f-468a-aa50-45990609be43)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/6723ad35-18b5-486a-9406-a4f54de5b437)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลอง เริ่มต้นด้วยการสร้างอ็อบเจกต์ dc ของคลาส DerivedClass และให้เรียกเมธอด PrintBaseHello() ของ dc ขึ้นมา

ในคลาส BaseClass มีตัวแปร Hello ที่ถูกกำหนดค่าเป็น "Hello From BaseClass" ซึ่งเป็นตัวแปรสมาชิก (member variable) แบบ public ซึ่งสามารถเข้าถึงได้จากภายนอกคลาสด้วยเครื่องหมาย .

ในคลาส DerivedClass เรากำหนดตัวแปร Hello ใหม่ (new) เพื่อบอกว่าเราไม่ต้องการสืบทอดตัวแปร Hello จาก BaseClass แต่ต้องการสร้างตัวแปรใหม่ที่มีชื่อเหมือนกันใน DerivedClass โดยมีค่าเป็น "Hello From DerivedClass" แทน

ใน DerivedClass เรามีเมธอด PrintBaseHello() ที่ใช้เพื่อพิมพ์ค่าของตัวแปร Hello ใน BaseClass โดยใช้คำสั่ง base.Hello ซึ่งจะทำให้เข้าถึงตัวแปร Hello ใน BaseClass

เมื่อทดลองรันโปรแกรมนี้ จะแสดงผลลัพธ์ดังนี้

Hello From BaseClass

จะเห็นว่าค่าที่แสดงออกมาเป็น "Hello From BaseClass" ซึ่งเป็นค่าของตัวแปร Hello ใน BaseClass ซึ่งถูกเข้าถึงผ่าน PrintBaseHello() ใน DerivedClass ด้วยคำสั่ง base.Hello ตามที่กำหนดไว้ในโค้ด

ดังนั้นเราจะเห็นการแสดงผลของผลลัพธ์ดังภาพด้านบน
