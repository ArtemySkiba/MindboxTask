SELECT P.Name, C.Name FROM Products P
LEFT OUTER JOIN ProductCategories PC ON PC.ProductID = P.ProductID
LEFT OUTER JOIN Categories C ON C.CategoryID = PC.CategoryID
ORDER BY P.Name
