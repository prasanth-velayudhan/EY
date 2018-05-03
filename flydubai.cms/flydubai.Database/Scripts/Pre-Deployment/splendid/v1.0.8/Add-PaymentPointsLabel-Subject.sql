use flydubai

if not exists (select null from sysobjects a 
join syscolumns c ON c.id = a.id
where a.type='U'
and a.[name] = 'PaymentPointLabels' and c.[Name] = 'PaymentPointsEmailSubject')
Begin

	Alter Table [dbo].[PaymentPointLabels]
	ADD [PaymentPointsEmailSubject] nvarchar(max) NOT NULL
	CONSTRAINT DF_PaymentPointLabels_PaymentPointsEmailSubject DEFAULT 'Email subject' WITH VALUES 

End
Go

if exists (select NULL from sysobjects where name = 'DF_PaymentPointLabels_PaymentPointsEmailSubject')
BEGIN	
	
	update [PaymentPointLabels] set [PaymentPointsEmailSubject] = 'View payment points map' where [LanguageId] = 1
	update [PaymentPointLabels] set [PaymentPointsEmailSubject] = N'عرض نقاط الدفع الخريطة' where [LanguageId] = 2
	
	ALTER TABLE [dbo].[PaymentPointLabels]
	DROP CONSTRAINT DF_PaymentPointLabels_PaymentPointsEmailSubject
	
	print 'Table PaymentPointsLabels has been updated with column PaymentPointsEmailSubject'

End