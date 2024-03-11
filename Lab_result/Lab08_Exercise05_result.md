## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/9608dcc0-412a-464a-8b17-fbc62652fd65)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/832c85b4-f754-4357-b0f9-a7d8dde36d71)

## อธิบายสิ่งที่พบในการทดลอง
### ไม่สามารถรันโค้ดได้เนื่องจากบรรทัด 17  class DerivedClass : BaseClass1, BaseClass2 ไม่สามารถทำได้

## หลังแก้โคด 
```
class DerivedClass : BaseClass1 //เลือกลบ BaseClass1,BaseClass2 ไม่สามารถสืบทอดได้จากทั้งคู่พร้อมกัน
{
    public DerivedClass()
    {
        System.Console.WriteLine("This is DerivedClass");
    }
}
```
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/855a8634-7d5c-4a03-beb2-191a9e3b7708)
