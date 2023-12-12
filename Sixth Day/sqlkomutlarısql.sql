--Select: çalışmak istediğimiz kodu seçmek için kullanılırız
--Select * from Customers
Select  ContactName,CustomerName,City from Customers
--kendi kolon başı  adlandırmanı yapmak için ise :
Select ContactName Adı, CustomerName  Sirketi,City Sehir from Customers 

--where şart için kullanılır
--şehri londra olanı seç 
Select* from Customers where City = "London"

--case insensitive büyük küçük harf duyarlılığı yok


--kategori numarası 1 veya 3 olanları seç (2 durumdan biri gerekli)
select * from Customers where categoryId=1 or categoryId= 3

--katgori numarası 1 ve fiyatı 10 olanları seç(2 durum birlikte gerek)
select*from Customers where categoryId=1 and UnıtPrice >= 10

--isme göre isimleri sırala
Select*from Products order by ProductName 
--fiyata göre sırala (asc artan desc azalan sıralama(des düş-en/azalan))
select*from Products order by UnityPrice desc

--kateogori numarası 1 olanları fiyatı azalan şeklinde sırala
select*from Products where CateogoryId=1 order by UnityPrice desc

--tüm satırların sayısını gösteriri
select count(*) from Products

select count(*) from Products where CategoryId=2

--hangi kategoride kaç ürünümüz var sorusu :
--1 -her bir grup için tablo yap
select categoryId from Products group by CategoryId
--2- her bir grup için eleman sayısını söyle
select categoryId,count(*) from Products group by CategoryId

--ürün sayısı x ten az olan kategorileri işaretle
select categoryId,count(*) from Products group by CategoryId having count(*)<=10

--fiyatı 20 den büyük ve adedi 10 küçük olan ürünlerin tablosunu oluştur
select categoryId, count(*) from products where UnitPrice>20 group by CategoryId having count(*)<10



--inner join ile 2 farklı listeyi bir araya getirdik
-- on ile şart koyduk (durum sağlanırsa)



select*from Products inner join Categories on Products.CategoryID = Categories.CategoryID


--hangi tablodan hangi kolonu seçtiğimizi *from  yerine istediğimiz kolonları yazarak seçebiliriz
select Producst.ProductsID,Products.ProductName,Products.UnitPrice,Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>=10


--C# da bu yapılanlar DTA data transformation Object olarak karşımıza çıkıyor


--inner join sadece eşleşen kayıtları getirir
-- left join yazıma göre solda olup sağda olmayanları da getir demek yani p de var od de yok olanları da
--right join left in tam tersi sağda var solda yok
-- inner joine yeni bir inner join daha eklenebilir(bitincisi bittikten sonra ikinciyle devam ederek)
Select * from Products P inner join [order Details] od
on  p.ProductID = od.Discount


--sisteme kayıt olmuş ama sipariş vermemiş müşteriler:
-- null demek o data yok demek yani tabloda o kısım boş
Select * from Customers c left join  ORDers o
on C.CustomerID= o.CustomerID
where o.CustomerID is null 

