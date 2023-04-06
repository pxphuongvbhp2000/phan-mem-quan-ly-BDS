CREATE DATABASE DoAnTotNghiep
GO

USE DoAnTotNghiep
GO

CREATE TABLE NhanVien 
(
	id VARCHAR(50) PRIMARY KEY,
	matkhaudangnhap  VARCHAR(50),
	hoten NVARCHAR(50),
	gioitinh NVARCHAR(5),
	ngaysinh DATE,
	sothecancuoc VARCHAR(20),
	nguyenquan NVARCHAR(200),
	diachithuongtru NVARCHAR(200),
	sdt VARCHAR(10),
	email VARCHAR(100),
	nganhang NVARCHAR(200),
	sotaikhoan VARCHAR(20),
	idchinhanh VARCHAR(10),
	idphongban VARCHAR(10),
	idchucvu VARCHAR(10),
	idnhomquyen VARCHAR(10),
	masothue VARCHAR(20),
	trangthai VARCHAR(20),
	ghichu TEXT
);
GO

CREATE TABLE ChiNhanh 
(
	id VARCHAR(10) PRIMARY KEY,
	tenchinhanh NVARCHAR(100),
	diachi NVARCHAR(100),
	ghichu TEXT
);
GO

CREATE TABLE PhongBan 
(
	id VARCHAR(10) PRIMARY KEY,
	tenphongban NVARCHAR(100),
	vitri NVARCHAR(100),
	ghichu TEXT
);
GO

CREATE TABLE ChucVu 
(
	id VARCHAR(10) PRIMARY KEY,
	tenchucvu NVARCHAR(100),
	ghichu TEXT
);
GO

CREATE TABLE NhomQuyen 
(
	id VARCHAR(10) PRIMARY KEY,
	tennhomquyen NVARCHAR(100),
	ghichu TEXT
);
GO

CREATE TABLE PhanQuyen 
(
	id VARCHAR(10) PRIMARY KEY,
	tenphanquyen NVARCHAR(100),
);
GO

CREATE TABLE NhomQuyenChiTiet
(
	idnhomquyen VARCHAR(10),
	idphanquyen VARCHAR(10),
	PRIMARY KEY(idnhomquyen, idphanquyen)
);
GO

CREATE TABLE ChuDauTu
(
	id VARCHAR(50) PRIMARY KEY,
	tencongty NVARCHAR(100),
	diachi NVARCHAR(200),
	sdt VARCHAR(10),
	email VARCHAR(100),
	website VARCHAR(100),
	ghichu TEXT
);
GO

CREATE TABLE DuAn 
(
	id VARCHAR(50) PRIMARY KEY,
	idchudautu VARCHAR(50),
	tenduan NVARCHAR(100),
	vitri NVARCHAR(200),
	dientich FLOAT,
	sogiayphep VARCHAR(20),
	noicap NVARCHAR(200),
	ngaycap DATE,
	idnhanvienphutrach VARCHAR(50),
	ghichu TEXT
);
GO

CREATE TABLE KhuDat
(
	id VARCHAR(50) PRIMARY KEY,
	idduan VARCHAR(50),
	tenkhu NVARCHAR(100),
	vitri NVARCHAR(200),
	soluonglo INT,
	dientich FLOAT,
	ghichu TEXT,
);
GO

CREATE TABLE LoaiBatDongSan
(
	id VARCHAR(10) PRIMARY KEY,
	tenloaiBDS NVARCHAR(100),
	ghichu TEXT
);
GO

CREATE TABLE BatDongSan
(
	id VARCHAR(50) PRIMARY KEY,
	idkhudat VARCHAR(50),
	idloaiBDS VARCHAR(10),
	diachi NVARCHAR(200),
	huong NVARCHAR(20),
	rong FLOAT,
	dai FLOAT,
	dientichdat FLOAT,
	dientichsantruoc FLOAT,
	dientichsansau FLOAT,
	dongia FLOAT,
	tylechietkhau FLOAT,
	tyleVAT FLOAT,
	trangthai NVARCHAR(20),
	ghichu TEXT
);
GO



CREATE TABLE KhachHang 
(
	id VARCHAR(50) PRIMARY KEY,
	hoten NVARCHAR(50),
	gioitinh NVARCHAR(5),
	ngaysinh DATE,
	sothecancuoc VARCHAR(20),
	nguyenquan NVARCHAR(200),
	diachithuongtru NVARCHAR(200),
	sdt VARCHAR(10),
	email VARCHAR(100),
	masothue VARCHAR(20),
	idnhanvienphutrach VARCHAR(50),
	ghichu TEXT
);
GO

CREATE TABLE AnhCanCuoc 
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idkhachhang VARCHAR(50),
	anhcancuoc IMAGE DEFAULT NULL
);
GO

CREATE TABLE AnhHoKhau
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idkhachhang VARCHAR(50),
	anhhokhau IMAGE DEFAULT NULL
);
GO

CREATE TABLE AnhKetHon
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idkhachhang VARCHAR(50),
	anhkethon IMAGE DEFAULT NULL
);
GO

CREATE TABLE NhuCau 
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idkhachhang VARCHAR(50),
	diachi NVARCHAR(200),
	huong NVARCHAR(100),
	rong VARCHAR(100),
	dai VARCHAR(100),
	dientichdat VARCHAR(100),
	dientichsantruoc VARCHAR(100),
	dientichsansau VARCHAR(100),
	dongia VARCHAR(100),
	ghichu TEXT
);
GO

CREATE TABLE PhieuGiuCho
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idkhachhang VARCHAR(50),
	idBDS VARCHAR(50),
	ngaylapphieu DATE,
	ngayhethan DATE,
	tiencoc FLOAT,
	tiendohoanthanh FLOAT,
	uutien INT,
	trangthai NVARCHAR(20),
	ghichu TEXT
);
GO

CREATE TABLE AnhGiuCho
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idphieugiucho INT,
	anhgiucho IMAGE DEFAULT NULL
);
GO

CREATE TABLE LichThanhToanGiuCho
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idphieugiucho INT,
	ngaythu DATE,
	sotien FLOAT,
	phantram FLOAT,
	trangthai NVARCHAR(20),
	anhphieuthu IMAGE DEFAULT NULL,
	ghichu TEXT
);
GO

CREATE TABLE PhieuDatCoc
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idkhachhang VARCHAR(50),
	idBDS VARCHAR(50),
	ngaylapphieu DATE,
	ngayhethan DATE,
	tiencoc FLOAT,
	tiendohoanthanh FLOAT,
	tienboithuong FLOAT,
	trangthai NVARCHAR(20),
	ghichu TEXT
);
GO

CREATE TABLE AnhDatCoc
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idphieudatcoc INT,
	anhdatcoc IMAGE DEFAULT NULL
);
GO

CREATE TABLE LichThanhToanDatCoc
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idphieudatcoc INT,
	ngaythu DATE,
	sotien FLOAT,
	phantram FLOAT,
	trangthai NVARCHAR(20),
	anhphieuthu IMAGE DEFAULT NULL,
	ghichu TEXT
);
GO

CREATE TABLE HopDongMuaBan
(
	id VARCHAR(50) PRIMARY KEY,
	idkhachhang VARCHAR(50),
	idBDS VARCHAR(50),
	ngaylap DATE,
	thanhtien FLOAT,
	tiendohoanthanh FLOAT,
	muchoahongCT FLOAT,
	muchoahongNV FLOAT,
	trangthai NVARCHAR(20),
	ghichu TEXT
);
GO

CREATE TABLE AnhHopDong
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idhopdongmuaban VARCHAR(50),
	anhhopdong IMAGE DEFAULT NULL
);
GO

CREATE TABLE LichThanhToanHopDong
(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	idhopdongmuaban VARCHAR(50),
	ngaythu DATE,
	sotien FLOAT,
	phantram FLOAT,
	trangthai NVARCHAR(20),
	anhphieuthu IMAGE DEFAULT NULL,
	ghichu TEXT
);
GO

ALTER TABLE NhanVien ADD FOREIGN KEY (idchinhanh) REFERENCES ChiNhanh (id);
GO

ALTER TABLE NhanVien ADD FOREIGN KEY (idphongban) REFERENCES PhongBan (id);
GO

ALTER TABLE NhanVien ADD FOREIGN KEY (idchucvu) REFERENCES ChucVu (id);
GO

ALTER TABLE NhanVien ADD FOREIGN KEY (idnhomquyen) REFERENCES NhomQuyen (id);
GO

ALTER TABLE NhomQuyenChiTiet ADD FOREIGN KEY (idnhomquyen) REFERENCES NhomQuyen (id);
GO

ALTER TABLE NhomQuyenChiTiet ADD FOREIGN KEY (idphanquyen) REFERENCES PhanQuyen (id);
GO

ALTER TABLE BatDongSan ADD FOREIGN KEY (idloaiBDS) REFERENCES LoaiBatDongSan (id);
GO

ALTER TABLE BatDongSan ADD FOREIGN KEY (idkhudat) REFERENCES KhuDat (id);
GO

ALTER TABLE DuAn ADD FOREIGN KEY (idchudautu) REFERENCES ChuDauTu (id);
GO

ALTER TABLE DuAn ADD FOREIGN KEY (idnhanvienphutrach) REFERENCES NhanVien (id);
GO

ALTER TABLE KhuDat ADD FOREIGN KEY (idduan) REFERENCES DuAn (id);
GO

ALTER TABLE KhachHang ADD FOREIGN KEY (idnhanvienphutrach) REFERENCES NhanVien (id);
GO

ALTER TABLE AnhCanCuoc ADD FOREIGN KEY (idkhachhang) REFERENCES KhachHang (id);
GO

ALTER TABLE AnhHoKhau ADD FOREIGN KEY (idkhachhang) REFERENCES KhachHang (id);
GO

ALTER TABLE AnhKetHon ADD FOREIGN KEY (idkhachhang) REFERENCES KhachHang (id);
GO

ALTER TABLE NhuCau ADD FOREIGN KEY (idkhachhang) REFERENCES KhachHang (id);
GO

ALTER TABLE PhieuGiuCho ADD FOREIGN KEY (idkhachhang) REFERENCES KhachHang (id);
GO

ALTER TABLE PhieuGiuCho ADD FOREIGN KEY (idBDS) REFERENCES BatDongSan (id);
GO

ALTER TABLE AnhGiuCho ADD FOREIGN KEY (idphieugiucho) REFERENCES PhieuGiuCho (id);
GO

ALTER TABLE LichThanhToanGiuCho ADD FOREIGN KEY (idphieugiucho) REFERENCES PhieuGiuCho (id);
GO

ALTER TABLE PhieuDatCoc ADD FOREIGN KEY (idkhachhang) REFERENCES KhachHang (id);
GO

ALTER TABLE PhieuDatCoc ADD FOREIGN KEY (idBDS) REFERENCES BatDongSan (id);
GO

ALTER TABLE AnhDatCoc ADD FOREIGN KEY (idphieudatcoc) REFERENCES PhieuDatCoc (id);
GO

ALTER TABLE LichThanhToanDatCoc ADD FOREIGN KEY (idphieudatcoc) REFERENCES PhieuDatCoc (id);
GO

ALTER TABLE HopDongMuaBan ADD FOREIGN KEY (idkhachhang) REFERENCES KhachHang (id);
GO

ALTER TABLE HopDongMuaBan ADD FOREIGN KEY (idBDS) REFERENCES BatDongSan (id);
GO

ALTER TABLE AnhHopDong ADD FOREIGN KEY (idhopdongmuaban) REFERENCES HopDongMuaBan (id);
GO

ALTER TABLE LichThanhToanHopDong ADD FOREIGN KEY (idhopdongmuaban) REFERENCES HopDongMuaBan (id);
GO

INSERT INTO ChiNhanh(id, tenchinhanh, diachi, ghichu) VALUES ('CNHP', N'Chi Nhánh Hải Phòng', N'Nguyễn Bình, Hải Phòng', N'');
GO
INSERT INTO ChiNhanh(id, tenchinhanh, diachi, ghichu) VALUES ('CNHN', N'Chi Nhánh Hà Nội', N'Thủ Đức, Hà Nội', N'');
GO

INSERT INTO PhongBan (id, tenphongban, vitri, ghichu) VALUES ('PBKT', N'Phòng Nhân Sự', N'Phòng 1 Tầng 1', N'');
GO
INSERT INTO PhongBan (id, tenphongban, vitri, ghichu) VALUES ('PBHC', N'Phòng Tài Chính', N'Phòng 2 Tầng 1', N'');
GO
INSERT INTO PhongBan (id, tenphongban, vitri, ghichu) VALUES ('PBKD', N'Phòng Kinh Doanh', N'Phòng 3 Tầng 1', N'');
GO

INSERT INTO ChucVu(id, tenchucvu, ghichu) VALUES ('CVGD', N'Giám Đốc', N'');
GO
INSERT INTO ChucVu(id, tenchucvu, ghichu) VALUES ('CVTP', N'Trưởng Phòng', N'');
GO
INSERT INTO ChucVu(id, tenchucvu, ghichu) VALUES ('CVPP', N'Phó Phòng', N'');
GO
INSERT INTO ChucVu(id, tenchucvu, ghichu) VALUES ('CVNV', N'Nhân Viên', N'');
GO


INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQNV', N'Quản Lý Nhân Viên');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQCN', N'Quản Lý Chi Nhánh');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQPB', N'Quản Lý Phòng Ban');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQCV', N'Quản Lý Chức Vụ');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQNQ', N'Quản Lý Nhóm Quyền');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQDS', N'Quản Lý Bất Động Sản');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQLD', N'Quản Lý Loại Bất Động Sản');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQDT', N'Quản Lý Chủ Đầu Tư');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQDA', N'Quản Lý Dự Án');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQKD', N'Quản Lý Khu Đất');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQKH', N'Quản Lý Khách Hàng');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQNC', N'Quản Lý Nhu Cầu');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQHD', N'Quản Lý Hợp Đồng');
GO
INSERT INTO PhanQuyen(id, tenphanquyen) VALUES ('PQTB', N'Thống Kê Báo Cáo');
GO

INSERT INTO NhomQuyen(id, tennhomquyen, ghichu) VALUES ('NQ00', N'o', N'');
GO
INSERT INTO NhomQuyen(id, tennhomquyen, ghichu) VALUES ('NQKT', N'Nhóm Quyền Kế Toán', N'');
GO
INSERT INTO NhomQuyen(id, tennhomquyen, ghichu) VALUES ('NQHC', N'Nhóm Quyền Tài Chính', N'');
GO
INSERT INTO NhomQuyen(id, tennhomquyen, ghichu) VALUES ('NQKD', N'Nhóm Quyền Kinh Doanh', N'');
GO

INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQNV');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQCN');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQPB');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQCV');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQNQ');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQDS');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQLD');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQDT');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQDA');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQKD');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQKH');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQNC');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQHD');
GO
INSERT INTO NhomQuyenChiTiet VALUES ('NQ00', 'PQTB');
GO

INSERT INTO NhanVien (id, matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan,
	diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,
	trangthai, ghichu
) VALUES (
	'NVA001221', '123', N'Nguyễn Văn Anh', N'Nam', '2000/12/21', '031200010954', N'Hải Phòng', N'Nguyễn Bình',
	'0123456789', 'VanA@gmail.com', 'MBbank', '12345678952145', 'CNHP', 'PBKD', 'CVGD', 'NQ00',
	'101234568', N'Ofline', N'');
GO

INSERT INTO NhanVien (id, matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan,
	diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,
	trangthai, ghichu
) VALUES (
	'PVQ991121', '123', N'Phạm Văn Quang', N'Nam', '1999/11/21', '031200010954', N'Hải Phòng', N'Nguyễn Bình',
	'0123456789', 'VanA@gmail.com', 'MBbank', '12345678952145', 'CNHP', 'PBKD', 'CVGD', 'NQ00',
	'101234568', N'Ofline', N'');
GO

INSERT INTO NhanVien (id, matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan,
	diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,
	trangthai, ghichu
) VALUES (
	'KTL991011', '123', N'Kim Thị Loan', N'Nam', '1999/10/11', '031200010954', N'Hải Phòng', N'Nguyễn Bình',
	'0123456789', 'VanA@gmail.com', 'MBbank', '12345678952145', 'CNHP', 'PBKD', 'CVGD', 'NQ00',
	'101234568', N'Ofline', N'');
GO

INSERT INTO ChuDauTu VALUES ('CTCPHH', N'Công ty CP Đầu tư Dịch vụ Tài chính Hoàng Huy', N'Số 116 Nguyễn Đức Cảnh, quận Lê Chân, TP. Hải Phòng', '0123456789', 'info@hoanghuy.vn', 'https://hoanghuy.com.vn', N'');


INSERT INTO DuAn VALUES ('DAHH', 'CTCPHH', N'Dự Án Hoàng Huy Plaza', N'Tô Hiệu, Hải Phòng', 2000, '0123456789', N'Hải Phòng', '2021/11/11', 'NVA001221', N'');
GO

INSERT INTO DuAn VALUES ('DAQV', 'CTCPHH', N'Dự Án Quang Vinh', N'Quang Vinh, Hải Phòng', 3000, '0123456789', N'Hải Phòng', '2022/01/13', 'NVA001221', N'');
GO

INSERT INTO KhuDat VALUES ('HH/A', 'DAHH', N'Khu Đất Nhà A', N'119, Tô Hiệu', 100, 500, N'');
GO
INSERT INTO KhuDat VALUES ('HH/B', 'DAHH', N'Khu Đất Nhà B', N'119, Tô Hiệu', 100, 500, N'');
GO
INSERT INTO KhuDat VALUES ('QV/A', 'DAQV', N'Khu Đất A', N'219, Quang Vinh', 100, 500, N'');
GO

INSERT INTO LoaiBatDongSan(id, tenloaiBDS, ghichu) VALUES ('LNP', N'Nhà Phố', N'');
GO
INSERT INTO LoaiBatDongSan(id, tenloaiBDS, ghichu) VALUES ('LDN', N'Đất Nền', N'');
GO
INSERT INTO LoaiBatDongSan(id, tenloaiBDS, ghichu) VALUES ('LCC', N'Chung Cư', N'');
GO
INSERT INTO LoaiBatDongSan(id, tenloaiBDS, ghichu) VALUES ('LCN', N'Đất Công Nghiệp', N'');
GO
INSERT INTO LoaiBatDongSan(id, tenloaiBDS, ghichu) VALUES ('LSH', N'Shop House', N'');
GO
INSERT INTO LoaiBatDongSan(id, tenloaiBDS, ghichu) VALUES ('LNN', N'Đất Nông Nghiệp', N'');
GO

INSERT INTO BatDongSan VALUES ('HH/A/1-1', 'HH/A', 'LCC', N'Nhà A, Tầng 1, Phòng 1', N'Đông', 5, 2, 120, 0, 0, 13000000, 0, 10, N'Mở Bán', N'')
GO
INSERT INTO BatDongSan VALUES ('HH/A/1-2', 'HH/B', 'LCC', N'Nhà A, Tầng 1, Phòng 2', N'Đông', 5, 2, 120, 0, 0, 13000000, 0, 10, N'Mở Bán', N'')
GO
INSERT INTO BatDongSan VALUES ('HH/B/1-1', 'QV/A', 'LCC', N'Nhà B, Tầng 1, Phòng 1', N'Đông', 5, 2, 120, 0, 0, 13000000, 0, 10, N'Mở Bán', N'')
GO

INSERT INTO KhachHang VALUES ('PT001221', N'Phạm Thái', N'Nam', '2000/12/21', '031200010954', N'Hải Phòng', N'Nguyễn Bình',
	'0123456789', 'PT@gmail.com', '101234568', 'NVA001221', N'')
GO

INSERT INTO KhachHang VALUES ('NT970121', N'Nguyễn Thành', N'Nam', '1997/01/21', '031200010954', N'Hải Phòng', N'Nguyễn Bình',
	'0123456789', 'NT@gmail.com', '101234568', 'KTL991011', N'')
GO

INSERT INTO KhachHang VALUES ('AT890311', N'Ánh Thơ', N'Nam', '1989/03/11', '031200010954', N'Hải Phòng', N'Nguyễn Bình',
	'0123456789', 'AT@gmail.com', '101234568', 'PVQ991121', N'')
GO

INSERT INTO NhuCau(idkhachhang, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau, dongia, ghichu) VALUES 
('PT001221', N'Hải Phòng', N'Đông', N'2 - 4 m', N'2 - 4 m', N'100 - 200 m2', N'3 - 6 m2', N'8 - 10 m', N'13000vnd/m2', N'')
GO


----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------


CREATE TRIGGER trg_MoBan_GiuCho ON PhieuGiuCho AFTER INSERT AS
BEGIN
	UPDATE BatDongSan SET BatDongSan.Trangthai = N'Giữ Chỗ' 
	WHERE BatDongSan.trangthai = N'Mở Bán' AND BatDongSan.id IN
	(
		SELECT idBDS FROM inserted
	)
END
GO


CREATE TRIGGER trg_GiuCho_MoBan ON PhieuGiuCho AFTER DELETE AS
BEGIN
	UPDATE BatDongSan SET BatDongSan.Trangthai = N'Mở Bán' 
	WHERE BatDongSan.trangthai = N'Giữ Chỗ' AND BatDongSan.id IN
	(
		SELECT idBDS FROM deleted
	)
END
GO

CREATE TRIGGER trg_GiuCho_DatCoc ON PhieuDatCoc AFTER INSERT AS
BEGIN
	UPDATE BatDongSan SET BatDongSan.Trangthai = N'Đặt Cọc' 
	WHERE (BatDongSan.trangthai = N'Mở Bán' OR BatDongSan.trangthai = N'Giữ Chỗ') AND BatDongSan.id IN
	(
		SELECT idBDS FROM inserted
	)
END
GO


CREATE TRIGGER trgDatCoc_MoBan ON PhieuDatCoc AFTER DELETE AS
BEGIN
	UPDATE BatDongSan SET BatDongSan.Trangthai = N'Mở Bán' 
	WHERE id IN
	(
		SELECT idBDS FROM deleted
	)
		
END
GO

CREATE TRIGGER trg_DatCoc_DangTienHanh ON HopDongMuaBan AFTER INSERT AS
BEGIN
	UPDATE BatDongSan SET BatDongSan.Trangthai = N'Đang Tiến Hành' 
	WHERE (BatDongSan.trangthai = N'Đặt Cọc' OR BatDongSan.trangthai = N'Giữ Chỗ' OR BatDongSan.trangthai = N'Mở Bán') AND BatDongSan.id IN
	(
		SELECT idBDS FROM inserted
	)
END
GO

CREATE TRIGGER trgDangTienHanh_MoBan ON HopDongMuaBan AFTER DELETE AS
BEGIN
	UPDATE BatDongSan SET BatDongSan.Trangthai = N'Mở Bán' 
	WHERE id IN
	(
		SELECT idBDS FROM deleted
	)
		
END
GO

CREATE TRIGGER trg_DangTienHanh_DaHoanThanh ON HopDongMuaBan AFTER UPDATE AS
BEGIN
	UPDATE BatDongSan SET BatDongSan.Trangthai = N'Đã Hoàn Thành' 
	WHERE id IN
	(
		SELECT HopDongMuaBan.idBDS FROM HopDongMuaBan
		WHERE HopDongMuaBan.tiendohoanthanh = 100
	)
	
END
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TRIGGER trg_TienDoPGC_INSERT ON LichThanhToanGiuCho AFTER INSERT AS
BEGIN
	UPDATE PhieuGiuCho SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanGiuCho.sotien) / PhieuGiuCho.tiencoc * 100
			FROM LichThanhToanGiuCho, inserted
			WHERE LichThanhToanGiuCho.idphieugiucho = inserted.idphieugiucho
			AND LichThanhToanGiuCho.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanGiuCho.idphieugiucho

	)
	WHERE PhieuGiuCho.id IN
	(
		SELECT idphieugiucho FROM inserted 
	)
	UPDATE PhieuGiuCho SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
	
END
GO



CREATE TRIGGER trg_TienDoPGC_UPDATE ON LichThanhToanGiuCho AFTER UPDATE AS
BEGIN
	UPDATE PhieuGiuCho SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanGiuCho.sotien) / PhieuGiuCho.tiencoc * 100
			FROM LichThanhToanGiuCho, inserted
			WHERE LichThanhToanGiuCho.idphieugiucho = inserted.idphieugiucho
			AND LichThanhToanGiuCho.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanGiuCho.idphieugiucho

	)
	WHERE PhieuGiuCho.id IN
	(
		SELECT idphieugiucho FROM inserted 
	)
	UPDATE PhieuGiuCho SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
END
GO

CREATE TRIGGER trg_TienDoPGC_DELETE ON LichThanhToanGiuCho AFTER DELETE AS
BEGIN
	UPDATE PhieuGiuCho SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanGiuCho.sotien) / PhieuGiuCho.tiencoc * 100
			FROM LichThanhToanGiuCho, deleted
			WHERE LichThanhToanGiuCho.idphieugiucho = deleted.idphieugiucho
			AND LichThanhToanGiuCho.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanGiuCho.idphieugiucho

	)
	WHERE PhieuGiuCho.id IN
	(
		SELECT idphieugiucho FROM deleted 
	)
	UPDATE PhieuGiuCho SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
END
GO


----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TRIGGER trg_TienDoPDC_INSERT ON LichThanhToanDatCoc AFTER INSERT AS
BEGIN
	UPDATE PhieuDatCoc SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanDatCoc.sotien) / PhieuDatCoc.tiencoc * 100
			FROM LichThanhToanDatCoc, inserted
			WHERE LichThanhToanDatCoc.idphieudatcoc = inserted.idphieudatcoc
			AND LichThanhToanDatCoc.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanDatCoc.idphieudatcoc

	)
	WHERE PhieuDatCoc.id IN
	(
		SELECT idphieudatcoc FROM inserted 
	)
	UPDATE PhieuDatCoc SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
	
END
GO



CREATE TRIGGER trg_TienDoPDC_UPDATE ON LichThanhToanDatCoc AFTER UPDATE AS
BEGIN
	UPDATE PhieuDatCoc SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanDatCoc.sotien) / PhieuDatCoc.tiencoc * 100
			FROM LichThanhToanDatCoc, inserted
			WHERE LichThanhToanDatCoc.idphieudatcoc = inserted.idphieudatcoc
			AND LichThanhToanDatCoc.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanDatCoc.idphieudatcoc

	)
	WHERE PhieuDatCoc.id IN
	(
		SELECT idphieudatcoc FROM inserted 
	)
	UPDATE PhieuDatCoc SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
END
GO

CREATE TRIGGER trg_TienDoPDC_DELETE ON LichThanhToanDatCoc AFTER DELETE AS
BEGIN
	UPDATE PhieuDatCoc SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanDatCoc.sotien) / PhieuDatCoc.tiencoc * 100
			FROM LichThanhToanDatCoc, deleted
			WHERE LichThanhToanDatCoc.idphieudatcoc = deleted.idphieudatcoc
			AND LichThanhToanDatCoc.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanDatCoc.idphieudatcoc

	)
	WHERE PhieuDatCoc.id IN
	(
		SELECT idphieudatcoc FROM deleted 
	)
	UPDATE PhieuDatCoc SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
END
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TRIGGER trg_TienDoHDMB_INSERT ON LichThanhToanHopDong AFTER INSERT AS
BEGIN
	UPDATE HopDongMuaBan SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanHopDong.sotien) / HopDongMuaBan.thanhtien * 100
			FROM LichThanhToanHopDong, inserted
			WHERE LichThanhToanHopDong.idhopdongmuaban = inserted.idhopdongmuaban
			AND LichThanhToanHopDong.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanHopDong.idhopdongmuaban

	)
	WHERE HopDongMuaBan.id IN
	(
		SELECT idhopdongmuaban FROM inserted 
	)
	UPDATE HopDongMuaBan SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
	
END
GO



CREATE TRIGGER trg_TienDoHDMB_UPDATE ON LichThanhToanHopDong AFTER UPDATE AS
BEGIN
	UPDATE HopDongMuaBan SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanHopDong.sotien) / HopDongMuaBan.thanhtien * 100
			FROM LichThanhToanHopDong, inserted
			WHERE LichThanhToanHopDong.idhopdongmuaban = inserted.idhopdongmuaban
			AND LichThanhToanHopDong.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanHopDong.idhopdongmuaban

	)
	WHERE HopDongMuaBan.id IN
	(
		SELECT idhopdongmuaban FROM inserted 
	)
	UPDATE HopDongMuaBan SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
END
GO

CREATE TRIGGER trg_TienDoHDMB_DELETE ON LichThanhToanHopDong AFTER DELETE AS
BEGIN
	UPDATE HopDongMuaBan SET tiendohoanthanh = 
	(
		SELECT SUM(LichThanhToanHopDong.sotien) / HopDongMuaBan.thanhtien * 100
			FROM LichThanhToanHopDong, deleted
			WHERE LichThanhToanHopDong.idhopdongmuaban = deleted.idhopdongmuaban
			AND LichThanhToanHopDong.trangthai = N'Đã Hoàn Thành'
			GROUP BY LichThanhToanHopDong.idhopdongmuaban

	)
	WHERE HopDongMuaBan.id IN
	(
		SELECT idhopdongmuaban FROM deleted 
	)
	UPDATE HopDongMuaBan SET tiendohoanthanh = 0 WHERE tiendohoanthanh IS NULL
END
GO

SELECT BatDongSan.id, diachi + ' -- ' + idkhudat  + ' -- ' + DuAn.vitri  + ' -- ' + KhuDat.vitri AS chitietBDS 
FROM BatDongSan 
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id
GO
----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------

--DROP VIEW v_PhieuGiuChoChiTiet
--DROP VIEW v_LTTGiuChoChiTiet

CREATE VIEW v_PhieuGiuChoChiTiet AS
SELECT	PhieuGiuCho.id, PhieuGiuCho.ngaylapphieu, PhieuGiuCho.ngayhethan, tiencoc, PhieuGiuCho.tiendohoanthanh, uutien, PhieuGiuCho.trangthai, 

		idkhachhang, KhachHang.hoten AS 'hotenkhachhang', KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,
		KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, 
		KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien',  

		idBDS, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,
		BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
		dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai AS 'trangthaiBDS',

		PhieuGiuCho.ghichu
FROM PhieuGiuCho
LEFT JOIN KhachHang ON PhieuGiuCho.idkhachhang = KhachHang.id
LEFT JOIN BatDongSan ON PhieuGiuCho.idBDS = BatDongSan.id
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id 
LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id
LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id 
GO

CREATE VIEW v_LTTGiuChoChiTiet AS
SELECT	LichThanhToanGiuCho.id, LichThanhToanGiuCho.idphieugiucho, ngaythu, LichThanhToanGiuCho.sotien, phantram, LichThanhToanGiuCho.trangthai,

		idkhachhang, KhachHang.hoten AS 'hotenkhachhang', KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,
		KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, 
		KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien',  

		idBDS, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,
		BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
		dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai AS 'trangthaiBDS',

		LichThanhToanGiuCho.ghichu, anhphieuthu
FROM LichThanhToanGiuCho
LEFT JOIN PhieuGiuCho ON LichThanhToanGiuCho.idphieugiucho = PhieuGiuCho.id
LEFT JOIN KhachHang ON PhieuGiuCho.idkhachhang = KhachHang.id
LEFT JOIN BatDongSan ON PhieuGiuCho.idBDS = BatDongSan.id
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id 
LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id
LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id 
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------

--DROP VIEW v_PhieuDatCocChiTiet
--DROP VIEW v_LTTDatCocChiTiet

CREATE VIEW v_PhieuDatCocChiTiet AS
SELECT	PhieuDatCoc.id, PhieuDatCoc.ngaylapphieu, PhieuDatCoc.ngayhethan, tiencoc, PhieuDatCoc.tiendohoanthanh, tienboithuong, PhieuDatCoc.trangthai, 

		idkhachhang, KhachHang.hoten AS 'hotenkhachhang', KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,
		KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, 
		KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien',  

		idBDS, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,
		BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
		dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai AS 'trangthaiBDS',

		PhieuDatCoc.ghichu
FROM PhieuDatCoc
LEFT JOIN KhachHang ON PhieuDatCoc.idkhachhang = KhachHang.id
LEFT JOIN BatDongSan ON PhieuDatCoc.idBDS = BatDongSan.id
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id 
LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id
LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id 
GO

CREATE VIEW v_LTTDatCocChiTiet AS
SELECT	LichThanhToanDatCoc.id, LichThanhToanDatCoc.idphieudatcoc, ngaythu, LichThanhToanDatCoc.sotien, phantram, LichThanhToanDatCoc.trangthai,

		idkhachhang, KhachHang.hoten AS 'hotenkhachhang', KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,
		KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, 
		KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien',  

		idBDS, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,
		BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
		dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai AS 'trangthaiBDS',

		LichThanhToanDatCoc.ghichu, anhphieuthu
FROM LichThanhToanDatCoc
LEFT JOIN PhieuDatCoc ON LichThanhToanDatCoc.idphieudatcoc = PhieuDatCoc.id
LEFT JOIN KhachHang ON PhieuDatCoc.idkhachhang = KhachHang.id
LEFT JOIN BatDongSan ON PhieuDatCoc.idBDS = BatDongSan.id
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id 
LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id
LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id 
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------

--DROP VIEW v_HopDongMuaBanChiTiet
--DROP VIEW v_LTTHopDongChiTiet

CREATE VIEW v_HopDongMuaBanChiTiet AS
SELECT	HopDongMuaBan.id, HopDongMuaBan.ngaylap, HopDongMuaBan.thanhtien, tiendohoanthanh, muchoahongNV, muchoahongCT, HopDongMuaBan.trangthai,

		idkhachhang, KhachHang.hoten AS 'hotenkhachhang', KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,
		KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, 
		KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien',  

		idBDS, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,
		BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
		dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai AS 'trangthaiBDS',

		HopDongMuaBan.ghichu
FROM HopDongMuaBan
LEFT JOIN KhachHang ON HopDongMuaBan.idkhachhang = KhachHang.id
LEFT JOIN BatDongSan ON HopDongMuaBan.idBDS = BatDongSan.id
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id 
LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id
LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id 
GO

CREATE VIEW v_LTTHopDongChiTiet AS
SELECT	LichThanhToanHopDong.id, LichThanhToanHopDong.idhopdongmuaban, ngaythu, LichThanhToanHopDong.sotien,phantram, LichThanhToanHopDong.trangthai,

		idkhachhang, KhachHang.hoten AS 'hotenkhachhang', KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,
		KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, 
		KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien',  

		idBDS, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,
		BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
		dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai AS 'trangthaiBDS',

		anhphieuthu, HopDongMuaBan.ghichu
FROM LichThanhToanHopDong
LEFT JOIN HopDongMuaBan ON LichThanhToanHopDong.idhopdongmuaban = HopDongMuaBan.id
LEFT JOIN KhachHang ON HopDongMuaBan.idkhachhang = KhachHang.id
LEFT JOIN BatDongSan ON HopDongMuaBan.idBDS = BatDongSan.id
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id 
LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id
LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id 
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------


CREATE VIEW v_PGCChiTiet AS
SELECT KhachHang.hoten, KhachHang.sdt, idBDS ,BatDongSan.diachi, ngaylapphieu ,tiencoc, uutien, PhieuGiuCho.ghichu 
FROM PhieuGiuCho 
LEFT JOIN BatDongSan ON PhieuGiuCho.idBDS = BatDongSan.id
LEFT JOIN KhachHang ON PhieuGiuCho.idkhachhang = KhachHang.id
GO

CREATE VIEW v_PDCChiTiet AS
SELECT KhachHang.hoten, KhachHang.sdt, idBDS ,BatDongSan.diachi, ngaylapphieu ,tiencoc, tienboithuong, PhieuDatCoc.ghichu 
FROM PhieuDatCoc 
LEFT JOIN BatDongSan ON PhieuDatCoc.idBDS = BatDongSan.id
LEFT JOIN KhachHang ON PhieuDatCoc.idkhachhang = KhachHang.id
GO

CREATE VIEW v_HDMBChiTiet AS
SELECT KhachHang.hoten, KhachHang.sdt, idBDS ,BatDongSan.diachi, ngaylap ,thanhtien, tiendohoanthanh, HopDongMuaBan.ghichu 
FROM HopDongMuaBan 
LEFT JOIN BatDongSan ON HopDongMuaBan.idBDS = BatDongSan.id
LEFT JOIN KhachHang ON HopDongMuaBan.idkhachhang = KhachHang.id
GO

CREATE VIEW v_LTTPGCChiTiet AS
SELECT KhachHang.hoten, KhachHang.sdt, idBDS ,BatDongSan.diachi, ngaythu, sotien, LichThanhToanGiuCho.ghichu 
FROM LichThanhToanGiuCho
LEFT JOIN PhieuGiuCho ON LichThanhToanGiuCho.idphieugiucho = PhieuGiuCho.id
LEFT JOIN BatDongSan ON PhieuGiuCho.idBDS = BatDongSan.id
LEFT JOIN KhachHang ON PhieuGiuCho.idkhachhang = KhachHang.id
GO

CREATE VIEW v_LTTPDCChiTiet AS
SELECT KhachHang.hoten, KhachHang.sdt, idBDS ,BatDongSan.diachi, ngaythu, sotien, LichThanhToanDatCoc.ghichu 
FROM LichThanhToanDatCoc
LEFT JOIN PhieuDatCoc ON LichThanhToanDatCoc.idphieudatcoc = PhieuDatCoc.id
LEFT JOIN BatDongSan ON PhieuDatCoc.idBDS = BatDongSan.id
LEFT JOIN KhachHang ON PhieuDatCoc.idkhachhang = KhachHang.id
GO

CREATE VIEW v_LTTHDMBChiTiet AS
SELECT KhachHang.hoten, KhachHang.sdt, idBDS ,BatDongSan.diachi, ngaythu, sotien, LichThanhToanHopDong.ghichu 
FROM LichThanhToanHopDong
LEFT JOIN HopDongMuaBan ON LichThanhToanHopDong.idhopdongmuaban = HopDongMuaBan.id
LEFT JOIN BatDongSan ON HopDongMuaBan.idBDS = BatDongSan.id
LEFT JOIN KhachHang ON HopDongMuaBan.idkhachhang = KhachHang.id
GO

CREATE VIEW v_NVChiTiet AS
SELECT hoten, gioitinh, ngaysinh, sothecancuoc, sdt, diachithuongtru, masothue, NhanVien.ghichu, idchinhanh, idphongban, idchucvu
FROM NhanVien
LEFT JOIN ChiNhanh ON NhanVien.idphongban = ChiNhanh.id
LEFT JOIN PhongBan ON NhanVien.idphongban = PhongBan.id
LEFT JOIN ChucVu ON NhanVien.idphongban = ChucVu.id
GO

--DROP VIEW v_DAChiTiet

CREATE VIEW v_DAChiTiet AS
SELECT tenduan, tencongty, vitri, dientich, sogiayphep, ngaycap, hoten, DuAn.ghichu, idnhanvienphutrach, idchudautu
FROM DuAn
LEFT JOIN NhanVien ON DuAn.idnhanvienphutrach = NhanVien.id
LEFT JOIN ChuDauTu ON DuAn.idchudautu = ChuDauTu.id
GO

--DROP VIEW v_BDSChiTiet

CREATE VIEW v_BDSChiTiet AS
SELECT BatDongSan.*, KhuDat.tenkhu, DuAn.tenduan, LoaiBatDongSan.tenloaiBDS, DuAn.id AS 'idduan', DuAn.vitri
FROM BatDongSan
LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id
LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id
LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id
GO


CREATE VIEW v_KHChiTiet AS
SELECT KhachHang.hoten, KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc, KhachHang.sdt, KhachHang.diachithuongtru, NhanVien.hoten AS 'hotennhanvien', KhachHang.ghichu, idnhanvienphutrach
FROM KhachHang
LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id
GO


CREATE VIEW v_HoaHongCT AS
SELECT sotien, ngaythu, ROUND(muchoahongCT / 100, 10) AS 'muchoahong', LichThanhToanHopDong.trangthai FROM LichThanhToanHopDong LEFT JOIN HopDongMuaBan ON LichThanhToanHopDong.idhopdongmuaban = HopDongMuaBan.id
GO

CREATE VIEW v_HoaHongNV AS
SELECT sotien, ngaythu, ROUND(muchoahongNV / 100, 10) AS 'muchoahong', LichThanhToanHopDong.trangthai FROM LichThanhToanHopDong LEFT JOIN HopDongMuaBan ON LichThanhToanHopDong.idhopdongmuaban = HopDongMuaBan.id
GO 
