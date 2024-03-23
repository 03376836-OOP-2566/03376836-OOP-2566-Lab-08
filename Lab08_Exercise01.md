# Lab 8 Exercise 1

## Class Inheritance

1.สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex01
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Student student1 = new Student();
student1.Name = "Somchai";
System.Console.WriteLine($"student1 name = {student1.Name}");

var student2 = new Student();
student2.Name = "Sompong";
System.Console.WriteLine($"student2 name = {student2.Name}");

class Person
{
    private string name = string.Empty;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Student:Person
{

}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/ec69a7e3-91d2-4eed-bce4-2fd74f4788a3)
### สามารถ Build ได้เพราะ เป็นการสืบทอด Class Inheritance โดยใช้ Class สืบทอดจาก class person
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-08/assets/144195555/1930d434-a0a5-4b0c-bedd-6f8f6bfc19b5)
### สามารถ Run ได้เพราะ ใช้ class person มาสืบทอด
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล
### student1 name = Somchai
### student2 name = Sompong
