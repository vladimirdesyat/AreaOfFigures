SELECT Products.name, Categories.name FROM Products
LEFT JOIN ProductsToCategories
ON Products.ID = ProductsToCategories.ProductID
LEFT JOIN Categories
ON ProductsToCategories.CategoryID = Categories.ID
