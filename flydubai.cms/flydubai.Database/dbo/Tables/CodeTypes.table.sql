CREATE TABLE [dbo].[CodeTypes] (
    [CodeTypeId]                          NVARCHAR (128) NOT NULL,
    [CodeTypeCategory_CodeTypeCategoryId] INT            NULL,
    [GdsEnabled]                          BIT            DEFAULT ((0)) NOT NULL,
    [MasterCode]                          VARCHAR (20)   NULL,
    PRIMARY KEY CLUSTERED ([CodeTypeId] ASC),
    CONSTRAINT [CodeTypeCategory_CodeTypes] FOREIGN KEY ([CodeTypeCategory_CodeTypeCategoryId]) REFERENCES [dbo].[CodeTypeCategories] ([CodeTypeCategoryId])
);







