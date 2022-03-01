git pull;
rm -rf .PublishFiles;
dotnet build;
dotnet publish -o /home/Wyj.Core/Wyj.Core.Api/bin/Debug/net6.0;
cp -r /home/Wyj.Core/Wyj.Core.Api/bin/Debug/net6.0 .PublishFiles;
echo "Successfully!!!! ^ please see the file .PublishFiles";