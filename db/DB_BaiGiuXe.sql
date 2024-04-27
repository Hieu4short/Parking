CREATE DATABASE BaiGiuXe
GO

USE BaiGiuXe
GO

CREATE TABLE TaiKhoan (
	id INT IDENTITY PRIMARY KEY,
	TenHienThi NVARCHAR(100),
	TenDangNhap NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL,
	LoaiTaiKhoan INT
);

INSERT INTO TaiKhoan (TenHienThi, TenDangNhap, MatKhau, LoaiTaiKhoan) VALUES (N'Hiếu', N'MH123', N'123', N'1');
INSERT INTO TaiKhoan (TenHienThi, TenDangNhap, MatKhau, LoaiTaiKhoan) VALUES (N'admin', N'admin', N'1', N'1');
SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = N'MH123' And MatKhau = N'123';
SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = N'admin' And MatKhau = N'1';

/*B?ng "LoaiXe" (Lo?i Xe): 
MaLoaiXe (INT, PRIMARY KEY): Khóa chính, ??nh danh duy nh?t cho m?i lo?i xe. TenLoaiXe (VARCHAR): Tên c?a lo?i xe (ví d?: "Xe ??p", "Xe g?n máy"). 
DonGiaGuiXe (DECIMAL): ??n giá g?i xe cho m?i lo?i xe.*/

CREATE TABLE LoaiXe (
	id INT IDENTITY PRIMARY KEY,
    MaLoaiXe NVARCHAR(20),
    TenLoaiXe NVARCHAR(50) NOT NULL,
    DonGiaGuiXe DECIMAL(10, 2) NOT NULL
);

INSERT INTO LoaiXe (MaLoaiXe, TenLoaiXe, DonGiaGuiXe) VALUES (N'xemay', N'Xe Máy', 3000);
INSERT INTO LoaiXe (MaLoaiXe, TenLoaiXe, DonGiaGuiXe) VALUES (N'xedap', N'Xe Đạp', 1000);
ALTER TABLE LoaiXe ALTER COLUMN MaLoaiXe NVARCHAR(20);
ALTER TABLE LoaiXe ALTER COLUMN TenLoaiXe NVARCHAR(20);
UPDATE LoaiXe SET TenLoaiXe = 'Xe đạp' WHERE id = 7;


SELECT * FROM LoaiXe;

/*B?ng "TheGuiXe" (Th? G?i Xe): 
MaTheGuiXe (INT, PRIMARY KEY): Khóa chính, ??nh danh duy nh?t cho m?i th? g?i xe. MaSoThe (VARCHAR): Mã s? th? g?i xe. 
TrangThaiThe (VARCHAR): Tr?ng thái th? (ví d?: "?ang s? d?ng", "Không còn s? d?ng").*/


CREATE TABLE TheGuiXe (
	id INT IDENTITY PRIMARY KEY,
    MaSoThe NVARCHAR(20) NOT NULL,
    TrangThaiThe NVARCHAR(20) NOT NULL,
	TinhTrangThe NVARCHAR(20)
);
DECLARE @IdTheGuiXe INT;
INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES ('XYZ678', N'Đang sử dụng', 'Tốt');
INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES ('ABC345', N'Đang sử dụng', 'Tốt');
INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES ('QWT567', N'Đang sử dụng', 'Tốt');
INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES ('DFT381', N'Trống', N'Tốt');
INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES ('FJR174', N'Trống', N'Tốt');
INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES ('FKY109', N'Trống', N'Tốt');
INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES ('ZPQ192', N'Trống', N'Tốt');
SELECT @IdTheGuiXe = SCOPE_IDENTITY();
SELECT * FROM TheGuiXe;

/*B?ng "NhanXe" (Nh?n Xe): 
MaNhanXe (INT, PRIMARY KEY): Khóa chính, ??nh danh duy nh?t cho m?i l?n nh?n xe. MaTheGuiXe (INT, FOREIGN KEY): Khóa ngo?i liên k?t v?i b?ng "TheGuiXe", ?? theo dõi th? g?i xe. 
NgayNhanXe DATE: Ngày nh?n xe. 
HinhAnhTrichXuat LONGBLOB: D? li?u hình ?nh trích xu?t t? webcam.*/
*/lỗi khi cập nhật cơ sở dữ liệu: conversion failed when converting the nvarchar value 'System.Data.DataRowView' to data type int*/



CREATE TABLE LuotGuiXe (
	id INT IDENTITY PRIMARY KEY,
	IdLoaiXe INT,
	DinhDanhXe NVARCHAR(10),
    IdTheGuiXe INT,
    ThoiGianNhanXe DATETIME DEFAULT GETDATE(),
	ThoiGianTraXe DATETIME,
	TrangThai NVARCHAR(20),
    HinhAnhTrichXuat VARBINARY(MAX),
    FOREIGN KEY (IdTheGuiXe) REFERENCES dbo.TheGuiXe(id),
	FOREIGN KEY (IdLoaiXe) REFERENCES dbo.LoaiXe(id)
);

/*ALTER TABLE LuotGuiXe ALTER COLUMN IdLoaiXe NVARCHAR(20);*/


INSERT INTO LuotGuiXe (IdLoaiXe, DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, TrangThai) VALUES ('6', '65B137986', 2, '2024-03-20 12:45:31', '2024-03-20 14:45:11', 'Đã trả xe');
INSERT INTO LuotGuiXe (IdLoaiXe, DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, TrangThai) VALUES ('6', '65B116886', 3, '2024-03-20 11:21:11', '2024-03-20 13:57:33', 'Đã trả xe');
SELECT * FROM LuotGuiXe;

ALTER TABLE LuotGuiXe
DROP CONSTRAINT FK__LuotGuiXe__IdThe__38996AB5;

ALTER TABLE LuotGuiXe
ADD CONSTRAINT FK__LuotGuiXe__IdThe__38996AB5
FOREIGN KEY (IdTheGuiXe)
REFERENCES TheGuiXe(id)
ON DELETE CASCADE;



/*B?ng "DoanhThu" (Doanh Thu): 
NgayThucHien DATE (PRIMARY KEY): Ngày th?c hi?n ghi nh?n doanh thu. 
DoanhThu DECIMAL: S? ti?n doanh thu trong ngày.*/

CREATE TABLE DoanhThu (
	id INT IDENTITY PRIMARY KEY,
    NgayThucHien DATETIME DEFAULT GETDATE(),
    DoanhThu DECIMAL(15, 2) NOT NULL,
	IdLuotGuiXe INT,
	FOREIGN KEY (IdLuotGuiXe) REFERENCES dbo.LuotGuiXe(id)
);

INSERT INTO DoanhThu (NgayThucHien, DoanhThu) VALUES ('2024-03-20 15:29:21', 3000);
INSERT INTO DoanhThu (NgayThucHien, DoanhThu) VALUES ('2024-03-20 14:45:11', 2000);
INSERT INTO DoanhThu (NgayThucHien, DoanhThu, IdLuotGuiXe) VALUES (GETDATE(), 2000, 3);
SELECT * FROM DoanhThu;
SELECT DoanhThu.NgayThucHien, DoanhThu.DoanhThu, LuotGuiXe.IdLoaiXe, LuotGuiXe.DinhDanhXe, LuotGuiXe.IdTheGuiXe, LuotGuiXe.ThoiGianNhanXe, LuotGuiXe.ThoiGianTraXe, LuotGuiXe.HinhAnhTrichXuat, LuotGuiXe.TrangThai
                         FROM DoanhThu 
                         INNER JOIN LuotGuiXe ON DoanhThu.IdLuotGuiXe = LuotGuiXe.id;


SELECT DATABASEPROPERTYEX('LoaiXe', 'Collation') AS DatabaseCollation;
ALTER DATABASE BaiGiuXe COLLATE Vietnamese_CS_AS;

INSERT INTO LuotGuiXe (IdLoaiXe, DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, TrangThai) VALUES (6, N'65B137986', 2, '2024-03-20 12:45:31', '2024-03-20 14:45:11', N'Đã trả xe');
SELECT * FROM LuotGuiXe ORDER BY id DESC;

SELECT LuotGuiXe.*, LoaiXe.TenLoaiXe FROM LuotGuiXe JOIN LoaiXe ON LuotGuiXe.IdLoaiXe = LoaiXe.id WHERE LuotGuiXe.TrangThai = N'Đã nhận xe' ORDER BY id DESC;