﻿CREATE TABLE [dbo].[PaymentPointPartnerTypes] (
    [PaymentPointPartnerTypeId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]                      NVARCHAR (MAX) NOT NULL,
    [InUse]                     BIT            NOT NULL,
    [LanguageId]                INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentPointPartnerTypeId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

