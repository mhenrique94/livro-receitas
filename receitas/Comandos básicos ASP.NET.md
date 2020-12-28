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

>Executar o Migrations ()

dotnet ef migrations add InitialCreate

>Documentação XML com Swagger

services.AddSwaggerGen(c => { c.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Intro API", Version = "v1" }); });

app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "Intro API"); });

