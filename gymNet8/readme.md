# GymNet8 API

Bem-vindo à **GymNet8 API**, uma API moderna para o gerenciamento completo de academias! Com recursos robustos para **gerenciamento de planos de associados**, **controle de estoque de suplementos**, **gestão de pagamentos**, **compras** e **estatísticas detalhadas**, esta API foi desenvolvida para automatizar e facilitar o controle e operação das academias.

A GymNet8 API proporciona uma solução completa para academias que desejam um controle centralizado e eficiente sobre suas operações diárias.

![GymNet8](https://www.exemplo.com/imagens/gymnet8-logo.png)

## Funcionalidades

### 1. **Gerenciamento de Associados**
A API permite o cadastro, gerenciamento e atualização dos dados dos associados da academia, incluindo:
- Registro de novos membros.
- Atualização de informações de membros (nome, e-mail, telefone, etc.).
- Controle de planos de academia, incluindo planos mensais, anuais, etc.
- Monitoramento de status do plano (ativo, expirado, renovação).

![Gerenciamento de Associados](https://www.exemplo.com/imagens/associados.png)

### 2. **Controle de Estoque de Produtos**
Gerencie o estoque de suplementos com total controle:
- Cadastro de suplementos (nome, descrição, preço, quantidade em estoque).
- Adição, remoção e atualização do estoque.
- Histórico de vendas de suplementos.
- Monitoramento de suplementos com baixo estoque.

![Controle de Estoque](https://www.exemplo.com/imagens/estoque.png)

### 3. **Gestão de Pagamentos e Compras**
Controle todos os pagamentos e compras feitas pelos membros:
- Registro de pagamentos de associados (mensais, anuais, etc.).
- Histórico de transações de pagamento.
- Geração de recibos de pagamento.
- Controle de compras de suplementos pelos membros.
- Relatórios financeiros de receitas e despesas.

![Gestão de Pagamentos](https://www.exemplo.com/imagens/pagamentos.png)

### 4. **Estatísticas e Relatórios**
Gerencie e visualize as principais métricas da sua academia:
- **Estatísticas de planos**: Veja quais planos são mais populares, quantos membros estão ativos e quando os planos expiram.
- **Relatórios de vendas**: Visualize as vendas de suplementos em tempo real, com gráficos e dados detalhados.
- **Estatísticas financeiras**: Acompanhe a saúde financeira da academia com relatórios sobre receitas e despesas mensais.
- **Notificações e alertas**: Receba alertas quando um plano estiver prestes a expirar ou quando o estoque de suplementos estiver baixo.

![Estatísticas](https://www.exemplo.com/imagens/estatisticas.png)

---

## Tecnologias Utilizadas

- **.NET 8**: Framework utilizado para o desenvolvimento da API.
- **ASP.NET Core**: Para criação da API RESTful.
- **Entity Framework Core**: Para interação com o banco de dados e gerenciamento de dados.
- **SQLite**: Banco de dados leve e fácil de configurar, perfeito para pequenos e médios projetos.
- **Swagger**: Para documentação da API e testes interativos.
- **Electron + Angular**: Para o frontend, proporcionando uma aplicação desktop moderna e interativa.

---

## Endpoints Principais

### 1. **Associados**
- `GET /api/clients`: Lista todos os associados.
- `GET /api/clients/{id}`: Detalhes de um associado específico.
- `POST /api/clients`: Cria um novo associado.
- `PUT /api/clients/{id}`: Atualiza as informações de um associado.
- `DELETE /api/clients/{id}`: Remove um associado.

### 2. **Suplementos**
- `GET /api/supplements`: Lista todos os suplementos.
- `GET /api/supplements/{id}`: Detalhes de um suplemento.
- `POST /api/supplements`: Adiciona um novo suplemento ao estoque.
- `PUT /api/supplements/{id}`: Atualiza as informações de um suplemento.
- `DELETE /api/supplements/{id}`: Remove um suplemento do estoque.

### 3. **Pagamentos**
- `GET /api/payments`: Lista todos os pagamentos realizados.
- `POST /api/payments`: Registra um novo pagamento.
- `GET /api/payments/{id}`: Detalhes de um pagamento específico.

### 4. **Estatísticas**
- `GET /api/statistics/plans`: Estatísticas dos planos de academia (ativos, expirando, etc.).
- `GET /api/statistics/sales`: Relatório de vendas de suplementos.
- `GET /api/statistics/financials`: Relatório financeiro da academia.

---

## Como Rodar o Projeto

### Pré-requisitos

- **.NET 8 SDK**: Baixe e instale a versão mais recente do .NET 8.
- **SQLite**: Instale o SQLite para utilizar o banco de dados local.
- **Editor de código**: Visual Studio Code ou Visual Studio, ambos com suporte completo para .NET.

### Passos para rodar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/gymnet8-api.git
   ```

2. Navegue até o diretório do projeto:
   ```bash
   cd gymnet8-api
   ```

3. Restaure as dependências do projeto:
   ```bash
   dotnet restore
   ```

4. Execute as migrações para configurar o banco de dados SQLite:
   ```bash
   dotnet ef database update
   ```

5. Execute a API:
   ```bash
   dotnet run
   ```

A API estará rodando no endereço `http://localhost:5000` ou `https://localhost:5001`.

---

## Documentação Interativa (Swagger UI)

A documentação da API é gerada automaticamente com o Swagger e pode ser acessada diretamente após iniciar a aplicação.

- Acesse a documentação interativa no navegador:
    - [Swagger UI](http://localhost:5000/swagger)

Nela, você pode testar todos os endpoints de forma visual e interativa.

---

## Frontend (Electron + Angular)

Este repositório é dedicado ao backend da aplicação. O **frontend** será desenvolvido em um repositório separado, utilizando **Electron** para uma aplicação desktop e **Angular** para a interface de usuário.

Você pode acessar o repositório do frontend [aqui](https://github.com/seu-usuario/frontend-gymnet8).

---

## Contribuindo

Contribuições são bem-vindas! Para contribuir:

1. Fork este repositório.
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`).
3. Commit suas mudanças (`git commit -am 'Adiciona nova feature'`).
4. Push para a branch (`git push origin feature/nova-feature`).
5. Abra um Pull Request.

---

## Licença

Este projeto está licenciado sob a **MIT License** - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

## Contato

Para dúvidas ou sugestões, entre em contato:

- Email: seu-email@dominio.com
- GitHub: [https://github.com/Gabriel-m-Coutinho](https://github.com/Gabriel-m-Coutinho)

---

## Imagens do Projeto

![Tela de Gerenciamento](https://www.exemplo.com/imagens/tela-gerenciamento.png)
