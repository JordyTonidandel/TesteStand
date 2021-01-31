IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Cliente] (
    [Id] int NOT NULL IDENTITY,
    [Razao_social] nvarchar(450) NULL,
    [Cnpj] nvarchar(450) NULL,
    [Data_fundacao] datetime2 NOT NULL,
    [Capital] float NOT NULL,
    [Quarentena] bit NOT NULL,
    [Status_cliente] bit NOT NULL,
    [Classificacao] nvarchar(1) NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY ([Id])
);

GO

CREATE UNIQUE INDEX [IX_Cliente_Cnpj] ON [Cliente] ([Cnpj]) WHERE [Cnpj] IS NOT NULL;

GO

CREATE UNIQUE INDEX [IX_Cliente_Razao_social] ON [Cliente] ([Razao_social]) WHERE [Razao_social] IS NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210131212320_ClienteModel', N'3.1.6');

GO

