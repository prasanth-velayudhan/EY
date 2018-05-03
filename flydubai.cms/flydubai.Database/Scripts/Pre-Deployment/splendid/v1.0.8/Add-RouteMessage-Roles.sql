use flydubai
go

if not exists(select 1 from [flydubai].[dbo].[Roles] where Name = 'RouteMessageApprover')
begin

	INSERT INTO [flydubai].[dbo].[Roles]
			   ([Name])
		 VALUES
			   ('RouteMessageEditor')

	INSERT INTO [flydubai].[dbo].[Roles]
			   ([Name])
		 VALUES
			   ('RouteMessageApprover')

	INSERT INTO [flydubai].[dbo].[Roles]
			   ([Name])
		 VALUES
			   ('RouteMessagePublisher')


	insert into [flydubai].[dbo].[MemberRole]
	select 1, r.Id from [flydubai].[dbo].[Roles] r where r.Name like 'RouteMessage%'

	print 'Route messages roles created'
end