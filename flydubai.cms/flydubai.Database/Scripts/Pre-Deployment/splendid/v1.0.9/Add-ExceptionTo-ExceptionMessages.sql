-- =============================================
-- Script Template
-- =============================================
use [flydubai]

INSERT INTO dbo.ExceptionMessages ([Area], [Key], [Language], [Value]) VALUES (N'Results', N'IsFutureDateValidation', N'en', N'Date must be today or later')
INSERT INTO dbo.ExceptionMessages ([Area], [Key], [Language], [Value]) VALUES (N'Results', N'IsFutureDateValidation', N'ar', N'يجب أن يكون التاريخ في وقت لاحق اليوم أو')


INSERT INTO dbo.ExceptionMessages ([Area], [Key], [Language], [Value]) VALUES (N'Results', N'HasValidParseString', N'en', N'An Item in this list is invalid')
INSERT INTO dbo.ExceptionMessages ([Area], [Key], [Language], [Value]) VALUES (N'Results', N'HasValidParseString', N'ar', N'عنصر في هذه القائمة غير صالح')