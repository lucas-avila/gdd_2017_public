create schema GDD_FORK
GO

create table GDD_FORK.Funcionality (func_name varchar(100) not null, func_id int identity not null, constraint Funcionality_PK primary key(func_id))
GO

create table GDD_FORK.Role (role_name varchar(100) not null, role_active bit not null, role_id int identity not null, constraint Role_PK primary key(role_id))
GO

create table GDD_FORK.Role_Funcionality (role_id int not null, func_id int not null, constraint Role_Funcionality_PK primary key(role_id,func_id),foreign key (role_id) references GDD_FORK.Role(role_id),foreign key (func_id) references GDD_FORK.Funcionality(func_id))
GO
