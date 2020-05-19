
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2020 14:21:31
-- Generated from EDMX file: C:\Users\hachi\source\repos\Proiect1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [abel];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FileProperty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Properties] DROP CONSTRAINT [FK_FileProperty];
GO
IF OBJECT_ID(N'[dbo].[FK_FileMetadata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Metadata] DROP CONSTRAINT [FK_FileMetadata];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Files]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Files];
GO
IF OBJECT_ID(N'[dbo].[Properties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Properties];
GO
IF OBJECT_ID(N'[dbo].[Metadata]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Metadata];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FilePath] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Properties'
CREATE TABLE [dbo].[Properties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FileId1] int  NOT NULL,
    [EventName] nvarchar(20)  NOT NULL,
    [PersonName] nvarchar(20)  NOT NULL,
    [LandscapeName] nvarchar(20)  NOT NULL,
    [PlaceName] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Metadata'
CREATE TABLE [dbo].[Metadata] (
    [FileID] int  NOT NULL,
    [FIleType] nvarchar(10)  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsDeleted] bit  NOT NULL,
    [File_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [PK_Properties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Metadata'
ALTER TABLE [dbo].[Metadata]
ADD CONSTRAINT [PK_Metadata]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FileId1] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [FK_FileProperty]
    FOREIGN KEY ([FileId1])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileProperty'
CREATE INDEX [IX_FK_FileProperty]
ON [dbo].[Properties]
    ([FileId1]);
GO

-- Creating foreign key on [File_Id] in table 'Metadata'
ALTER TABLE [dbo].[Metadata]
ADD CONSTRAINT [FK_FileMetadata]
    FOREIGN KEY ([File_Id])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileMetadata'
CREATE INDEX [IX_FK_FileMetadata]
ON [dbo].[Metadata]
    ([File_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------