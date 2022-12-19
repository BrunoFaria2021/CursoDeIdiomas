Projeto criação de uma Web API para uma empresa que oferece cursos de idiomas.


Para fazer uso do Migrations usei os comandos especificado abaixo

****************---

Para rodar a migrations entre na pasta  ->  cd .\CursosDeIdiomas.Infra\

****************---

Na sequencia  use o comando para adcionar-> dotnet ef --startup-project ..\CursosDeIdiomas.Services\ migrations add NomeDaMigrations --context SqlContext

****************---

para encerra use este comando para da um update.-> dotnet ef --startup-project ..\CursosDeIdiomas.Services\  database update --context SqlContext.