NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.6
NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.10

Scaffold-DbContext "Server=MSI\ANHKHOA;Database=hoadon;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Add-Migration hoadon
Update-Database