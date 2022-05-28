use [BlogDev]

select top 100
    [User].[Name], [User].[Email], [Role].[Name]
from
        [User]
    inner join [UserRole] on [UserRole].[UserId] = [User].[Id]
    inner join [Role] on [UserRole].[RoleId] = [Role].[Id]
