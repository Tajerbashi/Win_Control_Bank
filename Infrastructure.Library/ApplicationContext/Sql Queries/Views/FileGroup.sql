SP_HELPFILE
SELECT FILE_ID,NAME,SIZE,MAX_SIZE,GROWTH FROM SYS.Database_Files

IF DB_ID('Performance_TuningDB') > 0 
BEGIN
	ALTER DATABASE Performance_TuningDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE Performance_TuningDB
END
GO

CREATE DATABASE Performance_TuningDB

	ON PRIMARY
	(
		NAME  = Performance_TuningDB_Primary,
		FILENAME = 'C:\Database\Performance_TuningDB_Primary.mdf',
		SIZE = 100MB
	),
	FILEGROUP FG_Data
	(
		NAME  = FG_Data_1,
		FILENAME = 'C:\Database\FG_Data_1.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	),
	FILEGROUP FG_Index
	(
		NAME  = FG_Index_1,
		FILENAME = 'C:\Database\FG_Index_1.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	),
	FILEGROUP FG_Blob
	(
		NAME  = FG_Blob_1,
		FILENAME = 'C:\Database\FG_Blob_1.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	),
	(
		NAME  = FG_Blob_2,
		FILENAME = 'C:\Database\FG_Blob_2.ndf',
		SIZE = 1GB,
		FILEGROWTH=1GB
	)
	LOG ON
	(
		NAME  = Performance_TuningDB_Log,
		FILENAME = 'C:\Database\Performance_TuningDB_Log.ldf',
		SIZE = 1GB,
		FILEGROWTH=512MB
	)