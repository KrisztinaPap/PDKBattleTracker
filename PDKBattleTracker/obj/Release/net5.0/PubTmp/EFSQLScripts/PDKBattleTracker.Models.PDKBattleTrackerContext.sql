IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210124190928_InitialCreate')
BEGIN
    CREATE TABLE [Games] (
        [GameId] int NOT NULL IDENTITY,
        [GameDate] datetime2 NOT NULL,
        [Player1Name] nvarchar(max) NULL,
        [Player2Name] nvarchar(max) NULL,
        [Player1Faction] nvarchar(max) NULL,
        [Player2Faction] nvarchar(max) NULL,
        [Player1Score] int NOT NULL,
        [Player2Score] int NOT NULL,
        [Winner] nvarchar(max) NULL,
        CONSTRAINT [PK_Games] PRIMARY KEY ([GameId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210124190928_InitialCreate')
BEGIN
    CREATE TABLE [Players] (
        [PlayerId] int NOT NULL IDENTITY,
        [PlayerName] nvarchar(max) NULL,
        [PlayerTotalScore] int NOT NULL,
        CONSTRAINT [PK_Players] PRIMARY KEY ([PlayerId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210124190928_InitialCreate')
BEGIN
    CREATE TABLE [GamePlayer] (
        [GameId] int NOT NULL,
        [PlayerId] int NOT NULL,
        CONSTRAINT [PK_GamePlayer] PRIMARY KEY ([GameId], [PlayerId]),
        CONSTRAINT [FK_GamePlayer_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [Games] ([GameId]) ON DELETE CASCADE,
        CONSTRAINT [FK_GamePlayer_Players_PlayerId] FOREIGN KEY ([PlayerId]) REFERENCES [Players] ([PlayerId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210124190928_InitialCreate')
BEGIN
    CREATE INDEX [IX_GamePlayer_PlayerId] ON [GamePlayer] ([PlayerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210124190928_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210124190928_InitialCreate', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210126211547_Jan26-01')
BEGIN
    ALTER TABLE [Games] ADD [PlayerId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210126211547_Jan26-01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210126211547_Jan26-01', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210126222444_Jan26-02')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210126222444_Jan26-02', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127012326_Jan26-03')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127012326_Jan26-03', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127012811_Jan26-04')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127012811_Jan26-04', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127013127_Jan26-05')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Players]') AND [c].[name] = N'PlayerName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Players] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Players] ALTER COLUMN [PlayerName] nvarchar(max) NOT NULL;
    ALTER TABLE [Players] ADD DEFAULT N'' FOR [PlayerName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127013127_Jan26-05')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'Player2Name');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Games] ALTER COLUMN [Player2Name] nvarchar(max) NOT NULL;
    ALTER TABLE [Games] ADD DEFAULT N'' FOR [Player2Name];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127013127_Jan26-05')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'Player2Faction');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Games] ALTER COLUMN [Player2Faction] nvarchar(max) NOT NULL;
    ALTER TABLE [Games] ADD DEFAULT N'' FOR [Player2Faction];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127013127_Jan26-05')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'Player1Name');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Games] ALTER COLUMN [Player1Name] nvarchar(max) NOT NULL;
    ALTER TABLE [Games] ADD DEFAULT N'' FOR [Player1Name];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127013127_Jan26-05')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'Player1Faction');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Games] ALTER COLUMN [Player1Faction] nvarchar(max) NOT NULL;
    ALTER TABLE [Games] ADD DEFAULT N'' FOR [Player1Faction];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127013127_Jan26-05')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127013127_Jan26-05', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127020941_Jan26-06')
BEGIN
    ALTER TABLE [Games] ADD [FactionId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127020941_Jan26-06')
BEGIN
    CREATE TABLE [Factions] (
        [FactionId] int NOT NULL IDENTITY,
        [FactionName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Factions] PRIMARY KEY ([FactionId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127020941_Jan26-06')
BEGIN
    CREATE TABLE [GameFaction] (
        [GameId] int NOT NULL,
        [FactionId] int NOT NULL,
        CONSTRAINT [PK_GameFaction] PRIMARY KEY ([GameId], [FactionId]),
        CONSTRAINT [FK_GameFaction_Factions_FactionId] FOREIGN KEY ([FactionId]) REFERENCES [Factions] ([FactionId]) ON DELETE CASCADE,
        CONSTRAINT [FK_GameFaction_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [Games] ([GameId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127020941_Jan26-06')
BEGIN
    CREATE INDEX [IX_GameFaction_FactionId] ON [GameFaction] ([FactionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127020941_Jan26-06')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127020941_Jan26-06', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127170913_2021-01-27-01')
BEGIN
    ALTER TABLE [Games] ADD [SubFactionId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127170913_2021-01-27-01')
BEGIN
    CREATE TABLE [SubFactions] (
        [SubFactionId] int NOT NULL IDENTITY,
        [SubFactionName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_SubFactions] PRIMARY KEY ([SubFactionId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127170913_2021-01-27-01')
BEGIN
    CREATE TABLE [FactionSubFaction] (
        [FactionId] int NOT NULL,
        [SubFactionId] int NOT NULL,
        CONSTRAINT [PK_FactionSubFaction] PRIMARY KEY ([FactionId], [SubFactionId]),
        CONSTRAINT [FK_FactionSubFaction_Factions_FactionId] FOREIGN KEY ([FactionId]) REFERENCES [Factions] ([FactionId]) ON DELETE CASCADE,
        CONSTRAINT [FK_FactionSubFaction_SubFactions_SubFactionId] FOREIGN KEY ([SubFactionId]) REFERENCES [SubFactions] ([SubFactionId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127170913_2021-01-27-01')
BEGIN
    CREATE TABLE [GameSubFaction] (
        [GameId] int NOT NULL,
        [SubFactionId] int NOT NULL,
        CONSTRAINT [PK_GameSubFaction] PRIMARY KEY ([GameId], [SubFactionId]),
        CONSTRAINT [FK_GameSubFaction_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [Games] ([GameId]) ON DELETE CASCADE,
        CONSTRAINT [FK_GameSubFaction_SubFactions_SubFactionId] FOREIGN KEY ([SubFactionId]) REFERENCES [SubFactions] ([SubFactionId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127170913_2021-01-27-01')
BEGIN
    CREATE INDEX [IX_FactionSubFaction_SubFactionId] ON [FactionSubFaction] ([SubFactionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127170913_2021-01-27-01')
BEGIN
    CREATE INDEX [IX_GameSubFaction_SubFactionId] ON [GameSubFaction] ([SubFactionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127170913_2021-01-27-01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127170913_2021-01-27-01', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127171443_2021-01-27-02')
BEGIN
    ALTER TABLE [Games] ADD [Player1SubFaction] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127171443_2021-01-27-02')
BEGIN
    ALTER TABLE [Games] ADD [Player2SubFaction] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127171443_2021-01-27-02')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127171443_2021-01-27-02', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127172105_2021-01-27-03')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127172105_2021-01-27-03', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210128171316_2021-01-28-01')
BEGIN
    ALTER TABLE [Games] ADD [GameSizeId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210128171316_2021-01-28-01')
BEGIN
    CREATE TABLE [GameSizes] (
        [GameSizeId] int NOT NULL IDENTITY,
        [GameSizeName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_GameSizes] PRIMARY KEY ([GameSizeId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210128171316_2021-01-28-01')
BEGIN
    CREATE TABLE [GameGameSize] (
        [GameId] int NOT NULL,
        [GameSizeId] int NOT NULL,
        CONSTRAINT [PK_GameGameSize] PRIMARY KEY ([GameId], [GameSizeId]),
        CONSTRAINT [FK_GameGameSize_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [Games] ([GameId]) ON DELETE CASCADE,
        CONSTRAINT [FK_GameGameSize_GameSizes_GameSizeId] FOREIGN KEY ([GameSizeId]) REFERENCES [GameSizes] ([GameSizeId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210128171316_2021-01-28-01')
BEGIN
    CREATE INDEX [IX_GameGameSize_GameSizeId] ON [GameGameSize] ([GameSizeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210128171316_2021-01-28-01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210128171316_2021-01-28-01', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129160040_2021-01-29-01')
BEGIN
    ALTER TABLE [Games] ADD [MissionId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129160040_2021-01-29-01')
BEGIN
    CREATE TABLE [Mission] (
        [MissionId] int NOT NULL IDENTITY,
        [MissionName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Mission] PRIMARY KEY ([MissionId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129160040_2021-01-29-01')
BEGIN
    CREATE TABLE [GameMission] (
        [GameId] int NOT NULL,
        [MissionId] int NOT NULL,
        CONSTRAINT [PK_GameMission] PRIMARY KEY ([GameId], [MissionId]),
        CONSTRAINT [FK_GameMission_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [Games] ([GameId]) ON DELETE CASCADE,
        CONSTRAINT [FK_GameMission_Mission_MissionId] FOREIGN KEY ([MissionId]) REFERENCES [Mission] ([MissionId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129160040_2021-01-29-01')
BEGIN
    CREATE INDEX [IX_GameMission_MissionId] ON [GameMission] ([MissionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129160040_2021-01-29-01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210129160040_2021-01-29-01', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    ALTER TABLE [GameMission] DROP CONSTRAINT [FK_GameMission_Mission_MissionId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    ALTER TABLE [Mission] DROP CONSTRAINT [PK_Mission];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    EXEC sp_rename N'[Mission]', N'Missions';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    ALTER TABLE [Games] ADD [GameTypeId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    ALTER TABLE [Missions] ADD CONSTRAINT [PK_Missions] PRIMARY KEY ([MissionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    CREATE TABLE [GameTypes] (
        [GameTypeId] int NOT NULL IDENTITY,
        [GameTypeName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_GameTypes] PRIMARY KEY ([GameTypeId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    CREATE TABLE [GameGameType] (
        [GameId] int NOT NULL,
        [GameTypeId] int NOT NULL,
        CONSTRAINT [PK_GameGameType] PRIMARY KEY ([GameId], [GameTypeId]),
        CONSTRAINT [FK_GameGameType_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [Games] ([GameId]) ON DELETE CASCADE,
        CONSTRAINT [FK_GameGameType_GameTypes_GameTypeId] FOREIGN KEY ([GameTypeId]) REFERENCES [GameTypes] ([GameTypeId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    CREATE INDEX [IX_GameGameType_GameTypeId] ON [GameGameType] ([GameTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    ALTER TABLE [GameMission] ADD CONSTRAINT [FK_GameMission_Missions_MissionId] FOREIGN KEY ([MissionId]) REFERENCES [Missions] ([MissionId]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129161830_2021-01-29-03')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210129161830_2021-01-29-03', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129162749_2021-01-29-04')
BEGIN
    ALTER TABLE [Games] ADD [GameSystemId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129162749_2021-01-29-04')
BEGIN
    CREATE TABLE [GameSystems] (
        [GameSystemId] int NOT NULL IDENTITY,
        [GameSystemName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_GameSystems] PRIMARY KEY ([GameSystemId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129162749_2021-01-29-04')
BEGIN
    CREATE TABLE [GameGameSystem] (
        [GameId] int NOT NULL,
        [GameSystemId] int NOT NULL,
        CONSTRAINT [PK_GameGameSystem] PRIMARY KEY ([GameId], [GameSystemId]),
        CONSTRAINT [FK_GameGameSystem_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [Games] ([GameId]) ON DELETE CASCADE,
        CONSTRAINT [FK_GameGameSystem_GameSystems_GameSystemId] FOREIGN KEY ([GameSystemId]) REFERENCES [GameSystems] ([GameSystemId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129162749_2021-01-29-04')
BEGIN
    CREATE INDEX [IX_GameGameSystem_GameSystemId] ON [GameGameSystem] ([GameSystemId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129162749_2021-01-29-04')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210129162749_2021-01-29-04', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    EXEC sp_rename N'[Games].[Winner]', N'Player2Secondary3', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Custom1] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Custom2] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1PrimaryRound2Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1PrimaryRound3Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1PrimaryRound4Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1PrimaryRound5Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Secondary1Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Secondary1text] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Secondary2] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Secondary2Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Secondary3] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player1Secondary3Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2Custom1] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2Custom2] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2PrimaryRound2Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2PrimaryRound3Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2PrimaryRound4Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2PrimaryRound5Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2Secondary1Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2Secondary1text] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2Secondary2] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2Secondary2Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    ALTER TABLE [Games] ADD [Player2Secondary3Points] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129165605_2021-01-29-05')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210129165605_2021-01-29-05', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129232359_2021-01-29-06')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'Player1Score');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Games] DROP COLUMN [Player1Score];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129232359_2021-01-29-06')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'Player2Score');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Games] DROP COLUMN [Player2Score];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129232359_2021-01-29-06')
BEGIN
    ALTER TABLE [Players] ADD [NumberOfWins] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129232359_2021-01-29-06')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210129232359_2021-01-29-06', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129232515_2021-01-29-07')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210129232515_2021-01-29-07', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210129233545_2021-01-29-08')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210129233545_2021-01-29-08', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210201215318_2021-02-01-01')
BEGIN
    ALTER TABLE [Games] ADD [GameSystemName] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210201215318_2021-02-01-01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210201215318_2021-02-01-01', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210209180551_2021-02-09-01')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Players]') AND [c].[name] = N'NumberOfWins');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Players] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Players] DROP COLUMN [NumberOfWins];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210209180551_2021-02-09-01')
BEGIN
    ALTER TABLE [Games] ADD [IsCompleted] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210209180551_2021-02-09-01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210209180551_2021-02-09-01', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210227194946_2021-02-27-01')
BEGIN
    DROP TABLE [FactionSubFaction];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210227194946_2021-02-27-01')
BEGIN
    DROP TABLE [GameSubFaction];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210227194946_2021-02-27-01')
BEGIN
    DROP TABLE [SubFactions];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210227194946_2021-02-27-01')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'IsCompleted');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Games] DROP COLUMN [IsCompleted];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210227194946_2021-02-27-01')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Games]') AND [c].[name] = N'SubFactionId');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Games] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Games] DROP COLUMN [SubFactionId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210227194946_2021-02-27-01')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210227194946_2021-02-27-01', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210227215521_2021-02-27-02')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210227215521_2021-02-27-02', N'5.0.3');
END;
GO

COMMIT;
GO

