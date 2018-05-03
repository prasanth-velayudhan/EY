CREATE TABLE [dbo].[ExperienceCategoryVersionMedias] (
    [ExperienceCategoryVersion_ExperienceCategoryVersionId] INT           NOT NULL,
    [Media_MediaId]                                         INT           NOT NULL,
    [Filler]                                                NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ExperienceCategoryVersion_ExperienceCategoryVersionId] ASC, [Media_MediaId] ASC),
    CONSTRAINT [ExperienceCategoryVersion_Images_Source] FOREIGN KEY ([ExperienceCategoryVersion_ExperienceCategoryVersionId]) REFERENCES [dbo].[ExperienceCategoryVersions] ([ExperienceCategoryVersionId]) ON DELETE CASCADE,
    CONSTRAINT [ExperienceCategoryVersion_Images_Target] FOREIGN KEY ([Media_MediaId]) REFERENCES [dbo].[Media] ([MediaId]) ON DELETE CASCADE
);



