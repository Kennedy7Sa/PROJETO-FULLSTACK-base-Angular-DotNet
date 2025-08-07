# 📋 Sistema de Cadastro de Funcionários

Projeto Fullstack desenvolvido com **.NET 8 Web API** no backend e **Angular 20** no frontend, com objetivo de realizar o gerenciamento completo de funcionários (CRUD). O projeto utiliza **Entity Framework Core** com banco de dados **SQLite** e **Angular Material** para estilização da interface.

---

## 🔧 Tecnologias Utilizadas

### Backend (.NET 8)
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- CORS habilitado


### Frontend (Angular 20)
- Angular CLI
- Angular Material
- TypeScript


---

## ✅ Funcionalidades

- ✅ Cadastro de funcionários
- ✅ Listagem de funcionários
- ✅ Campo de busca por nome
- ✅ Edição de dados
- ✅ Exclusão de registros
- ✅ Atualização em tempo real
- ✅ Interface responsiva com Angular Material

---

## 📦 Como Executar o Projeto

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Node.js](https://nodejs.org/)
- Angular CLI (`npm install -g @angular/cli`)

### Backend

1. Navegue até a pasta do backend:
   ```bash
   cd ./Backend
   ```

2. Restaure os pacotes:
   ```bash
   dotnet restore
   ```

3. Aplique as migrations e crie o banco de dados:
   ```bash
   dotnet ef database update
   ```

4. Execute a API:
   ```bash
   dotnet run
   ```

### Frontend

1. Navegue até a pasta do frontend:
   ```bash
   cd ./Frontend
   ```

2. Instale as dependências:
   ```bash
   npm install
   ```

3. Execute o Angular:
   ```bash
   ng serve
   ```

4. Acesse o sistema:
   ```
   http://localhost:4200
   ```

---

## 🗃️ Estrutura do Projeto

```
📁 projeto-cadastro-funcionarios/
├── Backend/
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   ├── Migrations/
│   └── Program.cs
└── Frontend/
    ├── src/
    │   ├── app/
    │   │   ├── components/
    │   │   ├── services/
    │   │   └── models/
    └── angular.json
```

---

## 📌 Observações

- A aplicação permite a comunicação entre frontend e backend via **HTTPClient** com endpoints RESTful.
- O Angular Material foi utilizado para garantir um layout moderno e responsivo.
- O campo de busca permite filtrar funcionários por nome em tempo real.

---

## 📷 Demonstração

*Adicione aqui prints ou GIFs do sistema funcionando (opcional).*

---

## 🤝 Contribuição

Contribuições são bem-vindas! Fique à vontade para abrir issues ou pull requests.

---

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

---

## ✍️ Autor

Desenvolvido por **Kennedy S. Arruda**  
[LinkedIn](https://www.linkedin.com/in/kennedy-arruda-devbackend/)
