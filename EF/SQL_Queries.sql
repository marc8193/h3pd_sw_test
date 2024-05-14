select * from Items;
select * from Customers;

select * from Stocks;
select * from Locations;
select * from Orders;
select * from OrderLines;


select * from Inventories I
join Items on Items.id=I.ItemId
join Locations Loc on Loc.id=I.LocationId