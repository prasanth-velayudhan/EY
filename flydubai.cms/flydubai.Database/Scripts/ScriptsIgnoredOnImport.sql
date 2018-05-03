
-- =============================================
-- Script Template
-- =============================================
use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION;
GO
if not exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'RouteMessages')
Begin
	--The following statement was imported into the database project as a schema object and named dbo.RouteMessages.
--CREATE TABLE [dbo].[RouteMessages] (
--		[RouteMessageId]		INT IDENTITY (1, 1) NOT NULL,
--		[LanguageId]			INT	NOT NULL,
--		PRIMARY KEY CLUSTERED ([RouteMessageId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
--	);

End
GO
if not exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'RouteMessageVersions')
Begin

	--The following statement was imported into the database project as a schema object and named dbo.RouteMessageVersions.
--CREATE TABLE [dbo].[RouteMessageVersions] (
--		[RouteMessageVersionId]		INT IDENTITY (1, 1) NOT NULL,
--		[OriginAirportCode]			NVARCHAR  (3)	NOT NULL,
--        [DestinationAirportCode]	NVARCHAR  (3)	NOT NULL,
--        [ActivePeriodStartDate]		DATETIME2 (7)	NOT NULL,
--        [ActivePeriodEndDate]		DATETIME2 (7)	NULL,
--        [FlightNumRanges]			NVARCHAR  (MAX) NULL,
--        [FlightDateRanges]			NVARCHAR  (MAX) NULL,
--        [Message]					NVARCHAR  (MAX)	NOT NULL,
--        [OnMonday]					BIT				NULL,
--        [OnTuesday]					BIT				NULL,
--        [OnWednesday]				BIT				NULL,
--        [OnThursday]				BIT				NULL,
--        [OnFriday]					BIT				NULL,
--        [OnSaturday]				BIT				NULL,
--        [OnSunday]					BIT				NULL,
--        [ParentId]					INT				NOT NULL,
--		[UrlIdentifier]				NVARCHAR  (MAX)	NULL,
--		[CmsName]					NVARCHAR  (MAX) NULL,
--		[Version]					INT				NOT NULL,
--		[IsDraft]					BIT				NOT NULL,
--		[CreatedById]				INT				NULL,
--		[CreatedDate]				DATETIME2 (7)	NULL,
--		[ApprovedById]				INT				NULL,
--		[ApprovedDate]				DATETIME2 (7)	NULL,
--		[PublishedById]				INT				NULL,
--		[PublishedDate]				DATETIME2 (7)	NULL,
--		[UnpublishedById]			INT				NULL,
--		[UnpublishedDate]			DATETIME2 (7)	NULL,
--		PRIMARY KEY CLUSTERED ([RouteMessageVersionId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
--	);


End
GO
COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

GO
