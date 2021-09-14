use AstoreApplicationDB;
GO

select * from Customer.Customer;



insert into Customer.Customer
VALUES
('Summer','Holiday'),
('Winter','Break'),
('Spring','Lee');

insert into Store.Store
values
('Paneacea Store','Uptobia '),
('The Store','Arcadia Ave'),
('Super Store','Faraway Land');

insert into Store.Product
(ProductName, ProductDescription, ProductPrice)
values 
('Happy Pills','This makes you happy!',300.00),
('Honest','This will not make you honest',30.00),
('Super Star', 'This is a super star',30.00),
('Good Day Drink','Makes your day good',90.00),
('Isolation','Just Isolation',70.00),
('Temptaion','This is a temptation',800.00),
('Not an Isolation','Just Not an Isolation',70.00),
('Good Product','Good for you ',4.00),
('Normal People','Does not make you normal',20);
select * from Store.Product left join  Store.Inventory on Store.Product.ProductId = Store.Inventory.ProductId
inner join Store.Store on Store.Store.StoreId = Store.Inventory.StoreId;

select*from Store.Inventory;
insert into Store.[Order]
(CustomerId,StoreId,OrderDate)
values
(1,2,GETDATE()),
(1,3,GETDATE()),
(2,1,GETDATE());

SELECT * FROM Store.[Order];
delete from Store.Inventory where Store.Inventory.InventoryId =1;


INSERT INTO STORE.OrderProduct
(OrderID, ProductId,Quantity)
values 
(3,4,10),
(5,1,1),
(5,3,2);

insert into store.inventory
(StoreID,ProductId, Quantity)
values
(1,1,100),
(1,2,100),
(1,1,100),
(1,3,100),
(1,4,100),
(2,1,100),
(2,3,100),
(2,4,100),
(3,1,100),
(3,3,100),
(3,4,100),
(1,5,100),
(2,6,100),
(3,7,100),
(2,8,100),
(2,9,100),
(3,5,100),
(3,6,100);

select * from store.Product;