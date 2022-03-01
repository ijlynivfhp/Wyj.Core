#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#这种模式是直接在构建镜像的内部编译发布dotnet项目。
#注意下容器内输出端口是9291
#如果你想先手动dotnet build成可执行的二进制文件，然后再构建镜像，请看.Api层下的dockerfile。


FROM mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim AS build
WORKDIR /src
COPY ["Wyj.Core.Api/Wyj.Core.Api.csproj", "Wyj.Core.Api/"]
COPY ["Wyj.Core.Extensions/Wyj.Core.Extensions.csproj", "Wyj.Core.Extensions/"]
COPY ["Wyj.Core.Tasks/Wyj.Core.Tasks.csproj", "Wyj.Core.Tasks/"]
COPY ["Wyj.Core.IServices/Wyj.Core.IServices.csproj", "Wyj.Core.IServices/"]
COPY ["Wyj.Core.Model/Wyj.Core.Model.csproj", "Wyj.Core.Model/"]
COPY ["Wyj.Core.Common/Wyj.Core.Common.csproj", "Wyj.Core.Common/"]
COPY ["Wyj.Core.Services/Wyj.Core.Services.csproj", "Wyj.Core.Services/"]
COPY ["Wyj.Core.Repository/Wyj.Core.Repository.csproj", "Wyj.Core.Repository/"]
COPY ["Wyj.Core.EventBus/Wyj.Core.EventBus.csproj", "Wyj.Core.EventBus/"]
RUN dotnet restore "Wyj.Core.Api/Wyj.Core.Api.csproj"
COPY . .
WORKDIR "/src/Wyj.Core.Api"
RUN dotnet build "Wyj.Core.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Wyj.Core.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 9291 
ENTRYPOINT ["dotnet", "Wyj.Core.Api.dll"]
