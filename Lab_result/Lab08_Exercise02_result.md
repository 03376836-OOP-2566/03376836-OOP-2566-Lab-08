## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/9b66b0a8-3326-4aa2-93df-8caba6c6934b)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/c02f4ec0-962d-4af0-a017-7f6deb6eda33)

## อธิบายสิ่งที่พบในการทดลอง
### จากโปรแกรม DerivedClass สืบทอดจาก BaseClass ทำให้ derived class สามารถเข้าถึง method และ field ของ base class ได้ 
```
var dc = new DerivedClass(); // สร้าง Obj จาก DerivedClass
dc.Method1(dc.Field1);  // เรียกใช้ Method1 และ Field1 ของ BaseClass
dc.Method2(dc.Field1);  // เรียกใช้ Method2 ของ DerivedClass และ Field1 ของ BaseClass
dc.Method1(dc.Field2);  // เรียกใช้ Method1 ของ BaseClass และ Field2 ของ DerivedClass
dc.Method2(dc.Field2);  // เรียกใช้ Method2 และ Field2 ของ DerivedClass
```
