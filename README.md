# Shop
# תיאור הפרויקט
## ישויות
- הזמנה
- ספק
- מוצר
## מיפוי ROUTES  להזמנה
 - שליפת רשימת הזמנות 
GET https://localhost:7211/api/Order
- שליפת עובד לפי הזמנה
 GET https://localhost:7211/api/Order/1
- הוספת הזמנה
POST  https://localhost:7211/api/Order
- עדכון הזמנה
PUT https://localhost:7211/api/Order/1
- מחיקת הזמנה
DELETE https://localhost:7211/api/Order/1
##  מיפוי ROUTES  ספק
 - שליפת רשימת ספקים
GET https://localhost:7211/api/Provider
- שליפת ספק לפי מזהה
 GET   https://localhost:7211/api/Provider/1
- הוספת ספק
POST  https://localhost:7211/api/Provider
- עדכון ספק
PUT  https://localhost:7211/api/Provider/1
- מחיקת ספק
DELETE   https://localhost:7211/api/Provider/1
##   מיפוי ROUTES  מוצר
 - שליפת רשימת מוצרים
GET https://localhost:7211/api/Product
- שליפת מוצר  לפי מזהה
 GET   https://localhost:7211/api/Product/12
- הוספת מוצר
POST  https://localhost:7211/api/Product
- עדכון מוצר
PUT https://localhost:7211/api/Product/1
- עדכון מחיר מוצר 
PUT https://localhost:7211/api/Product/1/price
-  מחיקת מוצר
DELETE   https://localhost:7211/api/Product/1
