Projeto do curso WEB API .NET Core Essencial de Jos� Carlos Macarotti

# Escopo do projeto de API
Criar uma Web API para um cat�logo de produtos/categorias que pode atender uma rede de lojas ou supermercados.

- Criar um servi�o RESTful que permita que aplicativos clientes gerenciem o cat�logo de produtos e categorias
- Expor endpoints para criar, ler, editar e excluir produtos e tamb�m para consultar produtos e um produto espec�fico
- Expor endpoints para criar ler, editar e excluir categorias e tamb�m consultar categorias, uma categoria espec�fica 
  e os produtos de uma categoria.
- Para categorias, precisamos armazenar:o nome e o caminho da imagem
- Para produtos, precisamos armazenar : nome, descri��o, valor unit�rio, caminho da imagem, estoque, data do cadastro e categoria

## Etapas
1. Criar o projeto no VS 2022 Community - ApiCatalogo
2. Criar o projeto com op��o para habilitar a Open API e usar Controllers
3. Criar o modelo de entidades - Produto e Categoria
4. Configurar o projeto para usar o EF Core e incluir refer�ncias ao EF Core
5. Definir o banco de dados Usado � MySql e MySQL Workbench
6. Definir a classe de contexto do EF Core �AppDbContext
7. Definir o mapeamento de entidades para as tabelas � DbSet<T>
8. Registrar o contexto como um servi�o � Program
9. Definir a string de conex�o no arquivo appsettings.json
10. Definir o provedor do banco de dados (Pomelo) e obter a string de conex�o
11. Aplicar o Migrations e criar o banco de dados e as tabelas
12. Criar os controladores : ProdutosController e CategoriasController
13. Definir os endpoints ou m�todos Action para realizar as opera��es CRUD

## Seguran�a
- Permitir o acesso �s APIs somente a usu�rios autenticados
- Definir uma pol�tica de autoriza��o de acesso aos usu�rios 
- Criar um servi�o RESTful que permita gerenciar os usu�rios

- Expor endpoints para criar, ler, editar e excluir usu�rios e tamb�m para consultar usu�rios e um usu�rio espec�fico
- Para os usu�rios precisamos armazenar : nome, email/ senha

## Defini��o dos recursos, dos endpoints e do mapeamento
Endpoint da API : /v1/api/produtos
- GET /v1/api/produtos
- GET /V1/ api/produtos/1
- POST /v1/ api/produtos
- PUT /v1/api/produtos/1
- DELETE /v1/prodktos/1
 
Endpoint da API : /v1/api/categorias
- GET /v1/api/categorias
- GET /v1/ api/categorias/1
- POST /v1/ api/categorias
- PUT /v1/api/categorias/1
- DELETE /v1/categorias/1

Endpoint da API : /v1/api/usuarios
- GET /v1/api/usuarios
- GET /v1/ api/usuarios/1
- POST /v1/ api/usuarios
- PUT /v1/api/usuarios/1
- DELETE /v1/usuarios/1

## Persistencia dos dados
- Banco de dados relacional: Mysql
- Pomelo.EntityFrameworkCore.MySql
- Entity Framework Core
- Abordagem Code-First � Parte das entidades para criar as tabelas e o banco de dados
- Padr�o Reposit�rio (desacoplar o acesso aos dados da aplica��o)
