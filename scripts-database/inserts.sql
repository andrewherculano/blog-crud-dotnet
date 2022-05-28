use [BlogDev]

insert into 
    [User]
values (
    'Andrew Herculano',
    'andrew@global.com',
    'HASH',
    'Desenvolvedor Junior',
    'https://img.com',
    'andrew-herculano'
)

insert into 
    [User]
values (
    'Harry Potter',
    'harry_p@email.com',
    'HASH',
    'Mago',
    'https://img2.com',
    'harry-potter'
)

insert into 
    [Role]
values (
    'Autor',
    'autor'
)

insert into 
    [Role]
values (
    'Premium',
    'premium'
)

insert into 
    [Tag]
values (
    'ASP.NET',
    'asp-net'
)

insert into [UserRole] values (1, 1)

INSERT INTO [Category]
VALUES ('Categoria Teste 1', 'categoria-teste')


select * from [Post]
select * from [Role]
select * from [Category]
select * from [User]

insert into [Post] ([CategoryId], [AuthorId], [Title], [Summary], [Body], [Slug], [CreateDate], [LastUpdateDate])
values (1, 1, 'Post Titulo 1', 'Sumario teste', 'POST BODY', 'post-slug', '01/05/2022', '01/05/2014')

insert into [Post] ([CategoryId], [AuthorId], [Title], [Summary], [Body], [Slug], [CreateDate], [LastUpdateDate])
values (1, 2, 'Post Titulo 2', 'Sumario 2', 'POST BODY', 'post-2', '10/05/2022', '11/05/2014')