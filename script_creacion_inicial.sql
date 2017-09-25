create schema GDD_FORK
GO

create table GDD_FORK.Funcionality (func_name varchar(100) not null, func_id int identity not null, constraint Funcionality_PK primary key(func_id))
GO

create table GDD_FORK.Role (role_name varchar(100) not null, role_active bit not null, role_id int identity not null, constraint Role_PK primary key(role_id))
GO

create table GDD_FORK.Role_Funcionality (role_id int not null, func_id int not null, constraint Role_Funcionality_PK primary key(role_id,func_id),foreign key (role_id) references GDD_FORK.Role(role_id),foreign key (func_id) references GDD_FORK.Funcionality(func_id))
GO

create table GDD_FORK.Users (user_username varchar(150) not null ,user_password varchar(64) not null, constraint User_PK primary key(user_username))
GO

create table GDD_FORK.Role_user (user_id varchar(150) not null ,role_id int not null, constraint Role_user_PK primary key(user_id,role_id),foreign key (role_id) references GDD_FORK.Role(role_id),foreign key (user_id) references GDD_FORK.Users(user_username))
GO

create table GDD_FORK.Branch(branch_name varchar(150) not null, branch_address varchar(200) not null, branch_postal_code int not null, constraint Branch_PK primary key(branch_name) )
GO

create table gdd_fork.Branch_user (branch_id VARCHAR(150) NOT NULL,user_id   VARCHAR(150) NOT NULL, constraint branch_user_pk primary key (branch_id, user_id), foreign key (branch_id) references gdd_fork.Branch(branch_name),foreign key (user_id) references gdd_fork.Users (user_username)) 
GO