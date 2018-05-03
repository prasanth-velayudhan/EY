EXECUTE sp_addrolemember @rolename = N'db_owner', @membername = N'terminal\JHowland';

GO
EXECUTE sp_addrolemember @rolename = N'db_owner', @membername = N'gwedick';


GO
EXECUTE sp_addrolemember @rolename = N'db_owner', @membername = N'WEB2_LIVE_FZ';


GO
EXECUTE sp_addrolemember @rolename = N'db_owner', @membername = N'Web2_UAT_FZ';


GO
EXECUTE sp_addrolemember @rolename = N'db_owner', @membername = N'Web2_UAT7_FZ';


GO
EXECUTE sp_addrolemember @rolename = N'db_owner', @membername = N'Web2_IBS_FZ';


GO
EXECUTE sp_addrolemember @rolename = N'db_datareader', @membername = N'TERMINAL\svaid';


GO
EXECUTE sp_addrolemember @rolename = N'db_denydatawriter', @membername = N'TERMINAL\vpatel';


GO
EXECUTE sp_addrolemember @rolename = N'db_datareader', @membername = N'TERMINAL\mbarrera';


GO
EXECUTE sp_addrolemember @rolename = N'db_datareader', @membername = N'TERMINAL\vpatel';

