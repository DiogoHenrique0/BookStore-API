# 📚 BookStore API

API REST para gerenciamento de livros, desenvolvida em **ASP.NET Core**, como parte de um desafio prático para fixação de conceitos de back-end, arquitetura em camadas e boas práticas.

---

## 🚀 Funcionalidades

* Criar um livro
* Listar todos os livros
* Buscar um livro por ID
* Atualizar informações de um livro
* Excluir um livro

---

## 🧱 Arquitetura

O projeto foi desenvolvido seguindo uma separação clara de responsabilidades:

* **Controllers** → Camada HTTP (rotas e status codes)
* **Services** → Regras de negócio
* **Repositories** → Acesso e persistência de dados
* **Entities** → Modelo de domínio
* **DTOs** → Transferência de dados (entrada e saída)
* **Enums** → Valores fixos do domínio

---

## 📦 Modelo de Livro

### Campos obrigatórios

| Campo     | Tipo     | Regras                   |
| --------- | -------- | ------------------------ |
| id        | GUID     | Gerado automaticamente   |
| title     | string   | 2 a 120 caracteres       |
| author    | string   | 2 a 120 caracteres       |
| genre     | enum     | Valores pré-definidos    |
| price     | decimal  | ≥ 0                      |
| stock     | int      | ≥ 0                      |
| createdAt | DateTime | Gerado na criação        |
| updatedAt | DateTime | Atualizado em alterações |

---

## 🔌 Endpoints

### ➕ Criar livro

```
POST /api/books
```

Body:

```json
{
  "title": "Clean Code",
  "author": "Robert Martin",
  "genre": 1,
  "price": 99.90,
  "stock": 10
}
```

Resposta:

* `201 Created`
* Retorna o livro criado

---

### 📄 Listar livros

```
GET /api/books
```

Resposta:

* `200 OK`
* Lista de livros

---

### 🔍 Buscar livro por ID

```
GET /api/books/{id}
```

Resposta:

* `200 OK`
* `404 Not Found`

---

### ✏️ Atualizar livro

```
PUT /api/books/{id}
```

Body:

```json
{
  "title": "Clean Code Updated",
  "author": "Robert Martin",
  "genre": 1,
  "price": 79.90,
  "stock": 5
}
```

Resposta:

* `204 No Content`
* `404 Not Found`
* `409 Conflict`

---

### 🗑️ Excluir livro

```
DELETE /api/books/{id}
```

Resposta:

* `204 No Content`
* `404 Not Found`

---

## ⚙️ Tecnologias utilizadas

* .NET 7 / .NET 8
* ASP.NET Core
* Injeção de Dependência
* Data Annotations
* System.Text.Json
* Postman (testes)

---

## ▶️ Como executar o projeto

```bash
git clone https://github.com/DiogoHenrique0/bookstore-api.git
cd bookstore-api
dotnet restore
dotnet run
```

A API estará disponível em:

```
https://localhost:7257
```

---

## 🧪 Testes

Os endpoints podem ser testados utilizando o **Postman** ou **Swagger**.

---

## 📌 Observações

* A persistência de dados foi feita **em memória**, utilizando `Singleton`, apenas para fins de estudo.
* Em um cenário real, o projeto pode ser facilmente adaptado para utilizar um banco de dados relacional.

---

## 👨‍💻 Autor

Desenvolvido por **Diogo Henrique**
📍 Portugal
🚀 Estudando back-end e engenharia de software
