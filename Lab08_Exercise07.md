# Lab 8 Exercise 7

## Overriding base class member

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex07
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/8fcb42b2-34b7-4666-9dcc-f8b29470b5aa)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/51b8e083-e64d-406e-adc6-6bfd43c4f0b4)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/78f1bf59-132b-4a8d-ac71-cbf7c32cf12f)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/6d546364-a8e2-4912-9602-b38619dc2cea)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/10809ea7-e901-49ff-a31c-b630c804b77f)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้เริ่มต้นด้วยการสร้างอ็อบเจกต์ dc ของคลาส DerivedClass และพร้อมทั้งแสดงค่าของ dc.Hello ผ่านทางเมธอด WriteLine ของ Console

ในคลาส BaseClass มีตัวแปร Hello ที่ถูกกำหนดค่าเป็น "Hello From BaseClass" ซึ่งเป็นตัวแปรสมาชิก (member variable) แบบ public ซึ่งสามารถเข้าถึงได้จากภายนอกคลาสด้วยเครื่องหมาย 

ในคลาส DerivedClass ก็มีตัวแปร Hello ที่ถูกกำหนดค่าเป็น "Hello From DerivedClass" โดยตัวแปร Hello ใน DerivedClass นี้มีชื่อเหมือนกันกับตัวแปร Hello ใน BaseClass แต่มีขอบเขตของการใช้งานแยกกัน ซึ่งถ้ามีการเข้าถึงจากภายนอกคลาส DerivedClass จะใช้ตัวแปร Hello ที่ถูกกำหนดใน DerivedClass นี้เท่านั้น

ซึ่งมีค่าเป็น "Hello From DerivedClass" ไม่ได้สืบทอดค่าจาก BaseClass
เมื่อทดลองรันโปรแกรมนี้ จะแสดงผลลัพธ์ดังนี้

Hello From DerivedClas

จากคำสั่งจะเห็นผลการทดลองดังภาพด้านบน
