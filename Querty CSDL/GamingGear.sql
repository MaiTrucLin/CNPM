create database GamingGear
use GamingGear
create table KIEUPK(
					MakieuPK varchar(10) primary key,
					TenkieuPK nvarchar(30))
create table HANG(
					MaHANG varchar(10) primary key,
					Tenhang nvarchar(30),
					Quocgia nvarchar(30)
				)
create table NHACUNGCAP(
					MaNCC varchar(10) primary key,
					TenNCC nvarchar(30),
					Diachi nvarchar(50),
					soFax char(20),
					Mail char(30),
					)
create table LOAIPK(
					MaloaiPK varchar(10) primary key,
					TenloaiPK nvarchar(30),
					Gia real,
					MaHANG varchar(10),
					Thoigianbaohanh int,
					Soluongcuahang int,
					Soluongkho int,
					MaNCC varchar(10)
					foreign key(MaHANG) references HANG(MaHANG), 
					foreign key(MaNCC) references NHACUNGCAP(MaNCC)
					)
create table PHUKIEN(
					MaPK varchar(10) primary key,
					MaloaiPK varchar(10),
					MakieuPK varchar(10),
					foreign key(MaloaiPK) references LOAIPK(MaloaiPK), 
					foreign key(MakieuPK) references KIEUPK(MakieuPK),
					Thoigianbaohanh date,
					TTDaban bit,
					Vitri bit,
					)
create table TAIKHOAN(
					MaTK varchar(10) primary key,
					Id varchar(30), 
					Pw varchar(30),
					Phanquyen int,
					MaNV varchar(10),
					
					)
create table NHANVIEN(
					MaNV varchar(10) primary key,
					TenNV nvarchar(30),
					NgaySinh date,
					Diachi nvarchar(30),
					Chucvu nvarchar(30),
					Luong real,
					MaTK varchar(10)
					)				
create table THANHTOAN(
					MaTToan varchar(10) primary key,
					MaPK varchar(10)
					foreign key (MaPK) references PHUKIEN(MaPK)
					)
create table HOADON(
					MaHD varchar(10) primary key,
					MaTToan varchar(10),
					TenKH nvarchar(30),
					MaNV varchar(10),
					NgayxuatHD datetime,
					TongTienTT real
					foreign key(MaNV) references NHANVIEN(MaNV),
					foreign key(MaTToan) references THANHTOAN(MaTToan))
create table PHUKIENBAOHANH(
					MaPK varchar(10) primary key,
					Thoigianbaohanh date,
					Hantra date,
					TenKH nvarchar(30),
					SDT varchar(12),
					SoCMND varchar(14),
					Trangthai bit,
					MaNV varchar(10),
					Ngayhoantra date,
					Ngayhoantrathucte date
					)
Alter Table NHANVIEN add constrain NV_TK foreign key(MaNV) references NHANVIEN(MaNV)
Alter Table TAIKHOAN add constrain TK_NV foreign key(MaTK) REFERENCES TAIKHOAN(MaTK)	

--Dữ liệu nhân viên
insert into NHANVIEN values('NV001',N'Phạm Trung Dũng','1999/05/09',N'99 Lê Văn Việt',N'Giám đốc','10000000','TK001');
insert into NHANVIEN values('NV002',N'Nguyễn Thị Hồng','1999/06/20',N'99 Lê Văn Chí',N'Thu ngân','1000000','TK004');
insert into NHANVIEN values('NV003',N'Nguyễn Thị Phương Mai','1999/05/09',N'99 Lê Văn Việt',N'Thu ngân','1000000','TK005');
insert into NHANVIEN values('NV004',N'Trần Minh Tuy','1999/05/09',N'99 Lê Văn Việt',N'Thu ngân','1000000','TK006');
insert into NHANVIEN values('NV005',N'Võ Hoàng Hiệp','1999/05/09',N'99 Lê Văn Việt',N'Thu ngân','1000000','TK007');
insert into NHANVIEN values('NV006',N'Mai Trúc Lin','1999/05/09',N'99 Lê Văn Việt',N'Thu ngân','1000000','TK008');
insert into NHANVIEN values('NV007',N'Lâm Ngọc Anh','1999/05/09',N'99 Lê Văn Việt',N'Thu ngân','1000000','TK009');
insert into NHANVIEN values('NV008',N'Lê Gia Trung','1999/05/09',N'99 Lê Văn Việt',N'Quản lý kho','10000000','TK010');
insert into NHANVIEN values('NV009',N'Nguyễn Trọng','1999/05/09',N'99 Lê Văn Việt',N'Quản lý kho','10000000','TK011');
insert into NHANVIEN values('NV010',N'Nguyễn Vy','1999/05/09',N'99 Lê Văn Việt',N'Nhân viên bảo hành','10000000','TK012');
insert into NHANVIEN values('NV011',N'Nguyễn Nam','1999/05/09',N'99 Lê Văn Việt',N'Nhân viên bảo hành','10000000','TK013');


-- Du lieu KieuPK
insert into KIEUPK values('KPK001',N'Bàn phím');
insert into KIEUPK values('KPK002',N'Chuột');
insert into KIEUPK values('KPK003',N'VGA');
insert into KIEUPK values('KPK004',N'Headphone');
-- Du lieu HANG
insert into HANG values('HANG01','MSI','Pinoy');
insert into HANG values('HANG02','PPColor','United State');	
insert into HANG values('HANG03','NVIDIA','United State');
insert into HANG values('HANG04','DELL','United State');
insert into HANG values('HANG05','ASUS','United State');
insert into HANG values('HANG06','APLE','United State');
insert into HANG values('HANG07','HTC','CHINA');
-- Du lieu NhaCungCap
insert into NHACUNGCAP values('NCC001','Phong Vũ','16 Tuyên Quang','12345678','phongvu@gmail.com');
insert into NHACUNGCAP values('NCC002','Laptopno1','16 Võ Văn Ngân','87654321','laptop1@gmail.com');
insert into NHACUNGCAP values('NCC003','FPT','16 Tuyên Quang','12345678','fpt@gmail.com');
insert into NHACUNGCAP values('NCC004','Laptopnew','16 Võ Văn Ngân','87654321','laptopnew@gmail.com');
insert into NHACUNGCAP values('NCC005','SPKT','16 Tuyên Quang','12345678','phongvu@gmail.com');
insert into NHACUNGCAP values('NCC006','Intel','16 Võ Văn Ngân','87654321','laptop1@gmail.com');
insert into NHACUNGCAP values('NCC007','Trung Dung','14 Le Van Viet','12345678','phongvu@gmail.com');
insert into NHACUNGCAP values('NCC008','KTXD2','124 Võ Văn Ngân','87654321','laptop1@gmail.com');
-- Du lieu LoaiPK
insert into LOAIPK values ('Loai001','Gefore970',2000,'HANG02',6,13,13,'NCC002');
insert into LOAIPK values ('Loai002','GeforeTitan',4000,'HANG01',6,13,13,'NCC001');
insert into LOAIPK values ('Loai003','Gefore970',2000,'HANG03',6,13,13,'NCC002');
insert into LOAIPK values ('Loai004','GeforeTitanX',4000,'HANG03',6,13,13,'NCC001');
insert into LOAIPK values ('Loai005','Gefore980',1000,'HANG03',6,13,13,'NCC002');
insert into LOAIPK values ('Loai006','GeforeTitanZ',2100,'HANG03',6,13,13,'NCC001');
insert into LOAIPK values ('Loai007','Gefore975',1200,'HANG03',6,13,13,'NCC002');
insert into LOAIPK values ('Loai008','GeforeTitanM',2000,'HANG03',6,13,13,'NCC001');
insert into LOAIPK values ('Loai009','GeforeTitanX2',3200,'HANG03',6,13,13,'NCC001');
insert into LOAIPK values ('Loai0010','GeforeTitanZ1',2100,'HANG03',6,13,13,'NCC001');
insert into LOAIPK values ('Loai0011','Gefore985',3100,'HANG03',6,13,13,'NCC002');
insert into LOAIPK values ('Loai0012','GeforeTitanZ2',5100,'HANG03',6,13,13,'NCC001');
insert into LOAIPK values ('Loai0013','Gefore990',2000,'HANG03',6,13,13,'NCC002');
insert into LOAIPK values ('Loai0014','GeforeTitanZ1',1200,'HANG03',6,13,13,'NCC001');
insert into LOAIPK values ('Loai0015','Gefore1070',6000,'HANG02',6,13,13,'NCC002');
insert into LOAIPK values ('Loai0016','GeforeTitanM1',9000,'HANG01',6,13,13,'NCC001');
insert into LOAIPK values ('Loai0017','Gefore1080',4000,'HANG02',6,13,13,'NCC002');
insert into LOAIPK values ('Loai0018','GeforeTitanM!',4000,'HANG01',6,13,13,'NCC001');

-- Du lieu PHUKIEN
insert into PHUKIEN values('Gear001','Loai001','KPK001',null,0,1);
insert into PHUKIEN values('Gear002','Loai002','KPK002',null,0,1);
insert into PHUKIEN values('Gear003','Loai001','KPK003',null,0,1);
insert into PHUKIEN values('Gear004','Loai002','KPK001',null,0,1);
insert into PHUKIEN values('Gear005','Loai001','KPK002',null,0,1);
insert into PHUKIEN values('Gear006','Loai003','KPK003',null,0,1);
insert into PHUKIEN values('Gear007','Loai004','KPK001',null,0,1);
insert into PHUKIEN values('Gear008','Loai005','KPK002',null,0,1);
insert into PHUKIEN values('Gear009','Loai006','KPK003',null,0,1);
insert into PHUKIEN values('Gear010','Loai007','KPK001',null,0,1);
insert into PHUKIEN values('Gear011','Loai008','KPK002',null,0,1);
insert into PHUKIEN values('Gear012','Loai009','KPK001',null,0,1);
insert into PHUKIEN values('Gear013','Loai010','KPK002',null,0,1);
insert into PHUKIEN values('Gear014','Loai011','KPK001',null,0,1);
insert into PHUKIEN values('Gear015','Loai012','KPK003',null,0,1);
insert into PHUKIEN values('Gear016','Loai002','KPK001',null,0,1);
insert into PHUKIEN values('Gear017','Loai001','KPK003',null,0,1);
insert into PHUKIEN values('Gear018','Loai002','KPK001',null,0,1);
insert into PHUKIEN values('Gear019','Loai001','KPK003',null,0,1);
insert into PHUKIEN values('Gear020','Loai002','KPK001',null,0,1);
-- Du lieu Taikhoang
insert into TAIKHOAN values('TK001','quanlydung','12345677','1','NV001');
insert into TAIKHOAN values('TK002','quanlytrung','12345677','1','NV002');
insert into TAIKHOAN values('TK003','quanlypham','12345677','1','NV003');
insert into TAIKHOAN values('TK004','thunganha','12345677','2','NV004');
insert into TAIKHOAN values('TK005','thungannam','12345677','2','NV005');
insert into TAIKHOAN values('TK006','thunganlin','12345677','2','NV006');
insert into TAIKHOAN values('TK007','thunganmai','12345677','2','NV007');
insert into TAIKHOAN values('TK008','thungannuong','12345677','2','NV008');
insert into TAIKHOAN values('TK009','thunganhanh','12345677','2','NV009');
insert into TAIKHOAN values('TK010','quanlykhohang','12345677','3','NV010');
insert into TAIKHOAN values('TK011','quanlykhonam','12345677','3','NV011');
insert into TAIKHOAN values('TK012','nvtnbh_nam','12345677','4','NV012');
insert into TAIKHOAN values('TK013','nvtnbh_linh','12345677','4','NV013');


--Trigger

CREATE trigger TrungTaiKhoan on TAIKHOAN
after insert
as
begin 
	if update (Id)
	begin
		declare @tk varchar(20)
		set @tk =(select Id from inserted)
		declare @count int 
		set @count =(select count (*) from TAIKHOAN where Id =@tk)
		if (@count > 1)
		begin 
				raiserror ('Co  ten bi trung',16,1)
				rollback 
		end
	end
end






--Hàm trả về kiểu vô hướng
--Hàm trả về giá của phụ kiên
CREATE FUNCTION GiaPK(@mpk varchar(10)) 
RETURNS real
AS
BEGIN
	DECLARE @gia real;
	SELECT @gia=LOAIPK.Gia
	FROM PHUKIEN,LOAIPK
	WHERE PHUKIEN.MaloaiPK=LOAIPK.MaloaiPK and PHUKIEN.MaPK=@mpk
	Return @gia
END
print dbo.GiaPK('Gear001')
---Hàm trả về tên hãng 
CREATE FUNCTION TenHANG(@mpk varchar(10))
	RETURNS NVARCHAR(30) 
	AS
	BEGIN
	DECLARE @hang nvarchar(30)
	SELECT @hang=HANG.Tenhang
	FROM PHUKIEN,HANG,LOAIPK
	WHERE PHUKIEN.MaloaiPK=LOAIPK.MaloaiPK and LOAIPK.MaHANG=HANG.MaHANG and PHUKIEN.MaPK =@mpk
	RETURN @hang
	END
print dbo.TenHANG('Gear001')
---Hàm trả về 


--Ham-- trả về bảng
--Xem thông tin loại phụ kiên thông qua mã
CREATE FUNCTION XEMPK(@mapk varchar(10)) 
	RETURNS TABLE     
	AS 
	RETURN(SELECT TenloaiPK,Gia,Thoigianbaohanh,Soluongcuahang,Soluongkho
	FROM LOAIPK
	WHERE MaloaiPK=@mapk)
	SELECT * FROM XEMPK('Loai001')
-- Xem thông tin tất cả phụ kiện cùng một một mã loại
CREATE FUNCTION XEMDSPK(@maloaipk varchar(10)) 
	RETURNS TABLE     
	AS 
	RETURN(SELECT MaPK,TenloaiPK,MakieuPK
	FROM LOAIPK INNER JOIN PHUKIEN
	ON PHUKIEN.MaloaiPK=LOAIPK.MaloaiPK
	WHERE PHUKIEN.MaloaiPK=@maloaipk)
Select * FROM XEMDSPK('Loai001')
---Thống kê số phụ kiện của mỗi loại
CREATE FUNCTION TongPK()
RETURNS @bangthongke TABLE
     (
			MaloaiPK varchar(10),
			TenloaiPK nvarchar(30),
            Tongsopk    INT
      ) 
AS
      BEGIN
           
                  INSERT INTO @bangthongke
                  SELECT LOAIPK.MaloaiPK,LOAIPK.TenloaiPK,COUNT(MaPK) 
				  FROM (LOAIPK INNER JOIN PHUKIEN
							ON PHUKIEN.MaloaiPK=LOAIPK.MaloaiPK)
						GROUP BY LOAIPK.MaloaiPK,LOAIPK.TenloaiPK
            RETURN /*Trả kết quả về cho hàm*/
      END
SELECT * From TongPK()
---Thống kê phụ kiện của mỗi kiểu
CREATE FUNCTION TongKPK()
RETURNS @bangthongke TABLE
     (
			MakieuPK varchar(10),
			TenkieuPK nvarchar(30),
            Tongsopk    INT
      ) 
AS
      BEGIN         
                  INSERT INTO @bangthongke
                  SELECT KIEUPK.MakieuPK,KIEUPK.TenkieuPK,COUNT(MaPK) 
				  FROM (KIEUPK INNER JOIN PHUKIEN
							ON PHUKIEN.MakieuPK=KIEUPK.MakieuPK)
						GROUP BY KIEUPK.MakieuPK,KIEUPK.TenkieuPK
            RETURN /*Trả kết quả về cho hàm*/
      END
SELECT * From TongKPK()
--Danh sách sản phẩm của một hãng
--CREATE FUNCTION SanphamHang(@tenhang varchar(30))
CREATE FUNCTION SanphamHang(@tenhang varchar(30))
RETURNS @bangthongke TABLE	
	     (
			MaPK varchar(10),
			TenloaiPK nvarchar(30),
			TenkieuPK nvarchar(30)
		) 
	AS
     BEGIN         
                  INSERT INTO @bangthongke
                  SELECT PHUKIEN.MaPK,LOAIPK.TenloaiPK,KIEUPK.TenkieuPK
				  FROM LOAIPK,HANG,PHUKIEN,KIEUPK
				  WHERE	HANG.Tenhang = @tenhang and LOAIPK.MaHANG=HANG.MaHANG 
						and KIEUPK.MakieuPK=PHUKIEN.MakieuPK and PHUKIEN.MaloaiPK=LOAIPK.MaloaiPK		  
            RETURN /*Trả kết quả về cho hàm*/
      END
--Tìm phụ kiện theo hãng MSi-
SELECT * FROM SanphamHang('MSi')
--Tìm phụ kiện theo hãng PPColor
SELECT * FROM SanphamHang('PPColor')
---Produce
--Đổi mật khẩu
create procedure DoiMatKhau(@username varchar(30),@passwordcu varchar(30),@passwordmoi varchar(30))
as
begin tran
	declare @matkhaucu char(40), @matkhaumoi char(40)
	select @matkhaucu = TAIKHOAN.Pw from TAIKHOAN where TaiKhoan.Id=@username
	if (@matkhaucu=@passwordcu)
	begin
		set @matkhaumoi = @passwordmoi
		update TAIKHOAN set Pw = @passwordmoi where TaiKhoan.Id=@username
	end
if (@@ERROR<>0)
begin
	RAISERROR (N' có lỗi xảy ra khi đổi mật khẩu',16,1)
	rollback tran
	return
end
commit