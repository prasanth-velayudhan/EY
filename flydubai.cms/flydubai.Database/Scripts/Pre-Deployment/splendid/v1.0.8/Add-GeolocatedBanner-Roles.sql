-- =============================================
-- Script Template
-- =============================================
use flydubai
go

if not exists(select 1 from [flydubai].[dbo].[Roles] where Name = 'GeolocatedBannerApprover')
begin

	INSERT INTO [flydubai].[dbo].[Roles]
			   ([Name])
		 VALUES
			   ('GeolocatedBannerEditor')

	INSERT INTO [flydubai].[dbo].[Roles]
			   ([Name])
		 VALUES
			   ('GeolocatedBannerApprover')

	INSERT INTO [flydubai].[dbo].[Roles]
			   ([Name])
		 VALUES
			   ('GeolocatedBannerPublisher')


	insert into [flydubai].[dbo].[MemberRole]
	select 1, r.Id from [flydubai].[dbo].[Roles] r where r.Name like 'GeolocatedBanner%'

	print 'Geo-located Banner roles created'
end