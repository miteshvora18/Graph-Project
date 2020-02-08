--Graph Project
create database Graph

create table roles 
(
rid int identity(1,1) primary key,
rname varchar(100)
)

insert into roles values('admin')
insert into roles values('user')

create table logins
(
lid int identity(1,1) primary key,
rid int foreign key(rid) references roles(rid),
userid varchar(100),
pass varchar(100),
email varchar(100),
lvalid bit 
)

insert into logins values(1,'admin','admin','miteshvora18@gmail.com',0)

create table questions
(
qid int primary key identity(1,1),
qname varchar(500),
qdesc varchar(500),
qcreated int foreign key(qcreated) references logins(lid),
qlist varchar(500),
answer varchar(500),
qvalid bit
)

create table testScore
(
testid int primary key identity(1,1),
lid int foreign key(lid) references logins(lid),
totalQs int,
correctAns int,
percentage int,
testTime datetime
)

create table Facts
(
fid int primary key identity(1,1),
fname varchar(20),
fdesc varchar(500)
)