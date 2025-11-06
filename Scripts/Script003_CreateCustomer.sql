use DbUpSample
go
    
    

CREATE TABLE dbo.Customers(
    Id              int primary key identity(1,1),
    CustomerName    nvarchar(100),
    CustomerEmail   nvarchar(256),
    Address         int
)
