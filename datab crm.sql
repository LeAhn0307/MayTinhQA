create database crm
use crm 

create Table khachhang (
  idkhachhang int identity primary key,
  tenkhachhang nvarchar(100),
  email	varchar(100),
  dienthoai	nvarchar(100),
  diachi nvarchar(max),
  ngaysinh date,
  idthanhpho int foreign key references thanhpho(idthanhpho),
  idquanhuyen int foreign key references quanhuyen(idquanhuyen),
  ghichu nvarchar(max)
)
create Table loaikhachhang(
idkhachhang int foreign key references khachhang(idkhachhang),
loaikhachhang nvarchar(100),
)
create table thanhpho(
idthanhpho int identity primary key,
tenthanhpho nvarchar(100)
)
create table quanhuyen(
idquanhuyen int identity primary key,
idthanhpho int foreign key references thanhpho(idthanhpho),
tenquanhuyen nvarchar(100)
)
create Table vaitro (
  idvaitro int identity primary key,
  tenvaitro varchar(100)
)

create Table users (
  idusers int identity  primary key,
  tennguoidung varchar(100),
  matkhau varchar(100),
  email varchar(100),
  idvaitro int foreign key references vaitro(idvaitro)
)

create Table loaisanpham (
  idloaisanpham  int identity   primary key,
  tenloaisanpham nvarchar(100)
)
insert into loaisanpham values(N'Laptop')

create Table donhang (
  iddonhang int identity  primary key,
  trangthai nvarchar(100),
  ngaytao datetime default getdate(),
  idkhachhang int foreign key references khachhang(idkhachhang)
)
create Table sanpham (
  idsanpham int identity  primary key,
  tensanpham nvarchar(100),
  gia money,
  idloaisanpham int foreign key references loaisanpham(idloaisanpham),
  soluong int,
  mota nvarchar(100),
)
create table chucvu (
  idchucvu int identity  primary key,
  tenchucvu nvarchar(100)
)
create Table nhanvien (
  idnhanvien int identity  primary key,
  tennhanvien nvarchar(100),
  chucvu int foreign key references chucvu(idchucvu),
  idusers int foreign key references users(idusers)
) 
create table phanhoi (
  idphanhoi int identity  primary key,
  idkhachhang int foreign key references khachhang(idkhachhang),
  thongtinphanhoi nvarchar(100)
)
create Table danhmuc (
  idkhachhang int foreign key references khachhang(idkhachhang),
  idsanpham int foreign key references sanpham(idsanpham),
  idphanhoi int foreign key references phanhoi(idphanhoi)
)
create Table phieubaohanh (
  idphieubaohanh int identity  primary key,
  ngaytao datetime default getdate(),
  ngaybatdau datetime,
  ngayketthuc datetime,
  idsanpham int foreign key references sanpham(idsanpham),
  idnhanvien int foreign key references nhanvien(idnhanvien)
)
create Table phieudoitra (
  idphieudoitra int identity  primary key,
  ngaytao datetime default getdate(),
  idsanpham int foreign key references sanpham(idsanpham),
  idnhanvien int foreign key references nhanvien(idnhanvien)
)

create Table dichvu (
  iddichvu int identity  primary key,
  tendichvu nvarchar(100),
  ngaykhoitao DATETIME DEFAULT GETDATE(),
  trangthai NVARCHAR(50),
  mota nvarchar(100),
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idkhachhang int foreign key references khachhang(idkhachhang),
  idloaidichvu int foreign key references loaidichvu(idloaidichvu)
)

create Table loaidichvu (
  idloaidichvu int identity  primary key,
  tenloaidichvu nvarchar(100)
)
create table trangthaidichvu(
idtrangthai int identity primary key,
idloaidichvu int foreign key references loaidichvu(idloaidichvu),
tentrangthai nvarchar(max)
)
create Table khuyenmai (
  idkhuyenmai int identity  primary key,
  magiamgia varchar(100),
  giatri decimal(3,0),
  ngaybatdau date,
  ngayketthuc date,
  idnhanvien int foreign key references nhanvien(idnhanvien),
  idloaikhuyenmai int foreign key references loaikhuyenmai(idloaikhuyenmai)
)
create Table loaikhuyenmai (
  idloaikhuyenmai int identity  primary key,
  tenloaikhuyenmai nvarchar(100)
)
create Table chitietdonhang (
  idchitietdh int identity   primary key,
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

insert into vaitro values(N'Admin')
insert into vaitro values(N'User')

insert into users values('Admin1','123456','ggnhulon1234@gmail.com',1)
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

SELECT kh.idkhachhang, kh.tenkhachhang, kh.email, kh.dienthoai,kh.ngaysinh, 
CONCAT(kh.diachi, ', ', q.tenquanhuyen, ', ', tp.tenthanhpho) AS diachi,ghichu 
FROM khachhang kh 
JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho 
JOIN quanhuyen q ON kh.idquanhuyen = q.idquanhuyen

SELECT dv.iddichvu, dv.tendichvu,dv.ngaykhoitao,dv.trangthai,dv.mota,kh.tenkhachhang,nv.tennhanvien
FROM dichvu dv
join khachhang kh on kh.idkhachhang = dv.idkhachhang
join nhanvien nv on nv.idnhanvien = dv.idnhanvien

-- Thêm thành phố Hải Phòng
INSERT INTO thanhpho (tenthanhpho)
VALUES (N'Hải Phòng');

INSERT INTO thanhpho (tenthanhpho)
VALUES (N'Hà Nội');
INSERT INTO khachhang (tenkhachhang, email, dienthoai, diachi, ngaysinh, idthanhpho, idquanhuyen, ghichu)
VALUES 
(N'Nguyễn Văn Hưng', 'hung.nguyen@example.com', '0912345001', N'123 Hồng Bàng, Hải Phòng', '1990-01-15', 1, 1, N''),
(N'Phạm Thị Lan', 'lan.pham@example.com', '0912345002', N'45 Ngô Quyền, Hải Phòng', '1992-04-20', 1, 2, N''),
(N'Lê Văn Tuấn', 'tuan.le@example.com', '0912345003', N'67 Lê Chân, Hải Phòng', '1988-03-10', 1, 3, N''),
(N'Hoàng Thị Hương', 'huong.hoang@example.com', '0912345004', N'89 Hải An, Hải Phòng', '1995-12-01', 1, 4, N''),
(N'Vũ Văn Nam', 'nam.vu@example.com', '0912345005', N'12 Kiến An, Hải Phòng', '1991-07-07', 1, 5, N''),
(N'Trần Thị Thu', 'thu.tran@example.com', '0912345006', N'78 Dương Kinh, Hải Phòng', '1993-06-22', 1, 6, N''),
(N'Bùi Quang Dũng', 'dung.bui@example.com', '0912345007', N'34 Đồ Sơn, Hải Phòng', '1990-08-30', 1, 7, N''),
(N'Ngô Minh Đức', 'duc.ngo@example.com', '0912345008', N'90 An Dương, Hải Phòng', '1989-10-05', 1, 8, N''),
(N'Đỗ Thị Mai', 'mai.do@example.com', '0912345009', N'56 An Lão, Hải Phòng', '1996-11-11', 1, 9, N''),
(N'Đặng Văn Quân', 'quan.dang@example.com', '0912345010', N'88 Kiến Thụy, Hải Phòng', '1987-09-17', 1, 10, N'');

INSERT INTO chucvu VALUES (N'Nhân viên');
INSERT INTO users (tennguoidung, matkhau, email, idvaitro)
VALUES ('nhanvien1', '123456', 'nhanvien1@gmail.com', 2);
INSERT INTO nhanvien (tennhanvien, chucvu, idusers)
VALUES (N'Nguyễn Văn An', 1, 2);