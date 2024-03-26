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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/3a00b419-dbe5-43cd-8a78-afd4c6c35adb)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-08/assets/144195611/75c77687-a6ba-415f-9a2a-5820de588b92)

7.อธิบายสิ่งที่พบในการทดลอง
- เป็นการกำหนดค่าให้กับคุณสมบัติ ์ฤทำ ได้โดยไม่ต้องระบุ คุณสมบัติ nameอีกครั้ง ในคลาส Student ซึ่งเป็ฯผลมาจากสืบทอดคุณสมบัติคลาส Person
