﻿﻿-- Đồ án Nhập môn CNPM
-- Quản lý Khách sạn

-- Tạo database
CREATE DATABASE QLKS;
GO
USE QLKS;
GO

-- Tao bang LOAIPHONG
CREATE TABLE LOAIPHONG (
	MALPH char(4) PRIMARY KEY, -- Mã loại phòng : LP01, LP02, LP03, …
	TENLPH char(1),			   -- Tên loại phòng : A, B, C
	GIA money,				   -- Giá loại phòng
	GHICHU varchar(50),		   -- Ghi chú
	SOLUONG int				   -- Số lượng phòng trong loại phòng này
)

-- Tao bang PHONG
CREATE TABLE PHONG (
	MAPH char(4) PRIMARY KEY,   -- Mã phòng : P102, P203, …
	TRANGTHAI varchar(15),		-- Trạng thái phòng : trống, không trống, sửa chữa, dọn dẹp
	LAU tinyint,				-- Lầu : 5 
	MALPH char(4),
	CONSTRAINT FK_MALPH FOREIGN KEY (MALPH) REFERENCES LOAIPHONG(MALPH)
)

-- Tao bang NHANVIEN
CREATE TABLE NHANVIEN (
	MANV char(4) PRIMARY KEY,   -- Mã nhân viên
	HOTEN varchar(40),			-- Họ và tên 
	GIOITINH varchar(3),		-- Giới tính
	SDT varchar(12),			-- Số điện thoại
	EMAIL varchar(50),			-- Địa chỉ email
	DIACHI varchar(50),			-- Địa chỉ nhân viên
	NGVL smalldatetime,			-- Ngày vào làm
	LUONG money,				-- Lương của nhân viên
	MAQUANLY char(4)			-- Mã người quản lý
)

-- Tao bang KHACHHANG
CREATE TABLE KHACHHANG (
	MAKH char(4) PRIMARY KEY,	-- Mã khách hàng
	HOTEN varchar(40),			-- Họ tên khách hàng
	GIOITINH varchar(3),		-- Giới tính
	CMND varchar(12),			-- CMND
	SDT varchar(12),			-- Số điện thoại
	EMAIL varchar(50),			-- Địa chỉ email
	DIACHI varchar(50),			-- Địa chỉ khách hàng
	LOAIKH varchar(20)			-- Loại khách hàng
)

-- Tao bang LOAIDICHVU
CREATE TABLE LOAIDICHVU (
	MALDV char(4) PRIMARY KEY,	-- Mã Loại Dịch vụ
	TENDV varchar(20),			-- Tên dịch vụ
	MOTA varchar(40),			-- Mô tả dịch vụ
	DONGIA money				-- Đơn giá dịch vụ
)

-- Tao bang THUEPHONG 
CREATE TABLE THUEPHONG (
	MATP char(4) PRIMARY KEY,	-- Mã thuê phòng
	MAPH char(4),				-- Mã phòng
	MAKH char(4),				-- Mã khách hàng
	MANV char(4),				-- Mã nhân viên
	NGTHUE smalldatetime,		-- Ngày thuê phòng
	NGTRAPHONG smalldatetime,	-- Ngày trả phòng
	CONSTRAINT FK_MAPH FOREIGN KEY (MAPH) REFERENCES PHONG(MAPH),
	CONSTRAINT FK_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_MANV1 FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

--Tao bang HOADON
CREATE TABLE HOADON (
	MAHD char(4) PRIMARY KEY,	-- Mã hóa đơn
	NGLAP smalldatetime,		-- Ngày lập hóa đơn
	TONGTIEN money,				-- Tổng tiền
	MANV char(4),				-- Mã nhân viên
	MATP char(4),				-- Mã thuê phòng
	CONSTRAINT FK_MANV2 FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_MATP FOREIGN KEY (MATP) REFERENCES THUEPHONG(MATP)
)

-- Tao bang DICHVU
CREATE TABLE DICHVU ( 
	MADV char(4) PRIMARY KEY,	-- Mã Dịch vụ
	MALDV char(4),				-- Mã Loại Dịch vụ
	MATP char(4),				-- Mã Phòng Thuê
	NGBATDAUDV smalldatetime,	-- Ngày bắt đầu dịch vụ
	NGKETTHUCDV smalldatetime,	-- Ngày kết thúc dịch vụ
	SOLUONGDV int,				-- Số lượng dịch vụ
	TONGTIENDV money,			-- Tổng tiền dịch vụ
	CONSTRAINT FK_MALDV FOREIGN KEY (MALDV) REFERENCES LOAIDICHVU(MALDV)
)

-- Tao bang THAMSO
CREATE TABLE THAMSO (
	DoTuoiToiThieu tinyint,		-- Độ tuổi tối thiểu thuê phòng
	GiaLoaiA money,				-- Giá loại phòng A
	GiaLoaiB money,				-- Giá loại phòng B
	GiaLoaiC money,				-- Giá loại phòng C
	GiaLoaiX money,				-- Giá loại dịch vụ X
	GiaLoaiY money,				-- Giá loại dịch vụ Y
	GiaLoaiZ money				-- Giá loại dịch vụ Z
)

INSERT INTO THAMSO VALUES ('18','150000','170000','220000','50000','70000','100000');