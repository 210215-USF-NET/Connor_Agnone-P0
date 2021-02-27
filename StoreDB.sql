--table drops
drop table inventory;
drop table orderItems;
drop table orders;
drop table customers;
drop table locations;
drop table products;

--table creation
CREATE TABLE customers
(
    id int IDENTITY PRIMARY KEY,
    CustomerName varchar(100) not null,
    CustomerEmail varchar(100) not null
);

create table locations
(
    id int IDENTITY PRIMARY key,
    LocationName varchar(100) not null,
    LocationAddress varchar(100) not null
);

create table products
(
    id int IDENTITY PRIMARY key,
    ProductName varchar(20) not null,
    ProductPrice DECIMAL(5,2)
);

CREATE TABLE orders
(
    id int IDENTITY PRIMARY key,
    orderDate DATE,
    orderCustomer int REFERENCES customers(id),
    orderLocation int REFERENCES locations(id)
);

create table inventory
(
    id int IDENTITY PRIMARY key,
    quantity int not null,
    inventoryProduct int REFERENCES products(id),
    inventoryLocation int REFERENCES locations(id)
);

create table orderItems
(
    id int IDENTITY PRIMARY key,
    orderQuantity int not null,
    ordersID int REFERENCES orders(id),
    orderProduct int REFERENCES products(id)
);

--adding seed data
insert into customers (CustomerName, CustomerEmail) values
('Mary J', 'marryj@fake.email'),('Tom F','tom@real.email');

insert into products (ProductName, ProductPrice) values
('Bainberry', 15),('Bat Drool',5.50),('Bat Wool',7),('Blueleaf',3),('Cobweb',1.5),('Crystal',5),('Dragonwort',12),('Feather of Crow',8),('Foxglove',6),('Eye of Newt ',12),('Frog Tongue ',15),('Mandrake',12);

INSERT into locations (LocationName, LocationAddress) VALUES
('Cauldrons, Caustics, and candles','555 Broomstick Dr'),('Cauldron of Curiosities','42 Universe Ave'),('Which Craft for the Soul','76 Bakers Rd');

insert into inventory (inventoryLocation, inventoryProduct, quantity) VALUES
(1,1,6),(1,2,25),(1,3,10),(1,4,50),(1,5,20),(1,6,10),(1,7,5),(1,8,30),(1,9,22),(1,10,10),(1,11,2),(1,12,3),(2,1,12),(2,2,13),(2,3,8),(2,4,30),(2,5,13),(2,6,4),(2,7,10),(2,8,3),(2,9,4),(2,10,2),(2,11,1),(2,12,14),(3,1,5),(3,2,25),(3,3,20),(3,4,10),(3,5,6),(3,6,2),(3,7,15),(3,8,5),(3,9,20),(3,10,13),(3,11,8),(3,12,7);

select * from products;
select * from inventory where inventoryProduct = 11;