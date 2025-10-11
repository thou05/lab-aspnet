create database lab09shopingcart

use lab09shopingcart

-- 1. Bảng QUAN_TRI
CREATE TABLE QUAN_TRI (
    ID INT IDENTITY PRIMARY KEY,
    TaiKhoan NVARCHAR(50) NOT NULL,
    MatKhau NVARCHAR(50) NOT NULL,
    TrangThai NVARCHAR(20)
);

-- 2. Bảng KHACH_HANG
CREATE TABLE KHACH_HANG (
    ID INT IDENTITY PRIMARY KEY,
    MaKhachHang CHAR(10) UNIQUE NOT NULL,
    HoTenKhachHang NVARCHAR(100),
    Email NVARCHAR(100),
    MatKhau NVARCHAR(50),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(200),
    NgayDangKy DATE,
    TrangThai NVARCHAR(20)
);

-- 3. Bảng LOAI_SAN_PHAM
CREATE TABLE LOAI_SAN_PHAM (
    ID INT IDENTITY PRIMARY KEY,
    MaLoai CHAR(10) UNIQUE NOT NULL,
    TenLoai NVARCHAR(100),
    TrangThai NVARCHAR(20)
);

-- 4. Bảng SAN_PHAM
CREATE TABLE SAN_PHAM (
    ID INT IDENTITY PRIMARY KEY,
    MaSanPham CHAR(10) UNIQUE NOT NULL,
    TenSanPham NVARCHAR(100),
    HinhAnh NVARCHAR(200),
    SoLuong INT,
    DonGia DECIMAL(18,2),
    MaLoai CHAR(10) FOREIGN KEY REFERENCES LOAI_SAN_PHAM(MaLoai),
    TrangThai NVARCHAR(20)
);

-- 5. Bảng HOA_DON
CREATE TABLE HOA_DON (
    ID INT IDENTITY PRIMARY KEY,
    MaHoaDon CHAR(10) UNIQUE NOT NULL,
    MaKhachHang CHAR(10) FOREIGN KEY REFERENCES KHACH_HANG(MaKhachHang),
    NgayHoaDon DATE,
    NgayNhan DATE,
    HoTenKhachHang NVARCHAR(100),
    Email NVARCHAR(100),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(200),
    TongTriGia DECIMAL(18,2),
    TrangThai NVARCHAR(20)
);

-- 6. Bảng CT_HOA_DON
CREATE TABLE CT_HOA_DON (
    ID INT IDENTITY PRIMARY KEY,
    HoaDonID CHAR(10) FOREIGN KEY REFERENCES HOA_DON(MaHoaDon),
    SanPhamID CHAR(10) FOREIGN KEY REFERENCES SAN_PHAM(MaSanPham),
    SoLuongMua INT,
    DonGiaMua DECIMAL(18,2),
    ThanhTien AS (SoLuongMua * DonGiaMua),
    TrangThai NVARCHAR(20)
);

-- QUAN_TRI
INSERT INTO QUAN_TRI (TaiKhoan, MatKhau, TrangThai)
VALUES ('admin', '123456', 'Hoạt động');

-- KHACH_HANG
INSERT INTO KHACH_HANG (MaKhachHang, HoTenKhachHang, Email, MatKhau, DienThoai, DiaChi, NgayDangKy, TrangThai)
VALUES 
('KH001', N'Nguyễn Văn A', 'a@gmail.com', '123', '0901234567', N'Hà Nội', '2025-01-01', 'Hoạt động');

-- LOAI_SAN_PHAM
INSERT INTO LOAI_SAN_PHAM (MaLoai, TenLoai, TrangThai)
VALUES 
('L01', N'Điện thoại', 'Hoạt động'),
('L02', N'Laptop', 'Hoạt động');

-- SAN_PHAM
INSERT INTO SAN_PHAM (MaSanPham, TenSanPham, HinhAnh, SoLuong, DonGia, MaLoai, TrangThai)
VALUES 
('SP001', N'iPhone 15', 'iphone.jpg', 10, 25000000, 'L01', 'Còn hàng'),
('SP002', N'MacBook Air', 'macbook.jpg', 5, 35000000, 'L02', 'Còn hàng');

-- HOA_DON
INSERT INTO HOA_DON (MaHoaDon, MaKhachHang, NgayHoaDon, NgayNhan, HoTenKhachHang, Email, DienThoai, DiaChi, TongTriGia, TrangThai)
VALUES
('HD001', 'KH001', '2025-02-01', '2025-02-03', N'Nguyễn Văn A', 'a@gmail.com', '0901234567', N'Hà Nội', 60000000, 'Đã thanh toán');

-- CT_HOA_DON
INSERT INTO CT_HOA_DON (HoaDonID, SanPhamID, SoLuongMua, DonGiaMua, TrangThai)
VALUES
('HD001', 'SP001', 1, 25000000, 'Hoạt động'),
('HD001', 'SP002', 1, 35000000, 'Hoạt động');

