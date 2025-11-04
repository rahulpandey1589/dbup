use DbUpSample
go

CREATE TABLE dbo.Employee(
Id               INT IDENTITY(1,1),
FirstName	     VARCHAR(100),
LastName         VARCHAR(100),
Age              INT, 
Gender           VARCHAR(10)
)

