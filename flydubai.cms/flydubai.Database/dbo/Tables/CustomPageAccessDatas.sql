CREATE TABLE [dbo].[CustomPageAccessDatas] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [CustomPageID]   INT            NOT NULL,
    [UserID]         INT            NOT NULL,
    [AccessLevel]    INT            CONSTRAINT [DF_CustomPageAccess_AccessLevel] DEFAULT ((1)) NOT NULL,
    [CustomPageName] NVARCHAR (MAX) NOT NULL,
    [Url]            NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_CustomPageAccessDatas] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'1- admin, 2 - Editor', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'CustomPageAccessDatas', @level2type = N'COLUMN', @level2name = N'AccessLevel';

