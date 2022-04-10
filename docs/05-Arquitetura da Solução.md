# Arquitetura da Solução
## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

Abaixo segue o artefato "Diagrama de classes" com o <a href="https://lucid.app/lucidchart/1bba0da7-32fe-40fd-8dbf-2c14d4b8db6a/edit?page=0_0&invitationId=inv_65939ec6-47e0-4ec0-bbb8-82891f6fd860#">link</a> para melhor visualização:
![Diagrama de classes1](https://user-images.githubusercontent.com/90878497/162346872-2ed7579c-a2d9-4911-b568-5435ba65a464.jpg)


## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

Abaixo segue o artefato “Modelo ER” :


![Modelo ER](https://user-images.githubusercontent.com/75712250/162596790-5532bb8c-af19-4c08-ba37-3d198e865315.png)




## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
Abaixo o artefato  de “Esquema Relacional”:

![MOdelo relacional](https://user-images.githubusercontent.com/75712250/162597074-f68f00c4-b7c4-4a9a-a48c-88bfb212f2ff.png)



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
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Digitar nome do usuário e senha; Clicar em minhas assinaturas; Clicar em meus documentos; Selecionar documento para envio; Informar o usuário que receberá o documento; Clicar em enviar |
| Critérios de êxito    | Após enviar o documento, verificar se o outro usuário o recebeu corretamente |

| Caso de Teste | CT-06 - Notificar usuário do documento pendente |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-05 - Deve disparar um e-mail informando ao destinatário responsável pela assinatura sobre a alteração do status do documento |
| Objetivo do teste     | Verificar se o e-mail de notificação foi disparado corretamente |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Digitar nome do usuário e senha; Clicar em minhas assinaturas; Clicar em meus documentos; Selecionar documento para envio; Informar o usuário que receberá o documento; Clicar em enviar |
| Critérios de êxito    | Após enviar o documento, verificar se o outro usuário recebeu o e-mail de notificação |

| Caso de Teste | CT-07 - Abrir tíquete para alteração do documento |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-06 - Deve permitir a interação dos usuários por meio da abertura de um tíquete/chamado para alteração das informações contidas no documento, especificando onde é necessário mudar e qual a mudança |
| Objetivo do teste     | Verificar se o e-mail de notificação foi disparado corretamente |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Digitar nome do usuário e senha; Clicar em minhas assinaturas; Clicar em aguardando; Clicar em abrir chamado; Preencher as informações com as sugestões de alteração; Clicar em enviar |
| Critérios de êxito    | Após enviar o chamado aos envolvidos na assinatura, verificar sem todos receberam a notificação por e-mail |

| Caso de Teste | CT-08 - Registrar data e hora nas interações |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-07 - Deve registrar as informações de data/hora das interações de forma automática |
| Objetivo do teste     | Verificar se as informações de data/hora estão sendo salvas a cada interação entre os usuários |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Digitar nome do usuário e senha; Clicar em minhas assinaturas; Clicar em meus documentos; Selecionar documento para envio; Informar o usuário que receberá o documento; Clicar em enviar |
| Critérios de êxito    | Após qualquer interação entre os usuários por meio de assinatura, envio de documentos ou abertura de chamado, a data e hora deverão ficar registradas no documento |

| Caso de Teste | CT-09 - Definir plano de assinaturas |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-08 - Deve permitir que o usuário administrador altere/escolha o pacote que mais se adeque ao momento |
| Objetivo do teste     | Verificar se o plano escolhido condiz com a quantidade de assinaturas do cliente |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em novo usuário; Preencher com os dados pessoais; Clicar em cadastrar; Digitar e-mail novamente; Enviar e-mail para confirmação; Abrir e-mail em outra aba do navegador; Clicar no e-mail de confirmação recebido; Coletar código recebido; Retornar ao site; Digitar código recebido; Escolher plano de assinatura; Verificar quantidade de assinaturas no perfil |
| Critérios de êxito    | Após escolher o plano de assinaturas, a quantidade escolhida deve condizer com a quantidade disponível |

| Caso de Teste | CT-10 - Alterar pacote de assinaturas |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-08 - Deve permitir que o usuário administrador altere/escolha o pacote que mais se adeque ao momento |
| Objetivo do teste     | Verificar se a alteração feita no plano de assinaturas condiz com a quantidade de assinaturas do cliente |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Clicar em editar perfil; Clicar em alterar plano; Escolher novo plano de assinaturas; Salvar alterações |
| Critérios de êxito    | Após escolher o novo plano de assinaturas, a quantidade escolhida deve condizer com a quantidade disponível |

| Caso de Teste | CT-11 - Alterar pacote de assinaturas |
|-----------------------|----------------------------------------------------------------------|
| Requisitos associados | RF-09 - Deve permitir que o usuário administrador altere as permissões dos demais usuários |
| Objetivo do teste     | Verificar se as alterações feitas pelo usuário administrador no usuário comum foram realizadas |
| Passos                | Acessar o navegador; Informar endereço do site; Clicar em login; Clicar em editar perfil; Clicar em alterar perfil de usuário; Selecionar as funcionalidades desejadas; Salvar alterações |
| Critérios de êxito    | Após alterar as funcionalidades do usuário comum, o usuário deverá agir conforme suas permissões |


