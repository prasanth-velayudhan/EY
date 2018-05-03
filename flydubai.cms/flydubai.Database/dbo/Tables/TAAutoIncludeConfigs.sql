CREATE TABLE [dbo].[TAAutoIncludeConfigs] (
    [TAAutoIncludeMeal] BIT          NULL,
    [TAAutoIncludeIFE]  BIT          NULL,
    [MealCode]          NCHAR (20)   NULL,
    [ID]                INT          IDENTITY (1, 1) NOT NULL,
    [WrapMealCode]      VARCHAR (20) NULL
);



