### ผลที่ได้จากการรันคำสั่งในข้อ 3

![Screenshot 2024-03-23 153625](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-08/assets/144195697/f0fe7515-2808-4ca6-b4cb-673053b7a09d)

โปรแกรม Build ได้เพราะเมื่อสร้าง DerivedClass object จะมีการเรียก constructor ของ BaseClass2 ซึ่ง constructor ของ BaseClass2 จะเรียก constructor ของ BaseClass1

### ผลที่ได้จากการรันคำสั่งในข้อ 5

![Screenshot 2024-03-23 153628](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-08/assets/144195697/f0a53d9c-24e4-4a0e-9d58-fac9562801d1)

โปรแกรม Run ได้เพราะเมื่อสร้าง DerivedClass object จะมีการเรียก constructor ของ BaseClass2 ซึ่ง constructor ของ BaseClass2 จะเรียก constructor ของ BaseClass1

### สิ่งที่พบในการทดลอง
- โปรแกรม Build และ Run ได้เพราะเมื่อสร้าง DerivedClass object จะมีการเรียก constructor ของ BaseClass2 ซึ่ง constructor ของ BaseClass2 จะเรียก constructor ของ BaseClass1
- ผลลัพท์ที่ได้ คือ
  - This is BaseClass1
  - This is BaseClass2
  - This is DerivedClass

