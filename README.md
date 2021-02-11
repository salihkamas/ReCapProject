# Yazılım Geliştirici Yetiştirme Kampı
---
## ReCap Project / Araba Kiralama
![N|Solid](https://image.freepik.com/free-vector/car-rental-service-rent-vehicle-automobile-cartoon-illustration_212005-189.jpg)
# Getting Started
---

+ ##### Katmanlı Mimari ile oluşturulmuş, içerisinde Entities, DataAccess, Business, ConsoleUI, Core katmanlarını bulunduran gelişim sürecinde bir araba kiralama projesidir.

# Layers
---
## Entities
+ Entities Katmanında proje boyunca kullanacağımız nesneler bulunmaktadır.Şimdilik Car,Color ve Brand nesneleri bulunuyor.
#### Abstract
#### Concrete
+ [Car.cs](https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Car.cs)
+ [Color.cs]([Car.cs] (https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Color.cs))
+ [Brand.cs]([Car.cs] (https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Brand.cs))
#### DTOs
+ [CarDetailDto.cs](https://github.com/salihkamas/ReCapProject/blob/master/Entities/DTOs/CarDetailDto.cs) 
---
## DataAccess
+ DataAccess katmanında veriyi ekleme, silme , güncelleme gibi veritabanı işlemleri bulunmaktadır.
#### Abstract
+ [IBrandDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/IBrandDal.cs)
+ [ICarDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs)
+ [IColorDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/IColorDal.cs)
#### Concrete
+ EntityFramework
    + [CarRentalContext.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/CarRentalContext.cs)
    + [EfCarDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
+ InMemory
    + [InMemoryBrandDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryBrandDal.cs)
    + [InMemoryCarDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryCarDal.cs)
    + [InMemoryColorDal](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryColorDal.cs)
---
## Business
+ Business katmanı DataAccess tarafından çekilen verileri işleyecek olan katmandır. Kullanıcıdan gelen veriler öncelikle Business katmanına gelir burada işlenerek DataAccess katmanına aktarılır.
#### Abstract
+ [IBrandService.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Abstract/IBrandService.cs)
+ [ICarService](https://github.com/salihkamas/ReCapProject/blob/master/Business/Abstract/ICarService.cs)
+ [IColorService](https://github.com/salihkamas/ReCapProject/blob/master/Business/Abstract/IColorService.cs)
#### Concrete
+ [BrandManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/BrandManager.cs)
+ [CarManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/CarManager.cs)
+ [ColorManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/ColorManager.cs)
---
## Core
+ Core katmanında projedeki ortak kodlar bulunmaktadır. DataAcces katmanıyla ilgili nesneler DataAccess klasöründe, Entities ile ilgili olanlar is Entities klasöründe bulunmaktadır.
#### DataAccess
+ EntityFramework
    + [EfEntityRepositoryBase.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)
+ [IEntityRepository.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/DataAccess/IEntityRepository.cs)
#### Entities
+ [IDto.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Entities/IDto.cs)
+ [IEntity.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Entities/IEntity.cs)
---
# Tables
----
### Cars
| Variable | Data Type |
| ------- | ---------- |
| CarId | int |
| CarName | string |
| BrandId | int |
| ColorId | int |
| ModelYear | string |
| DailyPrice | decimal |
| Description | string |
### Brands
| Variable | Data Type |
| ------- | ---------- |
| BrandId | int |
| BrandName | string |
### Colors
| Variable | Data Type |
| ------- | ---------- |
| ColorId | int |
| ColorName | string |
---
# Installations
---
+ EntityFrameworkCore.SqlServer 3.1.11
---
# ScreenShots
---
![GetCarDetails](https://i.hizliresim.com/qWonB7.png)
![GetByBrandId](https://i.hizliresim.com/4PYsRz.png)
![GetByColorId](https://i.hizliresim.com/D5iy9P.png)
---
# Author
+ Salih Kamaş | [salihkamas](https://github.com/salihkamas)
