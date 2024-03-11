## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-3.png)

- สามารถ Build ได้ เพราะ เป็นการใช้ method และ field ของ base และ deroved class 

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-4.png)

- สามารถ Run ได้ เพราะ เป็นการเรียกใช้ method ต่างๆมาแสดงผล จาก class base Class และ DerivedClass สืบทอดจาก base Class 

## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล

- Method1() in BaseClass, string input = Field 1 in BaseClass 
- Method2() in DerivedClass, string input = Field 1 in BaseClass    
- Method1() in BaseClass, string input = Field 2 in DerivedClass    
- Method2() in DerivedClass, string input = Field 2 in DerivedClass 