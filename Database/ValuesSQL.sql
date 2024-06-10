insert into PHONG values 
('P101', N'Trống',1, 'LP01'), 
('P102', N'Trống',1, 'LP01'),
('P103', N'Trống',1, 'LP01'),
('P104', N'Trống',1, 'LP01'),
('P105', N'Trống',1, 'LP01'),
('P106', N'Trống',1, 'LP01'),
('P107', N'Trống',1, 'LP01'),
('P108', N'Trống',1, 'LP01'),
('P109', N'Trống',1, 'LP01'),
('P110', N'Trống',1, 'LP01'),
('P201', N'Trống',2, 'LP01'),
('P202', N'Trống',2, 'LP01'),
('P203', N'Trống',2, 'LP01'),
('P204', N'Trống',2, 'LP01'),
('P205', N'Trống',2, 'LP01'),
('P206', N'Trống',2, 'LP02'),
('P207', N'Trống',2, 'LP02'),
('P208', N'Trống',2, 'LP02'),
('P209', N'Trống',2, 'LP02'),
('P301', N'Trống',3, 'LP02'),
('P302', N'Trống',3, 'LP02'),
('P303', N'Trống',3, 'LP02'),
('P304', N'Trống',3, 'LP02'),
('P305', N'Trống',3, 'LP02'),
('P306', N'Trống',3, 'LP02'),
('P307', N'Trống',3, 'LP02'),
('P308', N'Trống',3, 'LP02'),
('P401', N'Trống',1, 'LP02'),
('P402', N'Trống',4, 'LP03'),
('P403', N'Trống',4, 'LP03'),
('P404', N'Trống',4, 'LP03'),
('P405', N'Trống',4, 'LP03'),
('P406', N'Trống',4, 'LP03');



INSERT INTO LOAIPHONG (MaLPH, TenLPH, Gia, Ghichu, Soluong)
VALUES ('LP01', 'A', 150000, N'Phòng đơn', 20),
       ('LP02', 'B', 170000, N'Phòng đôi', 15),
       ('LP03', 'C', 200000, N'Phòng gia đình', 10);


INSERT INTO LOAIDICHVU VALUES('LDV1',N'Giặt ủi quần áo',N'<= 2kg: 40k, >2kg phụ thu thêm 25k/kg.','40000');
INSERT INTO LOAIDICHVU VALUES('LDV2',N'Cho thuê xe máy',N'Chi phí thuê: 150k/ngày.','150000');
INSERT INTO LOAIDICHVU VALUES('LDV3',N'Thu đổi ngoại tệ',N'Tối đa 10.000.000vnđ, thu phí 2%.','1000000');
INSERT INTO LOAIDICHVU VALUES('LDV4',N'Đón khách',N'Miễn phí < 5km, > 6 km phụ thu 10.000/km','10000');
INSERT INTO LOAIDICHVU VALUES('LDV5',N'Buffet sáng',N'Khung giờ phụ vụ: 6h30-9h30 mỗi ngày.','50000');


INSERT INTO NHANVIEN VALUES('NV1', N'Trịnh Thị Lan Anh', N'Nữ', '22520083', '22520083@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')
INSERT INTO NHANVIEN VALUES('NV2', N'Trương Huỳnh Thuý An ', N'Nữ', '22520033', '22520033@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')
INSERT INTO NHANVIEN VALUES('NV3', N'Huỳnh Thị Hải Châu ', N'Nữ', '22520148', '22520148@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')
INSERT INTO NHANVIEN VALUES('NV4', N'Nguyễn Thị Thanh Tuyền', N'Nữ', '22521632', '22521632@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')
INSERT INTO NHANVIEN VALUES('NV5', N'Tăng Mỹ Hân  ', N'Nữ', '22520395', '22520395@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')
