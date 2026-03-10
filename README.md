# Employee Photo Viewer

A C# Windows Forms application that displays employee photos based on Employee ID.

## Features
- Search employee by ID
- Display employee photo
- Connected to MySQL database (XAMPP)

## Technologies
- C# Windows Forms
- MySQL
- XAMPP
- MySql.Data Connector

## Database Structure

Database: `employee_db`

Table: `employees`

| employee_id | name | photo_path |
|-------------|------|-----------|
| 1001 | Andi | photos/1001.jpg |
| 1002 | Lala | photos/1002.jpg |
| 1003 | Citra | photos/1003.jpg |
| 1004 | Dina | photos/1004.jpg |
| 1005 | Eka | photos/1005.jpg |

## Folder Structure
EmployeePhotoViewer
│
├ photos
│ ├ 1001.jpg
│ ├ 1002.jpg
│ ├ 1003.jpg
│ ├ 1004.jpg
│ └ 1005.jpg
│
├ Form1.cs
├ Program.cs

## How to Run
1. Start XAMPP (MySQL)
2. Import database `employee_db`
3. Run the project in Visual Studio
4. Enter Employee ID to display the photo
