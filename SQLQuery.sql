SELECT p.ProductName, c.CategoryName
        FROM Products AS p
        LEFT JOIN ProductCategories AS pc ON p.ProductId = pc.ProductId
        LEFT JOIN Categories AS c ON pc.CategoryId = c.CategoryId
        ORDER BY p.ProductName, c.CategoryName;
