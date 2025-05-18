create database crm
use crm 

create Table khachhang (
  idkhachhang int identity primary key,
  tenkhachhang nvarchar(100),
  email	varchar(100),
  dienthoai	nvarchar(100),
  diachi text,
  ngaysinh date
)
  CREATE TABLE thanhpho (
  idthanhpho INT IDENTITY PRIMARY KEY,
  tenthanhpho NVARCHAR(100) NOT NULL
)

CREATE TABLE quanhuyen (
  idquanhuyen INT IDENTITY PRIMARY KEY,
  idthanhpho INT FOREIGN KEY REFERENCES thanhpho(idthanhpho),
  tenquanhuyen NVARCHAR(100) NOT NULL
)
create Table loaikhachhang(
idkhachhang int foreign key references khachhang(idkhachhang),
loaikhachhang nvarchar(100),
)
create Table vaitro (
  idvaitro int identity primary key,
  tenvaitro varchar(100)
)

create Table users (
  idusers int identity primary key,
  tennguoidung varchar(100),
  matkhau text,
  email varchar(100),
  idvaitro int foreign key references vaitro(idvaitro)
)

create Table loaisanpham (
  idloaisanpham  int identity primary key,
  tenloaisanpham nvarchar(100)
)
insert into loaisanpham values(N'Laptop')

create Table donhang (
  iddonhang int identity primary key,
  trangthai nvarchar(100),
  idkhachhang int foreign key references khachhang(idkhachhang)
)

create Table sanpham (
  idsanpham int identity primary key,
  tensanpham nvarchar(100),
  gia money,
  idloaisanpham int foreign key references loaisanpham(idloaisanpham),
  soluong int,
  mota nvarchar(100),
)



create table chucvu (
  idchucvu int identity primary key,
  tenchucvu nvarchar(100)
)

create Table nhanvien (
  idnhanvien int identity primary key,
  tennhanvien nvarchar(100),
  chucvu int foreign key references chucvu(idchucvu),
  idusers int foreign key references users(idusers)
) 
create table thanhtoan (
  idthanhtoan int identity primary key,
  loaithanhtoan nvarchar(100) 
)
create table phanhoi (
  idphanhoi int identity primary key,
  idkhachhang int foreign key references khachhang(idkhachhang),
  thongtinphanhoi nvarchar(100)
)
create Table danhmuc (
  idkhachhang int foreign key references khachhang(idkhachhang),
  idsanpham int foreign key references sanpham(idsanpham),
  idphanhoi int foreign key references phanhoi(idphanhoi)
)
create Table phieubaohanh (
  idphieudoitra int identity primary key,
  ngaytao date,
  ngaybatdau date,
  ngayketthuc date,
  idsanpham int foreign key references sanpham(idsanpham),
  idnhanvien int foreign key references nhanvien(idnhanvien)
)
create Table phieudoitra (
  idphieubaohanh int identity primary key,
  ngaytao date,
  idsanpham int foreign key references sanpham(idsanpham),
  idnhanvien int foreign key references nhanvien(idnhanvien)
)

create Table dichvu (
  iddichvu int identity primary key,
  tendichvu nvarchar(100),
  mota nvarchar(100),
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idkhachhang int foreign key references khachhang(idkhachhang)
)

create Table loaikhuyenmai (
  idloaikhuyenmai int identity primary key,
  loaikhuyenmai nvarchar(100)
)

create Table khuyenmai (
  idkhuyenmai int identity primary key,
  magiamgia varchar(100),
  giatri decimal(3,0),
  ngaybatdau date,
  ngayketthuc date,
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idloaikhuyenmai int foreign key references loaikhuyenmai(idloaikhuyenmai)
)

create Table chitietdonhang (
  idchitietdh int identity primary key,
  iddonhang int foreign key references donhang(iddonhang),
  idkhachhang int foreign key references khachhang(idkhachhang),
  idsanpham int foreign key references sanpham(idsanpham),
  soluong int,
  idgiamgia int foreign key references khuyenmai(idkhuyenmai),
  dongia money,
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idthanhtoan int foreign key references thanhtoan(idthanhtoan)
)

create Table hoadon (
  idhoadon int identity primary key,
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idkhachhang int foreign key references khachhang(idkhachhang),
  iddonhang int foreign key references donhang(iddonhang),
  idchitietdh int foreign key references chitietdonhang(idchitietdh),
  tongtien money,
  ngaytao date
)

create Table congno (
  idcongno int identity primary key,
  tongtien money,
  trangthai nvarchar(100),
  idkhachhang int foreign key references khachhang(idkhachhang),
  idhoadon int foreign key references hoadon(idhoadon)
)
create table giaodich (
  idgiaodich int identity primary key,
  idkhachhang int foreign key references khachhang(idkhachhang),
  idhoadon int foreign key references hoadon(idhoadon),
  idchitietdh int foreign key references chitietdonhang(idchitietdh),
)
create table thongke (
idcongno int foreign key references congno(idcongno),
idphanhoi int foreign key references phanhoi(idphanhoi),
idgiaodich int foreign key references giaodich(idgiaodich),
)

insert into vaitro values(N'Admin')
insert into vaitro values(N'User')

insert into users values('Admin1','123456','admin1@gmail.com',1)
SET IDENTITY_INSERT users ON;
insert into chucvu(idchucvu,tenchucvu) values(2,N'nhan vien ban hang')
SET IDENTITY_INSERT users OFF;
INSERT INTO users VALUES (2, N'User2', N'123456', N'users2@gmail.com', 2)
update chucvu set idchucvu=1 where tenchucvu= N'quan ly'
insert into chucvu values(N'nhan vien ban hang')
insert into nhanvien Values (N'abc',2,2)
update nhanvien set tennhanvien = N'ccc' where idnhanvien = 2

Select chitietdonhang.idchitietdh,khachhang.tenkhachhang,sanpham.tensanpham,chitietdonhang.soluong,FORMAT(sanpham.gia, 'N0', 'vi-VN'),FORMAT((chitietdonhang.soluong*sanpham.gia),'N0', 'vi-VN')as ThanhTien From chitietdonhang inner join khachhang on khachhang.idkhachhang=chitietdonhang.idkhachhang inner join sanpham on sanpham.idsanpham=chitietdonhang.idsanpham 

insert into donhang(trangthai,idkhachhang) Values (N'Chờ',(SELECT idkhachhang FROM khachhang WHERE tenkhachhang =N''))
INSERT INTO quanhuyen (idthanhpho, tenquanhuyen) VALUES
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Ba Đình'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Hoàn Kiếm'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Tây Hồ'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Long Biên'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Cầu Giấy'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Dông Đa'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Thanh Xuân'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Hà Đông'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Sơn Tây'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Sóc Sơn'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Gia Lâm'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Đông Anh'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Ứng Hòa'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Mê Linh'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Mỹ Đức'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Phú Xuyên'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Chương Mỹ'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Thường Tín'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hà Nội'), N'Tây Hồ');

INSERT INTO quanhuyen (idthanhpho, tenquanhuyen) VALUES
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Hồng Bàng'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Ngô Quyền'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Lê Chân'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Kiến An'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Dương Kinh'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Thủy Nguyên'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Trúc Sơn'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'An Lão'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Kiến Thụy'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Vĩnh Bảo'),
((SELECT idthanhpho FROM thanhpho WHERE tenthanhpho = N'Hải Phòng'), N'Tiên Lãng');
