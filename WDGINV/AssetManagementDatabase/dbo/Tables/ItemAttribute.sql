CREATE TABLE [dbo].[ItemAttribute] (
    [AttributeId]   INT           IDENTITY (1, 1) NOT NULL,
    [AttributeName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Attribute] PRIMARY KEY CLUSTERED ([AttributeId] ASC)
);

