# Cadastro de Imóveis com Garagem (ASP.NET MVC)

Este é um projeto de exemplo em ASP.NET MVC para o cadastro de imóveis, onde cada imóvel está associado a uma pessoa, onde esse imovél pode ou não possuir uma garagem. O projeto permite a criação, leitura, atualização e exclusão (CRUD) de registros de imóveis e seus proprietários.

## Requisitos

- Visual Studio (ou qualquer outro IDE C# compatível)
- ASP.NET Core SDK
- SQL Server (ou outro banco de dados de sua escolha)

## Configuração do Banco de Dados

1. Crie um banco de dados no SQL Server (ou no banco de dados de sua escolha).

2. Atualize a string de conexão no arquivo `appsettings.json` para refletir as configurações do seu banco de dados.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "SuaStringDeConexãoAqui"
  },
  // ...
}
```

3. Abra o Package Manager Console no Visual Studio e execute as migrações para criar as tabelas no banco de dados:

```bash
Update-Database
```

## Executando o Projeto

1. Abra o projeto no Visual Studio.

2. Verifique se o projeto de inicialização está configurado para o projeto Web (geralmente chamado de "NomeDoProjeto.Web").

3. Pressione F5 para iniciar o aplicativo.

4. O aplicativo estará disponível em `https://localhost:5001` (ou outra porta, dependendo da configuração).

## Funcionalidades

- Cadastro, edição e exclusão de pessoas.
- Cadastro, edição e exclusão de imóveis.
- Cadastro, edição e exclusão de garagens.
- Associação de um imóvel a uma pessoa.
- Associação de um garagem a um imovel.
- Listagem de todos as pessoas cadastradas.
- Listagem de todos os imóveis cadastrados.
- Listagem de todos as garagens cadastradas.
- Filtros de pesquisa.

## Estrutura do Projeto

O projeto é organizado em conformidade com a arquitetura MVC (Model-View-Controller) do ASP.NET.

- **Models**: Definem os objetos de domínio, como Imóvel e Pessoa.
- **Views**: Contêm as interfaces do usuário para criar, editar e visualizar imóveis.
- **Controllers**: Controlam as interações entre as Views e os Models, processando as ações do usuário.
- **Data**: Lida com a lógica de acesso ao banco de dados e as migrações.
- **Services**: Contêm a lógica de negócios para gerenciar imóveis e pessoas.
- **ViewModels**: Modelos de exibição que moldam os dados exibidos nas Views.

## Contribuição

Sinta-se à vontade para contribuir com melhorias ou correções. Abra um "Pull Request" descrevendo suas alterações.

---
