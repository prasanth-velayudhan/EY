CREATE TABLE [dbo].[MobileHomeLabels] (
    [Language]         NVARCHAR (128) NOT NULL,
    [BookFlight]       NVARCHAR (MAX) NULL,
    [FlightStatus]     NVARCHAR (MAX) NULL,
    [Timetable]        NVARCHAR (MAX) NULL,
    [ViewTicket]       NVARCHAR (MAX) NULL,
    [ContactUs]        NVARCHAR (MAX) NULL,
    [MyBookings]       NVARCHAR (MAX) NULL,
    [FlydubaiFullSite] NVARCHAR (MAX) NULL,
    [Policies]         NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);



