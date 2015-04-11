
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/11/2015 23:07:14
-- Generated from EDMX file: E:\work\project\Fruit\Fruilt\DataMould\SqlServer.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FruitSales];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_T_UserT_PostAddress]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_PostAddress] DROP CONSTRAINT [FK_T_UserT_PostAddress];
GO
IF OBJECT_ID(N'[dbo].[FK_T_ProductsT_Fruits]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_Fruits] DROP CONSTRAINT [FK_T_ProductsT_Fruits];
GO
IF OBJECT_ID(N'[dbo].[FK_T_UserT_UserOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_ProductOrder] DROP CONSTRAINT [FK_T_UserT_UserOrders];
GO
IF OBJECT_ID(N'[dbo].[FK_T_UserOrdersT_ProductOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_ProductOrders] DROP CONSTRAINT [FK_T_UserOrdersT_ProductOrders];
GO
IF OBJECT_ID(N'[dbo].[FK_T_ProductsT_ProductOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_ProductOrders] DROP CONSTRAINT [FK_T_ProductsT_ProductOrders];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[T_User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_User];
GO
IF OBJECT_ID(N'[dbo].[T_Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Products];
GO
IF OBJECT_ID(N'[dbo].[T_Fruits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Fruits];
GO
IF OBJECT_ID(N'[dbo].[T_PostAddress]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_PostAddress];
GO
IF OBJECT_ID(N'[dbo].[T_ProductOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_ProductOrder];
GO
IF OBJECT_ID(N'[dbo].[T_ProductOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_ProductOrders];
GO
IF OBJECT_ID(N'[dbo].[T_Place]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Place];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'T_User'
CREATE TABLE [dbo].[T_User] (
    [T_UserID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(100)  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [Sexy] tinyint  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [LoginNum] nvarchar(50)  NOT NULL,
    [PassWord] nvarchar(100)  NOT NULL,
    [Phone] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'T_Products'
CREATE TABLE [dbo].[T_Products] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [OriginalPrice] nvarchar(max)  NOT NULL,
    [SalePrice] nvarchar(max)  NOT NULL,
    [SalesVolume] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'T_Fruits'
CREATE TABLE [dbo].[T_Fruits] (
    [FruitID] int IDENTITY(1,1) NOT NULL,
    [FruitName] nvarchar(200)  NOT NULL,
    [HowToEat] nvarchar(200)  NOT NULL,
    [Detail] nvarchar(max)  NOT NULL,
    [ProductSeason] tinyint  NOT NULL,
    [T_Products_ProductID] int  NOT NULL
);
GO

-- Creating table 'T_PostAddress'
CREATE TABLE [dbo].[T_PostAddress] (
    [PostAddressID] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(300)  NOT NULL,
    [IsDefault] bit  NOT NULL,
    [Phone] nvarchar(50)  NOT NULL,
    [ContentName] nvarchar(50)  NOT NULL,
    [Tel] nvarchar(50)  NOT NULL,
    [Detail] nvarchar(500)  NOT NULL,
    [T_User_T_UserID] int  NOT NULL
);
GO

-- Creating table 'T_ProductOrder'
CREATE TABLE [dbo].[T_ProductOrder] (
    [T_UserOrdersID] int IDENTITY(1,1) NOT NULL,
    [DateCreate] nvarchar(max)  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [SaleAmount] nvarchar(max)  NOT NULL,
    [OrderStatus] nvarchar(max)  NOT NULL,
    [LogisticsNum] nvarchar(max)  NOT NULL,
    [DatePay] nvarchar(max)  NOT NULL,
    [DateConfirm] nvarchar(max)  NOT NULL,
    [T_User_T_UserID] int  NOT NULL
);
GO

-- Creating table 'T_ProductOrders'
CREATE TABLE [dbo].[T_ProductOrders] (
    [T_ProductOrdersID] int IDENTITY(1,1) NOT NULL,
    [count] int  NOT NULL,
    [T_UserOrders_T_UserOrdersID] int  NOT NULL,
    [T_Products_ProductID] int  NOT NULL
);
GO

-- Creating table 'T_Place'
CREATE TABLE [dbo].[T_Place] (
    [T_PlaceID] int IDENTITY(1,1) NOT NULL,
    [PlaceName] nvarchar(200)  NOT NULL,
    [PlaceType] int  NOT NULL,
    [PlaceFatherID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [T_UserID] in table 'T_User'
ALTER TABLE [dbo].[T_User]
ADD CONSTRAINT [PK_T_User]
    PRIMARY KEY CLUSTERED ([T_UserID] ASC);
GO

-- Creating primary key on [ProductID] in table 'T_Products'
ALTER TABLE [dbo].[T_Products]
ADD CONSTRAINT [PK_T_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [FruitID] in table 'T_Fruits'
ALTER TABLE [dbo].[T_Fruits]
ADD CONSTRAINT [PK_T_Fruits]
    PRIMARY KEY CLUSTERED ([FruitID] ASC);
GO

-- Creating primary key on [PostAddressID] in table 'T_PostAddress'
ALTER TABLE [dbo].[T_PostAddress]
ADD CONSTRAINT [PK_T_PostAddress]
    PRIMARY KEY CLUSTERED ([PostAddressID] ASC);
GO

-- Creating primary key on [T_UserOrdersID] in table 'T_ProductOrder'
ALTER TABLE [dbo].[T_ProductOrder]
ADD CONSTRAINT [PK_T_ProductOrder]
    PRIMARY KEY CLUSTERED ([T_UserOrdersID] ASC);
GO

-- Creating primary key on [T_ProductOrdersID] in table 'T_ProductOrders'
ALTER TABLE [dbo].[T_ProductOrders]
ADD CONSTRAINT [PK_T_ProductOrders]
    PRIMARY KEY CLUSTERED ([T_ProductOrdersID] ASC);
GO

-- Creating primary key on [T_PlaceID] in table 'T_Place'
ALTER TABLE [dbo].[T_Place]
ADD CONSTRAINT [PK_T_Place]
    PRIMARY KEY CLUSTERED ([T_PlaceID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [T_User_T_UserID] in table 'T_PostAddress'
ALTER TABLE [dbo].[T_PostAddress]
ADD CONSTRAINT [FK_T_UserT_PostAddress]
    FOREIGN KEY ([T_User_T_UserID])
    REFERENCES [dbo].[T_User]
        ([T_UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_UserT_PostAddress'
CREATE INDEX [IX_FK_T_UserT_PostAddress]
ON [dbo].[T_PostAddress]
    ([T_User_T_UserID]);
GO

-- Creating foreign key on [T_Products_ProductID] in table 'T_Fruits'
ALTER TABLE [dbo].[T_Fruits]
ADD CONSTRAINT [FK_T_ProductsT_Fruits]
    FOREIGN KEY ([T_Products_ProductID])
    REFERENCES [dbo].[T_Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_ProductsT_Fruits'
CREATE INDEX [IX_FK_T_ProductsT_Fruits]
ON [dbo].[T_Fruits]
    ([T_Products_ProductID]);
GO

-- Creating foreign key on [T_User_T_UserID] in table 'T_ProductOrder'
ALTER TABLE [dbo].[T_ProductOrder]
ADD CONSTRAINT [FK_T_UserT_UserOrders]
    FOREIGN KEY ([T_User_T_UserID])
    REFERENCES [dbo].[T_User]
        ([T_UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_UserT_UserOrders'
CREATE INDEX [IX_FK_T_UserT_UserOrders]
ON [dbo].[T_ProductOrder]
    ([T_User_T_UserID]);
GO

-- Creating foreign key on [T_UserOrders_T_UserOrdersID] in table 'T_ProductOrders'
ALTER TABLE [dbo].[T_ProductOrders]
ADD CONSTRAINT [FK_T_UserOrdersT_ProductOrders]
    FOREIGN KEY ([T_UserOrders_T_UserOrdersID])
    REFERENCES [dbo].[T_ProductOrder]
        ([T_UserOrdersID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_UserOrdersT_ProductOrders'
CREATE INDEX [IX_FK_T_UserOrdersT_ProductOrders]
ON [dbo].[T_ProductOrders]
    ([T_UserOrders_T_UserOrdersID]);
GO

-- Creating foreign key on [T_Products_ProductID] in table 'T_ProductOrders'
ALTER TABLE [dbo].[T_ProductOrders]
ADD CONSTRAINT [FK_T_ProductsT_ProductOrders]
    FOREIGN KEY ([T_Products_ProductID])
    REFERENCES [dbo].[T_Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_ProductsT_ProductOrders'
CREATE INDEX [IX_FK_T_ProductsT_ProductOrders]
ON [dbo].[T_ProductOrders]
    ([T_Products_ProductID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------