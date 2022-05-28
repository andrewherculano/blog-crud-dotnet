use [BlogDev]

select * from [User]
select * from [Role]
select * from [Post]

alter table
    [User]
add
    [RoleId] int null

alter table
    [User]
add foreign key ([RoleId]) references [Role]([Id])
    
insert into 
    [User]
values ('Teste com perfil id', 'testeper@email.com', 'HASH', 'bio teste', 'http://img.com', 'perfil-id', 2)

select 
    [User].*, [Role].*
from 
    [User]
    inner join [UserRole] on [UserRole].[UserId] = [User].[Id]
    inner join [Role] on [UserRole].[RoleId] = [Role].[Id]

insert into [UserRole] values (2005, 1002)
