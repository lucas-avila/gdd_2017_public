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
	user_active bit NOT NULL,
	user_login_attempts int NOT NULL,
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
	com_id int identity NOT NULL,
	com_cuit nvarchar(50) NOT NULL,
	com_ent_id int NOT NULL,
	com_name nvarchar(255) NOT NULL,
	com_address nvarchar(255) NOT NULL,
	com_active bit NOT NULL,
	CONSTRAINT Company_PK PRIMARY KEY (com_id),
	FOREIGN KEY (com_ent_id) REFERENCES GDD_FORK.Entry(ent_id))
GO

CREATE TABLE GDD_FORK.Invoice (
	inv_nro numeric(18, 0) NOT NULL,
	inv_date datetime NOT NULL,
	inv_amount numeric(18, 2) NOT NULL,
	inv_total numeric(18, 2) NOT NULL,
	inv_fee_percentage numeric NOT NULL,
	inv_company_id int NOT NULL,
	CONSTRAINT Invoice_PK PRIMARY KEY (inv_nro),
	FOREIGN KEY (inv_company_id) REFERENCES GDD_FORK.Company(com_id))
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


CREATE TABLE GDD_FORK.BillRefund (
	ref_id int identity NOT NULL,
	ref_reason nvarchar(255) NOT NULL,
	CONSTRAINT BillRefund_PK PRIMARY KEY (ref_id))
GO

CREATE TABLE GDD_FORK.Bill (
	bill_number numeric(18, 0) NOT NULL,
	bill_cli_dni numeric(18, 0) NOT NULL,
	bill_com_id int NOT NULL,
	bill_inv_nro numeric(18, 0) NULL,
	bill_date datetime NOT NULL, 
	bill_total numeric(18, 2) NOT NULL,
	bill_expiration datetime NOT NULL,
	CONSTRAINT Bill_PK PRIMARY KEY (bill_number),
	FOREIGN KEY (bill_cli_dni) REFERENCES GDD_FORK.Client(cli_dni),
	FOREIGN KEY (bill_com_id) REFERENCES GDD_FORK.Company(com_id),
	FOREIGN KEY (bill_inv_nro) REFERENCES GDD_FORK.Invoice(inv_nro))
GO

CREATE TABLE GDD_FORK.Bill_Refund (
	bill_id numeric(18, 0) NOT NULL,
	refund_id int NOT NULL,
	CONSTRAINT Bill_Refund_PK PRIMARY KEY (bill_id, refund_id),
	FOREIGN KEY (bill_id) REFERENCES GDD_FORK.Bill(bill_number),
	FOREIGN KEY (refund_id) REFERENCES GDD_FORK.BillRefund(ref_id))
GO


CREATE TABLE GDD_FORK.Payment (
	pay_number numeric(18, 0) NOT NULL,
	pay_bill_number numeric(18, 0) NOT NULL,
	pay_branch_name nvarchar(50) NOT NULL,
	pay_paym_id int NOT NULL,
	pay_date datetime NOT NULL,
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

--DATA MIGRATION

INSERT INTO GDD_FORK.Client (cli_dni, cli_last_name, cli_name, cli_date_birth, cli_email, cli_address, cli_postal_code)
SELECT DISTINCT ([Cliente-Dni]), [Cliente-Apellido], [Cliente-Nombre], [Cliente-Fecha_Nac], [Cliente_Mail], [Cliente_Direccion], [Cliente_Codigo_Postal]
FROM gd_esquema.Maestra
GO

INSERT INTO GDD_FORK.Entry (ent_description)
SELECT DISTINCT (Rubro_Descripcion)
FROM gd_esquema.Maestra
GO

INSERT INTO GDD_FORK.Branch (branch_name, branch_address, branch_postal_code)
SELECT DISTINCT (Sucursal_Nombre), Sucursal_Dirección, Sucursal_Codigo_Postal
FROM gd_esquema.Maestra
WHERE Sucursal_Nombre IS NOT NULL
GO

INSERT INTO GDD_FORK.Payment_Method (paym_description)
SELECT DISTINCT (FormaPagoDescripcion)
FROM gd_esquema.Maestra
WHERE FormaPagoDescripcion IS NOT NULL
GO

INSERT INTO GDD_FORK.Company (com_cuit, com_ent_id, com_name, com_address, com_active)
SELECT DISTINCT (REPLACE(Empresa_Cuit, '-', '')),
		(SELECT ent_id
		FROM GDD_FORK.Entry
		WHERE ent_description = Rubro_Descripcion), Empresa_Nombre, Empresa_Direccion, 1
FROM gd_esquema.Maestra
GO

INSERT INTO GDD_FORK.Invoice (inv_nro,inv_date,inv_amount,inv_total,inv_fee_percentage,inv_company_id)
SELECT DISTINCT(Rendicion_Nro),Rendicion_Fecha,ItemRendicion_Importe,Factura_Total,10,(SELECT com_id FROM GDD_FORK.Company WHERE com_cuit = (REPLACE(Empresa_Cuit ,'-','')))
FROM gd_esquema.Maestra 
WHERE Rendicion_Nro is not null
GO

INSERT INTO GDD_FORK.Bill(bill_number,bill_cli_dni,bill_com_id,bill_inv_nro,bill_date,bill_total,bill_expiration)
SELECT DISTINCT (m.Nro_Factura),m.[Cliente-Dni],(SELECT com_id FROM GDD_FORK.Company WHERE com_cuit = (REPLACE(Empresa_Cuit ,'-',''))),
		(SELECT DISTINCT (m2.Rendicion_Nro)
		FROM gd_esquema.Maestra m2
		WHERE m2.Nro_Factura = m.Nro_Factura
		AND m2.Rendicion_Nro IS NOT NULL)
,m.Factura_Fecha,m.Factura_Total,m.Factura_Fecha_Vencimiento
FROM gd_esquema.Maestra m
GO

INSERT INTO GDD_FORK.Item(it_amount,it_bill_number,it_quantity)
SELECT distinct (m1.ItemFactura_Monto),Nro_Factura,ItemFactura_Cantidad
FROM gd_esquema.Maestra m1
WHERE m1.ItemFactura_Monto IS NOT NULL 
order by Nro_Factura asc
GO

INSERT INTO GDD_FORK.Payment(pay_number,pay_bill_number,pay_branch_name,pay_paym_id,pay_date,pay_total)
SELECT DISTINCT (Pago_nro),Nro_Factura,Sucursal_Nombre,
	(SELECT paym_id 
	FROM GDD_FORK.Payment_Method 
	WHERE paym_description = FormaPagoDescripcion)
,Pago_Fecha,Total 
FROM gd_esquema.Maestra
WHERE Pago_nro IS NOT NULL
GO

--USERS

INSERT INTO GDD_FORK.Users (user_active,user_login_attempts,user_username,user_password)
VALUES (1,0,'admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
GO

INSERT INTO GDD_FORK.Users (user_active,user_login_attempts,user_username,user_password)
VALUES (1,0,'pablo','26079e41910bcde04be636fbeecc9045379882b5ad3fe7f70b762436c6d98055')
GO

INSERT INTO GDD_FORK.Role (role_name,role_active)
VALUES ('Administrador',1)
GO

INSERT INTO GDD_FORK.Role (role_name,role_active)
VALUES ('Cobrador',1)
GO

INSERT INTO GDD_FORK.Role_user (user_id,role_id)
VALUES ('admin', (SELECT role_id FROM GDD_FORK.Role WHERE role_name = 'Administrador') )
GO

INSERT INTO GDD_FORK.Role_user (user_id,role_id)
VALUES ('pablo', (SELECT role_id FROM GDD_FORK.Role WHERE role_name = 'Cobrador') )
GO

INSERT INTO GDD_FORK.Branch_user (branch_id,user_id)
VALUES ((SELECT branch_name FROM GDD_FORK.Branch where branch_postal_code = 7210) ,'admin')
GO

INSERT INTO GDD_FORK.Branch_user (branch_id,user_id)
VALUES ((SELECT branch_name FROM GDD_FORK.Branch where branch_postal_code = 7210) ,'pablo')
GO


--STORES PROCEDURES

CREATE PROCEDURE GDD_FORK.sp_get_user (@username varchar(150))
AS
	BEGIN
		SELECT * FROM GDD_FORK.Users WHERE user_username=@username
	END
GO

CREATE PROCEDURE GDD_FORK.sp_update_user_attempts (@username varchar(150),@login_attempts int)
AS
	BEGIN
		DECLARE @active bit = 1
		IF @login_attempts >= 3
		BEGIN
			SET @active = 0
		END
		UPDATE GDD_FORK.Users set user_login_attempts = @login_attempts,user_active=@active 
		WHERE user_username=@username
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_role(@role_name varchar(100))
AS
	BEGIN
		SELECT *
		FROM GDD_FORK.Role
		WHERE role_name = @role_name;
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_roles(@user_id varchar(150), @active bit)
AS
	BEGIN
		SELECT r.role_active,r.role_name,r.role_id 
		FROM GDD_FORK.Role r join GDD_FORK.Role_user ru on r.role_id = ru.role_id
		WHERE ru.user_id = @user_id and r.role_active = @active
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_all_roles
AS
	BEGIN
		SELECT *
		FROM GDD_FORK.Role;
	END
GO

CREATE PROCEDURE GDD_FORK.sp_add_role(@role_name varchar(100), @role_active bit)
AS	
	BEGIN
		INSERT INTO GDD_FORK.Role (role_name, role_active) Values(@role_name, @role_active)
	END
GO

CREATE PROCEDURE GDD_FORK.sp_update_role(@role_id int, @role_name varchar(100), @role_active bit)
AS
	BEGIN
		UPDATE GDD_FORK.Role
		SET role_name = @role_name, role_active = @role_active
		WHERE role_id = @role_id
	END
GO

CREATE PROCEDURE GDD_FORK.sp_disable_role(@role_name varchar(100))
AS
	BEGIN
		DECLARE @role_id int
		SELECT @role_id = role_id FROM GDD_FORK.Role WHERE role_name = @role_name
		
		UPDATE GDD_FORK.Role
		SET role_active = 0
		WHERE role_id = @role_id

		DELETE FROM GDD_FORK.Role_user
		WHERE role_id = @role_id

	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_branchs(@user_id varchar(150))
AS
	BEGIN
		SELECT branch_name, branch_address, branch_postal_code from Branch join Branch_user on branch_id = branch_name
		where user_id = @user_id
	END
GO

CREATE PROCEDURE GDD_FORK.sp_link_functionality_role(@role_name varchar(100), @func_name varchar(100))
AS	
	BEGIN
		DECLARE @id int
		DECLARE @func_id int
		SELECT @func_id = func_id FROM GDD_FORK.Funcionality WHERE func_name = @func_name
		SELECT @id = role_id FROM GDD_FORK.Role WHERE role_name = @role_name
		INSERT INTO GDD_FORK.Role_Funcionality VALUES (@id, @func_id)
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_functionalities
AS
	BEGIN
		SELECT * 
		FROM GDD_FORK.Funcionality
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_functionality(@func_name varchar(100))
AS
	BEGIN 
		SELECT * 
		FROM GDD_FORK.Funcionality
		WHERE func_name = @func_name
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_role_functionalities(@role_id int)
AS
	BEGIN
		SELECT f.func_name, f.func_id 
		FROM Funcionality f 
		JOIN Role_Funcionality rf 
		ON rf.func_id = f.func_id
		WHERE rf.role_id = @role_id
	END
GO

CREATE PROCEDURE GDD_FORK.sp_remove_role_functionality(@role_id int, @func_id int)
AS
	BEGIN
		DELETE FROM GDD_FORK.Role_Funcionality
		WHERE role_id = @role_id
		AND func_id = @func_id
	END
GO

CREATE PROCEDURE GDD_FORK.sp_remove_role_from_users(@role_id int)
AS
	BEGIN
		DELETE FROM GDD_FORK.Role_user
		WHERE role_id = @role_id
	END
GO

CREATE PROCEDURE GDD_FORK.sp_create_client(@cli_dni numeric(18, 0),
	@cli_name nvarchar(255),
	@cli_last_name nvarchar(255),
	@cli_date_birth datetime,
	@cli_email nvarchar(255),
	@cli_address nvarchar(255),
	@cli_postal_code nvarchar(255))
AS
	BEGIN
		INSERT INTO Client (cli_dni,
							cli_name,
							cli_last_name,
							cli_date_birth,
							cli_email,
							cli_address,
							cli_postal_code)
				VALUES (@cli_dni,
						@cli_name,
						@cli_last_name,
						@cli_date_birth,
						@cli_email,
						@cli_address,
						@cli_postal_code);

	END
GO

CREATE PROCEDURE GDD_FORK.sp_update_client(@cli_id int,
	@cli_dni numeric(18, 0),
	@cli_name nvarchar(255),
	@cli_last_name nvarchar(255),
	@cli_date_birth datetime,
	@cli_email nvarchar(255),
	@cli_address nvarchar(255),
	@cli_postal_code nvarchar(255))
AS
	BEGIN
		UPDATE Client
				SET cli_dni = @cli_dni,
					cli_name = @cli_name,
					cli_last_name = @cli_last_name,
					cli_date_birth = @cli_date_birth,
					cli_email = @cli_email,
					cli_address = @cli_address,
					cli_postal_code = @cli_postal_code
				WHERE cli_id = @cli_id;
	END
GO

CREATE PROCEDURE GDD_FORK.sp_delete_client(@cli_id int)
AS
	BEGIN
		DELETE FROM Client
		WHERE cli_id = @cli_id;
	END
GO

CREATE PROCEDURE GDD_FORK.sp_select_client(@cli_dni numeric(18,0),
				@cli_name nvarchar(255),
				@cli_last_name nvarchar(255))
AS
	BEGIN
		SELECT * FROM Client
		WHERE ((@cli_dni is null) or (cli_dni = @cli_dni))
		and ((@cli_name = '') or (cli_name = @cli_name))
		and ((@cli_last_name = '') or (cli_last_name = @cli_last_name));
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_all_entries
AS
	BEGIN
		SELECT * 
		FROM GDD_FORK.Entry
	END
GO

CREATE PROCEDURE GDD_FORK.sp_get_all_companies
AS
	BEGIN
		SELECT * 
		FROM GDD_FORK.Company
	END
GO

CREATE PROCEDURE GDD_FORK.sp_check_cuit(@com_cuit nvarchar(50))
AS
	BEGIN
		SELECT * 
		FROM GDD_FORK.Company
		WHERE com_cuit = @com_cuit
	END
GO

CREATE PROCEDURE GDD_FORK.sp_insert_update_company(@com_id int = NULL,
	@com_name nvarchar(255),
	@com_address nvarchar(255),
	@com_cuit nvarchar(50),
	@com_ent_id int,
	@com_active bit)
AS
	BEGIN
		IF (@com_id IS NULL)
			BEGIN
				INSERT INTO GDD_FORK.Company (com_name, com_address, com_cuit, com_ent_id, com_active)
				VALUES (@com_name, @com_address, @com_cuit, @com_ent_id, @com_active)
			END
		ELSE
			BEGIN
				UPDATE GDD_FORK.Company
				SET com_name = @com_name,
					com_address = @com_address,
					com_cuit = @com_cuit,
					com_ent_id = @com_ent_id,
					com_active = @com_active
				WHERE com_id = @com_id
			END
	END
GO

CREATE PROCEDURE GDD_FORK.sp_change_active_company(@com_id int)
AS
	BEGIN
		UPDATE GDD_FORK.Company
		SET com_active = (~com_active)
		WHERE com_id = @com_id
	END
GO

CREATE PROCEDURE GDD_FORK.sp_search_companies(@com_name nvarchar(255) = NULL,@com_cuit nvarchar(50) = NULL,@com_ent_id int = NULL)
AS
	BEGIN
		SELECT * FROM GDD_FORK.Company
		WHERE ((@com_name IS NULL) OR (com_name like '%'+@com_name+'%'))
		AND ((@com_cuit IS NULL) OR (com_cuit like '%'+@com_cuit+'%'))
		AND ((@com_ent_id IS NULL) OR (com_ent_id like concat('%',@com_ent_id,'%')) )
	END
GO