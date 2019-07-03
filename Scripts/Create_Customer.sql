CREATE TABLE [dbo].[Customer]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50),
	[Status] TINYINT DEFAULT(1),
	[CreateTime] DATETIME
)
