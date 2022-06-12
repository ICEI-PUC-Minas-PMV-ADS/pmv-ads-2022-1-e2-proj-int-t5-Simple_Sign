

# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Nesta sessão serão apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema. O respectivo endereço (URL) e outras orientações serão apresentadas na sequência.

### Landing Page (RNF - 001, 002, 003, 004)

A Landing page apresenta os botões necessários para a navegação do usuário por todo o site. Um exemplo da tela é apresentado na imagem abaixo:

![Landing page unit](https://user-images.githubusercontent.com/90660755/173153864-40e3895c-c037-4e3d-a33f-5764b24ab7f2.jpeg)


#### Requisitos atendidos
* RNF-001 - Deve ser publicado em um ambiente acessível (Repl.it, GitHub Pages, Heroku.
* RNF-002 - Deve ser responsivo permitindo a visualização em qualquer dispositivo.
* RNF-003 - Deve ter um design simples e autoexplicativo.
* RNF-004 - Deve ser compatível com os principais navegadores do mercado.

#### Artefatos de funcionalidade

* index.html
* style.css

#### Estrutura de dados

[Landing Page](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-Simple_Sign/tree/main/src/landing%20page)




#### Instruções de acesso

1. Abra um navegador de Internet e informe a URL: https://simplesignproject.azurewebsites.net/
2. Abrirá a Landing Page.


### Página de Login (RF-001)

A tela Página de Login apresenta os campos necessários para validar o acesso do usuário à sua conta previamente criada. Os dados serão salvos em banco de dados criado no SQLServer. Um exemplo da tela é apresentado na imagem abaixo:

![login](https://user-images.githubusercontent.com/90660755/173146011-26a4f73c-ff50-4013-84bd-eb9c44a99024.jpeg)

#### Requisitos atendidos
* RF-001 - O sistema permitirá que usuários efetuem o login

#### Artefatos de funcionalidade
* ViewImports.cshtml
* ViewStart.cshtml
* LoginModel.cs

#### Estrutura de dados

[Tela de Login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-Simple_Sign/blob/main/src/Projeto%20SimpleSign/Views/Login/Index.cshtml)

#### Instruções de acesso

1. Abra um navegador de Internet e informe a URL: https://simplesignproject.azurewebsites.net/Login/Index
2. Abrirá a página de login.

### Página de Cadastro (RF-002)

A tela de Cadastro de apresenta os campos necessários para o usuário cadastrar uma conta. Os dados serão salvos em banco de dados criado no SQLServer. Um exemplo da tela é apresentado na imagem abaixo:

![Cadastro](https://user-images.githubusercontent.com/90660755/173247195-9b973f86-9352-4e8e-b8f3-f9e07e176356.png)


#### Requisitos atendidos
* RF-002 - O sistema permitirá que usuários se cadastrem

#### Artefatos de funcionalidade
* tela_de_cadastro.css
* tela_de_cadastro.html

#### Estrutura de dados

[Tela de Cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-Simple_Sign/tree/main/src/Tela%20de%20cadastro)

#### Instruções de acesso

1. Abra um navegador de Internet e informe a URL: https://simplesignproject.azurewebsites.net/Usuario/Criar
2. Abrirá a página de login.


### Lista de Contatos

A tela Lista de Contatos permite que sejam cadastrados os dados de contato dos usuários que utilizarão o sistema.

#### Artefatos de funcionalidade
* 

#### Estrutura de dados


#### Instruções de acesso


### Lista de Usuários (RF-009)

A tela Lista de Usuários permite que sejam cadastrados os perfis de cada usuário que fará uso do sistema.

#### Requisitos atendidos
* RF-009 - Deve permitir que o usuário administrador altere as permissões dos demais usuários

#### Artefatos de funcionalidade
*

#### Estrutura de dados


#### Instruções de acesso


