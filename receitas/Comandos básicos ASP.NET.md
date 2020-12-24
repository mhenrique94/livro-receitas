#COMANDOS ASP.NET

>Novo projeto depois da pasta já criada

dotnet new mvc

>adicionar pacote EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore  

dotnet add package Microsoft.EntityFrameworkCore.tools

dotnet add package Microsoft.EntityFrameworkCore.Design

>adicionar pacote SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

>antes do namespace class colocar 
using Microsoft.EntityFrameworkCore;

>Instalar comandos EntityFramework

dotnet tool install --global dotnet-ef

>Executar o Migrations

dotnet ef migrations add InitialCreate