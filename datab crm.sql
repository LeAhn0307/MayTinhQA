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
  idloaikhachhang int foreign key references loaikhachhang(idloaikhachhang),
  ghichu nvarchar(max)
)
create Table loaikhachhang(
idloaikhachhang int primary key,
loaikhachhang nvarchar(100)
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
  madonhang varchar(100),
  ngaytao datetime default getdate(),
  idkhachhang int foreign key references khachhang(idkhachhang),
  iddichvu int foreign key references dichvu(iddichvu),
  idtrangthai INT FOREIGN KEY REFERENCES trangthaidonhang(idtrangthai)
)
CREATE TABLE trangthaidonhang (
    idtrangthai INT identity PRIMARY KEY ,
    tentrangthai NVARCHAR(100) NOT NULL
);

INSERT INTO trangthaidonhang ( tentrangthai) VALUES
(N'Khởi tạo'),
(N'Chờ báo giá'),
( N'Đã báo giá'),
( N'Khách cần tư vấn thêm'),
( N'Chờ khách phản hồi'),
( N'Đã chuyển thành đơn thật'),
( N'Đã hủy / Không quan tâm');

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
  thongtinphanhoi nvarchar(100),
  iddichvu int foreign key references dichvu(iddichvu),
  idlienlac INT FOREIGN KEY REFERENCES lienlac(idlienlac)
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
  idnhanvien int foreign key references nhanvien(idnhanvien),
  iddichvu int foreign key references dichvu(iddichvu)
)
create Table phieudoitra (
  idphieudoitra int identity  primary key,
  ngaytao datetime default getdate(),
  idsanpham int foreign key references sanpham(idsanpham),
  idnhanvien int foreign key references nhanvien(idnhanvien),
  iddichvu int foreign key references dichvu(iddichvu)
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
  idsanpham int foreign key references sanpham(idsanpham),
  soluong int,
  dongia money
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

alter table lienlac add iddichvu int foreign key references dichvu(iddichvu)

CREATE TABLE lienlac (
  idlienlac INT IDENTITY PRIMARY KEY,
  idkhachhang INT FOREIGN KEY REFERENCES khachhang(idkhachhang), 
  idnhanvien INT FOREIGN KEY REFERENCES nhanvien(idnhanvien),   
  thoigian DATETIME DEFAULT GETDATE(),                          
  hinhthuc NVARCHAR(50),    
  tieude NVARCHAR(200),    
  noidung NVARCHAR(MAX),    
  ketqua NVARCHAR(200),     
  ghichu NVARCHAR(MAX),
  iddichvu int foreign key references dichvu(iddichvu)
)
INSERT INTO loaikhachhang (idloaikhachhang, loaikhachhang) VALUES
(1, N'VIP'),
(2, N'Trung thành'),
(3, N'Tiềm năng'),
(4, N'Ngủ quên'),
(5, N'Mới');
sELECT kh.idkhachhang, kh.tenkhachhang, kh.email,kh.dienthoai,kh.ngaysinh,kh.diachi,tp.tenthanhpho, qh.tenquanhuyen,  lkh.loaikhachhang,  kh.ghichu FROM khachhang kh LEFT JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho LEFT JOIN quanhuyen qh ON kh.idquanhuyen = qh.idquanhuyen LEFT JOIN loaikhachhang lkh ON kh.idloaikhachhang = lkh.idloaikhachhang where idkhachhang = 1

INSERT INTO loaisanpham (tenloaisanpham)
VALUES (N'Laptop');

INSERT INTO sanpham (tensanpham, gia, idloaisanpham, soluong, mota)
VALUES
(N'Laptop Dell XPS 13',      25000000, 1, 10, N'Intel Core i7-1250U, RAM 16GB, SSD 512GB, màn hình 13.4" FHD+'),
(N'Laptop HP Envy 15',       23000000, 1, 15, N'Intel Core i7-12700H, RAM 16GB, SSD 1TB, màn hình 15.6" FHD'),
(N'Laptop Asus ROG Strix',   32000000, 1, 8,  N'AMD Ryzen 7 6800H, RAM 16GB, SSD 1TB, RTX 3060, màn hình 15.6" 144Hz'),
(N'Laptop Acer Aspire 5',    17000000, 1, 12, N'Intel Core i5-1240P, RAM 8GB, SSD 512GB, màn hình 15.6" FHD'),
(N'Laptop MacBook Air M1',   28000000, 1, 9,  N'Apple M1, RAM 8GB, SSD 256GB, màn hình 13.3" Retina'),
(N'Laptop Lenovo ThinkPad X1',29000000,1, 7,  N'Intel Core i7-1260P, RAM 16GB, SSD 512GB, màn hình 14" WUXGA'),
(N'Laptop MSI GF63',         21000000, 1, 10, N'Intel Core i5-11400H, RAM 8GB, SSD 512GB, GTX 1650, màn hình 15.6" FHD'),
(N'Laptop Gigabyte Aero 15', 34000000, 1, 6,  N'Intel Core i7-11800H, RAM 16GB, SSD 1TB, RTX 3070, màn hình 15.6" 4K AMOLED'),
(N'Laptop Dell Inspiron 14', 19000000, 1, 14, N'Intel Core i5-1235U, RAM 8GB, SSD 512GB, màn hình 14" FHD'),
(N'Laptop Asus ZenBook 14',  26000000, 1, 11, N'Intel Core i7-1260P, RAM 16GB, SSD 512GB, màn hình 14" OLED 2.8K');

INSERT INTO donhang (madonhang, idkhachhang, idtrangthai, iddichvu, ngaytao)
VALUES (N'{maDon}', {idKhachHang},(SELECT idtrangthai FROM trangthaidonhang WHERE tentrangthai = N'Khởi tạo'), {idDichVu}, '{today}')

 INSERT INTO chitietdonhang (iddonhang, idsanpham, soluong, dongia)
 VALUES ('{idDonHang}', '{idSanPham}', '{soLuong}', '{donGia}')

 SELECT COLUMN_NAME, IS_NULLABLE, COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'donhang'
SELECT 
    dh.madonhang AS [MaDonHang],
    kh.tenkhachhang AS [KhachHang],
    STRING_AGG(
        sp.tensanpham + ' (x' + CAST(ctdh.soluong AS NVARCHAR) + ')', 
        ', '
    ) WITHIN GROUP (ORDER BY sp.tensanpham) AS [DanhSachSanPham],
    FORMAT(
        SUM(sp.gia * ctdh.soluong), 
        'N0', 'vi-VN'
    ) AS [TongTien],
    tt.tentrangthai AS [TrangThai]
FROM chitietdonhang ctdh
JOIN donhang dh ON dh.iddonhang = ctdh.iddonhang
JOIN khachhang kh ON kh.idkhachhang = dh.idkhachhang
JOIN sanpham sp ON sp.idsanpham = ctdh.idsanpham

LEFT JOIN trangthaidonhang tt ON dh.idtrangthai = tt.idtrangthai
WHERE dh.iddonhang = 4
GROUP BY dh.madonhang, kh.tenkhachhang, tt.tentrangthai
ORDER BY dh.madonhang DESC

select * from chitietdonhang

SELECT 
    dh.madonhang AS [MaDonHang],
    kh.tenkhachhang AS [KhachHang],
    STRING_AGG(
        sp.tensanpham + ' (x' + CAST(ctdh.soluong AS NVARCHAR) + ')', 
        ', '
    ) WITHIN GROUP (ORDER BY sp.tensanpham) AS [DanhSachSanPham],
    
    FORMAT(SUM(sp.gia * ctdh.soluong), 'N0', 'vi-VN') AS [TongTien],
    
    tt.tentrangthai AS [TrangThai]
FROM chitietdonhang ctdh
JOIN donhang dh ON dh.iddonhang = ctdh.iddonhang
JOIN khachhang kh ON kh.idkhachhang = dh.idkhachhang
JOIN sanpham sp ON sp.idsanpham = ctdh.idsanpham
LEFT JOIN trangthaidonhang tt ON dh.idtrangthai = tt.idtrangthai
GROUP BY dh.madonhang, kh.tenkhachhang, tt.tentrangthai
ORDER BY dh.madonhang DESC

SELECT 
    dh.madonhang AS [MaDonHang],
    kh.tenkhachhang AS [KhachHang],
    STRING_AGG(
        sp.tensanpham + ' (x' + CAST(ctdh.soluong AS NVARCHAR) + ')', 
        ', '
    ) WITHIN GROUP (ORDER BY sp.tensanpham) AS [DanhSachSanPham],
    
    FORMAT(SUM(sp.gia * ctdh.soluong), 'N0', 'vi-VN') AS [TongTien],
    
    tt.tentrangthai AS [TrangThai]
FROM chitietdonhang ctdh
JOIN donhang dh ON dh.iddonhang = ctdh.iddonhang
JOIN khachhang kh ON kh.idkhachhang = dh.idkhachhang
JOIN sanpham sp ON sp.idsanpham = ctdh.idsanpham
LEFT JOIN trangthaidonhang tt ON dh.idtrangthai = tt.idtrangthai
GROUP BY dh.madonhang, kh.tenkhachhang, tt.tentrangthai
ORDER BY dh.madonhang DESC;

SELECT 
    ctdh.idchitietdh,
    dh.madonhang AS [MaDonHang],
    kh.tenkhachhang AS [KhachHang],
    STRING_AGG(
        sp.tensanpham + ' (x' + CAST(ctdh.soluong AS NVARCHAR) + ')', 
        ', '
    ) WITHIN GROUP (ORDER BY sp.tensanpham) AS [DanhSachSanPham],
    FORMAT(
        SUM(sp.gia * ctdh.soluong), 
        'N0', 'vi-VN'
    ) AS [TongTien],
    tt.tentrangthai AS [TrangThai]
FROM chitietdonhang ctdh
JOIN donhang dh ON dh.iddonhang = ctdh.iddonhang
JOIN khachhang kh ON kh.idkhachhang = dh.idkhachhang
JOIN sanpham sp ON sp.idsanpham = ctdh.idsanpham
LEFT JOIN trangthaidonhang tt ON dh.idtrangthai = tt.idtrangthai
WHERE ctdh.idchitietdh=8
GROUP BY ctdh.idchitietdh, dh.madonhang, kh.tenkhachhang, tt.tentrangthai
ORDER BY dh.madonhang DESC

select ctdh.idchitietdh, dh.madonhang,sp.tensanpham,kh.tenkhachhang,ctdh.soluong,sp.gia,tt.tentrangthai from chitietdonhang ctdh
join donhang dh on ctdh.iddonhang=dh.iddonhang
join sanpham sp on ctdh.idsanpham=sp.idsanpham
join khachhang kh on dh.idkhachhang=kh.idkhachhang
join trangthaidonhang tt on dh.idtrangthai= tt.idtrangthai
where ctdh.idchitietdh=8