USE flydubai

ALTER TABLE	RouteMessageLabels
ADD			RestrictionsHeading NVARCHAR(MAX) NULL,
			ReadAndUnderstand NVARCHAR(MAX) NULL,
			RouteLabel NVARCHAR(MAX) NULL,
			DateLabel NVARCHAR(MAX) NULL,
			FlightNumLabel NVARCHAR(MAX) NULL,
			DaysAffectedLabel NVARCHAR(MAX) NULL,
			MondayName NVARCHAR(MAX) NULL,
			TuesdayName NVARCHAR(MAX) NULL,
			WednesdayaName NVARCHAR(MAX) NULL,
			ThursdayName NVARCHAR(MAX) NULL,
			FridayName NVARCHAR(MAX) NULL,
			SaturdayName NVARCHAR(MAX) NULL,
			SundayName NVARCHAR(MAX) NULL

GO

UPDATE	RouteMessageLabels
SET		Title = 'Important Notice',
		RestrictionsHeading = 'There are important restrictions on the following flight(s)',
		ReadAndUnderstand = 'Please ensure you have read and understood the restrictions',
		RouteLabel = 'Route',
		DateLabel = 'Date(s)',
		FlightNumLabel = 'Flight number(s)',
		DaysAffectedLabel = 'Days affected',
		MondayName = 'Monday',
		TuesdayName = 'Tuesday',
		WednesdayaName = 'Wednesday',
		ThursdayName = 'Thursday',
		FridayName = 'Friday',
		SaturdayName = 'Saturday',
		SundayName = 'Sunday'

WHERE	Language IN ('ar','en')		-- update both languages for now, don't have arabic copy ...

GO
