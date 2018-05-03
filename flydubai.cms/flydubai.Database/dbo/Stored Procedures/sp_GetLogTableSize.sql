-- =============================================
-- Author:		Gillian Wedick, flydubai
-- Create date: 21st Feb 2015
-- Description:	Get Log table size. Job will run this hourly
-- first entry at 7.45am first schedule will run at 8am
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetLogTableSize] 

--select * from LogtableSize
--exec sp_GetLogTableSize

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
SET NOCOUNT ON


DECLARE @cmdstr varchar(100)
DECLARE @Sort bit
SELECT @Sort = 0 /* Edit this value for sorting options */

CREATE TABLE [dbo].[#LogTableSize2](
	[tableName] [varchar](100) NULL,
	[numberofRows] [varchar](100) NULL,
	[reservedSize] [varchar](50) NULL,
	[dataSize] [varchar](50) NULL,
	[indexSize] [varchar](50) NULL,
	[unusedSize] [varchar](50) NULL
) ON [PRIMARY]

--Create Stored Procedure String

SELECT @cmdstr = 'sp_spaceused "Log"'
--Populate Tempoary Table
 INSERT INTO #LogTableSize2 EXEC(@cmdstr)
 
	INSERT INTO LogTableSizeNew (tablename, numberofRows, reservedSize, datasize, indexsize,unusedsize, logdate) 
	SELECT *, getdate()
	FROM [#LogTableSize2] 
	
DROP TABLE [#LogTableSize2]

END