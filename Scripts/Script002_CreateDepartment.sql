use DbUpSample
go
    

CREATE TABLE dbo.Department(
    Id               int primary key identity(1,1),
    DepartmentName   varchar(100),
    IsActive         bit
)