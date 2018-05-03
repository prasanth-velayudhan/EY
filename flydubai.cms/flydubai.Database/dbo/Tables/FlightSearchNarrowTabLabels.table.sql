﻿CREATE TABLE [dbo].[FlightSearchNarrowTabLabels] (
    [Language]                            NVARCHAR (128) NOT NULL,
    [ReturnOneWayAccessibilityText]       NVARCHAR (MAX) NULL,
    [ReturnRadioButtonText]               NVARCHAR (MAX) NULL,
    [OneWayRadioButtonText]               NVARCHAR (MAX) NULL,
    [FlyingFromFlyingToAccessibilityText] NVARCHAR (MAX) NULL,
    [FlyingFromLabelText]                 NVARCHAR (MAX) NULL,
    [FlyingFromPlaceholderText]           NVARCHAR (MAX) NULL,
    [FlyingToLabelText]                   NVARCHAR (MAX) NULL,
    [FlyingToPlaceholderText]             NVARCHAR (MAX) NULL,
    [AddMultipleDestinationsButton]       NVARCHAR (MAX) NULL,
    [FlyingDatesAccessibilityText]        NVARCHAR (MAX) NULL,
    [FlyingOutOnLabelText]                NVARCHAR (MAX) NULL,
    [FlyingBackOnLabelText]               NVARCHAR (MAX) NULL,
    [FlexibleOnDatesCheckboxText]         NVARCHAR (MAX) NULL,
    [PassengersAccessibilityText]         NVARCHAR (MAX) NULL,
    [PassengersLabelText]                 NVARCHAR (MAX) NULL,
    [AdultsLabelText]                     NVARCHAR (MAX) NULL,
    [AdultsAgeLabelText]                  NVARCHAR (MAX) NULL,
    [ChildrenLabelText]                   NVARCHAR (MAX) NULL,
    [ChildrenAgeLabelText]                NVARCHAR (MAX) NULL,
    [InfantsLabelText]                    NVARCHAR (MAX) NULL,
    [InfantsAgeLabelText]                 NVARCHAR (MAX) NULL,
    [InfantsTooltipHeadingText]           NVARCHAR (MAX) NULL,
    [InfantsTooltipBodyText]              NVARCHAR (MAX) NULL,
    [GroupBookingsLinkText]               NVARCHAR (MAX) NULL,
    [GroupBookingsTooltipHeadingText]     NVARCHAR (MAX) NULL,
    [GroupBookingsTooltipBodyText]        NVARCHAR (MAX) NULL,
    [GroupBookingsTooltipTelephoneText]   NVARCHAR (MAX) NULL,
    [GroupBookingsTooltipEmailText]       NVARCHAR (MAX) NULL,
    [GroupBookingsTooltipEmailAddress]    NVARCHAR (MAX) NULL,
    [PromoCodeAccessibilityText]          NVARCHAR (MAX) NULL,
    [PromoCodeLabelText]                  NVARCHAR (MAX) NULL,
    [PromoCodePlaceholderText]            NVARCHAR (MAX) NULL,
    [PromoCodeTooltipHeadingText]         NVARCHAR (MAX) NULL,
    [PromoCodeTooltipBodyText]            NVARCHAR (MAX) NULL,
    [SubmitDetailsAccessibilityText]      NVARCHAR (MAX) NULL,
    [ShowFlightsButton]                   NVARCHAR (MAX) NULL,
    [SeeFaqsText]                         NVARCHAR (MAX) NULL,
    [SeeFaqsLinkText]                     NVARCHAR (MAX) NULL,
    [SeeFaqsLinkUrl]                      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

