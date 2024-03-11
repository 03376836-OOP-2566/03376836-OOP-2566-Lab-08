## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/d3ac534f-c1bd-4559-8acf-65b0b368a875)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/dcbb9e74-383b-4fab-be36-d38356d55233)

## อธิบายสิ่งที่พบในการทดลอง
### โค้ดนี้เกี่ยวกับการใช้ reference ของ base class
### การใช้ reference ของ baseclass (BC) ทำให้สามารถเข้าถึงสมบัติของ Field1 ใน BaseClass จาก DerivedClass ในกรณีนี้ Field1 ของ DerivedClass ถูก "masked" ด้วย new keyword จึงไม่มีผลต่อ Field1 ของ Baseclass ที่ถูกเข้าถึงผ่าน reference ของ DerivedClass
```
class BaseClass
{
    public string Field1 = "Field1 of BaseClass";   // 1. BaseClass = Field1 of BaseClass
}
class DerivedClass:BaseClass
{
    new public string Field1 = "Field1 of DerivedClass"; // 2. DerivedClass = Field1 of DerivedClass (ใช้ new keyword เพื่อ mask)
}
DerivedClass DC = new DerivedClass();                  // สร้าง Obj DC จาก DerivedClass
System.Console.WriteLine($"DC.Field1 = {DC.Field1}");  // แสดงค่าของ Field1 จาก DC ของ DerivedClass
BaseClass BC = (BaseClass)DC;                          // สร้าง reference BC จาก DC ให้เป็น BaseClass
System.Console.WriteLine($"BC.Field1 = {BC.Field1}");  // แสดงค่าของ Field1 จาก BC ที่เป็น reference ของ BaseClass
```
