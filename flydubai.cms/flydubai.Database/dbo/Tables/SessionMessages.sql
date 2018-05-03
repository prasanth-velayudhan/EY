CREATE TABLE [dbo].[SessionMessages] (
    [SessionMessageID]  INT            IDENTITY (1, 1) NOT NULL,
    [SessionOutMessage] NVARCHAR (MAX) NULL,
    [Language]          INT            NOT NULL,
    [TA]                INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([SessionMessageID] ASC)
);

