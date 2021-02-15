# Yazılım Geliştirici Yetiştirme Kampı
---
## ReCap Project / Araba Kiralama
![N|Solid](https://image.freepik.com/free-vector/car-rental-service-rent-vehicle-automobile-cartoon-illustration_212005-189.jpg)
# Getting Started
---

+ ##### Katmanlı Mimari ile oluşturulmuş, içerisinde Entities, DataAccess, Business, ConsoleUI, Core katmanlarını bulunduran gelişim sürecinde bir araba kiralama projesidir.

# 15.02 Changes
---
+ WebAPI Katmanı eklendi
+ Tüm nesneler için API yazıldı

# Layers
---
## Entities
+ Entities Katmanında proje boyunca kullanacağımız nesneler bulunmaktadır.
#### Abstract
#### Concrete
+ [Car.cs](https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Car.cs)
+ [Color.cs]([Car.cs] (https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Color.cs))
+ [Brand.cs]([Car.cs] (https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Brand.cs))
+ [Customer.cs](https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Customer.cs)
+ [User.cs]([Car.cs] (https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/User.cs))
+ [Rental.cs]([Car.cs] (https://github.com/salihkamas/ReCapProject/blob/master/Entities/Concrete/Rental.cs))
#### DTOs
+ [CarDetailDto.cs](https://github.com/salihkamas/ReCapProject/blob/master/Entities/DTOs/CarDetailDto.cs) 
---
## DataAccess
+ DataAccess katmanında veriyi ekleme, silme , güncelleme gibi veritabanı işlemleri bulunmaktadır.
#### Abstract
+ [IBrandDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/IBrandDal.cs)
+ [ICarDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs)
+ [IColorDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/IColorDal.cs)
+ [ICustomerDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/ICustomerDal.cs)
+ [IUserDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/IUserDal.cs)
+ [IRentalDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Abstract/IRentalDal.cs)
#### Concrete
+ EntityFramework
    + [CarRentalContext.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/CarRentalContext.cs)
    + [EfCarDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
    + [EfBrandDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)
    + [EfColorDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)
    + [EfCustomerDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)
    + [EfRentalDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)
    + [EfUserDal.cs](https://github.com/salihkamas/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)
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
+ [ICustomerService](https://github.com/salihkamas/ReCapProject/blob/master/Business/Abstract/ICustomerService.cs)
+ [IRentalService](https://github.com/salihkamas/ReCapProject/blob/master/Business/Abstract/IRentalService.cs)
+ [IUserService](https://github.com/salihkamas/ReCapProject/blob/master/Business/Abstract/IUserService.cs)
#### Concrete
+ [BrandManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/BrandManager.cs)
+ [CarManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/CarManager.cs)
+ [ColorManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/ColorManager.cs)
+ [CustomerManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/CustomerManager.cs)
+ [RentalManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/RentalManager.cs)
+ [UserManager.cs](https://github.com/salihkamas/ReCapProject/blob/master/Business/Concrete/UserManager.cs)
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
#### Utilities
+ Results
    + Abstract
        + [IDataResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Abstract/IDataResult.cs)
        + [IResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Abstract/IResult.cs)
    + Concrete
        + [DataResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Concrete/DataResult.cs)
        + [ErrorDataResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Concrete/ErrorDataResult.cs)
        + [ErrorResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Concrete/ErrorResult.cs)
        + [ErrorDataResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Concrete/ErrorDataResult.cs)
        + [Result.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Concrete/Result.cs)
        + [SuccessDataResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Concrete/SuccessDataResult.cs)
        + [SuccessResult.cs](https://github.com/salihkamas/ReCapProject/blob/master/Core/Utilities/Results/Concrete/SuccessResult.cs)
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
### Users
| Variable | Data Type |
| ------- | ---------- |
| UserId | int |
| FirstName | string |
| LastName | string |
| Email | string |
| Password | string |
### Customers
| Variable | Data Type |
| ------- | ---------- |
| CustomerId | int |
| UserId | int |
| CompanyName | string |
### Rentals
| Variable | Data Type |
| ------- | ---------- |
| RentalId | int |
| CarId | int |
| CustomerId | int |
| RentDate | DateTime |
| ReturnDate | DateTime |
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
