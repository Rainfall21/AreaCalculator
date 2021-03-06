CREATE TABLE [Categories](
[ID] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
[Name] [varchar](50) NOT NULL);
CREATE TABLE [Products](
[ID] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
[Name] [varchar](50) NOT NULL,
[CategoryID] [int] NOT NULL);
INSERT INTO [Categories] ("Name") VALUES
('Beverages'),
('Meat and fish'),
('Vegetables and fruits');
INSERT INTO [Products] ("Name","CategoryID") VALUES
('Redbull',1),
('Tomatoes',3),
('Chicken',2),
('Potato Chips',0),
('Carrot',3);

select Products."Name", Categories."Name" From Products LEFT JOIN Categories ON products."categoryId" = categories."id"