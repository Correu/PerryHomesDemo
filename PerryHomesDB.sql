CREATE TABLE [users] (
  [id] integer PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [username] nvarchar(255),
  [email] nvarchar(255),
  [password] nvarchar(255),
  [created_at] timestamp DEFAULT 'now()'
)
GO

CREATE TABLE [userLinks] (
  [id] integer PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [userId] integer,
  [userType] integer
)
GO

CREATE TABLE [userTypes] (
  [id] integer PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [typeName] nvarchar(255)
)
GO

CREATE TABLE [realEstate] (
  [id] integer PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [address] nvarchar(255),
  [value] nvarchar(255),
  [type] integer
)
GO

CREATE TABLE [realEstateLinks] (
  [id] integer PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [realEstateId] integer,
  [imageId] integer
)
GO

CREATE TABLE [realEstateImage] (
  [id] integer PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [image] nvarchar(255)
)
GO

ALTER TABLE [users] ADD FOREIGN KEY ([id]) REFERENCES [userLinks] ([userId])
GO

ALTER TABLE [userTypes] ADD FOREIGN KEY ([id]) REFERENCES [userLinks] ([userType])
GO

ALTER TABLE [realEstateLinks] ADD FOREIGN KEY ([realEstateId]) REFERENCES [realEstate] ([id])
GO

ALTER TABLE [realEstateImage] ADD FOREIGN KEY ([id]) REFERENCES [realEstateLinks] ([imageId])
GO
