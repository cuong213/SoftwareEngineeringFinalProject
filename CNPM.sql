Create database CNPM
Go
Use CNPM

Create table NguoiDung (
	Username varchar(50),
	Password varchar(50),
	MaKT varchar(10),
	primary key(Username),
	foreign key (MaKT) references KeToan(MaKT)
)


insert into NguoiDung values('ketoan1' , '123123123' , 'KT01')
insert into NguoiDung values('ketoan2' , '123123123' , 'KT02')
select * from NguoiDung

Create table KeToan (
	MaKT varchar(10),
	TenKT varchar(50),
	DiaChi varchar(50),
	DienThoai varchar(20),
	Email varchar(50),
	primary key(MaKT)
)

insert into KeToan values('KT01' , 'Nguyen Thai Cuong' , 'TPHCM', '0982938912', 'cuong@gmail.com')
insert into KeToan values('KT02' , 'Tran Thien Tan' , 'Dong nai', '0982736124', 'tan@gmail.com')
Create table SanPham (
	MaSP varchar(10),
	TenSP varchar(50),
	MaLH varchar(10),
	DonVi varchar(20),
	primary key(MaSP),
	foreign key (MaLH) references LoaiHang(MaLH)
)

insert into SanPham values('SP001' , 'Sting' , 'LH01' , '500ml')
insert into SanPham values('SP002' , 'Bia 333' , 'LH02' , '1l')
insert into SanPham values('SP003' , 'Volka' , 'LH03' , '250ml')


select * from SanPham

Create table LoaiHang (
	MaLH varchar(10),
	TenLH varchar(50),
	primary key(MaLH)
)

insert into LoaiHang values('LH01', 'Nuoc ngot')
insert into LoaiHang values('LH02', 'Bia')
insert into LoaiHang values('LH03', 'Ruou')
select * from LoaiHang


Create table Kho (
	MaSP varchar(10),
	SLNhap int,
	SLXuat int,
	primary key(MaSP),
	foreign key (MaSP) references SanPham(MaSP)
)

insert into Kho values ('SP001' , 30 , 10)
insert into Kho values ('SP002' , 40 , 20)
insert into Kho values ('SP003' , 50 , 24)

Create table PhieuNhap (
	MaPN varchar(10),
	NgayNhap datetime,
	MaKT varchar(10),
	primary key(MaPN),
	foreign key (MaKT) references KeToan(MaKT)
)

insert into PhieuNhap values('PN01' , '1/1/2022' , 'KT01')
insert into PhieuNhap values('PN02' , '1/1/2022' , 'KT02')
insert into PhieuNhap values('PN03' , '2/1/2022' , 'KT01')
insert into PhieuNhap values('PN04' , '2/1/2022' , 'KT02')


select * from PhieuNhap
Create table ChiTietPN (
	MaPN varchar(10),
	MaSP varchar(10),
	SLNhap int,
	DGNhap money,
	primary key(MaPN, MaSP),
	foreign key (MaPN) references PhieuNhap(MaPN),
	foreign key (MaSP) references SanPham(MaSP)
)
insert into ChiTietPN values('PN01' , 'SP001' , 3 , 12000)
insert into ChiTietPN values('PN01' , 'SP003' , 4 , 210000)
insert into ChiTietPN values('PN01' , 'SP002' , 10 , 21000)
insert into ChiTietPN values ('PN02' , 'SP002' , 10 , 21000)
insert into ChiTietPN values ('PN02' , 'SP001' , 10 , 12000)
insert into ChiTietPN values ('PN02' , 'SP003' , 20 , 210000)
insert into ChiTietPN values ('PN03' , 'SP002' , 10 , 21000)
insert into ChiTietPN values ('PN03' , 'SP001' , 10 , 12000)
insert into ChiTietPN values ('PN03' , 'SP003' , 20 , 210000)
insert into ChiTietPN values ('PN04' , 'SP002' , 10 , 21000)
insert into ChiTietPN values ('PN04' , 'SP001' , 10 , 12000)


select * from ChiTietPN

Create table DonHang (
	MaDH varchar(10),
	MaDL varchar(10),
	NgayDH datetime,
	primary key(MaDH),
	foreign key (MaDL) references DaiLy(MaDL)
)

insert into DonHang values ('DH01', 'DL01' , '1/1/2022')
insert into DonHang values ('DH02' , 'DL02' , '1/1/2022')
insert into DonHang values ('DH03' , 'DL03' , '2/1/2022')


Create table ChiTietDH (
	MaDH varchar(10),
	MaSP varchar(10),
	SoLuong int,
	DonGia money,
	HinhThucTT varchar(50),
	TrangThaiDH varchar(50),
	primary key(MaDH, MaSP),
	foreign key (MaDH) references DonHang(MaDH),
	foreign key (MaSP) references SanPham(MaSP)
)
insert into ChiTietDH values ('DH01', 'SP001', 3 , 12000, 'Momo' , 'dang xem xet')
insert into ChiTietDH values ('DH02', 'SP002', 3 , 24000, 'Tien mat' , 'dang van chuyen')
insert into ChiTietDH values ('DH03', 'SP003', 3 , 210000, 'Momo' , 'dang xem xet')



Create table PhieuXuat (
	MaPX varchar(10),
	NgayXuat datetime,
	MaKT varchar(10),
	MaDH varchar(10),
	primary key(MaPX),
	foreign key (MaKT) references KeToan(MaKT),
	foreign key (MaDH) references DonHang(MaDH)
)

insert into PhieuXuat values ('PX01' , '2/1/2022', 'KT01' , 'DH01')
insert into PhieuXuat values ('PX02' , '2/1/2022', 'KT02' , 'DH02')
insert into PhieuXuat values ('PX03' , '2/1/2022', 'KT01' , 'DH03')

select * from PhieuXuat
Create table ChiTietPX (
	MaPX varchar(10),
	MaSP varchar(10),
	SoLuong int,	
	primary key(MaPX, MaSP),
	foreign key (MaPX) references PhieuXuat(MaPX),
	foreign key (MaSP) references SanPham(MaSP)
)

insert into ChiTietPX values ('PX01' , 'SP001' , 4)
insert into ChiTietPX values ('PX02' , 'SP002' , 10)
insert into ChiTietPX values ('PX03' , 'SP003' , 12)

create table DaiLy(
	MaDL varchar(10) primary key,
	TenDL varchar(50),
	DiaChiDL varchar(50),
	DienThoaiDL varchar(10)
)

insert into DaiLy values ('DL01', 'Tap hoa Xuan Mai' , '25 Ton Dan', '0928378492')
insert into DaiLy values ('DL02', 'Chill Coffee' , '17 Ly Thuong Kiet', '0982737182')
insert into DaiLy values ('DL03', 'Bar Boheme' , '72 Do Quang Dau', '0972817412')