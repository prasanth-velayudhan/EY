ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [flydubai_aer], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

