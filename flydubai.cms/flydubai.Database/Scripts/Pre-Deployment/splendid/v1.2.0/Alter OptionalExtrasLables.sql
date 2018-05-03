use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.OptionalExtrasLabels ADD
        InFlightEntertainment nvarchar(MAX) NULL,
        WantInflightEntertainment nvarchar(MAX) NULL,
        WantInflightEntertainmentDescription nvarchar(MAX) NULL,
        NoInFlightEntertainment nvarchar(MAX) NULL,																			
	    InFlightEntertainmentPackageDescription nvarchar(MAX) NULL,
	    DifferentIFEForEachFlight nvarchar(MAX) NULL,
	    InfantsNotHaveIFEAssigned nvarchar(MAX) NULL,
	    IFEUnavailableOnThisFlight nvarchar(MAX) NULL
GO
ALTER TABLE dbo.OptionalExtrasLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.OptionalExtrasLabels SET InFlightEntertainment = N'In-flight entertainment', 
                                WantInflightEntertainment  = N'Want to be entertained on your flight?', 
                                WantInflightEntertainmentDescription = N'For as little as AED 30 you can get access to over 300 music CDs, games, 150 TV shows and almost 200 movies.', 
                                NoInFlightEntertainment = N'Buy on board, if available', 
                                InFlightEntertainmentPackageDescription = N'Premium In-flight Entertainment Package {0} {1}', 
                                DifferentIFEForEachFlight = N'Choose a different package for each flight', 
                                InfantsNotHaveIFEAssigned = N'Infant under 2 years of age are not assigned their own In-flight Entertainment', 
                                IFEUnavailableOnThisFlight = N'Buy on board, if available.'  where [Language] = 'en'
GO

UPDATE dbo.OptionalExtrasLabels SET InFlightEntertainment = N'نظام الترفيه على متن الطائرة', 
                                WantInflightEntertainment  = N'هل تريد أن تستمتع بوقتك خلال الرحلة؟', 
                                WantInflightEntertainmentDescription = N'مقابل رسوم بسيطة ك 30 درهم يمكنك الحصول على صلاحية الاستمتاع بأكثر من 300 خيار من الموسيقى المتنوعة، الألعاب، 150 عرض تلفزيوني و 200  فيلم.', 
                                NoInFlightEntertainment = N'الشراء على متن الطائرة، إن وجد.', 
                                InFlightEntertainmentPackageDescription = N'Premium In-flight Entertainment Package {0} {1}', 
                                DifferentIFEForEachFlight = N'اختر حزمة مختلفة لكل رحلة', 
                                InfantsNotHaveIFEAssigned = N'الأطفال بعمر أقل من سنتين (لا يشغل مقعد على الطائرة) لن يتمكنوا من الاستفادة من نظام الترفيه على متن الطائرة.', 
                                IFEUnavailableOnThisFlight = N'الشراء على متن الطائرة، إن وجد.'  where [Language] = 'ar'
GO
COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO