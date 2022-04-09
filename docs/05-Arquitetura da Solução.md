# Arquitetura da Solução
## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

Abaixo segue o artefato "Diagrama de classes" com o <a href="https://lucid.app/lucidchart/1bba0da7-32fe-40fd-8dbf-2c14d4b8db6a/edit?page=0_0&invitationId=inv_65939ec6-47e0-4ec0-bbb8-82891f6fd860#">link</a> para melhor visualização:
![Diagrama de classes1](https://user-images.githubusercontent.com/90878497/162346872-2ed7579c-a2d9-4911-b568-5435ba65a464.jpg)


## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

Abaixo segue o artefato “Modelo ER” :



![Modelo ER](https://user-images.githubusercontent.com/75712250/162589066-1bbaec46-c618-4541-8f95-0656c86a44a8.png)




## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
Abaixo o artefato  de “Esquema Relacional”:



![MOdelo relacional](https://user-images.githubusercontent.com/75712250/162589524-5b5a7cb8-970d-475f-80c3-f87bb2d7e563.png)


## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

## Plano de Testes de Software

Os requisitos para realização dos testes de software são:
* Site publicado na Internet
* Navegador da Internet - Chrome, Firefox ou Edge
* Conectividade de Internet para acesso às plataformas (APISs)
Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

| Caso de Teste | CT-01 - Criar novo perfil de usuário |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-01 - Deve permitir que os usuários gerenciem um perfil com dados pessoais |
| Objetivo do teste     | Verificar se é possível criar um perfil de usuário |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em novo usuário; Preencher com os dados pessoais; Clicar em cadastrar; Digitar e-mail novamente; Enviar e-mail para confirmação; Abrir e-mail em outra aba do navegador; Clicar no e-mail de confirmação recebido; Coletar código recebido; Retornar ao site; Digitar código recebido; Escolher plano de assinatura; Fazer upload da assinatura ou Acessar o navegador; Informar endereço do site; Clicar em login; Clicar em editar perfil; Salvar alterações |
| Critérios de êxito    |Após o cadastro de novo usuário, o site será direcionado para a página do perfil; Aparecerá um menu com as opções de gestão dos documentos|

| Caso de Teste | CT-02 - Editar perfil de usuário |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-01 - Deve permitir que os usuários gerenciem um perfil com dados pessoais |
| Objetivo do teste     | Verificar se é possível editar um perfil de usuário |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Clicar em editar perfil; Salvar alterações |
| Critérios de êxito    | Após salvar as alterações, o site retornará à página do perfil com os dados atualizados |

| Caso de Teste | CT-03 - Filtrar documentos |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-02 - Deve possuir filtros para parametrizar a busca dos documentos armazenados |
| Objetivo do teste     | Verificar se é possível realizar um filtro por nome ou tipo de documento |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Digitar nome do usuário e senha; Clicar em domentos assinados; Preencher os dados da busca |
| Critérios de êxito    | O site deve carregar automaticamente os documentos que contenham as palavras pesquisadas |

| Caso de Teste | CT-04 - Categorizar documentos |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-03 - Deve permitir fazer upload dos documentos e armazená-los em sua conta, classificando-os pelo seu respectivo tipo |
| Objetivo do teste     | Verificar se é possível salvar um documento categorizando-o por tipo |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Digitar nome do usuário e senha; Clicar em novo documento; Clicar em publicar documentos; Clicar em selecionar um arquivo; Selecionar o tipo de documento |
| Critérios de êxito    | Após o cadastro do documento, deve-se visualizar as informações do mesmo, inclusive sua categoria |

| Caso de Teste | CT-05 - Enviar para assinatura |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-04 - Deve permitir que os documentos armazenados sejam direcionados a outros usuários para assinatura |
| Objetivo do teste     | Verificar se o documento foi direcionado para outro usuário assinar |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Digitar nome do usuário e senha; Clicar em meus documentos; Selecionar documento para envio; Informar o usuário que receberá o documento; Clicar em enviar |
| Critérios de êxito    | Após enviar o documento, verificar se o outro usuário o recebeu corretamente |



> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
