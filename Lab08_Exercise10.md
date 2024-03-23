# Lab 8 Exercise 10

## Using a references to a base class

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex10
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/8f3b1fad-ba94-46a0-8c08-420e06b5f22c)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
DerivedClass DC = new DerivedClass();
System.Console.WriteLine($"DC.Field1 = {DC.Field1}");
BaseClass BC = (BaseClass)DC;
System.Console.WriteLine($"BC.Field1 = {BC.Field1}");

class BaseClass
{
    public string Field1 = "Field1 of BaseClass"; 
}
class DerivedClass:BaseClass
{
    new public string Field1 = "Field1 of DerivedClass"; 
}
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/ecdc6501-22d5-43ab-a76d-81fbd65ebf5b)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex10
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/f9be73fd-025f-42c6-8a7a-622f05b8fca6)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/45cc666c-b971-4799-9417-067483c74fd6)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลอง เริ่มต้นด้วยการสร้างอ็อบเจกต์ DC ของคลาส DerivedClass และแสดงค่าของ DC.Field1 ซึ่งมีการเข้าถึงผ่านทางเมทอด WriteLine ของ Console

ในคลาส BaseClass มีตัวแปร Field1 ที่ถูกกำหนดค่าเริ่มต้นเป็น "Field1 of BaseClass"

ในคลาส DerivedClass เป็นคลาสที่สืบทอดจาก BaseClass และมีการเปรียบเทียบตัวแปร Field1 ใหม่โดยใช้คำสั่ง new ซึ่งจะทำให้มีตัวแปร Field1 ใน DerivedClass ที่มีชื่อเดียวกับตัวแปร Field1 ใน BaseClass แต่มีขอบเขตของการใช้งานแยกกัน

เมื่อทำการนำอ็อบเจกต์ DC ของ DerivedClass มาอ้างอิงในตัวแปร BC ที่มีประเภทเป็น BaseClass โดยใช้การแปลงชนิด (casting) และแสดงค่าของ BC.Field1 จะเห็นว่าค่าที่แสดงออกมาคือ "Field1 of BaseClass" ซึ่งเป็นค่าของตัวแปร Field1 ใน BaseClass ไม่ใช่ใน DerivedClass ถึงแม้ว่า DC จะเป็นอ็อบเจกต์ของ DerivedClass ก็ตาม แสดงผลลัพธ์ดังภาพด้านบน
