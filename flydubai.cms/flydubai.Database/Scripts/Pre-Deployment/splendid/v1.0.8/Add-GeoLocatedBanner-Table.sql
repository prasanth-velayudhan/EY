-- =============================================
-- Script Template
-- =============================================

use [flydubai]

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

BEGIN TRANSACTION;

if not exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'GeolocatedBanners')
Begin

	CREATE TABLE [dbo].[GeolocatedBanners] (
		[GeolocatedBannerId]		INT IDENTITY (1, 1) NOT NULL,
		[LanguageId]			INT	NOT NULL,
		PRIMARY KEY CLUSTERED ([GeolocatedBannerId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
	);

End
Go

if not exists (select null from sysobjects a
	where a.type='U'
	and a.[name] = 'GeolocatedBannerVersions')
Begin

	CREATE TABLE [dbo].[GeolocatedBannerVersions] (
		[GeolocatedBannerVersionId]	INT IDENTITY (1, 1) NOT NULL,
        [CountryId]					INT					NOT NULL,
		[Url]						NVARCHAR   (MAX)	NULL,
		[Image]						INT					NULL,
        [StartDate]					DATETIME2  (7)		NOT NULL,
        [EndDate]					DATETIME2  (7)		NOT NULL,
		[IsDefault]					BIT					NOT NULL,
        [ParentId]					INT					NOT NULL,
		[UrlIdentifier]				NVARCHAR  (MAX)		NULL,
		[CmsName]					NVARCHAR  (MAX)		NULL,
		[Version]					INT					NOT NULL,
		[IsDraft]					BIT					NOT NULL,
		[CreatedById]				INT					NULL,
		[CreatedDate]				DATETIME2 (7)		NULL,
		[ApprovedById]				INT					NULL,
		[ApprovedDate]				DATETIME2 (7)		NULL,
		[PublishedById]				INT					NULL,
		[PublishedDate]				DATETIME2 (7)		NULL,
		[UnpublishedById]			INT					NULL,
		[UnpublishedDate]			DATETIME2 (7)		NULL,
		PRIMARY KEY CLUSTERED ([GeolocatedBannerVersionId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
	);

End
Go

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

Go

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH NOCHECK
		ADD CONSTRAINT [GeolocatedBannerVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[GeolocatedBanners] ([GeolocatedBannerId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

	Go

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH NOCHECK
		ADD CONSTRAINT [GeolocatedBannerVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

	Go

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH NOCHECK
		ADD CONSTRAINT [GeolocatedBannerVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

	Go

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH NOCHECK
		ADD CONSTRAINT [GeolocatedBannerVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

	GO

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH NOCHECK
		ADD CONSTRAINT [GeolocatedBannerVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

	Go

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH CHECK CHECK CONSTRAINT [GeolocatedBannerVersion_Parent];

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH CHECK CHECK CONSTRAINT [GeolocatedBannerVersion_ApprovedBy];

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH CHECK CHECK CONSTRAINT [GeolocatedBannerVersion_CreatedBy];

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH CHECK CHECK CONSTRAINT [GeolocatedBannerVersion_PublishedBy];

	ALTER TABLE [dbo].[GeolocatedBannerVersions] WITH CHECK CHECK CONSTRAINT [GeolocatedBannerVersion_UnpublishedBy];

Go