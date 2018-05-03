USE flydubai


ALTER TABLE [dbo].[RouteMessageVersions]
DROP COLUMN [ActivePeriodStartDate], 
			 [ActivePeriodEndDate], 
			 [FlightNumRanges], 
			 [FlightDateRanges]
 GO
 
ALTER TABLE [dbo].[RouteMessageVersions]
ADD [PublishPeriodStartDate] DATETIME2 (7)  NOT NULL,
	[PublishPeriodEndDate]   DATETIME2 (7)  NOT NULL,
	[RouteDateRangeFrom]     DATETIME2 (7)  NULL,
	[RouteDateRangeTo]       DATETIME2 (7)  NULL,
	[AffectedDates]          NVARCHAR (MAX) NULL,
	[FlightNumberStartRange] INT            NULL,
	[FlightNumberEndRange]   INT            NULL,
	[AffectedFlightNumbers]  NVARCHAR (MAX) NULL
GO


	