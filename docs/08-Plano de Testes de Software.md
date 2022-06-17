# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
* Site publicado na Internet
* Navegador da Internet - Chrome, Firefox ou Edge
* Conectividade de Internet para acesso às plataformas (APISs)
Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

| Caso de Teste 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema permitirá que usuários se cadastrem |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na plataforma Simple Sign. |
| Passos 	| - Acessar o navegador - Informar o endereço do site <br> - Clicar em "cadastrar" <br> - Preencher os campos obrigatórios (nome, e-mail, CPF, senha) <br> - Clicar em "cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-02  Efetuar login**	|
|Requisito Associado | RF-002	- O sistema permitirá que usuários efetuem o login |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste | **CT-03 – Recuperação de senha** |
|Requisito Associado | RF-003 - O sistema deve permitir que o usuário cadastre uma nova senha caso o mesmo esqueça a atual.	|
|Objetivo do Teste | Verificar se o usuário consegue criar uma nova senha. |
|Passos | - Acessar o navegador <br> - Informar o endereço do site <br> - - Clicar em "Redefinir Senha" <br> Preencher o campo de CPF <br> -  Preencher o campo do e-mail <br> - Clicar em "Redefinir Senha" |
|Critério de Êxito | - O usuário consegue uma nova senha.  |
|  	|  	|
| Caso de Teste 	| **CT-04  Criar um novo contato**	|
|Requisito Associado | RF-004	- Deve permitir que o usuário cadastre um novo contato. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar um novo contato. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> -Na página inicial clicar em "Contatos" <br> Preencher os campos necessários <br> clicar em "Adicionar" |
|Critério de Êxito | - O novo contato foi criado com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-05  Editar um contato**	|
|Requisito Associado | RF-005	- Deve permitir que o usuário edite um contato. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar um contato. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> -Na página inicial clicar em "Contatos" <br> Clicar em "Editar" <br> Preencher os campos que deseja alterar <br> clicar em "Alterar" |
|Critério de Êxito | - O contato foi atualizado com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-06  Apagar um contato**	|
|Requisito Associado | RF-006	- Deve permitir que o usuário apague um contato. |
| Objetivo do Teste 	| Verificar se o usuário consegue apagar um contato. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> -Na página inicial clicar em "Contatos" <br> Clicar em "Apagar" <br> Clicar em "Confirmar exclusão"  |
|Critério de Êxito | - O contato foi apagado com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-07  Direcionar documentos para outros usuários**	|
|Requisito Associado | RF-007	- Deve permitir que os documentos armazenados sejam direcionados a outros usuários para assinatura. |
| Objetivo do Teste 	| Verificar se o usuário consegue direcionar documentos armazenados para outros usuários assinarem. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Na página inicial clicar em "Arquivos" <br> Clicar em "Direcionar documento" <br> Clicar em "Direcionar documento para assinatura"  |
|Critério de Êxito | - O documento foi enviado para assinatura com sucesso. |

| Caso de Teste 	| **CT-08  Disparar e-mail informando alteração de Status do Documento**	|
|Requisito Associado | RF-008	- Deve disparar um e-mail informando ao destinatário responsável pela assinatura sobre a alteração do status do documento. |
| Objetivo do Teste 	| Verificar se foi enviado ao destinatário que assinará o documento, um em-mail informando sobre a alteração de status do documento. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Na página inicial clicar em "Arquivos" <br> Clicar em "Direcionar documento" <br> Clicar em "Direcionar documento para assinatura" <br> Quando o documento for direcionado, o sistema enviará um email ao destinatário informando alteração do status do documento. |
|Critério de Êxito | - O e-mail foi enviado com sucesso. |

| Caso de Teste 	| **CT-09  Disparar e-mail informando alteração de Status do Documento**	|
|Requisito Associado | RF-009	- Deve permitir a interação dos usuários por meio da abertura de um tíquete/chamado para alteração das informações contidas no documento, especificando onde é necessário mudar e qual a mudança. |
| Objetivo do Teste 	| Verificar se foi enviado ao destinatário que assinará o documento, um em-mail informando sobre a alteração de status do documento. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de CPF <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Na página inicial clicar em "Arquivos" <br> Clicar em "Direcionar documento" <br> Clicar em "Direcionar documento para assinatura" <br> Quando o documento for direcionado, o sistema enviará um email ao destinatário informando alteração do status do documento. |
|Critério de Êxito | - O e-mail foi enviado com sucesso. |