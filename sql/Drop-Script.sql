IF db_id('LevelUp') IS NOT NULL
BEGIN
  USE [LevelUp];
  
  IF EXISTS (SELECT name FROM sys.database_principals WHERE name = N'LU_App')
  BEGIN
    DROP USER [LU_App];
  END;

  IF EXISTS (SELECT name FROM sys.database_principals WHERE name = N'LU_Read')
  BEGIN
    DROP USER [LU_Read];
  END;

  IF EXISTS (SELECT name FROM sys.database_principals WHERE name = N'LU_SP')
  BEGIN
    DROP USER [LU_SP];
  END;

  IF EXISTS (SELECT name FROM sys.database_principals WHERE name = N'LU_No')
  BEGIN
    DROP USER [LU_No];
  END;

  IF DATABASE_PRINCIPAL_ID('db_execproc') IS NOT NULL
  BEGIN
    DROP ROLE [db_execproc];
  END;

  DROP DATABASE [LevelUp];
END;

USE [master];

IF EXISTS (SELECT loginname FROM master.dbo.syslogins WHERE name = 'LU_App' and dbname = 'LevelUp')
BEGIN
  DROP LOGIN [LU_App];
END;

IF EXISTS (SELECT loginname FROM master.dbo.syslogins WHERE name = 'LU_Read' and dbname = 'LevelUp')
BEGIN
  DROP LOGIN [LU_Read];
END;

IF EXISTS (SELECT loginname FROM master.dbo.syslogins WHERE name = 'LU_SP' and dbname = 'LevelUp')
BEGIN
  DROP LOGIN [LU_SP];
END;

IF EXISTS (SELECT loginname FROM master.dbo.syslogins WHERE name = 'LU_No' and dbname = 'LevelUp')
BEGIN
  DROP LOGIN [LU_No];
END;