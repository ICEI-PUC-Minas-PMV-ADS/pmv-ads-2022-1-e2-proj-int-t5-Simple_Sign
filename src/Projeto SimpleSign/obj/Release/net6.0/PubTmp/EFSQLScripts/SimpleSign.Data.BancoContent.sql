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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220427015343_CriandoTabelaContatos')
BEGIN
    CREATE TABLE [Contatos] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [CPF] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Contatos] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220427015343_CriandoTabelaContatos')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220427015343_CriandoTabelaContatos', N'6.0.5');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220502024811_CriacaoTabelaUsuario')
BEGIN
    CREATE TABLE [Usuarios] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NULL,
        [Login] nvarchar(max) NULL,
        [Email] nvarchar(max) NOT NULL,
        [Perfil] int NOT NULL,
        [Senha] nvarchar(max) NULL,
        [DataCadastro] datetime2 NOT NULL,
        [DataAtualizacao] datetime2 NULL,
        CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220502024811_CriacaoTabelaUsuario')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220502024811_CriacaoTabelaUsuario', N'6.0.5');
END;
GO

COMMIT;
GO

