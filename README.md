# Desafio Autoglass

Projeto  desafio/teste técnico de programação Autoglass.

## Estrutura do Projeto

O projeto está organizado em várias camadas para facilitar a manutenção, escalabilidade e testabilidade.

- **API:**
  - Projeto do tipo Web Api responsável por fornecer endpoints e interagir com a camada de Application.

- **Application:**
  - Projeto do tipo Class Library contendo a lógica de aplicação e orquestração de operações.

- **Domain:**
  - Projeto do tipo Class Library que define os modelos de domínio, interfaces e serviços essenciais para a lógica de negócios.

- **DTOs:**
  - Projeto do tipo Class Library contendo Data Transfer Objects (DTOs) que facilitam a comunicação entre diferentes camadas.

- **Infra:**
  - Projeto do tipo Class Library responsável por lidar com a camada de infraestrutura, como acesso a banco de dados, serviços externos, etc.

- **IoC:**
  - Projeto do tipo Class Library que gerencia a inversão de controle (IoC) e injeção de dependência no projeto.

