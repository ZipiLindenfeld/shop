# Shop
# תיאור הפרויקט
## ישויות
- עובד
- ספק
- מוצר
## מיפוי ROUTES  לעובד
 - שליפת רשימת עובדים 
GET https://localhost:7211/api/Employee
- שליפת עובד לפי מזהה
 GET https://localhost:7211/api/Employee/1
- הוספת עובד
POST  https://localhost:7211/api/Employee
- עדכון עובד
PUT https://localhost:7211/api/Employee/1
- מחיקת עובד
DELETE https://localhost:7211/api/Employee/1
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
- שליפת מוצר  לפי מחיר
 GET   https://localhost:7211/api/Product/12
- הוספת מוצר
POST  https://localhost:7211/api/Product
- עדכון מוצר
PUT https://localhost:7211/api/Product/1
- עדכון מחיר מוצר 
PUT https://localhost:7211/api/Product/1/12
-  מחיקת מוצר
DELETE   https://localhost:7211/api/Product/1
