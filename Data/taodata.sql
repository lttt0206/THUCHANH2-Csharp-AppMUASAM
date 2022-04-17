create table Sanpham (
	idsanpham int IDENTITY(1,1) not null PRIMARY KEY,
	tensanpham nvarchar(200),
	danhmuc nvarchar(200),
	gia money not null,
	soluong int not null,
	mota nvarchar(300)
)
------------------------------------------
create table Daxem (
	idsanpham int not null
)
------------------------------------------
create table Hinhanh (
    idhinhanh int IDENTITY(1,1) not null PRIMARY KEY,
	idsanpham int not null
)
---------------------------------------
create table Donhang (
	iddonhang int IDENTITY(1,1) not null PRIMARY KEY,
	tennguoinhan nvarchar(200),
	diachinhan nvarchar(200),
	thanhtien money not null,
	tinhtrang int not null,
	ngaydat nvarchar(200)
)
-------------------------------------------
create table CTDH (
	iddonhang int not null,
	idsanpham int not null,
	sl int,
	giatien money
)
------------------------------------------------
create table Giohang (
	idsanpham int not null,
	soluong int
)

drop table Giohang