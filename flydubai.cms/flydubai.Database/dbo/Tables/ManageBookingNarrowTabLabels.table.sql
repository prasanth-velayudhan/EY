﻿CREATE TABLE [dbo].[ManageBookingNarrowTabLabels] (
    [Language]                                 NVARCHAR (128) NOT NULL,
    [YourBookingDetailsSectionText]            NVARCHAR (MAX) NULL,
    [YourBookingDetailsParagraph1Text]         NVARCHAR (MAX) NULL,
    [YourBookingDetailsParagraph2BoldText]     NVARCHAR (MAX) NULL,
    [YourBookingDetailsParagraph3Text]         NVARCHAR (MAX) NULL,
    [FindBookingAccessibilityText]             NVARCHAR (MAX) NULL,
    [BookingReferenceLabelText]                NVARCHAR (MAX) NULL,
    [LastNameLabelText]                        NVARCHAR (MAX) NULL,
    [ConfirmAuthorisedCheckbox]                NVARCHAR (MAX) NULL,
    [ViewBookingButton]                        NVARCHAR (MAX) NULL,
    [AlreadyRegisteredSectionText]             NVARCHAR (MAX) NULL,
    [AlreadyRegisteredParagraph1Text]          NVARCHAR (MAX) NULL,
    [LogInToAccountAccessibilityText]          NVARCHAR (MAX) NULL,
    [EmailAddressLabelText]                    NVARCHAR (MAX) NULL,
    [PasswordLabelText]                        NVARCHAR (MAX) NULL,
    [ForgottenDetailsLink]                     NVARCHAR (MAX) NULL,
    [LoginToAccountButton]                     NVARCHAR (MAX) NULL,
    [WantToRegisterSectionText]                NVARCHAR (MAX) NULL,
    [WantToRegisterParagraph1Text]             NVARCHAR (MAX) NULL,
    [RegisterHereLink]                         NVARCHAR (MAX) NULL,
    [LoggedInYourBookingDetailsParagraphText]  NVARCHAR (MAX) NULL,
    [LoggedInConfirmAuthorisedCheckbox]        NVARCHAR (MAX) NULL,
    [LoggedInActiveBookingsSectionTitle]       NVARCHAR (MAX) NULL,
    [LoggedInActiveBookingsParagraphText]      NVARCHAR (MAX) NULL,
    [LoggedInActiveBookingOriginToDestination] NVARCHAR (MAX) NULL,
    [LoggedInActiveBookingsViewAllButton]      NVARCHAR (MAX) NULL,
    [LoggedInYourProfileSectionTitle]          NVARCHAR (MAX) NULL,
    [LoggedInYourProfileParagraphText]         NVARCHAR (MAX) NULL,
    [LoggedInYourProfileManageProfileButton]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

