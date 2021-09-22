-- Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='Berlin'

-- case insentivite
sElEcT* from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by UnitPrice asc--Fiyata göre sırala
select * from Products order by UnitPrice desc--Fiyata göre sırala

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) Sayi from Products 

select count(*) Sayi from Products where CategoryID=1

select CategoryID,count(*) from Products group by CategoryID

select CategoryID,count(*) from Products group by CategoryID 
having count(*)<10

select * from Products inner join Categories
on Products.CategoryID=Categories.CategoryID

select Products.ProductID,Products.ProductName,Products.UnitPrice,
Categories.CategoryName from Products inner join Categories on
Products.CategoryID =Categories.CategoryID


select Products.ProductID,Products.ProductName,Products.UnitPrice,
Categories.CategoryName from Products inner join Categories on
Products.CategoryID =Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null