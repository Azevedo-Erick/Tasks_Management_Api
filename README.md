# API de Gerenciamento de Tarefas em C# .NET 7

Esta é uma API em C# .NET 7 para gerenciamento de tarefas. Ela permite que os usuários criem, atualizem, excluam e listem tarefas, bem como atribuam tarefas a usuários. Esta API é projetada para ser usada como um backend para um aplicativo de gerenciamento de tarefas.

## Stack Utilizada

## Requisitos

- .NET 7 SDK
- Um banco de dados SQL Server ou outro banco de dados compatível
- Postman ou outra ferramenta similar para testar as chamadas da API

## Documentação

1. [Diagrama de Entidade Relacional](./Docs/ER_DIAGRAM.md)

## Rodando localmente

1. Clone o repositório:

```shell
git clone https://github.com/seu-usuario/api-gerenciamento-tarefas.git
```
Abra o projeto em seu ambiente de desenvolvimento preferido.

Configure as strings de conexão com o banco de dados no arquivo appsettings.json:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "SuaStringDeConexãoAqui"
  }
}
```
No terminal, navegue até a pasta do projeto e execute as migrações para criar o banco de dados:

```
dotnet ef database update
```

Inicie o aplicativo:
```
dotnet run
```
A API estará disponível em http://localhost:5000.


## Uso da Api

Você pode usar uma ferramenta como o Postman ou cURL para fazer chamadas à API. Aqui estão alguns exemplos de chamadas:

### Documentação da API

#### Retorna todos os itens

```http
  GET /
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `` | `string` | **Obrigatório**.|

#### Retorna um item

```http
  GET /id
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | **Obrigatório**. O ID do item que você quer |




## Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas, enviar solicitações pull ou melhorar a documentação.

## Licença
Este projeto é licenciado sob a MIT.

Apreciamos seu interesse em nossa API de gerenciamento de tarefas em C# .NET 7. Se você tiver alguma dúvida ou precisar de assistência, não hesite em entrar em contato comigo.

Happy coding!😄


## Aprendizados