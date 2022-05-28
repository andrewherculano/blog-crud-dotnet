USE [BlogDev]

SELECT TOP 100 * FROM [User]

SELECT TOP 100 * FROM [Role]

SELECT TOP 100 * FROM [Tag]

SELECT * FROM [UserRole]

SELECT [User].*, [Role].*
FROM [User]
    LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
    LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]

SELECT * FROM [Category]

select top 100 * from [Post]
