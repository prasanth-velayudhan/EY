-- =============================================
-- Author:		Gillian WEdick, flydubai
-- Create date: 21st Feb 2015
-- Description:	Get flydubai_aer tx logsize
-- =============================================
CREATE PROCEDURE sp_GetTxLogSize
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into TxLogSize
    select size*8, GETDATE()  as date
    from sysfiles where fileid = 2
    
    --select * from TxLogSize
END