SELECT Products.Title, Categories.Title
FROM Products
LEFT JOIN ProductCategory ON Products.Id=ProductCategory.ProductsId
LEFT JOIN Categories ON ProductCategory.CategoriesId=Categories.Id