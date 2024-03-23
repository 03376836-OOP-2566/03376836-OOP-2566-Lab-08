# Lab 8 Exercise 1

## Class Inheritance

1.สร้าง console application project

```cmd
dotnet new console --name Lab08_Ex01
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/6bd8e6db-6609-4bee-8da4-ed73885b9f7a)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/dd6f931f-04c0-457b-8114-c0d3fed063b0)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab08_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/31f38293-debc-4aba-b042-e10be6515dab)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab08_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-08/assets/144197034/e36717ed-6945-4263-a471-f11ab38398c9)

7.อธิบายสิ่งที่พบในการทดลอง

จากโค้ดของคำสั่งของโปรแกรมจะเห็นว่ามี การสร้างอ็อบเจกต์ของคลาส Student และกำหนดค่าให้กับแอตทริบิวต์ Name ของแต่ละอ็อบเจกต์ ซึ่ง Name เป็นแอตทริบิวต์ของคลาส Person ซึ่งมีการกำหนดให้เป็นแอตทริบิวต์สาธารณะ (public) ซึ่งสามารถเข้าถึงได้จากภายนอกคลาส ดังนั้นเราสามารถกำหนดค่าและเข้าถึงค่าของ Name ได้โดยตรงผ่านการเข้าถึงโดยใช้วิธีการเข้าถึง (accessor methods) ในที่นี้คือเมื่อกำหนดค่า Name ให้กับอ็อบเจกต์ของ Student แล้ว เราสามารถเข้าถึงค่า Name นั้นผ่านทางอ็อบเจกต์เหล่านั้นได้โดยตรง ผลลัพธ์ที่แสดงผลบนหน้าจอ เราจะเห็นชื่อของนักเรียนที่ถูกกำหนดให้กับแอตทริบิวต์ Name ของแต่ละอ็อบเจกต์ student1 และ student2 ซึ่งได้แสดงชื่อตามที่กำหนดไว้ในการสร้างและกำหนดค่าให้กับ Name ของแต่ละอ็อบเจกต์ นั่นคือ "Somchai" และ "Sompong" ตามลำดับ ดังภาพการแสดงผลด้านบน
