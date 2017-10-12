CREATE schema GDD_FORK
GO

CREATE TABLE GDD_FORK.Funcionality (
	func_name varchar(100) NOT NULL, 
	func_id int identity NOT NULL, 
	CONSTRAINT Funcionality_PK PRIMARY KEY(func_id))
GO

CREATE TABLE GDD_FORK.Role (
	role_name varchar(100) NOT NULL, 
	role_active bit NOT NULL, 
	role_id int identity NOT NULL, 
	CONSTRAINT Role_PK PRIMARY KEY(role_id))
GO

CREATE TABLE GDD_FORK.Role_Funcionality (
	role_id int NOT NULL, 
	func_id int NOT NULL, 
	CONSTRAINT Role_Funcionality_PK PRIMARY KEY(role_id,func_id),
	FOREIGN KEY (role_id) REFERENCES GDD_FORK.Role(role_id),
	FOREIGN KEY (func_id) REFERENCES GDD_FORK.Funcionality(func_id))
GO

CREATE TABLE GDD_FORK.Users (
	user_username varchar(150) NOT NULL, 
	user_password varchar(64) NOT NULL, 
	CONSTRAINT User_PK PRIMARY KEY(user_username))
GO

CREATE TABLE GDD_FORK.Role_user (
	user_id varchar(150) NOT NULL, 
	role_id int NOT NULL, 
	CONSTRAINT Role_user_PK PRIMARY KEY(user_id,role_id), 
	FOREIGN KEY (role_id) REFERENCES GDD_FORK.Role(role_id), 
	FOREIGN KEY (user_id) REFERENCES GDD_FORK.Users(user_username))
GO

CREATE TABLE GDD_FORK.Branch(
	branch_name nvarchar(50) NOT NULL, 
	branch_address nvarchar(50) NOT NULL, 
	branch_postal_code numeric(18,0) NOT NULL, 
	CONSTRAINT Branch_PK PRIMARY KEY(branch_name) )
GO

CREATE TABLE GDD_FORK.Branch_user (
	branch_id nvarchar(50) NOT NULL, 
	user_id varchar(150) NOT NULL, 
	CONSTRAINT branch_user_pk PRIMARY KEY (branch_id, user_id), 
	FOREIGN KEY (branch_id) REFERENCES GDD_FORK.Branch(branch_name),
	FOREIGN KEY (user_id) REFERENCES GDD_FORK.Users (user_username)) 
GO

CREATE TABLE GDD_FORK.Entry (
	ent_id int identity NOT NULL,
	ent_description nvarchar(255) NOT NULL,
	CONSTRAINT Entry_PK PRIMARY KEY (ent_id))
GO

CREATE TABLE GDD_FORK.Company (
	com_cuit nvarchar(50) NOT NULL,
	com_ent_id int NOT NULL,
	com_name nvarchar(255) NOT NULL,
	com_address nvarchar(255) NOT NULL,
	CONSTRAINT Company_PK PRIMARY KEY (com_cuit),
	FOREIGN KEY (com_ent_id) REFERENCES GDD_FORK.Entry(ent_id))
GO

CREATE TABLE GDD_FORK.Invoice (
	inv_nro numeric(18, 0) NOT NULL,
	inv_date datetime NOT NULL,
	inv_amount numeric(18, 2) NOT NULL,
	inv_total numeric(18, 2) NOT NULL,
	inv_fee_percentage numeric NOT NULL,
	inv_subtotal numeric(18, 2) NOT NULL,
	inv_company_cuit nvarchar(50) NOT NULL, 
	CONSTRAINT Invoice_PK PRIMARY KEY (inv_nro),
	FOREIGN KEY (inv_company_cuit) REFERENCES GDD_FORK.Company(com_cuit))
GO

CREATE TABLE GDD_FORK.Client (
	cli_id int identity NOT NULL,
	cli_dni numeric(18, 0) NOT NULL,
	cli_name nvarchar(255) NOT NULL,
	cli_last_name nvarchar(255) NOT NULL,
	cli_date_birth datetime NOT NULL,
	cli_email nvarchar(255),
	cli_address nvarchar(255) NOT NULL,
	cli_postal_code nvarchar(255) NOT NULL,
	CONSTRAINT Client_PK PRIMARY KEY (cli_dni))
GO

CREATE TABLE GDD_FORK.Payment_Method (
	paym_id int identity NOT NULL,
	paym_description nvarchar(255) NOT NULL,
	CONSTRAINT Payment_Method_PK PRIMARY KEY (paym_id))
GO

CREATE TABLE GDD_FORK.Bill_Refund (
	bill_id numeric(18, 0) NOT NULL,
	refund_id int NOT NULL,
	CONSTRAINT Bill_Refund_PK PRIMARY KEY (bill_id, refund_id),
	FOREIGN KEY (bill_id) REFERENCES GDD_FORK.Bill(bill_id),
	FOREIGN KEY (refund_id) REFERENCES GDD_FORK.BillRefund(ref_id))
GO

CREATE TABLE GDD_FORK.BillRefund (
	ref_id int identity NOT NULL,
	ref_reason nvarchar(255) NOT NULL,
	CONSTRAINT BillRefund_PK PRIMARY KEY (ref_id))
GO

CREATE TABLE GDD_FORK.Bill (
	bill_number numeric(18, 0) NOT NULL,
	bill_cli_dni numeric(18, 0) NOT NULL,
	bill_com_cuit nvarchar(50) NOT NULL,
	bill_ref_id int NOT NULL,
	bill_inv_nro numeric(18, 0) NOT NULL,
	bill_date datetime NOT NULL, 
	bill_total numeric(18, 2) NOT NULL,
	bill_expiration datetime NOT NULL,
	CONSTRAINT Bill_PK PRIMARY KEY (bill_number),
	FOREIGN KEY (bill_cli_dni) REFERENCES GDD_FORK.Client(cli_dni),
	FOREIGN KEY (bill_com_cuit) REFERENCES GDD_FORK.Company(com_cuit),
	FOREIGN KEY (bill_ref_id) REFERENCES GDD_FORK.BillRefund(ref_id),
	FOREIGN KEY (bill_inv_nro) REFERENCES GDD_FORK.Invoice(inv_nro))
GO

CREATE TABLE GDD_FORK.Payment (
	pay_number numeric(18, 0) NOT NULL,
	pay_bill_number numeric(18, 0) NOT NULL,
	pay_branch_name nvarchar(50) NOT NULL,
	pay_paym_id int NOT NULL,
	pay_date datetime NOT NULL,
	pay_item_number numeric(18, 0) NOT NULL,
	pay_total numeric(18, 2) NOT NULL,
	CONSTRAINT Payment_PK PRIMARY KEY (pay_number),
	FOREIGN KEY (pay_bill_number) REFERENCES GDD_FORK.Bill(bill_number),
	FOREIGN KEY (pay_branch_name) REFERENCES GDD_FORK.Branch(branch_name),
	FOREIGN KEY (pay_paym_id) REFERENCES GDD_FORK.Payment_Method(paym_id))
GO

CREATE TABLE GDD_FORK.Item (
	it_number int identity NOT NULL,
	it_bill_number numeric(18, 0) NOT NULL,
	it_amount numeric(18, 2) NOT NULL,
	it_quantity numeric(18, 0) NOT NULL,
	CONSTRAINT Item_PK PRIMARY KEY (it_number, it_bill_number),
	FOREIGN KEY (it_bill_number) REFERENCES GDD_FORK.Bill(bill_number))
GO