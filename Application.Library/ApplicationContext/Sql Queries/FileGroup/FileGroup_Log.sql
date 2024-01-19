IF DB_ID('Performance_Tuning_LogFile_DB') > 0 
BEGIN
	ALTER DATABASE Performance_Tuning_LogFile_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE Performance_Tuning_LogFile_DB
END
GO
CREATE DATABASE Performance_Tuning_LogFile_DB

	ON PRIMARY
	(
		NAME  = Performance_Tuning_LogFile_DB_Primary,
		FILENAME = 'C:\Database\Performance_Tuning_LogFile_DB_Primary.mdf',
		SIZE = 100MB
	),
	FILEGROUP FG_Dimension1
	(
		NAME  = FG_Dimension1,
		FILENAME = 'C:\Database\FG_Dimension1.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	),
	(
		NAME  = FG_Dimension2,
		FILENAME = 'C:\Database\FG_Dimension2.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	),
	FILEGROUP FG_FACT
	(
		NAME  = FG_FACT1,
		FILENAME = 'C:\Database\FG_FACT1.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	),
	(
		NAME  = FG_FACT2,
		FILENAME = 'C:\Database\FG_FACT2.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	)
	LOG ON
	(
		NAME  = Performance_Tuning_LogFile_DB_Log,
		FILENAME = 'C:\Database\Performance_Tuning_LogFile_DB_Log.ldf',
		SIZE = 1GB,
		FILEGROWTH=512MB
	)
-----------------------------------------------------
--ها VLF مشاهده 
DBCC LOGINFO
-----------------------------------------------------
-- مشاهده محتوای لاگ رکورد ها
SELECT * FROM sys.fn_dblog(null,null)