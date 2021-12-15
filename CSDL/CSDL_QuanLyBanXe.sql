Create database CSDL_QuanLyBanXe

go
Use CSDL_QuanLyBanXe

go
Create Table NhanVien(
	MaNV varchar(10) Constraint PK_EmpKey Primary Key,
	HoTen nvarchar(250),
	NgaySinh date,
	Gioitinh nvarchar(4),
	DiaChi nvarchar(255),
	Email varchar(50),
	SoDienThoai varchar(11),
	Luong int,
	NgayVaoLam date default GETDATE(),
	HinhAnh image
);

Create Table KhachHang(
	MaKH varchar(10) Constraint PK_CusKey Primary Key,
	TenKH nvarchar(255) not null,
	DiaChi nvarchar(255),
	ThanhPho nvarchar(50),
	SoDienThoai varchar(11)
);

Create Table HoaDon(
	MaHD varchar(10) Constraint PK_RecptKey Primary Key,
	MaNV varchar(10) References NhanVien(MaNV) not null,
	MaKH varchar(10) References KhachHang(MaKH) not null,
	NgayLapHD date default GETDATE(),
	NgayNhanHang date
);

Create Table SanPham (
	MaXe varchar(10) Constraint PK_CarKey Primary Key,
	TenXe nvarchar(25),
	HangXe varchar(20),
	NamSanXuat date,
	DonGia bigint,
	HinhAnh image,
);

Create Table ChiTietHoaDon(
	MaHD varchar(10) References HoaDon(MaHD),
	MaXe varchar(10) References SanPham(MaXe),
	Soluong int default 1,
	Constraint PK_DetailRecptKey Primary Key(MaHD,MaXe),
	Constraint CheckSoLuongCTHD Check (SoLuong>0)
);



Create Table TaiKhoan(
	id varchar(15) primary key,
	pass varchar(15) not null,
	role nvarchar(25) not null
);


insert into KhachHang values ('KH01',N'Nguyễn Văn An', N'Số 1 Võ Văn Ngân', N'TP Thủ Đức','0932323232');
insert into KhachHang values ('KH02',N'Đinh Minh Khôi',N'Số 12 Kha Vạn Cân Quận 1',N'TPHCM','0984343433');
insert into KhachHang values ('KH03',N'Trần Nguyễn Quốc Khánh',N'Số 32 Hàng Xanh Bình Thạnh',N'TPHCM','095453453');
insert into KhachHang values ('KH04',N'Diệp Thái Dương',N'100/2 Hiệp Bình Chánh',N'TPHCM','035435454');
insert into KhachHang values ('KH05',N'Phạm Đức Huấn',N'Số 123  Quận Gò Vấp',N'TPHCM','032323432');
insert into KhachHang values ('KH06',N'Nguyễn K Hải',N'Số 32 Quận Tân Phú',N'TPHCM','034344545');
insert into KhachHang values ('KH07',N'Thái Văn Toàn',N'Số 1245 Mỏ Cày',N'Bến Tre','0943678863');
insert into KhachHang values ('KH08',N'Lê Công Minh',N'Số 545 Cai Lậy',N'Tiền Giang','093254433');
insert into KhachHang values ('KH09',N'Hồ Gia Tự',N'Số 324 Cái Bè',N'Vĩnh Long','094323345');
insert into KhachHang values ('KH10',N'Lâm Thị Nhung',N'Số 678 Bà Rịa E',N'Vũng Tàu','0977212144');
go
insert into NhanVien values ('NV01',N'Lê Lan Anh','1980-3-23',N'Nữ',N'212 Trần Hưng Đạo Quận 5','anhlannguyen@gmail.com','097878787',1500,'2014-4-6',null);
insert into NhanVien values ('NV02',N'Lâm Ti Phong','1990-10-2',N'Nam',N'9 Bạch Đằng, Núi Đèo, Thủy Nguyên','anhlannguyen@gmail.com','06290916',2000,'2010-2-3',null);
insert into NhanVien values ('NV03',N'Nguyễn Minh Nhựt','1972-3-4',N'Nam',N'368 Võ Văn Tần, Phường 5, Quận 3','anhlannguyen@gmail.com','03582063',2500,'2009-4-5',null);
insert into NhanVien values ('NV04',N'Tăng Thanh Hà','1988-4-12',N'Nữ',N'Tầng 8, Jardine House 58 Đồng Khởi, P. Bến Nghé','anhlannguyen@gmail.com','032323565',1500,'2012-5-16',null);
insert into NhanVien values ('NV05',N'Đinh Minh Thư','1996-7-1',N'Nữ',N'  36 Bạch Đằng, P.4','anhlannguyen@gmail.com','042323546',3000,'2015-7-8',null);
insert into NhanVien values ('NV06',N'Hoàng Quốc Việt','1994-1-2',N'Nam',N'98/48 Cộng Hòa, Phường 13','anhlannguyen@gmail.com','024343453',2500,'2014-3-6',null);
insert into NhanVien values ('NV07',N'Trần Đức Duy','1984-4-3',N'Nam',N'Số 194 Biên Hòa','anhlannguyen@gmail.com','03656567',2000,'2013-4-6',null);
go
insert into HoaDon values ('HD01','NV01','KH01','2020-2-1','2021-4-2');
insert into HoaDon values ('HD02','NV02','KH02','2019-1-2','2020-5-4');
insert into HoaDon values ('HD03','NV03','KH03','2018-12-1','2019-4-3');
insert into HoaDon values ('HD04','NV04','KH04','2017-3-11','2018-4-2');
insert into HoaDon values ('HD05','NV05','KH05','2015-4-21','2018-3-2');
insert into HoaDon values ('HD06','NV06','KH06','2016-6-1','2018-8-12');
insert into HoaDon values ('HD07','NV07','KH07','2019-12-1','2017-3-4');
go
--Sản phẩm
Insert into SanPham values ('Au001', 'A1', 'Audi', '2020-11-09', 53000, NULL);
Insert into SanPham values ('Au002', 'A4', 'Audi', '2020-10-04', 169500, NULL);
Insert into SanPham values ('Au003', 'A6', 'Audi', '2020-10-11', 250000, NULL);
Insert into SanPham values ('Au004', 'A7', 'Audi', '2020-10-04', 260000, NULL);
Insert into SanPham values ('Au005', 'A8', 'Audi', '2020-11-06', 56000, NULL);
Insert into SanPham values ('Au006', 'Q2', 'Audi', '2020-09-07', 135000, NULL);
Insert into SanPham values ('Au007', 'Q3', 'Audi', '2020-11-08', 176000, NULL);
Insert into SanPham values ('Au008', 'Q5', 'Audi', '2020-12-30', 237000,  NULL);
Insert into SanPham values ('Au009', 'Q7', 'Audi', '2020-11-12', 324000,  NULL);
Insert into SanPham values ('Au010', 'Q8', 'Audi', '2020-10-23', 450500,  NULL);
Insert into SanPham values ('Au011', 'R8', 'Audi', '2020-12-07', 450000,  NULL);

Insert into SanPham values ('Fo001', 'Focus', 'Ford', '2020-10-09', 770000, NULL);
Insert into SanPham values ('Fo002', 'Everest', 'Ford', '2020-11-22', 9990000, NULL);
Insert into SanPham values ('Fo003', 'Ecosport', 'Ford', '2020-08-12', 603000, NULL);
Insert into SanPham values ('Fo004', 'Ranger', 'Ford', '2020-12-01', 6160000, NULL);
Insert into SanPham values ('Fo005', 'Ranger Raptor', 'Ford', '2020-10-15', 1198000, NULL);
Insert into SanPham values ('Fo006', 'Explorer', 'Ford', '2020-09-02', 2268000, NULL);

Insert into SanPham values ('Ho001', 'Jazz', 'Honda', '2020-12-08', 54400, NULL);
Insert into SanPham values ('Ho002', 'City', 'Honda', '2020-10-17', 52900, NULL);
Insert into SanPham values ('Ho003', 'CR-V', 'Honda', '2020-08-20', 998000,  NULL);
Insert into SanPham values ('Ho004', 'Brio', 'Honda', '2020-11-07', 4180000, NULL);
Insert into SanPham values ('Ho005', 'Civic', 'Honda', '2020-08-29', 729000,NULL);
Insert into SanPham values ('Ho006', 'Accord', 'Honda', '2020-10-17', 131900,NULL);

Insert into SanPham values ('Hy001', 'Grand i10', 'Hyundai', '2020-11-16', 3280000, NULL);
Insert into SanPham values ('Hy002', 'Elantra', 'Hyundai', '2020-12-07', 750000, NULL);
Insert into SanPham values ('Hy003', 'Kona', 'Hyundai', '2020-09-13', 616000, NULL);
Insert into SanPham values ('Hy004', 'Accent', 'Hyundai', '2020-07-30', 426000, NULL);
Insert into SanPham values ('Hy005', 'Tuson', 'Hyundai', '2020-10-18', 767000, NULL);
Insert into SanPham values ('Hy006', 'Santafe', 'Hyundai', '2020-12-09', 980000, NULL);

Insert into SanPham values ('Ki001', 'Rondo', 'Kia', '2020-12-01', 559000, NULL);
Insert into SanPham values ('Ki002', 'Cerato', 'Kia', '2020-12-14', 544000, NULL);
Insert into SanPham values ('Ki003', 'Morning', 'Kia', '2020-09-10', 304000, NULL);
Insert into SanPham values ('Ki004', 'Optima', 'Kia', '2020-12-07', 7590000, NULL);
Insert into SanPham values ('Ki005', 'Sedona', 'Kia', '2020-08-19', 1010000, NULL);
Insert into SanPham values ('Ki006', 'Seltos', 'Kia', '2020-12-18', 599000, NULL);
Insert into SanPham values ('Ki007', 'Sorento', 'Kia', '2020-11-01', 769000, NULL);
Insert into SanPham values ('Ki008', 'Quoris', 'Kia', '2020-08-05', 270800, NULL);

Insert into SanPham values ('Ma001', 'Mazda 2', 'Mazda', '2020-09-02', 509000, NULL);
Insert into SanPham values ('Ma002', 'Mazda 3', 'Mazda', '2020-10-15', 509000, NULL);
Insert into SanPham values ('Ma003', 'Mazda 6', 'Mazda', '2020-11-03', 50900, NULL);
Insert into SanPham values ('Ma004', 'Mazda CX-5', 'Mazda', '2020-11-11', 50900, NULL);
Insert into SanPham values ('Ma005', 'Mazda CX-8', 'Mazda', '2020-09-20', 509000, NULL);

Insert into SanPham values ('Me001', 'C 180', 'Mercedes', '2020-09-21', 1499000, NULL);
Insert into SanPham values ('Me002', 'C 200', 'Mercedes', '2020-10-01', 169900, NULL);
Insert into SanPham values ('Me003', 'C 300', 'Mercedes', '2020-11-30', 1969000, NULL);
Insert into SanPham values ('Me004', 'E 180', 'Mercedes', '2020-09-07', 2050000, NULL);
Insert into SanPham values ('Me005', 'E 200', 'Mercedes', '2020-12-17', 2290000, NULL);
Insert into SanPham values ('Me006', 'E 300', 'Mercedes', '2020-09-23', 2920000, NULL);
Insert into SanPham values ('Me007', 'S 450L', 'Mercedes', '2020-11-27', 42990000, NULL);
Insert into SanPham values ('Me008', 'Maybach S-Class', 'Mercedes', '2020-03-30', 7469000, NULL);
Insert into SanPham values ('Me009', 'GLC 200', 'Mercedes', '2020-02-21', 179900000, NULL);
Insert into SanPham values ('Me010', 'GLC 300', 'Mercedes', '2020-10-06', 249900, NULL);
Insert into SanPham values ('Me011', 'AMG G63', 'Mercedes', '2020-11-16', 1095000, NULL);

Insert into SanPham values ('Mi001', 'Xpander', 'Mitsubishi', '2020-10-11', 555000, NULL);
Insert into SanPham values ('Mi002', 'Attrage', 'Mitsubishi', '2020-11-21', 375000, NULL);
Insert into SanPham values ('Mi003', 'Outlander', 'Mitsubishi', '2020-08-14', 82500, NULL);
Insert into SanPham values ('Mi004', 'Pajero Sport', 'Mitsubishi', '2020-07-30', 1062000, NULL);

Insert into SanPham values ('Su001', 'Ciaz', 'Suzuki', '2020-09-12', 535000, NULL);
Insert into SanPham values ('Su002', 'Vitara', 'Suzuki', '2020-04-22', 779000, NULL);
Insert into SanPham values ('Su003', 'Swift', 'Suzuki', '2020-09-15', 4490000, NULL);
Insert into SanPham values ('Su004', 'Ertiga', 'Suzuki', '2020-08-02', 5590000, NULL);
Insert into SanPham values ('Su005', 'XL7', 'Suzuki', '2020-06-17', 5890000,NULL);

Insert into SanPham values ('To001', 'Camry', 'Toyota', '2020-07-15', 123500, NULL);
Insert into SanPham values ('To002', 'Vios', 'Toyota', '2020-08-25', 530000, NULL);
Insert into SanPham values ('To003', 'Corolla Altis', 'Toyota', '2020-10-09', 763000, NULL);
Insert into SanPham values ('To004', 'Corolla Cross', 'Toyota', '2020-11-30', 820000, NULL);
Insert into SanPham values ('To005', 'Rush', 'Toyota', '2020-12-12', 633000, NULL);
Insert into SanPham values ('To006', 'Fortuner', 'Toyota', '2020-10-04', 138800, NULL);
Insert into SanPham values ('To007', 'Innova', 'Toyota', '2020-08-29', 879000, NULL);

Insert into SanPham values ('Vi001', 'Fadil', 'VinFast', '2020-08-17', 45900, NULL);
Insert into SanPham values ('Vi002', 'LUX A2.0', 'VinFast', '2020-10-27', 120600, NULL);
Insert into SanPham values ('Vi003', 'LUX SA2.0', 'VinFast', '2020-12-13', 144300,NULL);
go

insert into ChiTietHoaDon values('HD01','MX01',1);
insert into ChiTietHoaDon values('HD02','MX02',2);
insert into ChiTietHoaDon values('HD03','MX03',2);
insert into ChiTietHoaDon values('HD04','MX04',3);
insert into ChiTietHoaDon values('HD05','MX05',1);
insert into ChiTietHoaDon values('HD06','MX06',2);