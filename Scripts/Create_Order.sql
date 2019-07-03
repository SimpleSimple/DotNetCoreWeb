CREATE TABLE [dbo].[Order] (
    [Id]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [OrderNo]    NVARCHAR (100) NOT NULL,
    [CustomerId] BIGINT         NOT NULL,
    [GoodsId]    BIGINT         NOT NULL,
    [Total]      DECIMAL (6, 2) NULL,
    [Status]     TINYINT        DEFAULT ((1)) NOT NULL,
    [CreateId]   BIGINT         NULL,
    [CreateTime] DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

