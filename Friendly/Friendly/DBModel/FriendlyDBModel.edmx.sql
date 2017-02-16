
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/16/2017 10:59:02
-- Generated from EDMX file: C:\Users\Ann-Kathrine\Source\Repos\Friendly\Friendly\Friendly\DBModel\FriendlyDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FriendlyDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FieldOfProfessionProfile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Profiles] DROP CONSTRAINT [FK_FieldOfProfessionProfile];
GO
IF OBJECT_ID(N'[dbo].[FK_Profile_Location_Location]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Profile_Location] DROP CONSTRAINT [FK_Profile_Location_Location];
GO
IF OBJECT_ID(N'[dbo].[FK_Profile_Location_Profile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Profile_Location] DROP CONSTRAINT [FK_Profile_Location_Profile];
GO
IF OBJECT_ID(N'[dbo].[FK_Profile_LocationPurpose]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Profile_Location] DROP CONSTRAINT [FK_Profile_LocationPurpose];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FieldOfProfessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FieldOfProfessions];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Profile_Location]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profile_Location];
GO
IF OBJECT_ID(N'[dbo].[Profiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profiles];
GO
IF OBJECT_ID(N'[dbo].[Purposes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Purposes];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FieldOfProfessions'
CREATE TABLE [dbo].[FieldOfProfessions] (
    [industry] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [city] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Profile_Location_Purpos'
CREATE TABLE [dbo].[Profile_Location_Purpos] (
    [city] nvarchar(50)  NOT NULL,
    [email] nvarchar(50)  NOT NULL,
    [ptype] nvarchar(50)  NOT NULL,
    [fromdate] datetime  NULL,
    [todate] datetime  NULL
);
GO

-- Creating table 'Profiles'
CREATE TABLE [dbo].[Profiles] (
    [email] nvarchar(50)  NOT NULL,
    [firstName] nvarchar(50)  NULL,
    [lastName] nvarchar(50)  NULL,
    [birthdate] datetime  NULL,
    [picture] varbinary(max)  NULL,
    [profession] nvarchar(50)  NULL,
    [password] nvarchar(max)  NOT NULL,
    [industry_fk] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Purposes'
CREATE TABLE [dbo].[Purposes] (
    [ptype] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [industry] in table 'FieldOfProfessions'
ALTER TABLE [dbo].[FieldOfProfessions]
ADD CONSTRAINT [PK_FieldOfProfessions]
    PRIMARY KEY CLUSTERED ([industry] ASC);
GO

-- Creating primary key on [city] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([city] ASC);
GO

-- Creating primary key on [city], [email], [ptype] in table 'Profile_Location_Purpos'
ALTER TABLE [dbo].[Profile_Location_Purpos]
ADD CONSTRAINT [PK_Profile_Location_Purpos]
    PRIMARY KEY CLUSTERED ([city], [email], [ptype] ASC);
GO

-- Creating primary key on [email] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [PK_Profiles]
    PRIMARY KEY CLUSTERED ([email] ASC);
GO

-- Creating primary key on [ptype] in table 'Purposes'
ALTER TABLE [dbo].[Purposes]
ADD CONSTRAINT [PK_Purposes]
    PRIMARY KEY CLUSTERED ([ptype] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [industry_fk] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [FK_FieldOfProfessionProfile]
    FOREIGN KEY ([industry_fk])
    REFERENCES [dbo].[FieldOfProfessions]
        ([industry])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FieldOfProfessionProfile'
CREATE INDEX [IX_FK_FieldOfProfessionProfile]
ON [dbo].[Profiles]
    ([industry_fk]);
GO

-- Creating foreign key on [city] in table 'Profile_Location_Purpos'
ALTER TABLE [dbo].[Profile_Location_Purpos]
ADD CONSTRAINT [FK_Profile_Location_Location]
    FOREIGN KEY ([city])
    REFERENCES [dbo].[Locations]
        ([city])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [email] in table 'Profile_Location_Purpos'
ALTER TABLE [dbo].[Profile_Location_Purpos]
ADD CONSTRAINT [FK_Profile_Location_Profile]
    FOREIGN KEY ([email])
    REFERENCES [dbo].[Profiles]
        ([email])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Profile_Location_Profile'
CREATE INDEX [IX_FK_Profile_Location_Profile]
ON [dbo].[Profile_Location_Purpos]
    ([email]);
GO

-- Creating foreign key on [ptype] in table 'Profile_Location_Purpos'
ALTER TABLE [dbo].[Profile_Location_Purpos]
ADD CONSTRAINT [FK_Profile_LocationPurpose]
    FOREIGN KEY ([ptype])
    REFERENCES [dbo].[Purposes]
        ([ptype])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Profile_LocationPurpose'
CREATE INDEX [IX_FK_Profile_LocationPurpose]
ON [dbo].[Profile_Location_Purpos]
    ([ptype]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------