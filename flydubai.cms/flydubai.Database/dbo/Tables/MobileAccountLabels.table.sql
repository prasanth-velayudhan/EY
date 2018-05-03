CREATE TABLE [dbo].[MobileAccountLabels] (
    [Language]                              NVARCHAR (128) NOT NULL,
    [LogInToYourAccount]                    NVARCHAR (MAX) NULL,
    [EmailAddress]                          NVARCHAR (MAX) NULL,
    [Password]                              NVARCHAR (MAX) NULL,
    [ForgotPassword]                        NVARCHAR (MAX) NULL,
    [LogIn]                                 NVARCHAR (MAX) NULL,
    [ResetPassword]                         NVARCHAR (MAX) NULL,
    [YourNewPasswordHasBeenSentToYourEmail] NVARCHAR (MAX) NULL,
    [YouHaveLoggedOut]                      NVARCHAR (MAX) NULL,
    [Home]                                  NVARCHAR (MAX) NULL,
    [BackToTop]                             NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

