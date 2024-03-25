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

![10](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/6a82e53a-b59c-44a7-b676-3dbc602079de)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![10 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-08/assets/144195995/4ee51438-2484-43a3-8c15-f5373516cf85)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ ปกติ
โปรแกรมจะแสดงผล
DC.Field1 = Field1 of DerivedClass
BC.Field1 = Field1 of BaseClass
