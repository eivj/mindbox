CREATE TABLE Products(Id INT PRIMARY KEY, ProductName VARCHAR(30));

INSERT INTO Products(Id, ProductName)
VALUES
(1, 'apple'),
(2,'cherry'),
(3, 'juice'),
(4, 'salmon'),
(5, 'beef');

CREATE TABLE Categories(Id INT PRIMARY KEY, CategoryName varchar(30));

INSERT INTO Categories(Id, CategoryName)
VALUES
(1, 'fruit'),
(2, 'meat_and_fish'),
(3, 'cheap_products'),
(4, 'expensive_products');


CREATE TABLE Products_Categories(Product_Id INT FOREIGN KEY REFERENCES Products(Id),
								Category_Id INT FOREIGN KEY REFERENCES Categories(Id),
								PRIMARY KEY(Product_Id, Category_Id));
INSERT INTO Products_Categories(Product_Id, Category_Id )
VALUES
(1, 1),
(1, 3),
(2, 1),
(2, 3),
(4, 2),
(4, 4),
(5, 2),
(5, 4);

SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN Products_Categories
ON Products.Id = Products_Categories.Product_Id
LEFT JOIN Categories
ON Products_Categories.Category_Id = Categories.Id
						

