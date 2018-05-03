-- =============================================
-- Script Template
-- =============================================
use flydubai

if not exists (select null from sysobjects a 
join syscolumns c ON c.id = a.id
where a.type='U'
and a.[name] = 'RouteMessageLabels')
Begin

	Create Table [dbo].[RouteMessageLabels] (
		[Language] nvarchar(128) Not NULL,
		[Title] nvarchar(max) NOT NULL,
		[AcceptButton] nvarchar(max) NOT NULL,
		[CancelButton] nvarchar(max) NOT NULL,
		PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
		);
		

		
	insert into [RouteMessageLabels] ([Language], [Title], [AcceptButton], [CancelButton]) values('en', 'Message from webpage', 'Accept', 'Cancel');
	insert into [RouteMessageLabels] ([Language], [Title], [AcceptButton], [CancelButton]) values('ar', N'رسالة من صفحة ويب', N'قبل', N'إلغاء');	
	

End
Go