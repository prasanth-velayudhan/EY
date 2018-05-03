CREATE TABLE [dbo].[MonthLocaliseds] (
    [MonthLocalisedId] INT           IDENTITY (1, 1) NOT NULL,
    [Month]            INT           NOT NULL,
    [MonthCode]        NVARCHAR (50) NOT NULL,
    [Language]         NVARCHAR (50) NOT NULL
);

