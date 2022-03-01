color B

del  .PublishFiles\*.*   /s /q

dotnet restore

dotnet build

cd Wyj.Core.Api

dotnet publish -o ..\Wyj.Core.Api\bin\Debug\net6.0\

md ..\.PublishFiles

xcopy ..\Wyj.Core.Api\bin\Debug\net6.0\*.* ..\.PublishFiles\ /s /e 

echo "Successfully!!!! ^ please see the file .PublishFiles"

cmd