CREATE TABLE [dbo].[RouteMessageLabels] (
    [Language]            NVARCHAR (128) NOT NULL,
    [Title]               NVARCHAR (MAX) NOT NULL,
    [AcceptButton]        NVARCHAR (MAX) NOT NULL,
    [CancelButton]        NVARCHAR (MAX) NOT NULL,
    [RestrictionsHeading] NVARCHAR (MAX) NULL,
    [ReadAndUnderstand]   NVARCHAR (MAX) NULL,
    [RouteLabel]          NVARCHAR (MAX) NULL,
    [DateLabel]           NVARCHAR (MAX) NULL,
    [FlightNumLabel]      NVARCHAR (MAX) NULL,
    [DaysAffectedLabel]   NVARCHAR (MAX) NULL,
    [MondayName]          NVARCHAR (MAX) NULL,
    [TuesdayName]         NVARCHAR (MAX) NULL,
    [WednesdayaName]      NVARCHAR (MAX) NULL,
    [ThursdayName]        NVARCHAR (MAX) NULL,
    [FridayName]          NVARCHAR (MAX) NULL,
    [SaturdayName]        NVARCHAR (MAX) NULL,
    [SundayName]          NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);

