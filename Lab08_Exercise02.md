# Lab 8 Exercise 2

## Class Inheritance การใช้งาน method และ field ของ base และ  derived class

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex02
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/7227daf3-6536-4f7f-b9e9-661fd9a87136)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/8f68985f-2ec5-4f60-9364-e3b55fbf60e0)

7.อธิบายสิ่งที่พบในการทดลอง
- เป็นการทำงานแบบโครงสร้างแบบสืบทอด
dc.Method1(dc.Field1);: เมธอด Method1() ในคลาส BaseClass ถูกเรียก และฟิลด์ Field1 ในคลาส BaseClass ถูกส่งเป็นอาร์กิวเมนต์ ผลลัพธ์: "Method1() in BaseClass, string input = Field 1 in BaseClass"
dc.Method2(dc.Field1);: เมธอด Method2() ในคลาส DerivedClass ถูกเรียก และฟิลด์ Field1 ในคลาส BaseClass ถูกส่งเป็นอาร์กิวเมนต์ ผลลัพธ์: "Method2() in DerivedClass, string input = Field 1 in BaseClass"
dc.Method1(dc.Field2);: เมธอด Method1() ในคลาส BaseClass ถูกเรียก และฟิลด์ Field2 ในคลาส DerivedClass ถูกส่งเป็นอาร์กิวเมนต์ ผลลัพธ์: "Method1() in BaseClass, string input = Field 2 in DerivedClass"
dc.Method2(dc.Field2);: เมธอด Method2() ในคลาส DerivedClass ถูกเรียก และฟิลด์ Field2 ในคลาส DerivedClass ถูกส่งเป็นอาร์กิวเมนต์ ผลลัพธ์: "Method2() in DerivedClass, string input = Field 2 in DerivedClass"
