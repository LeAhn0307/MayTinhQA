create database crm
use crm 

create Table khachhang (
  idkhachhang int primary key,
  tenkhachhang nvarchar(100),
  email	varchar(100),
  dienthoai	nvarchar(100),
  diachi nvarchar(max),
  ngaysinh date,
  idthanhpho int foreign key references thanhpho(idthanhpho),
  idquanhuyen int foreign key references quanhuyen(idquanhuyen),
  ghichu nvarchar(max)
)
alter table khachhang add ghichu nvarchar(max)
INSERT INTO khachhang (idkhachhang, tenkhachhang, email, dienthoai, diachi, ngaysinh, idthanhpho, idquanhuyen)
VALUES ({id},N'{hoten}', '{email}', '{sdt}', N'{diachi}', '{ngaysinh}', {idThanhPho}, {idQuan})"
create Table loaikhachhang(
idkhachhang int foreign key references khachhang(idkhachhang),
loaikhachhang nvarchar(100),
)
create table thanhpho(
idthanhpho int primary key,
tenthanhpho nvarchar(100)
)
create table quanhuyen(
idquanhuyen int  primary key,
idthanhpho int foreign key references thanhpho(idthanhpho),
tenquanhuyen nvarchar(100)
)
create Table vaitro (
  idvaitro int  primary key,
  tenvaitro varchar(100)
)

create Table users (
  idusers int  primary key,
  tennguoidung varchar(100),
  matkhau text,
  email varchar(100),
  idvaitro int foreign key references vaitro(idvaitro)
)

create Table loaisanpham (
  idloaisanpham  int  primary key,
  tenloaisanpham nvarchar(100)
)
insert into loaisanpham values(N'Laptop')

create Table donhang (
  iddonhang int  primary key,
  trangthai nvarchar(100),
  ngaytao datetime default getdate(),
  idkhachhang int foreign key references khachhang(idkhachhang)
)
create Table sanpham (
  idsanpham int  primary key,
  tensanpham nvarchar(100),
  gia money,
  idloaisanpham int foreign key references loaisanpham(idloaisanpham),
  soluong int,
  mota nvarchar(100),
)
create table chucvu (
  idchucvu int  primary key,
  tenchucvu nvarchar(100)
)
create Table nhanvien (
  idnhanvien int  primary key,
  tennhanvien nvarchar(100),
  chucvu int foreign key references chucvu(idchucvu),
  idusers int foreign key references users(idusers)
) 
create table phanhoi (
  idphanhoi int  primary key,
  idkhachhang int foreign key references khachhang(idkhachhang),
  thongtinphanhoi nvarchar(100)
)
create Table danhmuc (
  idkhachhang int foreign key references khachhang(idkhachhang),
  idsanpham int foreign key references sanpham(idsanpham),
  idphanhoi int foreign key references phanhoi(idphanhoi)
)
create Table phieubaohanh (
  idphieubaohanh int  primary key,
  ngaytao datetime default getdate(),
  ngaybatdau datetime,
  ngayketthuc datetime,
  idsanpham int foreign key references sanpham(idsanpham),
  idnhanvien int foreign key references nhanvien(idnhanvien)
)
create Table phieudoitra (
  idphieudoitra int  primary key,
  ngaytao datetime default getdate(),
  idsanpham int foreign key references sanpham(idsanpham),
  idnhanvien int foreign key references nhanvien(idnhanvien)
)

create Table dichvu (
  iddichvu int  primary key,
  tendichvu nvarchar(100),
  mota nvarchar(100),
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idkhachhang int foreign key references khachhang(idkhachhang),
  idloaidichvu int foreign key references loaidichvu(idloaidichvu)
)

create Table loaidichvu (
  idloaidichvu int  primary key,
  tenloaidichvu nvarchar(100)
)

create Table khuyenmai (
  idkhuyenmai int  primary key,
  magiamgia varchar(100),
  giatri decimal(3,0),
  ngaybatdau date,
  ngayketthuc date,
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idloaikhuyenmai int foreign key references loaikhuyenmai(idloaikhuyenmai)
)
create Table loaikhuyenmai (
  idloaikhuyenmai int  primary key,
  tenloaikhuyenmai nvarchar(100)
)
create Table chitietdonhang (
  idchitietdh int  primary key,
  iddonhang int foreign key references donhang(iddonhang),
  idkhachhang int foreign key references khachhang(idkhachhang),
  idsanpham int foreign key references sanpham(idsanpham),
  soluong int,
  idkhuyenmai int foreign key references khuyenmai(idkhuyenmai),
  dongia money,
  idnhanvien int foreign key references nhanvien(idnhanvien),
)

create table thongke (
idkhachhang int foreign key references khachhang(idkhachhang),
idphanhoi int foreign key references phanhoi(idphanhoi),
iddonhang int foreign key references donhang(iddonhang)
)

insert into vaitro values(1,N'Admin')
insert into vaitro values(2,N'User')

insert into users values(1,'Admin1','123456','ggnhulon1234@gmail.com',1)
SET IDENTITY_INSERT users ON;
insert into chucvu(idchucvu,tenchucvu) values(2,N'nhan vien ban hang')
SET IDENTITY_INSERT users OFF;
INSERT INTO users VALUES (2, N'User2', N'123456', N'users2@gmail.com', 2)
update chucvu set idchucvu=1 where tenchucvu= N'quan ly'
insert into chucvu values(N'nhan vien ban hang')
insert into nhanvien Values (N'abc',2,2)
update nhanvien set tennhanvien = N'ccc' where idnhanvien = 2

Select chitietdonhang.idchitietdh,khachhang.tenkhachhang,sanpham.tensanpham,chitietdonhang.soluong,FORMAT(sanpham.gia, 'N0', 'vi-VN'),FORMAT((chitietdonhang.soluong*sanpham.gia),'N0', 'vi-VN')as ThanhTien From chitietdonhang inner join khachhang on khachhang.idkhachhang=chitietdonhang.idkhachhang inner join sanpham on sanpham.idsanpham=chitietdonhang.idsanpham 

SELECT kh.idkhachhang, kh.tenkhachhang, kh.email, kh.dienthoai,kh.ngaysinh, CONCAT(kh.diachi, ', ', q.tenquanhuyen, ', ', tp.tenthanhpho) AS diachi FROM khachhang kh JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho JOIN quanhuyen q ON kh.idquanhuyen = q.idquanhuyen

alter table khuyenmai add idkhachhang int foreign key references khachhang(idkhachhang)
