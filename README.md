# Lista de Contatos

Criado por: Guilherme Beltran.

Para rodar o projeto localmente:

1) Alterar os dados em appsettings.json, apontando para a base de dados e subtistuir as configurações do SMTP;
2) Primeiro acesso deve ser feito com usuário: "admin" e senha "123";
3) Alterar o email do usuário "admin" para o email que receberá o email com a nova senha.

# Qual o objetivo deste projeto?
  - Local onde pode ser armazenado uma lista de contatos para um usuário;
  - Cada usuário possui sua lista particular de contatos;
  - Somente os usuários com perfil Administrador podem visualizar/editar os usuários do sistema;
  - Os usuários administradores podem visualizar a quantidade e a lista de contatos de todos os outros usuários.

# Porque foi elaborado desta forma?

  - Este projeto teve como objetivo aplicar conceitos de OO, técnicas avançadas em C#, Asp.Net e EF. Além disso, também foca na manipulação dos dados de forma segura, mostrando que é possível criar sistemas de código limpo, seguros, eficientes e com ótimo desempenho.
  - A regra de negócio é genérica, pode ser alterada a qualquer momento e por quem desejar reutilizar este projeto.
  - As tabelas não são responsivas pois não é o objetivo do projeto. Além disso, foi utilizada a biblioteca jQuery datable.net, que pode ser encontrada em: https://datatables.net/

# O que foi aplicado neste projeto?

  - O projeto foi desenvolvido utilizando as seguintes tecnologias:
    - .Net 6.0;
    - SQL Server 2019;
    - Asp.Net Core;
    - Entity Framework;
    - Html;
    - Css;
    - Bootstrap;
    - Javascript;
    - jQuery;
    - Ajax.

# Quais técnicas C# foram aplicadas?
    - Migration;
    - Sobrecarga de métodos;
    - LINQ;
    - Expressões Lambdas;
    - Autenticação/Autorização;
    - Envio de Email;
    - Classes abstratas;
    - Métodos de extensões;
    - Propriedades automáticas;
    - Tratamento de exceções por tipo;
    - Entre outras.
