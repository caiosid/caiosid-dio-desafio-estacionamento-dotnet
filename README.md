# Desafio: Sistema de Estacionamento - Fundamentos .NET

---

Este repositório contém a resolução do desafio proposto no bootcamp de **Fundamentos .NET** da Digital Innovation One (DIO). O objetivo do projeto é desenvolver um sistema simples para gerenciar um estacionamento, permitindo o registro de veículos, cálculo de valores por permanência e a listagem dos veículos estacionados.

## Sobre o Projeto

O projeto consiste na implementação de uma classe `Estacionamento` que simula as operações básicas de um estacionamento. Ele foi projetado para ajudar no aprendizado de conceitos fundamentais de programação em **C#** e **.NET**, como manipulação de listas, estruturas condicionais, loops e interação com o usuário via console.

## Funcionalidades

A aplicação oferece as seguintes funcionalidades principais através de um menu interativo no console:

* **Adicionar Veículo:** Permite registrar um novo veículo no estacionamento, solicitando sua placa.
* **Remover Veículo:** Remove um veículo do estacionamento. Ao remover, o sistema calcula e exibe o valor total a ser cobrado, baseado em um preço inicial e um preço por hora.
* **Listar Veículos:** Exibe todos os veículos atualmente estacionados.
* **Menu Interativo:** Permite ao usuário escolher entre as operações disponíveis e encerrar o programa.

## Tecnologias Utilizadas

* **C#**
* **.NET** (Framework ou Core, dependendo da sua implementação)

## Como o Sistema Calcula o Preço

A classe `Estacionamento` utiliza as seguintes variáveis para o cálculo do preço:

* `precoInicial`: Um valor fixo cobrado inicialmente ao estacionar.
* `precoPorHora`: Um valor cobrado por cada hora que o veículo permanece estacionado.

O cálculo total é realizado na funcionalidade de remoção de veículo, considerando o tempo de permanência (que você precisará implementar para simular as horas).

## Estrutura do Código

A parte central do projeto é a classe `Estacionamento`, que possui os seguintes membros:

* **Variáveis:**
    * `precoInicial` (decimal): Preço fixo de entrada.
    * `precoPorHora` (decimal): Preço por hora de permanência.
    * `veiculos` (List<string>): Uma lista para armazenar as placas dos veículos estacionados.
* **Métodos:**
    * `AdicionarVeiculo()`: Adiciona um veículo à lista.
    * `RemoverVeiculo()`: Remove um veículo da lista e calcula o valor a ser pago.
    * `ListarVeiculos()`: Exibe a lista de veículos.

## Como Rodar o Projeto

1.  Clone este repositório para sua máquina local:
    ```bash
    git clone [LINK_DO_SEU_REPOSITORIO]
    ```
2.  Navegue até o diretório do projeto no terminal.
3.  Compile e execute o projeto usando o .NET CLI:
    ```bash
    dotnet build
    dotnet run
    ```
4.  Siga as instruções no console para interagir com o sistema do estacionamento.

## O Desafio

O desafio consistiu em completar o código-base fornecido pela DIO, implementando a lógica necessária para as funcionalidades de adição, remoção (com cálculo de preço) e listagem de veículos, além de construir o menu de interação com o usuário.

---

**Observações:**

* Lembre-se de substituir `[LINK_DO_SEU_REPOSITORIO]` pelo link real do seu repositório no GitHub.
* Você pode personalizar este README adicionando capturas de tela do sistema em funcionamento, ou detalhes específicos sobre as suas escolhas de implementação!
