### ผลที่ได้จากการรันคำสั่งในข้อ 3
![Screenshot 2024-03-23 151908](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-08/assets/144195697/c7b0bf31-60a1-40d3-a358-86aff97dbef0)


โปรแกรม Build ได้เพราะ DerivedClass สามารถเข้าถึงฟิลด์และเรียกใช้เมธอดของ BaseClass ได้โดยตรง

### ผลที่ได้จากการรันคำสั่งในข้อ 5

![Screenshot 2024-03-23 151913](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-08/assets/144195697/1c7084c1-30d7-4abc-84fe-f80c3ab610e5)


โปรแกรม Run ได้เพราะ DerivedClass สามารถเข้าถึงฟิลด์และเรียกใช้เมธอดของ BaseClass ได้โดยตรง

### สิ่งที่พบในการทดลอง
- โปรแกรม Build และ Run ได้เพราะ DerivedClass สามารถเข้าถึงฟิลด์และเรียกใช้เมธอดของ BaseClass ได้โดยตรง
- ผลลัพท์ที่ได้ คือ
  - Method1() in BaseClass, string input = Field 1 in BaseClass 
  - Method2() in DerivedClass, string input = Field 1 in BaseClass 
  - Method1() in BaseClass, string input = Field 2 in DerivedClass 
  - Method2() in DerivedClass, string input = Field 2 in DerivedClass 
