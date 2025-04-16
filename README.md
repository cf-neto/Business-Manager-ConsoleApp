# Business Manager ConsoleApp

**Business Manager** é um sistema de console escrito em C#, desenvolvido segundo princípios de Programação Orientada a Objetos e Clean Code. Permite ao gerente de uma empresa cadastrar, listar, buscar e remover funcionários de forma rápida e organizada, mantendo um dicionário interno para persistência em memória.

---

## 📋 Índice

1. [Visão Geral](#visão-geral)  
2. [Funcionalidades](#funcionalidades)  
3. [Tecnologias](#tecnologias)  
4. [Estrutura do Projeto](#estrutura-do-projeto)  
5. [Instalação](#instalação)  
6. [Uso](#uso)  
7. [Melhorias Futuras](#melhorias-futuras)  
8. [Contribuição](#contribuição)  

---

## <a name="visão-geral"></a>🎯 Visão Geral

Como gerente geral, você precisa de ferramentas confiáveis para:

- **Cadastrar** novos membros da equipe  
- **Listar** todos os colaboradores  
- **Buscar** informações de um funcionário específico  
- **Remover** funcionários  

Este projeto entrega um protótipo completo de um sistema CLI (Command‑Line Interface) que demonstra práticas reais de mercado em C#.

---

## <a name="funcionalidades"></a>🚀 Funcionalidades

- **CRUD completo de Funcionários**  
- **Dicionário em memória** para acesso rápido por nome (chave)  
- **Cálculo de bônus** automático com base em produtividade  
- **Menu interativo de console**, todo em Português  
- **Clean Code & SOLID**: separação de responsabilidades em Interfaces e Services.

---

## <a name="tecnologias"></a>🛠 Tecnologias

- **Linguagem:** C#  
- **\.NET CLI:** Console Application (net6.0 ou superior)  
- **Paradigma:** Programação Orientada a Objetos (POO)  
- **Padrões:** SOLID, Clean Architecture (Interfaces e Services)  

---

## <a name="estrutura-do-projeto"></a>📂 Estrutura do Projeto

```plaintext
Business-Manager-ConsoleApp/
│
├── Program.cs                 # Ponto de entrada e menu principal
├── BusinessManager.csproj
├── README.md
│
├── Interfaces/
│   └── IFuncionarioService.cs # Contrato de operações de funcionário
│
├── Services/
│   └── FuncionarioService.cs  # Lógica de negócio e armazenamento em dicionário
└──
```

## **Certifique-se de que você tem o .NET SDK 9.0 instalado.**

- Para compilar e executar o projeto:

```bash
dotnet build
dotnet run
```

## <a name="instalação"></a>⚙️ Instalação

```bash
git clone https://github.com/cf-neto/Business-Manager-ConsoleApp.git
cd Business-Manager-ConsoleApp
```

## <a name="uso"></a>🚀 Uso
Ao executar o programa, você verá o seguinte menu:
```markdown
=== Business Manager ===
1. Adicionar Funcionário
2. Listar Funcionários
3. Remover Funcionário
4. Procurar Funcionário
0. Sair
```

## <a name="melhorias-futuras"></a>Melhorias futuras
- Deixar o app completo com mais funções
- Expandir para um design mais organizado

## <a name="contribuição"></a>🤝 Contribuição
Contribuições são bem-vindas!
Abra uma issue com melhorias ou bugs, ou envie um pull request com novas funcionalidades.
