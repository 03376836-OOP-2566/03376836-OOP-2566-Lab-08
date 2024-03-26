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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/db09408d-5bfd-4b4b-9fac-e250a6f03a4a)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-08/assets/144195708/c8917d4a-aad4-497e-8947-a8ddc3a7c32f)

7.อธิบายสิ่งที่พบในการทดลอง

เมื่อสร้าง DerivedClass ด้วย DerivedClass DC = new DerivedClass(); และทำการแสดงค่า DC.Field1 และ BC.Field1 
จะได้ผลลัพธ์ดังนี้:
DC.Field1 = Field1 of DerivedClass
BC.Field1 = Field1 of BaseClass
