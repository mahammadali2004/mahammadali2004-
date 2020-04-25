create table Users(
id int primary key identity,
Fullname nvarchar (150)not null,
Email nvarchar (200) unique,
Password nvarchar(250)not null,
IsAdmin bit  default 0 not null,
IsActivated bit default 0 not null,
IsDeleted bit default 1 not null,

)