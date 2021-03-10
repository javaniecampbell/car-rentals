
SELECT A.Id, B.Name, B.Quantity, A.UserId AS BoughtBy from Carts A
RIGHT JOIN CartItem B
ON B.CartId = A.Id
WHERE B.CartId = 2



