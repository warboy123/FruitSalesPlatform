
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/21/2015 00:56:17
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
IF OBJECT_ID(N'[dbo].[FK_T_UserT_UserOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_ProductOrder] DROP CONSTRAINT [FK_T_UserT_UserOrders];
GO
IF OBJECT_ID(N'[dbo].[FK_T_UserOrdersT_ProductOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_ProductOrders] DROP CONSTRAINT [FK_T_UserOrdersT_ProductOrders];
GO
IF OBJECT_ID(N'[dbo].[FK_T_ProductsC_ProductFruitS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[C_ProductFruitS] DROP CONSTRAINT [FK_T_ProductsC_ProductFruitS];
GO
IF OBJECT_ID(N'[dbo].[FK_T_FruitsC_ProductFruits]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[C_ProductFruitS] DROP CONSTRAINT [FK_T_FruitsC_ProductFruits];
GO
IF OBJECT_ID(N'[dbo].[FK_T_FruitsT_Warehousing]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_Warehousing] DROP CONSTRAINT [FK_T_FruitsT_Warehousing];
GO
IF OBJECT_ID(N'[dbo].[FK_T_FruitsT_Inventory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_Inventory] DROP CONSTRAINT [FK_T_FruitsT_Inventory];
GO
IF OBJECT_ID(N'[dbo].[FK_T_SupplierT_SupplierFruit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_SupplierFruit] DROP CONSTRAINT [FK_T_SupplierT_SupplierFruit];
GO
IF OBJECT_ID(N'[dbo].[FK_T_FruitsT_Storage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_Storage] DROP CONSTRAINT [FK_T_FruitsT_Storage];
GO
IF OBJECT_ID(N'[dbo].[FK_T_FruitsT_SupplierFruit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_SupplierFruit] DROP CONSTRAINT [FK_T_FruitsT_SupplierFruit];
GO
IF OBJECT_ID(N'[dbo].[FK_T_PermissionT_ManagerPermission]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_ManagerPermission] DROP CONSTRAINT [FK_T_PermissionT_ManagerPermission];
GO
IF OBJECT_ID(N'[dbo].[FK_T_ManagerT_ManagerPermission]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[T_ManagerPermission] DROP CONSTRAINT [FK_T_ManagerT_ManagerPermission];
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
IF OBJECT_ID(N'[dbo].[T_ProductOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_ProductOrder];
GO
IF OBJECT_ID(N'[dbo].[T_ProductOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_ProductOrders];
GO
IF OBJECT_ID(N'[dbo].[T_Place]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Place];
GO
IF OBJECT_ID(N'[dbo].[T_PostAddress]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_PostAddress];
GO
IF OBJECT_ID(N'[dbo].[C_ProductFruitS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[C_ProductFruitS];
GO
IF OBJECT_ID(N'[dbo].[T_Inventory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Inventory];
GO
IF OBJECT_ID(N'[dbo].[T_Warehousing]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Warehousing];
GO
IF OBJECT_ID(N'[dbo].[T_Storage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Storage];
GO
IF OBJECT_ID(N'[dbo].[T_Supplier]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Supplier];
GO
IF OBJECT_ID(N'[dbo].[T_SupplierFruit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_SupplierFruit];
GO
IF OBJECT_ID(N'[dbo].[T_Manager]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Manager];
GO
IF OBJECT_ID(N'[dbo].[T_Permission]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Permission];
GO
IF OBJECT_ID(N'[dbo].[T_ManagerPermission]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_ManagerPermission];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'T_User'
CREATE TABLE [dbo].[T_User] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(100)  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [Sex] tinyint  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [LoginNum] nvarchar(50)  NOT NULL,
    [PassWord] nvarchar(100)  NOT NULL,
    [Phone] nvarchar(50)  NULL,
    [Enabled] bit  NOT NULL
);
GO

-- Creating table 'T_Products'
CREATE TABLE [dbo].[T_Products] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [OriginalPrice] decimal(18,0)  NOT NULL,
    [SalePrice] decimal(18,0)  NOT NULL,
    [SalesVolume] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [ProductName] nvarchar(max)  NOT NULL,
    [Detail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'T_Fruits'
CREATE TABLE [dbo].[T_Fruits] (
    [FruitID] int IDENTITY(1,1) NOT NULL,
    [FruitName] nvarchar(200)  NOT NULL,
    [HowToEat] nvarchar(200)  NULL,
    [Detail] nvarchar(4000)  NULL,
    [ProductSeason] tinyint  NOT NULL,
    [PlaceID] int  NOT NULL,
    [Enabled] bit  NOT NULL
);
GO

-- Creating table 'T_ProductOrder'
CREATE TABLE [dbo].[T_ProductOrder] (
    [UserOrdersID] int IDENTITY(1,1) NOT NULL,
    [DateCreate] datetime  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL,
    [SaleAmount] decimal(18,0)  NOT NULL,
    [OrderStatus] tinyint  NOT NULL,
    [LogisticsNum] nvarchar(max)  NOT NULL,
    [DatePay] datetime  NOT NULL,
    [DateConfirm] datetime  NOT NULL,
    [UserID] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [postage] decimal(18,0)  NOT NULL,
    [T_User_UserID] int  NOT NULL
);
GO

-- Creating table 'T_ProductOrders'
CREATE TABLE [dbo].[T_ProductOrders] (
    [ProductOrdersID] int IDENTITY(1,1) NOT NULL,
    [Count] int  NOT NULL,
    [UserOrdersID] int  NOT NULL,
    [ProductID] int  NOT NULL,
    [T_UserOrders_UserOrdersID] int  NOT NULL
);
GO

-- Creating table 'T_Place'
CREATE TABLE [dbo].[T_Place] (
    [PlaceID] int IDENTITY(1,1) NOT NULL,
    [PlaceName] nvarchar(200)  NOT NULL,
    [PlaceType] nvarchar(max)  NOT NULL,
    [PlaceFatherID] int  NOT NULL,
    [Enabled] bit  NOT NULL
);
GO

-- Creating table 'T_PostAddress'
CREATE TABLE [dbo].[T_PostAddress] (
    [PostAddressID] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(300)  NULL,
    [IsDefault] bit  NOT NULL,
    [Phone] nvarchar(50)  NOT NULL,
    [ContentName] nvarchar(50)  NOT NULL,
    [Tel] nvarchar(50)  NOT NULL,
    [Detail] nvarchar(500)  NULL,
    [UserID] int  NOT NULL,
    [PlaceID] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [T_User_UserID] int  NOT NULL
);
GO

-- Creating table 'C_ProductFruitS'
CREATE TABLE [dbo].[C_ProductFruitS] (
    [ProductFruitsID] int IDENTITY(1,1) NOT NULL,
    [ProductID] int  NOT NULL,
    [FruitID] int  NOT NULL,
    [T_Products_ProductID] int  NOT NULL,
    [T_Fruits_FruitID] int  NOT NULL
);
GO

-- Creating table 'T_Inventory'
CREATE TABLE [dbo].[T_Inventory] (
    [InventoryID] int IDENTITY(1,1) NOT NULL,
    [Count] int  NOT NULL,
    [FruitID] int  NOT NULL,
    [StorageID] int  NOT NULL,
    [T_Fruits_FruitID] int  NOT NULL
);
GO

-- Creating table 'T_Warehousing'
CREATE TABLE [dbo].[T_Warehousing] (
    [StockinID] int IDENTITY(1,1) NOT NULL,
    [FruitID] nvarchar(max)  NOT NULL,
    [count] decimal(18,0)  NOT NULL,
    [datecreate] datetime  NOT NULL,
    [StorageID] nvarchar(max)  NOT NULL,
    [PlaceID] int  NOT NULL,
    [DeliverAddress] nvarchar(max)  NOT NULL,
    [dateStockin] datetime  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [SupplierID] int  NULL,
    [T_Fruits_FruitID] int  NOT NULL
);
GO

-- Creating table 'T_Storage'
CREATE TABLE [dbo].[T_Storage] (
    [StorageID] int IDENTITY(1,1) NOT NULL,
    [PlaceID] int  NOT NULL,
    [Address] nvarchar(500)  NULL,
    [Enabled] bit  NOT NULL,
    [FruitID] int  NOT NULL,
    [T_Fruits_FruitID] int  NOT NULL
);
GO

-- Creating table 'T_Supplier'
CREATE TABLE [dbo].[T_Supplier] (
    [SupplierID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Address] nvarchar(500)  NULL,
    [Tel] nvarchar(50)  NULL,
    [Phone] nvarchar(50)  NOT NULL,
    [Contacts] nvarchar(50)  NOT NULL,
    [Detail] nvarchar(500)  NULL,
    [Enabled] bit  NOT NULL,
    [PlaceID] int  NOT NULL
);
GO

-- Creating table 'T_SupplierFruit'
CREATE TABLE [dbo].[T_SupplierFruit] (
    [SupplierFruitID] int IDENTITY(1,1) NOT NULL,
    [FruitID] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [T_Supplier_SupplierID] int  NOT NULL,
    [T_Fruits_FruitID] int  NOT NULL
);
GO

-- Creating table 'T_Manager'
CREATE TABLE [dbo].[T_Manager] (
    [ManagerID] int IDENTITY(1,1) NOT NULL,
    [LoginNum] nvarchar(200)  NOT NULL,
    [PassWord] nvarchar(200)  NOT NULL,
    [Enabled] bit  NOT NULL,
    [DateCreate] datetime  NOT NULL
);
GO

-- Creating table 'T_Permission'
CREATE TABLE [dbo].[T_Permission] (
    [PermissionID] int IDENTITY(1,1) NOT NULL,
    [PermissionName] nvarchar(200)  NOT NULL,
    [PermissionNum] nvarchar(200)  NOT NULL,
    [ParentNum] nvarchar(200)  NOT NULL,
    [PermissionType] tinyint  NOT NULL,
    [PermissionUrl] nvarchar(200)  NOT NULL,
    [PermissionAction] nvarchar(200)  NOT NULL,
    [PermissionStyle] nvarchar(200)  NOT NULL,
    [Enabled] bit  NOT NULL
);
GO

-- Creating table 'T_ManagerPermission'
CREATE TABLE [dbo].[T_ManagerPermission] (
    [ManagerPermissionID] int IDENTITY(1,1) NOT NULL,
    [ManagerID] int  NOT NULL,
    [PermissionID] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [Permission] tinyint  NOT NULL,
    [T_Permission_PermissionID] int  NOT NULL,
    [T_Manager_ManagerID] int  NOT NULL
);
GO

-- Creating table 'T_ProductPic'
CREATE TABLE [dbo].[T_ProductPic] (
    [ProductPicID] int IDENTITY(1,1) NOT NULL,
    [PicURL] nvarchar(500)  NOT NULL,
    [ThumbPicURL] nvarchar(500)  NOT NULL,
    [DateCreate] datetime  NOT NULL,
    [ProductID] int  NOT NULL,
    [T_Products_ProductID] int  NOT NULL
);
GO

-- Creating table 'T_FruitPic'
CREATE TABLE [dbo].[T_FruitPic] (
    [FruitPicID] int IDENTITY(1,1) NOT NULL,
    [PicURL] nvarchar(500)  NOT NULL,
    [ThumbPicURL] nvarchar(500)  NOT NULL,
    [DateCreate] datetime  NOT NULL,
    [FruitID] int  NOT NULL,
    [T_Fruits_FruitID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserID] in table 'T_User'
ALTER TABLE [dbo].[T_User]
ADD CONSTRAINT [PK_T_User]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
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

-- Creating primary key on [UserOrdersID] in table 'T_ProductOrder'
ALTER TABLE [dbo].[T_ProductOrder]
ADD CONSTRAINT [PK_T_ProductOrder]
    PRIMARY KEY CLUSTERED ([UserOrdersID] ASC);
GO

-- Creating primary key on [ProductOrdersID] in table 'T_ProductOrders'
ALTER TABLE [dbo].[T_ProductOrders]
ADD CONSTRAINT [PK_T_ProductOrders]
    PRIMARY KEY CLUSTERED ([ProductOrdersID] ASC);
GO

-- Creating primary key on [PlaceID] in table 'T_Place'
ALTER TABLE [dbo].[T_Place]
ADD CONSTRAINT [PK_T_Place]
    PRIMARY KEY CLUSTERED ([PlaceID] ASC);
GO

-- Creating primary key on [PostAddressID] in table 'T_PostAddress'
ALTER TABLE [dbo].[T_PostAddress]
ADD CONSTRAINT [PK_T_PostAddress]
    PRIMARY KEY CLUSTERED ([PostAddressID] ASC);
GO

-- Creating primary key on [ProductFruitsID] in table 'C_ProductFruitS'
ALTER TABLE [dbo].[C_ProductFruitS]
ADD CONSTRAINT [PK_C_ProductFruitS]
    PRIMARY KEY CLUSTERED ([ProductFruitsID] ASC);
GO

-- Creating primary key on [InventoryID] in table 'T_Inventory'
ALTER TABLE [dbo].[T_Inventory]
ADD CONSTRAINT [PK_T_Inventory]
    PRIMARY KEY CLUSTERED ([InventoryID] ASC);
GO

-- Creating primary key on [StockinID] in table 'T_Warehousing'
ALTER TABLE [dbo].[T_Warehousing]
ADD CONSTRAINT [PK_T_Warehousing]
    PRIMARY KEY CLUSTERED ([StockinID] ASC);
GO

-- Creating primary key on [StorageID] in table 'T_Storage'
ALTER TABLE [dbo].[T_Storage]
ADD CONSTRAINT [PK_T_Storage]
    PRIMARY KEY CLUSTERED ([StorageID] ASC);
GO

-- Creating primary key on [SupplierID] in table 'T_Supplier'
ALTER TABLE [dbo].[T_Supplier]
ADD CONSTRAINT [PK_T_Supplier]
    PRIMARY KEY CLUSTERED ([SupplierID] ASC);
GO

-- Creating primary key on [SupplierFruitID] in table 'T_SupplierFruit'
ALTER TABLE [dbo].[T_SupplierFruit]
ADD CONSTRAINT [PK_T_SupplierFruit]
    PRIMARY KEY CLUSTERED ([SupplierFruitID] ASC);
GO

-- Creating primary key on [ManagerID] in table 'T_Manager'
ALTER TABLE [dbo].[T_Manager]
ADD CONSTRAINT [PK_T_Manager]
    PRIMARY KEY CLUSTERED ([ManagerID] ASC);
GO

-- Creating primary key on [PermissionID] in table 'T_Permission'
ALTER TABLE [dbo].[T_Permission]
ADD CONSTRAINT [PK_T_Permission]
    PRIMARY KEY CLUSTERED ([PermissionID] ASC);
GO

-- Creating primary key on [ManagerPermissionID] in table 'T_ManagerPermission'
ALTER TABLE [dbo].[T_ManagerPermission]
ADD CONSTRAINT [PK_T_ManagerPermission]
    PRIMARY KEY CLUSTERED ([ManagerPermissionID] ASC);
GO

-- Creating primary key on [ProductPicID] in table 'T_ProductPic'
ALTER TABLE [dbo].[T_ProductPic]
ADD CONSTRAINT [PK_T_ProductPic]
    PRIMARY KEY CLUSTERED ([ProductPicID] ASC);
GO

-- Creating primary key on [FruitPicID] in table 'T_FruitPic'
ALTER TABLE [dbo].[T_FruitPic]
ADD CONSTRAINT [PK_T_FruitPic]
    PRIMARY KEY CLUSTERED ([FruitPicID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [T_User_UserID] in table 'T_PostAddress'
ALTER TABLE [dbo].[T_PostAddress]
ADD CONSTRAINT [FK_T_UserT_PostAddress]
    FOREIGN KEY ([T_User_UserID])
    REFERENCES [dbo].[T_User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_UserT_PostAddress'
CREATE INDEX [IX_FK_T_UserT_PostAddress]
ON [dbo].[T_PostAddress]
    ([T_User_UserID]);
GO

-- Creating foreign key on [T_User_UserID] in table 'T_ProductOrder'
ALTER TABLE [dbo].[T_ProductOrder]
ADD CONSTRAINT [FK_T_UserT_UserOrders]
    FOREIGN KEY ([T_User_UserID])
    REFERENCES [dbo].[T_User]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_UserT_UserOrders'
CREATE INDEX [IX_FK_T_UserT_UserOrders]
ON [dbo].[T_ProductOrder]
    ([T_User_UserID]);
GO

-- Creating foreign key on [T_UserOrders_UserOrdersID] in table 'T_ProductOrders'
ALTER TABLE [dbo].[T_ProductOrders]
ADD CONSTRAINT [FK_T_UserOrdersT_ProductOrders]
    FOREIGN KEY ([T_UserOrders_UserOrdersID])
    REFERENCES [dbo].[T_ProductOrder]
        ([UserOrdersID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_UserOrdersT_ProductOrders'
CREATE INDEX [IX_FK_T_UserOrdersT_ProductOrders]
ON [dbo].[T_ProductOrders]
    ([T_UserOrders_UserOrdersID]);
GO

-- Creating foreign key on [T_Products_ProductID] in table 'C_ProductFruitS'
ALTER TABLE [dbo].[C_ProductFruitS]
ADD CONSTRAINT [FK_T_ProductsC_ProductFruitS]
    FOREIGN KEY ([T_Products_ProductID])
    REFERENCES [dbo].[T_Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_ProductsC_ProductFruitS'
CREATE INDEX [IX_FK_T_ProductsC_ProductFruitS]
ON [dbo].[C_ProductFruitS]
    ([T_Products_ProductID]);
GO

-- Creating foreign key on [T_Fruits_FruitID] in table 'C_ProductFruitS'
ALTER TABLE [dbo].[C_ProductFruitS]
ADD CONSTRAINT [FK_T_FruitsC_ProductFruits]
    FOREIGN KEY ([T_Fruits_FruitID])
    REFERENCES [dbo].[T_Fruits]
        ([FruitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_FruitsC_ProductFruits'
CREATE INDEX [IX_FK_T_FruitsC_ProductFruits]
ON [dbo].[C_ProductFruitS]
    ([T_Fruits_FruitID]);
GO

-- Creating foreign key on [T_Fruits_FruitID] in table 'T_Warehousing'
ALTER TABLE [dbo].[T_Warehousing]
ADD CONSTRAINT [FK_T_FruitsT_Warehousing]
    FOREIGN KEY ([T_Fruits_FruitID])
    REFERENCES [dbo].[T_Fruits]
        ([FruitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_FruitsT_Warehousing'
CREATE INDEX [IX_FK_T_FruitsT_Warehousing]
ON [dbo].[T_Warehousing]
    ([T_Fruits_FruitID]);
GO

-- Creating foreign key on [T_Fruits_FruitID] in table 'T_Inventory'
ALTER TABLE [dbo].[T_Inventory]
ADD CONSTRAINT [FK_T_FruitsT_Inventory]
    FOREIGN KEY ([T_Fruits_FruitID])
    REFERENCES [dbo].[T_Fruits]
        ([FruitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_FruitsT_Inventory'
CREATE INDEX [IX_FK_T_FruitsT_Inventory]
ON [dbo].[T_Inventory]
    ([T_Fruits_FruitID]);
GO

-- Creating foreign key on [T_Supplier_SupplierID] in table 'T_SupplierFruit'
ALTER TABLE [dbo].[T_SupplierFruit]
ADD CONSTRAINT [FK_T_SupplierT_SupplierFruit]
    FOREIGN KEY ([T_Supplier_SupplierID])
    REFERENCES [dbo].[T_Supplier]
        ([SupplierID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_SupplierT_SupplierFruit'
CREATE INDEX [IX_FK_T_SupplierT_SupplierFruit]
ON [dbo].[T_SupplierFruit]
    ([T_Supplier_SupplierID]);
GO

-- Creating foreign key on [T_Fruits_FruitID] in table 'T_Storage'
ALTER TABLE [dbo].[T_Storage]
ADD CONSTRAINT [FK_T_FruitsT_Storage]
    FOREIGN KEY ([T_Fruits_FruitID])
    REFERENCES [dbo].[T_Fruits]
        ([FruitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_FruitsT_Storage'
CREATE INDEX [IX_FK_T_FruitsT_Storage]
ON [dbo].[T_Storage]
    ([T_Fruits_FruitID]);
GO

-- Creating foreign key on [T_Fruits_FruitID] in table 'T_SupplierFruit'
ALTER TABLE [dbo].[T_SupplierFruit]
ADD CONSTRAINT [FK_T_FruitsT_SupplierFruit]
    FOREIGN KEY ([T_Fruits_FruitID])
    REFERENCES [dbo].[T_Fruits]
        ([FruitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_FruitsT_SupplierFruit'
CREATE INDEX [IX_FK_T_FruitsT_SupplierFruit]
ON [dbo].[T_SupplierFruit]
    ([T_Fruits_FruitID]);
GO

-- Creating foreign key on [T_Permission_PermissionID] in table 'T_ManagerPermission'
ALTER TABLE [dbo].[T_ManagerPermission]
ADD CONSTRAINT [FK_T_PermissionT_ManagerPermission]
    FOREIGN KEY ([T_Permission_PermissionID])
    REFERENCES [dbo].[T_Permission]
        ([PermissionID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_PermissionT_ManagerPermission'
CREATE INDEX [IX_FK_T_PermissionT_ManagerPermission]
ON [dbo].[T_ManagerPermission]
    ([T_Permission_PermissionID]);
GO

-- Creating foreign key on [T_Manager_ManagerID] in table 'T_ManagerPermission'
ALTER TABLE [dbo].[T_ManagerPermission]
ADD CONSTRAINT [FK_T_ManagerT_ManagerPermission]
    FOREIGN KEY ([T_Manager_ManagerID])
    REFERENCES [dbo].[T_Manager]
        ([ManagerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_ManagerT_ManagerPermission'
CREATE INDEX [IX_FK_T_ManagerT_ManagerPermission]
ON [dbo].[T_ManagerPermission]
    ([T_Manager_ManagerID]);
GO

-- Creating foreign key on [T_Products_ProductID] in table 'T_ProductPic'
ALTER TABLE [dbo].[T_ProductPic]
ADD CONSTRAINT [FK_T_ProductsT_ProductPic]
    FOREIGN KEY ([T_Products_ProductID])
    REFERENCES [dbo].[T_Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_ProductsT_ProductPic'
CREATE INDEX [IX_FK_T_ProductsT_ProductPic]
ON [dbo].[T_ProductPic]
    ([T_Products_ProductID]);
GO

-- Creating foreign key on [T_Fruits_FruitID] in table 'T_FruitPic'
ALTER TABLE [dbo].[T_FruitPic]
ADD CONSTRAINT [FK_T_FruitsT_FruitPic]
    FOREIGN KEY ([T_Fruits_FruitID])
    REFERENCES [dbo].[T_Fruits]
        ([FruitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_T_FruitsT_FruitPic'
CREATE INDEX [IX_FK_T_FruitsT_FruitPic]
ON [dbo].[T_FruitPic]
    ([T_Fruits_FruitID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------