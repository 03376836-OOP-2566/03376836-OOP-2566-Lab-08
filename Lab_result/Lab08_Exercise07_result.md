## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/61de460d-a520-418d-9295-5478e53358f6)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/93e9c50e-3d48-4e7e-9ddd-680fbf813e5a)

## อธิบายสิ่งที่พบในการทดลอง
### 
```cs
DerivedClass dc = new DerivedClass();
System.Console.WriteLine(dc.Hello);

class BaseClass
{
    public string HelloBase = "Hello From BaseClass";
}
class DerivedClass : BaseClass
{
    public string Hello = "Hello From DerivedClass";
}
```
### ที่ขึ้น warning เนื่องจากมีชื่อ Hello ซ้ำ
### การที่มี member ที่มีชื่อเหมือนกันใน BaseClass และ DerivedClass จะทำให้ DerivedClass ไม่ได้ทำการ "override" สมบัติจาก BaseClass แต่เป็นการ "hide" (ซ่อน) สมบัติของ BaseClass ที่ถูกปกปิดไป
