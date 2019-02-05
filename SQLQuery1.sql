USE TheEverythingStore
SELECT * FROM Products;
INSERT INTO Categories (Name) VALUES ('Books');

SELECT * FROM Categories;

INSERT INTO Products (Name, Description, Price, CategoryId)
VALUES ('Man''s Search for Meaning', 'Fantastic Book', 8.99, 1);

INSERT INTO Products (Name, Description, Price, CategoryId)
VALUES ('Man in a high castle', 'Not quite as good of a Book', 7.99, 1);

SELECT * FROM Products;