-- step 1
create database [BlogDev]

-- step 2
use [BlogDev]

-- table user
create table [User] (
    [Id] int not null identity(1, 1),
    [Name] nvarchar(100) not null,
    [Email] varchar(200) not null,
    [PasswordHash] varchar(255) not null,
    [Bio] text not null,
    [Image] varchar(2000) not null,
    [Slug] varchar(80) not null,

    constraint [PK_User] primary key([Id]),
    constraint [UQ_User_Email] unique([Email]),
    constraint [UQ_User_Slug] unique([Slug])
)
-- indexs user
create nonclustered index [IX_User_Email] on [User]([Email])
create nonclustered index [IX_User_Slug] on [User]([Slug])

-- table role
create table [Role] (
    [Id] int not null identity(1, 1),
    [Name] varchar(80) not null,
    [Slug] varchar(80) not null,

    constraint [PK_Role] primary key([Id]),
    constraint [UQ_Role_Slug] unique([Slug])
)
-- index role
create nonclustered index [IX_Role_Slug] on [Role]([Slug])

--table user role
create table [UserRole] (
    [UserId] int not null,
    [RoleId] int not null,

    constraint [PK_UserRole] primary key ([UserId], [RoleId])
)

--table category
create table [Category] (
    [Id] int not null identity(1, 1),
    [Name] varchar(80) not null,
    [Slug] varchar(80) not null,

    constraint [PK_Category] primary key([Id]),
    constraint [UQ_Category_Slug] unique([Slug])
)
-- index category
create nonclustered index [IX_Category_Slug] on [Category]([Slug])

-- table post
create table [Post] (
    [Id] int not null identity(1, 1),
    [CategoryId] int not null,
    [AuthorId] int not null,
    [Title] varchar(160) not null,
    [Summary] varchar(255) not null,
    [Body] text not null,
    [Slug] varchar(80) not null,
    [CreateDate] datetime not null default(GETDATE()),
    [LastUpdateDate] datetime not null default(GETDATE()),

    constraint [PK_Post] primary key([Id]),
    constraint [FK_Post_Category] foreign key([CategoryId]) references [Category]([Id]),
    constraint [FK_Post_Author] foreign key([AuthorId]) references [User]([Id]),
    constraint [UQ_Post_Slug] unique([Slug])
)
-- index post
create nonclustered index [IX_Post_Slug] ON [Post]([Slug])

-- table tag
create table [Tag] (
    [Id] int not null identity(1, 1),
    [Name] varchar(80) not null,
    [Slug] varchar(80) not null,

    constraint [PK_Tag] primary key([Id]),
    constraint [UQ_Tag_Slug] unique([Slug])
)
-- index tag
create nonclustered index [IX_Tag_Slug] ON [Tag]([Slug])

-- table post tag
create table [PostTag] (
    [PostId] int not null,
    [TagId] int not null,

    constraint PK_PostTag primary key([PostId], [TagId])
)
