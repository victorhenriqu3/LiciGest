# **LiciGest**

Um sistema desenvolvido para facilitar o gerenciamento de licitações públicas, promovendo maior organização, eficiência e transparência no processo licitatório.

---

## **Índice**

1. [Visão Geral](#visão-geral)
2. [Funcionalidades Principais](#funcionalidades-principais)
3. [Tecnologias Utilizadas](#tecnologias-utilizadas)
4. [Estrutura do Projeto](#estrutura-do-projeto)
5. [Autor](#autor)

---

## **Visão Geral**

O **LiciGest** é uma aplicação que permite gerenciMIgrationsar processos licitatórios, documentos, fornecedores e relatórios de forma centralizada. Ele foi projetado para atender órgãos públicos e privados que realizam ou participam de licitações.

O sistema é baseado na arquitetura **Domain-Driven Design (DDD)**, garantindo flexibilidade e robustez para atender regras de negócio específicas. Ele utiliza **Blazor** para uma interface web interativa e responsiva, integrando-se perfeitamente com uma API desenvolvida em .NET.

---

## **Funcionalidades Principais**

- **Gestão de Licitações**: Cadastro, edição e acompanhamento de licitações.
- **Gerenciamento de Fornecedores**: Registro e busca de fornecedores participantes.
- **Relatórios Estatísticos**: Geração de relatórios detalhados em formatos como Excel e PDF.
- **Controle de Documentos**: Upload e organização de documentos relacionados às licitações.
- **Painel de Controle**: Interface amigável para visualização de dados e métricas em tempo real.

---

## **Tecnologias Utilizadas**

### **Back-end**

- **.NET 8.0**: Para construção da API.
- **Entity Framework Core**: Para mapeamento objeto-relacional e migrações.
- **ClosedXML**: Para manipulação de arquivos Excel.
- **Moq e xUnit**: Para testes automatizados.

### **Front-end**

- **Blazor**: Para construção de interfaces web interativas.
- **CSS/SCSS**: Para estilização personalizada.

### **Banco de Dados**

- **SQL Server**: Para armazenamento de dados.

### **Outras Tecnologias**MIgrations

- **Arquitetura DDD**: Organização modular com camadas bem definidas.
- **Clean Architecture**: Separação de responsabilidades e foco na manutenibilidade.
- **Git**: Controle de versão.

---

## Estrutura do Projeto

Essa estrutura de pastas segue princípios de Domain-Driven Design (DDD), organizando o código em camadas bem definidas para separar as responsabilidades e facilitar a manutenção, escalabilidade e testes da aplicação.

```bash
├── Domain/
│ ├── Entities/ # Entidades principais do domínio
│ ├── ValueObjects/ # Objetos de valor
│ └── Repositories/ # Interfaces para persistência de dados.
│
├── Infra/
│ ├── Persistence/ # Implementações concretas dos repositórios.
│ ├── Config/ # Configuração de banco de dados, serviços, etc.
│ └── Migrations/ # Mapeamento e migrações EF Core.
│
├── Services/
│ ├── UseCases/ # Casos de uso da aplicação (orquestra lógica de domínio e infraestrutura).
│ ├── DTOs/ # Modelos de entrada e saída de dados.
│ └── Mappers/ # Conversores entre entidades de domínio e DTOs.
│
├── UI/
│ ├── Pages/ # Páginas Blazor
│ ├── Components/ # Componentes reutilizáveis (Botões, Modais, etc.).
│ ├── Services/ # Serviços que consomem a API do back-end.
│ └── Styles/ # Arquivos CSS/SCSS para estilização.
│
└── Tests/
├── ApplicationTests/ # Testes unitários e de integração para Application.
├── DomainTests/ # Testes de regras de negócios do domínio.
└── InfraTests/ # Testes de integração da infraestrutura.
```

Abaixo, segue a descrição de cada camada:

- **Domain/** : Essa é a camada central, que encapsula as regras de negócio e o modelo do domínio. Ela é independente de tecnologias ou frameworks externos, refletindo as regras e comportamentos fundamentais da aplicação.

  - **Entities/** : Contém as entidades principais do domínio, representando conceitos centrais como objetos com identidade única e comportamentos.

  - **ValueObjects/** : Contém os Objetos de Valor, que são imutáveis e representam conceitos sem identidade própria (como endereços ou números de telefone).

  - **Repositories/** : Define interfaces para os repositórios, que abstraem o acesso e manipulação de dados persistidos.

- **Infra/** : Esta camada contém as implementações concretas de persistência e configurações relacionadas à infraestrutura. Ela serve de ponte entre o domínio e as tecnologias externas, como bancos de dados ou APIs externas.

  - **Persistence/**: Implementações das interfaces de repositórios definidas na camada de domínio.
  - **Config/** : Configurações específicas de banco de dados, serviços externos, provedores de autenticação, etc.
  - **Migrations/** : Scripts e mapeamentos gerados pelo Entity Framework Core para gerenciamento do banco de dados.

- **Services/** : Essa camada implementa a lógica de aplicação e orquestra a interação entre a camada de domínio e infraestrutura.

  - **UseCases/** : Contém os casos de uso que descrevem as operações e fluxos principais da aplicação, como a criação de um novo pedido ou a gestão de licitações.
  - **DTOs/** : Objetos de Transferência de Dados (Data Transfer Objects), utilizados para entrada e saída de dados, isolando as entidades de domínio da camada de apresentação.
  - **Mappers/** : Implementações de mapeamento entre entidades de domínio e DTOs, facilitando a conversão e transporte de dados entre as camadas.

- **UI/** : A camada de interface com o usuário, que implementa a interação visual e lógica para o front-end, utilizando Blazor para criar uma aplicação moderna e responsiva.

  - **Pages/** : Páginas principais da aplicação, cada uma representando uma funcionalidade ou visão específica.
  - **Components/** : Componentes reutilizáveis, como botões, modais ou tabelas, que facilitam a construção de interfaces consistentes.
  - **Services/** : Serviços front-end que consomem APIs do back-end para comunicação e troca de dados.
  - **Styles/** : Arquivos CSS/SCSS responsáveis pela estilização da interface, garantindo uma aparência personalizada e responsiva.

---

## Autor

<a href="https://www.linkedin.com/in/victorhenriqu3/">
 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/43153097?v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Victor Henrique</b></sub></a> <a href="mailto:victorhenriqu3@outlook.com" title="Email"></a>

Feito com ❤️ por [Victor Lima](https://www.linkedin.com/in/victorhenriqu3/).
<br/>👋🏽 Entre em contato!

[![Linkedin Badge](https://img.shields.io/badge/-Victor%20Henrique-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/victorhenriqu3/)](https://www.linkedin.com/in/victorhenriqu3/)
[![Outlook Badge](https://img.shields.io/badge/-victorhenriqu3@outlook.com-blue?style=flat-square&logo=microsoft-outlook&logoColor=white&link=mailto:victorhenriqu3@outlook.com)](mailto:victorhenriqu3@outlook.com)
