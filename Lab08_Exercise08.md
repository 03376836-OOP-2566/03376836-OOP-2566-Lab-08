# Lab 8 Exercise 8

## Masking base class member with `new` keyword

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex08
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/4cac399d-873d-4501-9225-2b93fb974dc3)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/6b14162c-0602-4c06-b038-3e5d95740187)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/0e22fe6a-c749-47ca-86e1-1ac31de74fba)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/a5099ab4-4a0e-4bb8-b530-36fc6663ba43)

7.อธิบายสิ่งที่พบในการทดลอง


จากการทดลองนี้เรามีการสร้างอ็อบเจกต์ dc ของคลาส DerivedClass และพร้อมทั้งแสดงค่าของ dc.Hello ผ่านทางเมธอด WriteLine ของ Console

ในคลาส BaseClass มีตัวแปร Hello ที่ถูกกำหนดค่าเป็น "Hello From BaseClass" ซึ่งเป็นตัวแปรสมาชิก (member variable) แบบ public ซึ่งสามารถเข้าถึงได้จากภายนอกคลาสด้วยเครื่องหมาย  

ในคลาส DerivedClass เรากำหนดตัวแปร Hello ใหม่ (new) เพื่อบอกว่าเราไม่ต้องการสืบทอดตัวแปร Hello จาก BaseClass แต่ต้องการสร้างตัวแปรใหม่ที่มีชื่อเหมือนกันใน DerivedClass โดยมีค่าเป็น "Hello From DerivedClass" แทน

เมื่อทดลองรันโปรแกรมนี้ จะแสดงผลลัพธ์ดังนี้

Hello From DerivedClass

จะเห็นว่าค่าที่แสดงออกมาเป็น "Hello From DerivedClass" ตามที่กำหนดใน DerivedClass นั่นเอง ดังนั้นการใช้งาน new ในการสร้างตัวแปรใหม่ใน DerivedClass ได้ทำให้ค่าของตัวแปร Hello ถูกเปลี่ยนแปลงในขอบเขตของ DerivedClass เท่านั้น ไม่ได้ส่งผลกับตัวแปร Hello ใน BaseClass จากการทดลองจะได้ผลลัพธ์ดังด้านบน
