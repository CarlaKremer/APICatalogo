Projeto do curso WEB API .NET Core Essencial de Jose Carlos Macoratti

# Escopo do projeto de API
Criar uma Web API para um catálogo de produtos/categorias que pode atender uma rede de lojas ou supermercados.

- Criar um serviço RESTful que permita que aplicativos clientes gerenciem o catálogo de produtos e categorias
- Expor endpoints para criar, ler, editar e excluir produtos e também para consultar produtos e um produto específico
- Expor endpoints para criar ler, editar e excluir categorias e também consultar categorias, uma categoria específica 
  e os produtos de uma categoria.
- Para categorias, precisamos armazenar: o nome e o caminho da imagem
- Para produtos, precisamos armazenar : nome, descrição, valor unitário, caminho da imagem, estoque, data do cadastro e categoria

## Etapas
1. Criar o projeto no VS 2022 Community - ApiCatalogo
2. Criar o projeto com opção para habilitar a Open API e usar Controllers
3. Criar o modelo de entidades - Produto e Categoria
4. Configurar o projeto para usar o EF Core e incluir referências ao EF Core
5. Definir o banco de dados Usado — MySql e MySQL Workbench
6. Definir a classe de contexto do EF Core — AppDbContext
7. Definir o mapeamento de entidades para as tabelas — DbSet<T>
8. Registrar o contexto como um serviço — Program
9. Definir a string de conexão no arquivo appsettings.json
10. Definir o provedor do banco de dados (Pomelo) e obter a string de conexão
11. Aplicar o Migrations e criar o banco de dados e as tabelas
12. Criar os controladores : ProdutosController e CategoriasController
13. Definir os endpoints ou métodos Action para realizar as operações CRUD

## Segurança
- Permitir o acesso às APIs somente a usuários autenticados
- Definir uma política de autorização de acesso aos usuários 
- Criar um serviço RESTful que permita gerenciar os usuários

- Expor endpoints para criar, ler, editar e excluir usuários e também para consultar usuários e um usuário específico
- Para os usuários precisamos armazenar : nome, email/ senha

## Definição dos recursos, dos endpoints e do mapeamento
Endpoint da API : /produtos
- GET /produtos
- GET /produtos/1
- POST /produtos
- PUT /produtos/1
- DELETE /produtos/1
 
Endpoint da API : /categorias
- GET /categorias
- GET /categorias/1
- POST /categorias
- PUT /categorias/1
- DELETE /categorias/1

Endpoint da API : /usuarios
- GET /usuarios
- GET /usuarios/1
- POST /usuarios
- PUT /usuarios/1
- DELETE /usuarios/1

## Persistência dos dados
- Banco de dados relacional: Mysql
- Pomelo.EntityFrameworkCore.MySql
- Entity Framework Core
- Abordagem Code-First — Parte das entidades para criar as tabelas e o banco de dados
- Padrão Repositório (desacoplar o acesso aos dados da aplicação)
