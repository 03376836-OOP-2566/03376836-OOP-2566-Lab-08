# Lab 8 Exercise 2

## Class Inheritance การใช้งาน method และ field ของ base และ  derived class

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex02
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/dd63b4ee-90d8-45ec-aecb-253f2fd68e51)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var dc = new DerivedClass();
dc.Method1(dc.Field1);  // call with method and field of base class
dc.Method2(dc.Field1);  // call with method of derived class and field of base class
dc.Method1(dc.Field2);  // call with method of base class and field of derived class
dc.Method2(dc.Field2);  // call with method and field of derived class

class BaseClass
{
    public string Field1 = "Field 1 in BaseClass";
    public void Method1(string value)
    {
        System.Console.WriteLine($"Method1() in BaseClass, string input = {value} ");
    }
}
class DerivedClass: BaseClass
{
    public string Field2 = "Field 2 in DerivedClass";
    public void Method2(string value)
    {
        System.Console.WriteLine($"Method2() in DerivedClass, string input = {value} ");
    }

}
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/0bbe554b-2f62-4cb0-a43a-0607d50632d3)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/89640aab-bb08-47b2-b038-b765893a69e3)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/3bd1c765-0f13-412f-b0ca-4ecafdce681f)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองจะเห็นว่า มีการสร้างคลาส BaseClass และ DerivedClass โดย DerivedClass เป็นซับคลาสของ BaseClass ซึ่งหมายความว่า DerivedClass สืบทอดคุณสมบัติจาก BaseClass และสามารถมีคุณสมบัติเพิ่มเติมได้ ในที่นี้คือการเพิ่มฟิลด์ Field2 และเมธอด Method2 ใน DerivedClass  เราสร้างอ็อบเจกต์ของ DerivedClass ด้วยตัวแปร dc และทดสอบการเรียกเมธอดและการเข้าถึงฟิลด์ของทั้ง BaseClass และ DerivedClass ผ่านอ็อบเจกต์ dc จากโค้ดของ  dc.Method1(dc.Field1);: เรียกเมธอด Method1 ของ BaseClass ด้วยการส่งค่าของฟิลด์ Field1 ของ DerivedClass ผลลัพธ์ที่คาดหวังคือ "Method1() in BaseClass, string input = Field 1 in BaseClass" เช่นเดียวกันกับ dc.Method2(dc.Field1);: เรียกเมธอด Method2 ของ DerivedClass ดังนั้นจากโค้ดทั้งหมดจะสรุแได้ว่า เป็นการเรียกเมธอดและการเข้าถึงฟิลด์ในซับคลาส DerivedClass สามารถทำได้ทั้งแบบใช้เมธอดและฟิลด์ของ BaseClass และแบบใช้เมธอดและฟิลด์ของ DerivedClass ตามต้องการแต่ละกรณีที่นำมาใช้งาน เราจะเห็นการแสดงผลดังภาพด้านบน
