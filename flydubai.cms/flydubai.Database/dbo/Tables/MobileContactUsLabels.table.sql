CREATE TABLE [dbo].[MobileContactUsLabels] (
    [Language]                         NVARCHAR (128) NOT NULL,
    [IAmCallingFrom]                   NVARCHAR (MAX) NULL,
    [SelectCountry]                    NVARCHAR (MAX) NULL,
    [SelectCity]                       NVARCHAR (MAX) NULL,
    [SelectService]                    NVARCHAR (MAX) NULL,
    [GetContactNumber]                 NVARCHAR (MAX) NULL,
    [FilterCities]                     NVARCHAR (MAX) NULL,
    [ServiceRequired]                  NVARCHAR (MAX) NULL,
    [CallingFromCity]                  NVARCHAR (MAX) NULL,
    [FlyDubaiCallCentre]               NVARCHAR (MAX) NULL,
    [FlyDubaiContactNumber]            NVARCHAR (MAX) NULL,
    [NoCallCentresFoundForThisCountry] NVARCHAR (MAX) NULL,
    [NoTravelPartnersFoundForThisCity] NVARCHAR (MAX) NULL,
    [NoPaymentPartnersFoundInThisCity] NVARCHAR (MAX) NULL,
    [PaymentPartners]                  NVARCHAR (MAX) NULL,
    [NoCallCentresFoundForUAE]         NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);



