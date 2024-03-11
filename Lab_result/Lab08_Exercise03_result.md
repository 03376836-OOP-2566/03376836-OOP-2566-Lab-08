## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/ea3523f4-66d6-4220-afa4-6513b16ad6f5)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-08/assets/144196505/3abead79-d4c0-47bf-a530-015b348c35b1)

## อธิบายสิ่งที่พบในการทดลอง
### จากโปรแกรม DerivedClass สืบทอด จาก BaseClass1 ดังนั้น constructor ของ BaseClass1 จะถูกเรียกใช้งานขณะที่สร้างวัตถุจาก DerivedClass แต่ Constructor ของ BaseClass2 ไม่ถูกเรียกใช้เนื่องจาก DerivedClass ไม่ได้สืบทอด BaseClass2
```
DerivedClass dc = new DerivedClass(); // สืบทอดจาก BaseClass1 ตัวเดียวจึงแสดงผลทั้ง BaseClass1 และ DerivedClass
```
