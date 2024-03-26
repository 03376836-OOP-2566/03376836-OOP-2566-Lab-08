# Lab 8 Exercise 10

## Using a references to a base class

1. สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex10
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex10
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/7062bfce-c80e-45a6-80c1-3ef9f8391656)
### สามารถ build ได้ เพราะการใช้ reference ของ base class ในที่นี้ช่วยให้เราสามารถอ้างถึงอ็อบเจกต์ของ derived class ได้ และพึ่งพาการแปลงชนิดเพื่อให้ reference ของ base class เรียกใช้เมธอดหรือเข้าถึงสมาชิกของ derived class ได้โดยตรง
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/bf691b79-097e-4ee5-9970-c71122edca5d)
### สามารถ Run ได้ ปกติ
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล
### DC.Field1 = Field1 of DerivedClass
### BC.Field1 = Field1 of BaseClass
