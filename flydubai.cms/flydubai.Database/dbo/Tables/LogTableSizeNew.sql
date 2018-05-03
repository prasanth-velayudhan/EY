CREATE TABLE [dbo].[LogTableSizeNew] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [tableName]    VARCHAR (100) NULL,
    [numberofRows] VARCHAR (100) NULL,
    [reservedSize] VARCHAR (50)  NULL,
    [dataSize]     VARCHAR (50)  NULL,
    [indexSize]    VARCHAR (50)  NULL,
    [unusedSize]   VARCHAR (50)  NULL,
    [logDate]      DATETIME      DEFAULT (getdate()) NULL
);

