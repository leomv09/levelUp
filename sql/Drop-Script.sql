IF db_id('LevelUp') IS NOT NULL
BEGIN

  USE [LevelUp];
  IF EXISTS (SELECT name FROM sys.database_principals WHERE name = N'LevelUp_User')
  BEGIN
    DROP USER [LevelUp_User];
  END;

  USE [master];
  IF EXISTS (SELECT loginname FROM master.dbo.syslogins WHERE name = 'LevelUp_Login' and dbname = 'LevelUp')
  BEGIN
    DROP LOGIN [LevelUp_Login];
  END;

  IF DATABASE_PRINCIPAL_ID('db_execproc') IS NOT NULL
  BEGIN
    DROP ROLE [db_execproc];
  END;

  DROP DATABASE [LevelUp];
END;