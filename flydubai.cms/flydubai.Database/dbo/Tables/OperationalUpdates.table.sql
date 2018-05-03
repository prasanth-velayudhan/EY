CREATE TABLE [dbo].[OperationalUpdates] (
    [OperationalUpdateId]      INT            IDENTITY (1, 1) NOT NULL,
    [Language]                 NVARCHAR (MAX) NULL,
    [IconCssClass]             NVARCHAR (MAX) NULL,
    [Message]                  NVARCHAR (MAX) NULL,
    [VisibleOnContentWebsite]  BIT            NOT NULL,
    [VisibleToRegisteredUsers] BIT            NOT NULL,
    [VisibleToTravelAgents]    BIT            NOT NULL,
    [DateCreated]              DATETIME2 (7)  NOT NULL,
    [DateModified]             DATETIME2 (7)  NOT NULL,
    [DateDeleted]              DATETIME2 (7)  NOT NULL,
    [IsDeleted]                BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([OperationalUpdateId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

