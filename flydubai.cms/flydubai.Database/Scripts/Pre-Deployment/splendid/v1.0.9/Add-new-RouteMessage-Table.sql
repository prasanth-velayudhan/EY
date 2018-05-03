-- =============================================
-- Script Template
-- =============================================
use [flydubai]


ALTER TABLE [dbo].[RouteMessageVersions]
	DROP CONSTRAINT [RouteMessageVersion_Parent];

Go

ALTER TABLE [dbo].[RouteMessageVersions]
	DROP CONSTRAINT [RouteMessageVersion_ApprovedBy];

Go

ALTER TABLE [dbo].[RouteMessageVersions]
	DROP CONSTRAINT [RouteMessageVersion_CreatedBy];

Go

ALTER TABLE [dbo].[RouteMessageVersions]
	DROP CONSTRAINT [RouteMessageVersion_PublishedBy];

GO

ALTER TABLE [dbo].[RouteMessageVersions]
	DROP CONSTRAINT [RouteMessageVersion_UnpublishedBy];

Go

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

BEGIN TRANSACTION;

if exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'RouteMessageVersions')
Begin
	
	Drop Table [RouteMessageVersions]

End
Go

if exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'RouteMessages')
Begin
	
	Drop Table [RouteMessages]

End
Go

if not exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'RouteMessages')
Begin
	CREATE TABLE [dbo].[RouteMessages] (
		[RouteMessageId]		INT IDENTITY (1, 1) NOT NULL,
		[LanguageId]			INT	NOT NULL,
		PRIMARY KEY CLUSTERED ([RouteMessageId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
	);
End
Go


if not exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'RouteMessageVersions')
Begin

	CREATE TABLE [dbo].[RouteMessageVersions] (
		[RouteMessageVersionId]		INT IDENTITY (1, 1) NOT NULL,
		[Title]						NVARCHAR  (MAX) NOT NULL,
		[OriginAirportCode]			NVARCHAR  (3)	NOT NULL,
        [DestinationAirportCode]	NVARCHAR  (3)	NOT NULL,
        [PublishPeriodStartDate]	DATETIME2 (7)	NOT NULL,
        [PublishPeriodEndDate]		DATETIME2 (7)	NOT NULL,
		[RouteDateRangeFrom]		DATETIME2 (7)	NULL,
		[RouteDateRangeTo]			DATETIME2 (7)	NULL,
		[AffectedDates]				NVARCHAR  (MAX) NULL,
		[FlightNumberStartRange]	int				NULL,
		[FlightNumberEndRange]		int				NULL,
		[AffectedFlightNumbers]		NVARCHAR  (MAX) NULL,
        [Message]					NVARCHAR  (MAX)	NOT NULL,
        [OnMonday]					BIT				NULL,
        [OnTuesday]					BIT				NULL,
        [OnWednesday]				BIT				NULL,
        [OnThursday]				BIT				NULL,
        [OnFriday]					BIT				NULL,
        [OnSaturday]				BIT				NULL,
        [OnSunday]					BIT				NULL,
        [ParentId]					INT				NOT NULL,
		[UrlIdentifier]				NVARCHAR  (MAX)	NULL,
		[CmsName]					NVARCHAR  (MAX) NULL,
		[Version]					INT				NOT NULL,
		[IsDraft]					BIT				NOT NULL,
		[CreatedById]				INT				NULL,
		[CreatedDate]				DATETIME2 (7)	NULL,
		[ApprovedById]				INT				NULL,
		[ApprovedDate]				DATETIME2 (7)	NULL,
		[PublishedById]				INT				NULL,
		[PublishedDate]				DATETIME2 (7)	NULL,
		[UnpublishedById]			INT				NULL,
		[UnpublishedDate]			DATETIME2 (7)	NULL,
		PRIMARY KEY CLUSTERED ([RouteMessageVersionId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
	);

End
Go

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

Go

ALTER TABLE [dbo].[RouteMessageVersions] WITH NOCHECK
	ADD CONSTRAINT [RouteMessageVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[RouteMessages] ([RouteMessageId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

Go

ALTER TABLE [dbo].[RouteMessageVersions] WITH NOCHECK
	ADD CONSTRAINT [RouteMessageVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

Go

ALTER TABLE [dbo].[RouteMessageVersions] WITH NOCHECK
	ADD CONSTRAINT [RouteMessageVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

Go

ALTER TABLE [dbo].[RouteMessageVersions] WITH NOCHECK
	ADD CONSTRAINT [RouteMessageVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

GO

ALTER TABLE [dbo].[RouteMessageVersions] WITH NOCHECK
	ADD CONSTRAINT [RouteMessageVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

Go

ALTER TABLE [dbo].[RouteMessageVersions] WITH CHECK CHECK CONSTRAINT [RouteMessageVersion_Parent];

ALTER TABLE [dbo].[RouteMessageVersions] WITH CHECK CHECK CONSTRAINT [RouteMessageVersion_ApprovedBy];

ALTER TABLE [dbo].[RouteMessageVersions] WITH CHECK CHECK CONSTRAINT [RouteMessageVersion_CreatedBy];

ALTER TABLE [dbo].[RouteMessageVersions] WITH CHECK CHECK CONSTRAINT [RouteMessageVersion_PublishedBy];

ALTER TABLE [dbo].[RouteMessageVersions] WITH CHECK CHECK CONSTRAINT [RouteMessageVersion_UnpublishedBy];