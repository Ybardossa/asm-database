-- Ensure the login does not already exist
IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'MyLogin')
BEGIN
    CREATE LOGIN MyLogin WITH PASSWORD = 'MyPassword';
END

-- Use the ThucTap database and create a user for the login
USE ThucTap;
IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = 'MyUser')
BEGIN
    CREATE USER MyUser FOR LOGIN MyLogin;
    EXEC sp_addrolemember 'db_owner', 'MyUser';
END

-- Check the server principals
SELECT name, type_desc FROM sys.server_principals WHERE name = 'MyLogin';

-- Create the ThucTap database if it does not exist
IF DB_ID('ThucTap') IS NULL
BEGIN
    CREATE DATABASE ThucTap;
END

USE ThucTap;

-- Create tables if they do not exist
IF OBJECT_ID('TBLKhoa', 'U') IS NULL
BEGIN
  CREATE TABLE TBLKhoa (
    Makhoa CHAR(10) PRIMARY KEY,
    Tenkhoa CHAR(30) NOT NULL,
    Dienthoai CHAR(10) CHECK (Dienthoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
END

IF OBJECT_ID('TBLGiangVien', 'U') IS NULL
BEGIN
    CREATE TABLE TBLGiangVien (
    Magv INT PRIMARY KEY,
    Hotengv CHAR(30) NOT NULL,
    Luong DECIMAL(7, 2) CHECK (Luong >= 0),
    Makhoa CHAR(10) NOT NULL,
    FOREIGN KEY (Makhoa) REFERENCES TBLKhoa(Makhoa)
);
END

IF OBJECT_ID('TBLSinhVien', 'U') IS NULL
BEGIN
   CREATE TABLE TBLSinhVien (
    Masv INT PRIMARY KEY,
    Hotensv CHAR(40) NOT NULL,
    Makhoa CHAR(10) NOT NULL,
    Namsinh INT CHECK (Namsinh >= 1900 AND Namsinh <= YEAR(GETDATE())),
    Quequan CHAR(30) NOT NULL,
    FOREIGN KEY (Makhoa) REFERENCES TBLKhoa(Makhoa)
);
END

IF OBJECT_ID('TBLDeTai', 'U') IS NULL
BEGIN
 CREATE TABLE TBLDeTai (
    Madt CHAR(10) PRIMARY KEY,
    Tendt CHAR(30) NOT NULL,
    Kinhphi INT CHECK (Kinhphi >= 0),
    Noithuctap CHAR(30) NOT NULL,
    Makhoa CHAR(10) NOT NULL,
    Status CHAR(10) CHECK (Status IN ('Done', 'Pending')),
    Semester CHAR(10) NOT NULL,
    Magv INT NOT NULL,
    FOREIGN KEY (Makhoa) REFERENCES TBLKhoa(Makhoa),
    FOREIGN KEY (Magv) REFERENCES TBLGiangVien(Magv)
);
END

IF OBJECT_ID('TBLHuongDan', 'U') IS NULL
BEGIN
    CREATE TABLE TBLHuongDan (
        Masv INT,
        Madt CHAR(10),
        Magv INT,
        KetQua DECIMAL(5, 2),
        PRIMARY KEY (Masv, Madt),
        FOREIGN KEY (Masv) REFERENCES TBLSinhVien(Masv),
        FOREIGN KEY (Madt) REFERENCES TBLDeTai(Madt),
        FOREIGN KEY (Magv) REFERENCES TBLGiangVien(Magv)
    );
END

-- Insert data into TBLKhoa
IF NOT EXISTS (SELECT 1 FROM TBLKhoa WHERE Makhoa = 'K01')
BEGIN
    INSERT INTO TBLKhoa (Makhoa, Tenkhoa, Dienthoai) VALUES ('K01', 'Computer Science', '1234567890');
END

IF NOT EXISTS (SELECT 1 FROM TBLKhoa WHERE Makhoa = 'K02')
BEGIN
    INSERT INTO TBLKhoa (Makhoa, Tenkhoa, Dienthoai) VALUES ('K02', 'Mathematics', '0987654321');
END

-- Alter table TBLGiangVien to ensure the column Luong is correct
ALTER TABLE TBLGiangVien ALTER COLUMN Luong DECIMAL(7, 2);

-- Insert data into TBLGiangVien
IF NOT EXISTS (SELECT 1 FROM TBLGiangVien WHERE Magv = 1)
BEGIN
    INSERT INTO TBLGiangVien (Magv, Hotengv, Luong, Makhoa) VALUES (1, 'Nguyen Van A', 5000.00, 'K01');
END

IF NOT EXISTS (SELECT 1 FROM TBLGiangVien WHERE Magv = 2)
BEGIN
    INSERT INTO TBLGiangVien (Magv, Hotengv, Luong, Makhoa) VALUES (2, 'Tran Thi B', 6000.00, 'K02');
END

-- Insert data into TBLSinhVien
IF NOT EXISTS (SELECT 1 FROM TBLSinhVien WHERE Masv = 101)
BEGIN
    INSERT INTO TBLSinhVien (Masv, Hotensv, Makhoa, Namsinh, Quequan) VALUES (101, 'Le Van C', 'K01', 2000, 'Hanoi');
END

IF NOT EXISTS (SELECT 1 FROM TBLSinhVien WHERE Masv = 102)
BEGIN
    INSERT INTO TBLSinhVien (Masv, Hotensv, Makhoa, Namsinh, Quequan) VALUES (102, 'Pham Thi D', 'K02', 1999, 'Saigon');
END

-- Insert data into TBLDeTai
IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T01')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Status, Semester) VALUES ('T01', 'AI Research', 10000, 'FPT', 'Done', 'current_semester');
END

IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T02')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Status, Semester) VALUES ('T02', 'Data Analysis', 15000, 'FPT', 'Pending', 'current_semester');
END

-- Insert data into TBLHuongDan
IF NOT EXISTS (SELECT 1 FROM TBLHuongDan WHERE Masv = 101 AND Madt = 'T01')
BEGIN
    INSERT INTO TBLHuongDan (Masv, Madt, Magv, KetQua) VALUES (101, 'T01', 1, 9.5);
END

IF NOT EXISTS (SELECT 1 FROM TBLHuongDan WHERE Masv = 102 AND Madt = 'T02')
BEGIN
    INSERT INTO TBLHuongDan (Masv, Madt, Magv, KetQua) VALUES (102, 'T02', 2, 8.7);
END

-- Create Users table and insert admin user
IF OBJECT_ID('Users', 'U') IS NULL
BEGIN
  CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(50) NOT NULL CHECK (LEN(Password) >= 6)
);
    INSERT INTO Users (Username, Password) VALUES ('admin', '123');
END

-- Ensure the necessary columns are present in the TBLDeTai table
IF COL_LENGTH('TBLDeTai', 'Makhoa') IS NULL
BEGIN
    ALTER TABLE TBLDeTai ADD Makhoa CHAR(10);
END

IF COL_LENGTH('TBLDeTai', 'Status') IS NULL
BEGIN
    ALTER TABLE TBLDeTai ADD Status CHAR(10);
END

IF COL_LENGTH('TBLDeTai', 'Semester') IS NULL
BEGIN
    ALTER TABLE TBLDeTai ADD Semester CHAR(10);
END

IF COL_LENGTH('TBLDeTai', 'Magv') IS NULL
BEGIN
    ALTER TABLE TBLDeTai ADD Magv INT;
END

-- Insert data into TBLDeTai with the new columns
IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T01')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Makhoa, Status, Semester, Magv) 
    VALUES ('T01', 'AI Research', 10000, 'FPT', 'K01', 'Done', '2024S1', 1);
END

IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T02')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Makhoa, Status, Semester, Magv) 
    VALUES ('T02', 'Data Analysis', 15000, 'FPT', 'K02', 'Pending', '2024S1', 2);
END

-- Additional entries for more diverse data
IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T03')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Makhoa, Status, Semester, Magv) 
    VALUES ('T03', 'Machine Learning', 20000, 'FPT', 'K01', 'Done', '2024S2', 1);
END

IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T04')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Makhoa, Status, Semester, Magv) 
    VALUES ('T04', 'Blockchain', 18000, 'FPT', 'K02', 'Pending', '2024S2', 2);
END

IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T05')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Makhoa, Status, Semester, Magv) 
    VALUES ('T05', 'Cybersecurity', 22000, 'FPT', 'K01', 'Done', '2024S2', 1);
END

IF NOT EXISTS (SELECT 1 FROM TBLDeTai WHERE Madt = 'T06')
BEGIN
    INSERT INTO TBLDeTai (Madt, Tendt, Kinhphi, Noithuctap, Makhoa, Status, Semester, Magv) 
    VALUES ('T06', 'Big Data', 25000, 'FPT', 'K02', 'Pending', '2024S2', 2);
END

-- Statistical queries
SELECT COUNT(*) FROM TBLDeTai WHERE Status = 'Done' AND Semester = '2024S1';
SELECT COUNT(*) FROM TBLDeTai WHERE Status = 'Pending' AND Semester = '2024S1';

SELECT COUNT(*) FROM TBLDeTai WHERE Status = 'Done' AND Semester = '2024S2';
SELECT COUNT(*) FROM TBLDeTai WHERE Status = 'Pending' AND Semester = '2024S2';

SELECT TBLKhoa.Tenkhoa, COUNT(TBLDeTai.Madt) AS NumberOfTopics
FROM TBLDeTai
JOIN TBLKhoa ON TBLDeTai.Makhoa = TBLKhoa.Makhoa
WHERE Semester = '2024S2'
GROUP BY TBLKhoa.Tenkhoa
ORDER BY NumberOfTopics DESC
OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY;

SELECT TBLGiangVien.Hotengv, COUNT(TBLDeTai.Madt) AS NumberOfTopics
FROM TBLDeTai
JOIN TBLGiangVien ON TBLDeTai.Magv = TBLGiangVien.Magv
WHERE Semester = '2024S2'
GROUP BY TBLGiangVien.Hotengv
ORDER BY NumberOfTopics DESC
OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY;

-- Verify the data
SELECT * FROM TBLKhoa;
SELECT * FROM TBLGiangVien;
SELECT * FROM TBLSinhVien;
SELECT * FROM TBLDeTai;
SELECT * FROM TBLHuongDan;
SELECT * FROM Users;