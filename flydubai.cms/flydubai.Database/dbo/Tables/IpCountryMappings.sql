CREATE TABLE [dbo].[IpCountryMappings] (
    [Id]           INT          NOT NULL,
    [FromIp]       NUMERIC (18) NULL,
    [ToIp]         NUMERIC (18) NULL,
    [CountryCode3] VARCHAR (50) NULL,
    CONSTRAINT [PK_IpCountryMappings] PRIMARY KEY NONCLUSTERED ([Id] ASC)
);

