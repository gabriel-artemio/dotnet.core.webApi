# Web API ASP .NET Core
### Sistema de Cadastro de Produtos

Este é um projeto de Web API ASP .NET Core, que terá como função cadastrar produtos e fazer todas as ações de CRUD na base de dados.

Estarei utilizando o banco de dados SQL Server e o Entity Framework
## Funcionalidades

- CRUD - Create, Read, Update e Delete

- No projeto já tem a migration, é necessário apenas criar a base de dados e alterar os parametros no appsettings.json, e depois no terminal do Console de Projetos rodar o comando: update-database


## Stack utilizada

**Back-end:** NET 5.0 Core, SQL Server


## Documentação da API

#### Retorna todos os produtos

```http
  GET /api/produtos
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
|  | `string` | Não precisa de autenticação |

#### Retorna um produto

```http
  GET /api/produtos/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | **Obrigatório**. O ID do item que você quer |

#### Adicionar um produto

```http
  POST /api/produtos/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Nome`      | `string` | **Obrigatório**. O nome do produto |
`Descricao` | `string` | Descrição do produto |
`Preco` | `decimal` | Preço do produto |

#### Editar um produto

```http
  PUT /api/produtos/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Nome`      | `string` | **Obrigatório**. O nome do produto |
`Descricao` | `string` | Descrição do produto |
`Preco` | `decimal` | Preço do produto |

#### Deletar um produto

```http
  DELETE /api/produtos/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Id`      | `int` | **Obrigatório** informar o Id do produto |
