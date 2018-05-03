USE flydubai_aer
GO

-- All scripting below added from original deployment scripts into UAT.
-- Sections may need re-ordering, file lables can be removed, etc. Currently all comments
-- are for validation checks only.

-- From "Platinum CMS Scripts_22_July_2013.sql"
--OptionalExtrasLabels
UPDATE [dbo].[OptionalExtrasLabels]
	SET [Meal] = N'Meal', [MealDefault] = N'A three-course meal with choice of drinks', 
	[NoDietary] = N'No Dietary Requirements', [VegetarianMeal] = N'Vegetarian oriental meal', 
	[MealDescription] = N'A three-course meal with choice of drinks', 
	[InfantsNotHaveMeal] = N'Infant under 2 years of age are not assigned their own meal' 
	,[Economy]  = N'ECONOMY'
	,[Business]  = N'BUSINESS'
	,[IFEBusinessMessage]  = N'Watch TV and movies on your personal 12.1" HD touchscreen'
	,[BuyMealOnBoard] = N'Buy snacks and drinks on board, if available'
	,[DietaryRequirement]=N'Dietary requirements'
	WHERE  [Language] ='en'
go

--YourJourneyLabels Start here
UPDATE [dbo].[YourJourneyLabels]
	Set [BusinessFare] = N'Business'
	,[Cabin]  = N'Cabin'
	,[BasicFare]  = N'Basic'
	,[Economy]  = N'ECONOMY'
	,[Business]  = N'BUSINESS'
	,[HotMealAndDrinks]  = N'Hot meal and drinks'
	WHERE  [Language] ='en'
	go

--ResultsTabLabels Start here
UPDATE [dbo].[ResultsTabLabels]
Set [Depart] = N'Depart'
	,[Arrive]  = N'Arrive'
	,[BasicFare]  = N'Basic'
	,[Economy]  = N'ECONOMY'
	,[Business]  = N'BUSINESS'
	,[NotAvailable] = N'Not Available'
	WHERE  [Language] ='en'
go

--FareTypeLabels Start here
UPDATE [dbo].[FareTypeLabels]
	Set [FareType4Name] = N'Business'
	WHERE  [LanguageId] = 1
go

--FareTypes Start here
UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 109
	,[Fare4ImageUrl] = N'/en/media/image/109/'
	,[Fare4Description] = N'Includes all taxes and surcharges'
	WHERE  [FareTypeId] = 1
go
	
UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 69
, [Fare4ImageUrl] =  N'/en/media/image/69/'
, [Fare4Description] =  N'A free 15 kg hand baggage allowance'
WHERE  [FareTypeId] = 2
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 68
, [Fare4ImageUrl] = N'/en/media/image/68/'
, [Fare4Description] =  N'Includes 40 kg checked baggage allowance'
WHERE  [FareTypeId] = 3
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 106
, [Fare4ImageUrl] = N'/en/media/image/106/'
, [Fare4Description] = N'You can change your booking. Any difference in fare needs to be paid, but no fee will be charged for changes made more than 24 hours before departure. A fee of AED 365 (per person, per flight) will be charged for changes made less than 24 hours before departure. '
WHERE  [FareTypeId] = 4
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 108
, [Fare4ImageUrl] = N'/en/media/image/108/'
, [Fare4Description] = N'You can cancel your booking. A fee of AED 200 (per person, per flight) will be charged for cancellations made more than 24 hours before departure. A fee of AED 365 (per person, per flight) will be charged for cancellations made less than 24 hours before departure. '
WHERE  [FareTypeId] = 5
go


INSERT [dbo].[BusinessHandBaggages] ([Weight]) VALUES (15)


--CodeTypeCategories
INSERT [dbo].[CodeTypeCategories] ( [Name]) VALUES ( N'Meals')
INSERT [dbo].[CodeTypeCategories] ( [Name]) VALUES ( N'Business Baggage')
INSERT [dbo].[CodeTypeCategories] ( [Name]) VALUES ( N'Business In Flight Entertainment')
go

--CodeTypes Start
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'VGML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'JBAG', 12)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'IFPJ', 13)
go

--CodeTypeLocaliseds start here
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Vegetarian meal requested', N'VGML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'TV + movies on 12.1" HD touchscreen', N'IFPJ')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'40 kg Baggage Allowance', N'JBAG')
go

-- BookingLabels Start here
UPDATE [dbo].[BookingLabels]
	SET [HotMeal] = N'Hot meal'
	  ,[NoMealOptionsInfent] = N'No meal options'
      ,[Economy] = N'ECONOMY'
      ,[Business] = N'BUSINESS'
      ,[Basic] = N'basic'
      ,[BusinessHandBaggage] = N'15 kg hand baggage'
      ,[Premium] = N'Premium'
      ,[BuySnacksAndDrinksOnBoard] = N'Buy snacks and drinks on board'
      ,[Meal] = N'Meal'
	WHERE  [Language] ='en'
go

-- From "Platinum CMS Scripts_23_July_2013.sql"
-- SeatMapping
INSERT [dbo].[seatmappings]([FlightNo], [FlightType], [Cabin]) VALUES ( N'12B', N'PLAT', N'BUSINESS')
INSERT [dbo].[seatmappings]([FlightNo], [FlightType], [Cabin]) VALUES ( N'162Y', N'PLAT', N'ECONOMY')
INSERT [dbo].[seatmappings]([FlightNo], [FlightType], [Cabin]) VALUES ( N'162Y', N'73M', N'ECONOMY')
INSERT [dbo].[seatmappings]([FlightNo], [FlightType], [Cabin]) VALUES ( N'189Y', N'73H', N'ECONOMY')

INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'DBML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'VLML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'AVML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'CHML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'LSML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'HNML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'LFML', 11)
INSERT [dbo].[CodeTypes] ([CodeTypeId], [CodeTypeCategory_CodeTypeCategoryId]) VALUES (N'VOML', 11)

INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Diabetic meal requested', N'DBML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Vegetarian lacto-ovo meal requested', N'VLML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Asian vegetarian meal requested', N'AVML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Vegetarian oriental meal requested', N'VOML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Child meal requested', N'CHML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Low salt meal requested', N'LSML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Hindu meal requested', N'HNML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'en', N'Low fat meal requested', N'LFML')

-- From "Platinum CMS Scripts_26_July_2013.sql"
UPDATE [dbo].[ResultsTabLabels]
   SET [NoFlights] = 'No Flights Available'
WHERE Language='en'
GO

-- OptionalExtrasLabels
UPDATE [dbo].[OptionalExtrasLabels]
	SET [Meal] = N'وجبة', [MealDefault] = N'وجبة من ثلاثة أطباق مع خيار من المشروبات', 
	[NoDietary] = N'لا يوجد متطلبات الغذائية', [VegetarianMeal] = N'وجبة نباتي الشرقية', 
	[MealDescription] = N'وجبة من ثلاثة أطباق مع خيار من المشروبات', 
	[InfantsNotHaveMeal] = N'لم يتم تعيينها الرضع أقل من 2 سنة من العمر وجبة خاصة بهم' 
	,[Economy]  = N'الاقتصاد'
	,[Business]  = N'عمل'
	,[IFEBusinessMessage]  = N'مشاهدة التلفزيون والأفلام على الشخصية 12.1 "HD شاشة تعمل باللمس'
	,[BuyMealOnBoard] = N'شراء الوجبات الخفيفة والمشروبات على متن الطائرة، إذا كانت متوفرة'
	,[DietaryRequirement]=N'المتطلبات الغذائية'
	WHERE  [Language] ='ar'
	
	UPDATE [dbo].[YourJourneyLabels]
	Set [BusinessFare] = N'عمل'
	,[Cabin]  = N'قمرة'
	,[BasicFare]  = N'الأساسية'
	,[Economy]  = N'الاقتصاد'
	,[Business]  = N'عمل'
	,[HotMealAndDrinks]  = N'وجبة ساخنة ومشروبات'
	WHERE  [Language] ='ar'
	
	UPDATE [dbo].[ResultsTabLabels]
Set [Depart] = N'غادر'
	,[Arrive]  = N'وصل'
	,[BasicFare]  = N'الأساسية'
	,[Economy]  = N'الاقتصاد'
	,[Business]  = N'عمل'
	,[NotAvailable] = N'غير متاح'
	WHERE  [Language] ='ar'
	
	UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 109
	,[Fare4ImageUrl] = N'/ar/media/image/109/'
	,[Fare4Description] = N'يشمل جميع الضرائب والرسوم الإضافية'
	WHERE  [FareTypeId] = 11 
go

-- FareTypes
UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 69
, [Fare4ImageUrl] =  N'/ar/media/image/69/'
, [Fare4Description] =  N'الافراج عن 15 كجم اليد بدل الأمتعة'
WHERE  [FareTypeId] = 12
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 68
, [Fare4ImageUrl] = N'/ar/media/image/68/'
, [Fare4Description] =  N'يتضمن 40 كجم فحص الأمتعة المسموح بها'
WHERE  [FareTypeId] = 13
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 106
, [Fare4ImageUrl] = N'/ar/media/image/106/'
, [Fare4Description] = N'يمكنك تغيير الحجز الخاص بك. أي فرق في أجرة يحتاج إلى أن يدفع، ولكن لا يتوجب دفع رسوم للالتغييرات التي تم إجراؤها قبل مغادرة أكثر من 24 ساعة. سيتم دفع مبلغ 365 درهم (لكل شخص، لكل رحلة) لالتغييرات التي تم إجراؤها قبل المغادرة أقل من 24 ساعة.'
WHERE  [FareTypeId] = 14
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 108
, [Fare4ImageUrl] = N'/ar/media/image/108/'
, [Fare4Description] = N'يمكنك إلغاء الحجز الخاص بك. سيتم دفع مبلغ 200 درهم (للشخص في الرحلة) لالغاء أدلى قبل المغادرة أكثر من 24 ساعة. سيتم دفع مبلغ 365 درهم (لكل شخص، لكل رحلة) لالغاء أدلى قبل المغادرة أقل من 24 ساعة.'
WHERE  [FareTypeId] = 15
go

-- CodeTypeLocaliseds
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'طلب وجبة نباتية', N'VGML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'تلفزيون + الأفلام على 12.1 "HD شاشة تعمل باللمس', N'IFPJ')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'40 كجم وزن الأمتعة', N'JBAG')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'طلبت وجبة مرضى السكري', N'DBML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'وجبة نباتية شركة لاكتو البيضة مطلوب', N'VLML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'طلب وجبة نباتية آسيوية', N'AVML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'مطلوب وجبة الشرقية نباتي', N'VOML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'طلبت وجبة الطفل', N'CHML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'طلبت وجبة منخفضة الملح', N'LSML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'طلبت وجبة الهندوسية', N'HNML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ar', N'طلبت وجبة منخفضة الدهون', N'LFML')

-- BookingLabels
UPDATE [dbo].[BookingLabels]
	SET [HotMeal] = N'وجبة ساخنة'
	  ,[NoMealOptionsInfent] = N'توجد خيارات وجبة'
      ,[Economy] = N'الاقتصاد'
      ,[Business] = N'عمل'
      ,[Basic] = N'الأساسية'
      ,[BusinessHandBaggage] = N'15 كلغ حقائب اليد'
      ,[Premium] = N'علاوة'
      ,[BuySnacksAndDrinksOnBoard] = N'شراء الوجبات الخفيفة والمشروبات على متن الطائرة'
      ,[Meal] = N'وجبة'
	WHERE  [Language] ='ar'
go

-- From "Platinum CMS Scripts_30_July_2013.sql"
Update [dbo].[SeatMappings] set FlightType='73B' where Cabin='BUSINESS' AND FlightNo='12B'

-- From "Platinum CMS Scripts_31_July_2013.sql"
Update [dbo].[SeatMappings] set FlightType='73B' where Cabin='ECONOMY' AND FlightNo='162Y' AND FlightType='PLAT'
GO
INSERT INTO [ExceptionMessages]([Language],[Key],[Value],[Area])
  VALUES ('en', 'BusinessTicketCouldNotFindBooking', N'Sorry, we were unable to find your booking. Please verify the details you''ve entered and try again. ', 'Search'),
      ('ar', 'BusinessTicketCouldNotFindBooking', N'عفواً، لم نتمكن من العثور على الحجز الخاص بك. يرجى التأكد من التفاصيل التي قمت بإدخالها والمحاولة مرة ثانية.', 'Search')
GO

UPDATE [dbo].[OptionalExtrasLabels]
      SET [MealDescription] = N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.',[MealHeading]= N'Meal'
      WHERE  [Language] ='en'
GO

-- From "Platinum CMS Scripts_02_Aug_2013.sql"
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Vegetarian meal' where [CodeType_CodeTypeId] = 'VGML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Enjoy movies on the 12.1-inch built-in touchscreen' where [CodeType_CodeTypeId] = 'IFPJ' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'40 kg checked baggage allowance' where [CodeType_CodeTypeId] = 'JBAG' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Diabetic meal' where [CodeType_CodeTypeId] = 'DBML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Vegetarian lacto-ovo meal' where [CodeType_CodeTypeId] = 'VLML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Asian vegetarian meal' where [CodeType_CodeTypeId] = 'AVML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Vegetarian oriental meal' where [CodeType_CodeTypeId] = 'VOML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Child meal' where [CodeType_CodeTypeId] = 'CHML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Low salt meal' where [CodeType_CodeTypeId] = 'LSML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Hindu meal' where [CodeType_CodeTypeId] = 'HNML' and [Language] = 'en'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Low fat meal' where [CodeType_CodeTypeId] = 'LFML' and [Language] = 'en'
GO

-- From "Platinum CMS Scripts_04_Aug_2013.sql"
UPDATE [dbo].[OptionalExtrasLabels]
	SET [Meal] = N'Meal', [MealDefault] = N'A three-course meal with choice of drinks', 
	[NoDietary] = N'No Dietary Requirements', [VegetarianMeal] = N'Vegetarian oriental meal', 
	[MealDescription] = N'A three-course meal with choice of drinks', 
	[InfantsNotHaveMeal] = N'Infant under 2 years of age are not assigned their own meal' 
	,[Economy]  = N'ECONOMY'
	,[Business]  = N'BUSINESS'
	,[IFEBusinessMessage]  = N'Watch TV and movies on your personal 12.1" HD touchscreen'
	,[BuyMealOnBoard] = N'Buy snacks and drinks on board, if available'
	,[DietaryRequirement]=N'Dietary requirements'
	WHERE  [Language] ='ru'
go

UPDATE [dbo].[YourJourneyLabels]
	Set [BusinessFare] = N'Business'
	,[Cabin]  = N'Cabin'
	,[BasicFare]  = N'Basic'
	,[Economy]  = N'ECONOMY'
	,[Business]  = N'BUSINESS'
	,[HotMealAndDrinks]  = N'Hot meal and drinks'
	WHERE  [Language] ='ru'
go	

UPDATE [dbo].[ResultsTabLabels]
Set [Depart] = N'Depart'
	,[Arrive]  = N'Arrive'
	,[BasicFare]  = N'Basic'
	,[Economy]  = N'ECONOMY'
	,[Business]  = N'BUSINESS'
	,[NotAvailable] = N'Not Available'
	WHERE  [Language] ='ru'
	
go

UPDATE [dbo].[FareTypeLabels]
	Set [FareType4Name] = N'Business'
	WHERE  [LanguageId] = 3
	
go
	
UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 109
	,[Fare4ImageUrl] = N'/ru/media/image/109/'
	,[Fare4Description] = N'Includes all taxes and surcharges'
	WHERE  [FareTypeId] = 21
go
	
UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 69
, [Fare4ImageUrl] =  N'/ru/media/image/69/'
, [Fare4Description] =  N'A free 15 kg hand baggage allowance'
WHERE  [FareTypeId] = 22
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 68
, [Fare4ImageUrl] = N'/ru/media/image/68/'
, [Fare4Description] =  N'Includes 40 kg checked baggage allowance'
WHERE  [FareTypeId] = 23
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 106
, [Fare4ImageUrl] = N'/ru/media/image/106/'
, [Fare4Description] = N'You can change your booking. Any difference in fare needs to be paid, but no fee will be charged for changes made more than 24 hours before departure. A fee of AED 365 (per person, per flight) will be charged for changes made less than 24 hours before departure. '
WHERE  [FareTypeId] = 24
go

UPDATE [dbo].[FareTypes]
Set [Fare4Image] = 108
, [Fare4ImageUrl] = N'/ru/media/image/108/'
, [Fare4Description] = N'You can cancel your booking. A fee of AED 200 (per person, per flight) will be charged for cancellations made more than 24 hours before departure. A fee of AED 365 (per person, per flight) will be charged for cancellations made less than 24 hours before departure. '
WHERE  [FareTypeId] = 25
go


INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Vegetarian meal requested', N'VGML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'TV + movies on 12.1" HD touchscreen', N'IFPJ')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'40 kg Baggage Allowance', N'JBAG')
go

update [dbo].[CodeTypeLocaliseds] set [Name] =N'Vegetarian meal' where [CodeType_CodeTypeId] = 'VGML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Enjoy movies on the 12.1-inch built-in touchscreen' where [CodeType_CodeTypeId] = 'IFPJ' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'40 kg checked baggage allowance' where [CodeType_CodeTypeId] = 'JBAG' and [Language] = 'ru'
go
UPDATE [dbo].[BookingLabels]
	SET [HotMeal] = N'Hot meal'
	  ,[NoMealOptionsInfent] = N'No meal options'
      ,[Economy] = N'ECONOMY'
      ,[Business] = N'BUSINESS'
      ,[Basic] = N'basic'
      ,[BusinessHandBaggage] = N'15 kg hand baggage'
      ,[Premium] = N'Premium'
      ,[BuySnacksAndDrinksOnBoard] = N'Buy snacks and drinks on board'
      ,[Meal] = N'Meal'
	WHERE  [Language] ='ru'
go

INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Diabetic meal requested', N'DBML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Vegetarian lacto-ovo meal requested', N'VLML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Asian vegetarian meal requested', N'AVML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Vegetarian oriental meal requested', N'VOML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Child meal requested', N'CHML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Low salt meal requested', N'LSML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Hindu meal requested', N'HNML')
INSERT [dbo].[CodeTypeLocaliseds] ( [Language], [Name], [CodeType_CodeTypeId]) VALUES ( N'ru', N'Low fat meal requested', N'LFML')

go
UPDATE [dbo].[OptionalExtrasLabels]
      SET [MealDescription] = N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.',[MealHeading]= N'Meal'
      WHERE  [Language] ='ru'
      
go
UPDATE [dbo].[OptionalExtrasLabels]
      SET [MealDescription] = N'Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.',
      [MealHeading]= N'Meal'
      WHERE  [Language] ='ar'
go
INSERT INTO [ExceptionMessages]([Language],[Key],[Value],[Area])
  VALUES ('ru', 'BusinessTicketCouldNotFindBooking', N'Sorry, we were unable to find your booking. Please verify the details you''ve entered and try again. ', 'Search')
GO

-- From "Platinum CMS Scripts_07_Aug_2013.sql"
UPDATE OptionalExtrasLabels
SET InfantsNotHaveTASSRAssigned = N'Infants under 2 years of age don’t have their own visa allowance '
WHERE [Language] = 'en'

UPDATE OptionalExtrasLabels
SET InfantsNotHaveTASSRAssigned = N'الرضع أقل من 2 سنة من العمر لم يكن لديك المسموح لهم تأشيرة خاصة'
WHERE [Language] = 'ar'

UPDATE OptionalExtrasLabels
SET InfantsNotHaveTASSRAssigned = N'Дети до 2-летнего возраста не имеют своих собственных пособие визы'
WHERE [Language] = 'ru'

update [dbo].[CodeTypeLocaliseds] set [Name] =N'Enjoy movies on the 12.1-inch built-in HD touchscreen' where [CodeType_CodeTypeId] = 'IFPJ' and [Language] = 'en'

update [dbo].[CodeTypeLocaliseds] set [Name] =N'الوجبة النباتية' where [CodeType_CodeTypeId] = 'VGML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'وجبة مرضى السكري ' where [CodeType_CodeTypeId] = 'DBML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'الوجبة النباتية الخالية من اللحوم (تحتوي على المنتجات الحيوانية)' where [CodeType_CodeTypeId] = 'VLML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'الوجبة النباتية الآسيوية ' where [CodeType_CodeTypeId] = 'AVML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'الوجبة النباتية الشرقية ' where [CodeType_CodeTypeId] = 'VOML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'وجبة الأطفال' where [CodeType_CodeTypeId] = 'CHML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'الوجبة قليلة الملح ' where [CodeType_CodeTypeId] = 'LSML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'الوجبة الهندوسية' where [CodeType_CodeTypeId] = 'HNML' and [Language] = 'ar'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'الوجبة قليلة الدسم ' where [CodeType_CodeTypeId] = 'LFML' and [Language] = 'ar'

update [dbo].[CodeTypeLocaliseds] set [Name] =N'Вегетарианский обед' where [CodeType_CodeTypeId] = 'VGML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Диабетическое питание' where [CodeType_CodeTypeId] = 'DBML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Вегетарианский молочно-яичный обед ' where [CodeType_CodeTypeId] = 'VLML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Азиатский вегетарианский обед' where [CodeType_CodeTypeId] = 'AVML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Восточный вегетарианский обед' where [CodeType_CodeTypeId] = 'VOML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Детский обед' where [CodeType_CodeTypeId] = 'CHML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Обед с пониженным содержанием соли' where [CodeType_CodeTypeId] = 'LSML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Индийский обед' where [CodeType_CodeTypeId] = 'HNML' and [Language] = 'ru'
update [dbo].[CodeTypeLocaliseds] set [Name] =N'Обед с низким содержанием жира' where [CodeType_CodeTypeId] = 'LFML' and [Language] = 'ru'
go
