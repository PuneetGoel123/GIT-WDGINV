CREATE TABLE [dbo].[Item] (
    [ItemId]   INT            IDENTITY (1, 1) NOT NULL,
    [ItemName] NVARCHAR (100) NOT NULL,
    [ItemType] NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([ItemId] ASC)
);

