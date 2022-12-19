<h1 align="center">:file_cabinet: Web API CursoDeIdiomas README.md</h1>

## :memo: Descrição
Este projeto foi elaborado por meio do teste da empresa Marlin para vaga Estágio .NET C#, onde foi pedido para criar UM Web API para uma empresa que oferece cursos de idiomas, dentro desse projeto foi criado uma base de dados usando o SQL Server Managmente Studio com as tabelas mencionadas a baixo, ainda na criação foi elaborado total de 3 CRUD sitados abaixo em CRUD Métodos API, dentro desse projeto tambem foi criada algumas regras de negócio.

## :books: Funcionalidades
👨‍💻💻 Tabelas do Banco

✔️<b>ALUNO</b> (Nome,Cpf,E-mail)

✔️<b>TURMA</b> (Número,AnoLetivo)

✔️<b>Matriculas</b>

👨‍💻<b>CRUD Métodos API:
  
 ✔️<b>ALUNO</b>:  (Cadastro,Alteração,Liste de todos os Alunos e Exclusão);
  
 ✔️<b>TURMA</b>:  (Cadastro,Alteração,Liste de todos os Turmas e Exclusão);
  
 ✔️<b>MATRICULA</b>:  (Cadastro,Liste de todas as Matriculas e Exclusão);

👨‍💻 Regra de negócios

✔️Aluno não pode ser cadastrado repetido (validação pelo CPF);

✔️ No momento de cadastrar um aluno, deve-se informar pelo menos uma turma que ele irá cursar;  

✔️O mesmo aluno pode ser matriculado em várias turmas diferentes, porém a Matrícula não pode ser repetida na mesma turma;   

✔️ Uma turma não pode ter mais de 5 alunos;  

✔️Turma não pode ser excluída se possuir alunos;

## ✔️ :wrench: Tecnologias / Metodologias utilizadas
 
* CSharp
  
* AspNetCore
 
* SQL Server
  
* Swashbuckle.AspNetCore
  
* DDD
  
* EF Code First
  
* Repository Patterns
  
* Injeções de depencências
  
* Microsoft.EntityFrameworkCore
  
* Microsoft.EntityFrameworkCore.Design
  
* Microsoft.EntityFrameworkCore.SqlServer
  
* Microsoft.EntityFrameworkCore.Tools
  
* Microsoft.Extensions.DependencyInjection
  
* Swashbuckle.AspNetCore.Swagger

## :rocket: Rodando o projeto
Para rodar o repositório é necessário clonar o mesmo, dar o seguinte comando para iniciar o projeto:
```
<Para fazer uso do Migrations usei os comandos especificado abaixo

****************---

Para rodar a migrations entre na pasta  ->  cd .\CursosDeIdiomas.Infra\

****************---

Na sequencia  use o comando para adcionar-> dotnet ef --startup-project ..\CursosDeIdiomas.Services\ migrations add NomeDaMigrations --context SqlContext

****************---

para encerra use este comando para da um update.-> dotnet ef --startup-project ..\CursosDeIdiomas.Services\  database update --context SqlContext.>
```

## :soon: Implementação futura
* O que será implementado na próxima sprint?

## :handshake: Colaboradores
https://github.com/BrunoFaria2021

## :dart: Status do projeto
<p align="
LEFT
">
<img src="http://img.shields.io/static/v1?label=STATUS&message=DESENVOLVIMENTO CONCLUIDO &color=GREEN&style=for-the-badge"/>
</p>

