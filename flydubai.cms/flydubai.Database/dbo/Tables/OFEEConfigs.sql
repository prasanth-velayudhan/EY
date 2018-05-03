CREATE TABLE [dbo].[OFEEConfigs] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [ParentIATA]   VARCHAR (20)    NOT NULL,
    [Origin]       CHAR (3)        NOT NULL,
    [Destination]  CHAR (3)        NOT NULL,
    [Currency]     CHAR (3)        NOT NULL,
    [OFEE]         DECIMAL (18, 3) NOT NULL,
    [Active]       BIT             NOT NULL,
    [DateModified] DATE            NOT NULL
);

