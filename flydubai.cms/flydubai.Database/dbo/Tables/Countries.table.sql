CREATE TABLE [dbo].[Countries] (
    [CountryId]                                 INT            IDENTITY (1, 1) NOT NULL,
    [AlphaNumeric2]                             NVARCHAR (2)   NULL,
    [AlphaNumeric3]                             NVARCHAR (3)   NULL,
    [IsoNumeric]                                NVARCHAR (3)   NULL,
    [TelephoneCode]                             NVARCHAR (MAX) NULL,
    [WebsiteLanguage]                           NVARCHAR (MAX) NULL,
    [IsPassportAndNationalityMandatoryTA]       BIT            DEFAULT ((0)) NOT NULL,
    [IsPassportAndNationalityMandatoryConsumer] BIT            DEFAULT ((0)) NOT NULL,
    [IsPassportAndNationalityMandatoryMobile]   BIT            DEFAULT ((0)) NOT NULL,
    [IsApisIsMandatoryTA]                       BIT            DEFAULT ((0)) NOT NULL,
    [IsApisIsMandatoryConsumer]                 BIT            DEFAULT ((0)) NOT NULL,
    [IsCabinTypeAll]                            BIT            CONSTRAINT [DF_Countries_IsCabinTypeAll] DEFAULT ((0)) NOT NULL,
    [IsCabinTypeBusiness]                       BIT            CONSTRAINT [DF_Countries_IsCabinTypeBusiness] DEFAULT ((0)) NOT NULL,
    [IsCabinTypeEconomy]                        BIT            CONSTRAINT [DF_Countries_IsCabinTypeEconomy] DEFAULT ((0)) NOT NULL,
    [IsCabinTypeAllTA]                          BIT            CONSTRAINT [DF_Countries_IsCabinTypeAllTA] DEFAULT ((0)) NOT NULL,
    [IsCabinTypeBusinessTA]                     BIT            CONSTRAINT [DF_Countries_IsCabinTypeBusinessTA] DEFAULT ((0)) NOT NULL,
    [IsCabinTypeEconomyTA]                      BIT            CONSTRAINT [DF_Countries_IsCabinTypeEconomyTA] DEFAULT ((0)) NOT NULL,
    [IsInsuranceMandatoryTA]                    BIT            DEFAULT ((0)) NOT NULL,
    [IsInsuranceMandatoryConsumer]              BIT            DEFAULT ((0)) NOT NULL,
    [IsInsuranceMandatoryMobile]                BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([CountryId] ASC)
);









