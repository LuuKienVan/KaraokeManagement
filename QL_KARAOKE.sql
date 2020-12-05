create database QL_KARAOKE
go
use QL_KARAOKE
go

Set dateformat DMY

create table DICHVU 
(
   ID_DICHVU            int identity(1,1)              not null,
   TENDICHVU            nvarchar(100)                  null,
   GIADICHVU            int							   null,
   primary key (ID_DICHVU)
);

create table HOADON 
(
   ID_HOADON            int identity(1,1)              not null,
   ID_NHANVIEN          int				               not null,
   NGAYTHANHTOAN		Date						   not null default getdate(),
   TINHTRANG			int							   not null,
   primary key (ID_HOADON)
);


create table NHANVIEN 
(
   ID_NHANVIEN          int identity(1,1)              not null,
   HOTEN                nvarchar(100)                  null,
   NGAYSINH             date                           null,
   GIOITINH             int		                       null,
   CMND                 varchar(12)                    null,
   SDT                  varchar(10)                    null,
   DIACHI               nvarchar(100)                  null,
   EMAIL				varchar(100)
   primary key (ID_NHANVIEN)
);

create table PHONG 
(
   ID_PHONG             char(4)                        not null,
   TIENTHUE             int		                       not null,
   TINHTRANG			nvarchar(10)				   not null,
   LOAIPHONG            char(3)                        null,
   primary key (ID_PHONG)
);

create table CHITIETHOADON 
(
   ID_HOADON            int							   not null,
   ID_PHONG				char(4)						   not null,
   ID_DICHVU            int							   not null,
   count int not null default 0,
   primary key(ID_HOADON, ID_PHONG, ID_DICHVU)
);

create table TAIKHOAN
(
	TEN_TAIKHOAN varchar(20) not null,
	TEN_HIENTHI nvarchar(100) not null,
	MATKHAU varchar(100) not null,
	LOAITAIKHOAN int not null,
	primary key(TEN_TAIKHOAN)
);

alter table CHITIETHOADON
   add constraint FK_CHITIETHOADON_ID_HOADON foreign key (ID_HOADON)
      references HOADON (ID_HOADON)

alter table CHITIETHOADON
   add constraint FK_CHITIETHOADON_ID_DICHVU foreign key (ID_DICHVU)
      references DICHVU (ID_DICHVU)

alter table CHITIETHOADON
	add constraint FK_CHITIETHOADON_ID_PHONG foreign key (ID_PHONG)
		references PHONG (ID_PHONG)

alter table HOADON
   add constraint FK_HOADON_ID_NHANVIEN foreign key (ID_NHANVIEN)
      references NHANVIEN (ID_NHANVIEN)

alter table PHONG
	add constraint DF_PHONG_TINHTRANG default N'Trống' for TINHTRANG

alter table TAIKHOAN
	add constraint DF_TAIKHOAN_MATKHAU default '123456' for MATKHAU
--------------PROC----------------

--NHANVIEN--
go
create proc InsertNhanVien(@HOTEN nvarchar(100), @NGAYSINH date, @GIOITINH int, @CMND varchar(12), @SDT varchar(10), @DIACHI nvarchar(50), @EMAIL varchar(100))
as
begin
	insert into NHANVIEN values(@HOTEN,@NGAYSINH,@GIOITINH,@CMND,@SDT,@DIACHI,@EMAIL)
end

go
create proc UpdateNhanVien(@ID_NHANVIEN int, @HOTEN nvarchar(100), @NGAYSINH date, @GIOITINH int, @CMND varchar(12), @SDT varchar(10), @DIACHI nvarchar(50), @EMAIL varchar(100))
as
begin
	Update NHANVIEN
	Set HOTEN=@HOTEN, NGAYSINH=@NGAYSINH, GIOITINH=@GIOITINH, CMND=@CMND, SDT=@SDT, DIACHI=@DIACHI, EMAIL=@EMAIL
	Where ID_NHANVIEN = @ID_NHANVIEN
end

go
create proc DeleteNhanVien(@ID_NHANVIEN int)
as
begin
	Delete from NHANVIEN
	where ID_NHANVIEN = @ID_NHANVIEN
end

go
create proc UserLogin(@TEN_TAIKHOAN varchar(20), @MATKHAU varchar(100))
as
begin
	select * from TAIKHOAN where TEN_TAIKHOAN = @TEN_TAIKHOAN and MATKHAU = @MATKHAU
end

go
create proc LoadRoomList
as
begin
	select * from PHONG
end

-------TAI KHOAN-------
insert into TAIKHOAN values('QuanLy1','QuanLy1','123456',0)
insert into TAIKHOAN values('NhanVien1','NhanVien1','123456',1)
--select * from TAIKHOAN where TEN_TAIKHOAN = 'QuanLy1' and MATKHAU = '123456'

--------PHONG----------
insert into PHONG values
('N101',150000,N'Trống','NOR'),
('N102',150000,N'Trống','NOR'),
('N201',150000,N'Trống','NOR'),
('N202',150000,N'Trống','NOR'),
('N301',150000,N'Trống','NOR'),
('N302',150000,N'Trống','NOR'),
('V101',200000,N'Trống','VIP'),
('V102',200000,N'Trống','VIP'),
('V201',200000,N'Trống','VIP'),
('V202',200000,N'Trống','VIP'),
('V301',200000,N'Trống','VIP'),
('V302',200000,N'Trống','VIP')

insert into DICHVU values
(N'Cá viên',10000),
(N'Bắp rang',10000),
(N'Rong biển',30000),
(N'Hạt điều',10000),
(N'Đậu phộng',10000),
(N'Nước suối',10000),
(N'Coca',15000),
(N'Bia',30000)

insert into NHANVIEN values
(N'Nguyễn Văn A','01/01/1990',1,'123456789','0901234560',N'123, Láng Hạ, Đống Đa, Hà Nội','NguyenVanA@gmail.com'),
(N'Nguyễn Thị Hà','02/02/1991',0,'123456788','0901234561',N'123, Láng Hạ, Đống Đa, Hà Nội','NguyenThiHA@gmail.com'),
(N'Lê Tuyết Anh','03/03/1992',0,'123456787','0901234562',N'127, Láng Hạ, Đống Đa, Hà Nội','LeTuyetAnh@gmail.com'),
(N'Trần Văn Nam','04/04/1993',1,'123456789','0901234563',N'152, Láng Hạ, Đống Đa, Hà Nội','TranVanNam@gmail.com')

insert into CHITIETHOADON values
(''),
(),
()
Update TAIKHOAN
set TEN_HIENTHI = 'NhanVien1', LOAITAIKHOAN = 1 where TEN_TAIKHOAN = 'NhanVien1'