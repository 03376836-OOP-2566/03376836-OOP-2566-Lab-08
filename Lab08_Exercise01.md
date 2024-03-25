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

<img width="551" alt="Screenshot 2024-03-24 040057" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/0824409f-dd08-4e3d-a81e-1fcc5ca159c9">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="551" alt="Screenshot 2024-03-24 040057" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-08/assets/144195963/7c8cebc6-9828-46db-b634-cb79f1e61130">

7.อธิบายสิ่งที่พบในการทดลอง


student1 name = Somchai
student2 name = Sompong
