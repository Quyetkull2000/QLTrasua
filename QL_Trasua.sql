CREATE DATABASE QLTraSua
GO

USE QLTraSua
GO

CREATE TABLE TableFood
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Nhân viên',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: Nhân viên
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

--Thêm trường totalPrice vào bảng Bill
Alter table Bill 
	ADD totalPrice float

Go



CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

-- THÊM DỮ LIỆU VÀO CÁC BẢNG

Insert into TableFood values 
	(N'Bàn 1',N'Trống'),
	(N'Bàn 2',N'Trống'),
	(N'Bàn 3',N'Trống'),
	(N'Bàn 4',N'Trống'),
	(N'Bàn 5',N'Trống'),
	(N'Bàn 6',N'Trống'),
	(N'Bàn 7',N'Trống'),
	(N'Bàn 8',N'Trống'),
	(N'Bàn 9',N'Trống'),
	(N'Bàn 10',N'Trống'),
	(N'Bàn 11',N'Trống'),
	(N'Bàn 12',N'Trống'),
	(N'Bàn 13',N'Trống'),
	(N'Bàn 14',N'Trống'),
	(N'Bàn 15',N'Trống')

Go

Insert into Account values 
	('admin','Admin','admin123',1),
	('Quyetkull',N'Nhân viên','Quyetkull2000',0),
	('Quangbess',N'Nhân viên','Quangbees2000',0),
	('NgoTrang',N'Nhân viên','NgoTrang2307',0),
	('Thuyhang',N'Nhân viên','Thuyhang2000',0),
	('Lehuyen',N'Nhân viên','Lehuyen2000',0),
	('Phithuy',N'Nhân viên','Phithuybka',0),
	('Ngocluu',N'Nhân viên','Ngocluu91',0),
	('Minhhang',N'Nhân viên','Minhhang97',0),
	('Thanhlong',N'Nhân viên','Thanhlongbro',0)
	
GO


Insert into FoodCategory values
	(N'Hồng Trà'),
	(N'Trà sữa'),
	(N'Sinh Tố'),
	(N'Đồ ăn kèm')


Insert into Food values
	(N'Trà sữa trân châu Hoàng Gia','2','25000'),
	(N'Trà sữa Dâu Pha Lê Tuyết','2','45000'),
	(N'Trà sữa khoai môn','2','42000'),
	(N'Trà sữa Xoài','2','42000'),
	(N'Trà sữa trân châu kem cheese','2','36000'),
	(N'Trà sữa Thạch Đào Tiên Tử','2','50000'),
	(N'Trà sữa Matcha','2','27000'),
	(N'Trà sữa Socola','2','27000'),
	(N'Sinh Tố Xoài','3','32000'),
	(N'Sinh Tố Dâu','3','39000'),
	(N'Sinh Tố Dưa Hấu','3','29000'),
	(N'Sinh Tố Dứa','3','45000'),
	(N'Hồng Trà cam xả','1','22000'),
	(N'Hồng Trà Xoài','1','20000'),
	(N'Hồng Trà Hoàng Gia','1','18000'),
	(N'Hướng dương','4','10000'),
	(N'Cá viên chiên','4','25000'),
	(N'Khoai Tây Chiên','4','25000'),
	(N'Bắp xào tép','4','25000')
GO

Insert into Bill values
	(GETDATE(),null,1,0), 
	(GETDATE(),null,2,0),
	(GETDATE(),null,3,1),
	(GETDATE(),null,4,1),
	(GETDATE(),null,5,0),
	(GETDATE(),null,6,1),
	(GETDATE(),null,7,0),
	(GETDATE(),null,8,1),    --Checkin/Checkout/idTable/status(1-Checkout rồi/0-Chưa Checkout)
	(GETDATE(),null,9,0),
	(GETDATE(),null,10,1),
	(GETDATE(),null,11,0),
	(GETDATE(),null,12,1),
	(GETDATE(),null,13,1),
	(GETDATE(),null,14,0),
	(GETDATE(),null,15,1)

GO

Insert into BillInfo values
	(1,6,2),  
	(2,8,3), 
	(3,7,4),
	(4,1,3), 
	(5,2,2), 
	(6,3,1), 
	(7,4,3), 
	(8,5,6), 
	(9,9,3),     --idBill / idFood / count(SL)
	(10,11,2), 
	(11,10,1), 
	(12,13,3), 
	(13,12,4), 
	(14,15,3), 
	(15,14,2)
	

GO

			-- VIEW

-- Tạo khung nhìn thực đơn gồm id, tên và giá món ăn
Create View View_ListFood
AS
	Select  * From Food

select * from View_ListFood

Go

-- Tạo khung nhìn danh sách nhân viên 
Create View View_Nhanvien
As
	Select UserName 
	from Account
	Where Type= '0'

Select * From View_Nhanvien


			-- STORED PRODURES

--Thủ tục đưa ra tất cả thông tin tài khoản có username là tham số truyền vào
CREATE PROC sp_GetAccount  @username nvarchar(100)
AS
	BEGIN
		Select * from Account where UserName= @username
	END
GO

EXEC sp_GetAccount @username= N'Quyetkull' 


GO

--Lấy thông tin đăng nhập(Lấy tất cả thông tin từ bảng Account khi đúng username và password)
Create Proc sp_Login  @userName nvarchar(100), @passWord nvarchar(100)
As
Begin
	Select * from Account Where UserName= @userName and PassWord= @passWord
End

EXEC sp_Login @userName= N'Quyetkull',@passWord= N'Quyetkull2000'
Go

-- Lấy ra DS các bàn ăn
Create Proc sp_GetTableList
As
	Select * from TableFood

Exec sp_GetTableList

Go


Go
-- Thêm món vào Bill
create proc sp_InsertBill @idTable int
As
Begin
	Insert Bill(DateCheckIn,DateCheckOut,idTable,status) 
	Values (GETDATE(),null,@idTable,0)
End

Go

Create Proc sp_BillInfo 
@idBill int, @idFood int, @count int
As
Begin
	Insert BillInfo(idBill,idFood,count) 
	 Values (@idBill,@idFood,@count)
End

Go


--Lấy ra danh sách hóa đơn theo ngày người dùng nhập vào
Create Proc sp_GetListTable  @DateCheckIn date, @DateCheckOut date
As
Begin 
	Select TableFood.name as 'Tên bàn', Bill.totalPrice as 'Tổng tiền', DateCheckIn as 'Ngày vào', DateCheckOut as 'Ngày ra'
	from Bill, TableFood
	Where DateCheckIn= @DateCheckIn and DateCheckOut= @DateCheckOut and Bill.status=1 and TableFood.id= Bill.idTable
End

Go

			-- TRIGGER	

--Trigger cập nhật status khi bàn đó cập nhật bill
CREATE TRIGGER UpdateBillInfo
On BillInfo for insert, update
as
begin
	Declare @idBill int
	Select @idBill = idBill from inserted
	Declare @idTable int
	Select @idTable = idTable from Bill where id = @idBill and status = 0

	Update TableFood set status = N'Có người' where id = @idTable
End
go


Create TRIGGER UpdateBill
On Bill for update
as
begin
	declare @idBill int
	select @idBill = id from inserted
	Declare @idTable int
	Select @idTable = idTable from Bill where id = @idBill 

	Declare @count int = 0
	select @count = COUNT(*) from Bill where idTable = @idTable and status = 0
	if (@count = 0)
		update TableFood set status = N'Trống' where id = @idTable
end 

Go

			-- FUNCTION
CREATE FUNCTION SumFood()
returns int
as begin
	declare @SumFood int
	select @SumFood =(
		select COUNT(id)
		From Food)
	return @SumFood
END



Go
Create Function ListFood (@FCategory nvarchar(100))
returns @Food table (id int, name nvarchar(100), price float)
As
Begin
	Insert into @Food
	Select Food.id, Food.name, Food.price
	From Food
	inner join FoodCategory On Food.idCategory = FoodCategory.id
	Where Food.idCategory= @FCategory
	return 
End

Select * from ListFood('3')







