use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION

INSERT INTO dbo.CodeTypeCategories ([Name]) VALUES (N'In Flight Entertainment')
GO

INSERT INTO dbo.CodeTypes ([CodeTypeId] , [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'IFPP',10)
GO

INSERT INTO dbo.CodeTypeLocaliseds ([Language],[Name],[CodeType_CodeTypeId]) VALUES (N'en',N'Premium In Flight Entertainment Package',N'IFPP')
GO

INSERT INTO dbo.CodeTypeLocaliseds ([Language],[Name],[CodeType_CodeTypeId]) VALUES (N'ar',N'Premium In Flight Entertainment Package',N'IFPP')
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO