# Exercise 9.1
![Ex9 1](https://github.com/65030179179Pattarapon/03376836-OOP-2566-Lab-08/assets/144198506/727cd585-4a17-4bd8-b0c4-9a677a392ab6)

# Exercise 9.2
![Ex9 2](https://github.com/65030179179Pattarapon/03376836-OOP-2566-Lab-08/assets/144198506/daa22788-1b69-40b2-8894-6eb8d2160c55)

##
#### 
ในการทดลองนี้ เราสร้างคลาส DerivedClass ซึ่งสืบทอดจาก BaseClass และกำหนดตัวแปร Hello ใหม่ใน DerivedClass โดยใช้คีย์เวิร์ด new เพื่อแสดงว่าเรากำลังซ่อนตัวแปร Hello ใน BaseClass ดังนั้น Hello ใน DerivedClass จะไม่ได้ส่งผลต่อ Hello ใน BaseClass จากนั้น เราสร้างเมธอด PrintBaseHello ใน DerivedClass เพื่อพิมพ์ค่าของ Hello ใน BaseClass โดยใช้ base.Hello เพื่อเข้าถึง Hello ใน BaseClass ผลลัพธ์ที่พิมพ์ออกทางหน้าจอจะเป็น "Hello From BaseClass" ตามค่าที่กำหนดใน BaseClass แม้ว่าเราจะกำหนดค่าใหม่ใน Hello ใน DerivedClass แต่ PrintBaseHello ใช้ base.Hello ซึ่งจะใช้ค่าจาก Hello ใน BaseClass
