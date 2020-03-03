CREATE PROCEDURE sproc_tblCars_Insert
--create parameters for the storted procdeures 
@CarID Int,
@CarReg Varchar(50),
@CarName Varchar(50),
@CarModel Varchar(50),
@CarColour Varchar(50),
@CarEngineSize int,
@Price int,

AS
--insert the new record
Insert INTO tblCars (CarID, CarReg, CarName, CarModel, CarColour, EngineSize, Price)
values (@CarID, @CarReg, @CarName, @CarModel, @CarColour, @EngineSize, @Price)

--return the prim key value of the new record
return @@Identity 
