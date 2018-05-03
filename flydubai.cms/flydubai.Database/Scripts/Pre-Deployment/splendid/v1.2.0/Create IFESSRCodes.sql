use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
CREATE TABLE [dbo].[IFESSRCodes]
(
    [IFESSRCodeId] INT IDENTITY (1, 1) NOT NULL,
    [IFECode]        NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([IFESSRCodeId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
)
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.IFESSRCodes SET (LOCK_ESCALATION = TABLE)
GO

INSERT INTO dbo.IFESSRCodes ([IFECode]) VALUES (N'IFPP')
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO