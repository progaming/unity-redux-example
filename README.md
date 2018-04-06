## โครงสร้างโฟลเดอร์ของแต่ละซีน
-- **Actions**  
-- **States**   
-- Redux.cs

## การสร้าง Action หรือ State ใหม่
1. ตั้งชื่อ namespace ให้สอดคล้องกับ path ของโฟลเดอร์
2. เมื่อสร้าง Action หรือ State แล้ว ให้นำ class ไปเพิ่มในไฟล์ Redux.cs ด้วย
3. ภายใน scene ต้องมี game object ที่มี component Redux แปะอยู่
4. class View ที่ต้องการเข้าถึง Redux ให้ประกาศตัวแปร public เพื่อมารับ Redux ไปใช้งาน