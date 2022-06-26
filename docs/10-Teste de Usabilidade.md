# Plano de Testes de Usabilidade

Testes de funcionalidades e regras de negócios avaliam o funcionamento da ferramenta e sua aderência aos requisitos e especificações definidas na fase de planejamento do sistema. Testa-se, para cada componente, se o sistema responde corretamente às solicitações realizadas. 

O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação interativa, utilizandi uma avaliação por observação. Por meio dele, são recolhidos dados sobre comportamento, medindo e considerando as reações dos usuários diante de diferentes layouts e funcionalidades. Após sua realização, uma análise de usabilidade e das principais dificuldades é efetuada para realizar melhorias na plataforma, proporcionando uma melhor experiência ao usuário.

O planejamento dos testes de usabilidade a serem realizados com usuários são descritos a seguir: Requisitos do teste; Método utilizado; Ojetivos do teste de usabilidade;  Roteiro detalhado das tarefas que foram desempenhadas pelos usuários. A seguir, estão listados os parâmetros do Plano de Teste de Usabilidade adotado para aplicação SimpleSign.

Para o projeto em questão, realizaremos o modelo de Testes Remotos Não Moderados de Usabilidade.

### Testes Remotos Moderados de Usabilidade

Esse é o tipo de teste de usabilidade que costuma ser realizado online. Por conta disso, o investimento também é menor. Nele os participantes realizam os estudos diretamente em seus próprios dispositivos, como tablets, smartphones e notebooks.

### Vantagens em fazer testes de usabilidade à distância

A velocidade do desenvolvimento não é prejudicado, principalmente quando o time trabalha com ciclos contínuos de entrega, a flexibilidade do teste remoto facilita a cadência de entregas:
-	Conseguir fazer testes de usabilidade mesmo de home office.
-	O custo de retribuição oferecido é menor pois o entrevistado não terá custo e nem perde tempo no deslocamento.
-	O entrevistado continua no seu ambiente natural.
-	Conseguir testar 100% dos projetos até pequenas melhorias, trazer pessoas até a empresa para testar uma única funcionalidade.

### Objetivos do teste:

- Descoberta de problemas
  > Seu objetivo é identificar e corrigir eventuais problemas existentes na plataforma e averiguar quais são os obstáculos para a fluida utilização da aplicação.
- Teste de aprendizado
  > O modelo adotado será o de teste de experimentação, por meio do qual, para realizar uma tarefa específica, uma pessoa que lida com a ferramenta pela primeira vez terá que começar do zero.

### Perguntas que a avaliação visa responder:

- Os usuários conseguem transitar entre os principais módulos do sistema?
- O tempo de resposta causa erros ou frustração?
- As telas refletem o modelo conceitual do usuário?
- Que obstáculos impedem que as tarefas sejam concluídas?

### Perfil do usuário:

Serão selecionados os usuários de acordo com as personas definidas na metodologia do trabalho, sendo elas, pessoas que poosuem gostos por leitura e possuem algumas das características citadas nas personas e história de usuários como, pessoa aposentada, pessoa com deficiência visual, idosa, escritora e estudante.

### Procedimento de teste

- Recepção do participante e explicações sobre o termo de consentimento livre e esclarecido (TCLE);
- Orientação sobre o teste: objetivo; garantia de anonimato; forma de observação (registro de áudio/vídeo/anotações);
- Teste: cenários de tarefas, o que será medido;
- *Debriefing* do participante: entrevista pós-test, ecomentários gerais sobre o produto / preferências.

### Requisitos  do ambinete/equipamento de teste

Os requisitos para realização dos testes são:

- Conectividade de internet por dados móveis ou por banda larga;
- Navegador da internet - Chrome, Firefox, Safari ou Edge;
- Disponibilidade do usuário em acessar ferramentas de videoconferência com compartilhamento de tela - Zoom, Google Meet, Teams, Webcam.


### Método utilizado: Observação direta, medição e Avaliação

O teste terá cinco participantes que irão avaliar o desempenho e a interação do site, de acordo com as necessidades que correspondem com a finalidade da aplicação e com sugestões de melhorias.

Os participantes terão como responsabilidade, analisar da forma mais eficiente um conjunto de tarefas, a eles desempenhados e fornecer feedback sobre a usabilidade da aplicação.

Para cada tarefa do participante é possível medir:

- Eficácia
> Conclusão de tarefas sem erro<br>
> Conclusão de tarefa com erro (não crítico)<br>
> Erros críticos<br>
> Quantidade de cliques ou toques errados<br>
> Freqüência de pedido de ajuda<br>
- Eficiência
> Tempo de execução da tarefa<br>
> Tempo utilizado na primeira tentativa x segunda tentativa<br>
- Satisfação - serão avaliados através de escala 1 a 5
> Satisfação ao realizar uma tarefa<br>
> Satisfação geral do teste

### Tarefas a serem observadas: Observação direta, medição e Avaliação

Seguem as tarefas a serem executadas pelos participantes e observadas


| **Caso de Teste** 	| **CTU-01 – Cadastro de usuário** 	|
|:---:	|:---:	|
| **Perfil** 	| Usuário (todos)	|
| **Objetivo do Teste** 	| Avaliar a tela de cadastro de novo usuário 	|
| **Ações necessárias** 	| 1. Acessar a primeira tela do site pelo browser;<br>2. Clicar na opção “Criar Conta”;<br>3. Preencher os campos necessários do formulário;<br>4. Navegar pelo fluxo de cadastro seguindo os passos orientados na tela e clicar em “Salvar". 	|
|  	|  	|
| **Caso de Teste** 	| **CTU-02 – Login de usuário** 	|
| **Perfil** 	| Usuário (todos) 	|
| **Objetivo do Teste** 	| Avaliar a usabilidade da tela de Login 	|
| **Ações necessárias** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Visualizar a página de login;<br>4. Preencher CPF no campo indicado;<br>5. Preencher senha no campo indicado;<br>6. Clicar em ‘Entrar’. 	|
|  	|  	|
| **Caso de Teste** 	| **CTU-03 – Recuperar senha** 	|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Analisar a função de recuperação de senha 	|
| **Ações necessárias** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Clicar em recuperar senha;<br>4. Digitar dados;<br>5. Ir ao e-mail informado;<br>6. Copiar senha enviada;<br>7. retornar a pagina de login e efetuar login.	|
|  	|  	|
| **Caso de Teste** 	| **CTU-04 – Tela Funcionalidades - Dashboard**|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Avaliar a tela de funcionalidades do usuário 	|
| **Passos** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Visualizar a página principal;<br>4. Clicar em Entrar;<br>5. Preencher CPF e a senha ou login Social;<br>6. Verificar a página principal do perfil em Minha Conta. 	|
|  	|  	|
| **Caso de Teste** 	| **CTU-05 – Tela Funcionalidades + Exibição de documentos** 	|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Avaliar a tela de exibição de documentos 	|
| **Passos** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Visualizar a página principal;<br>4. Clicar em Entrar;<br>5. Verificar se a página exibe uma lista de documentos preeexistente. 	|
|  	|  	|
| **Caso de Teste** 	| **CTU-06 – Importar Documentos** 	|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Avaliar a funcionalidade de Importar Documentos 	|
| **Passos** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Visualizar a página principal;<br>4. Clicar em Entrar;<br>5. Na tela Funcionalidades do Usuário, Importar Arquivos;<br>6. Clicar no botão  e selecionar o arquivo;<br>7. Clicar em enviar"; <br>8. Ser direcionado para tela de exibição de arquivos. 	|
|  	|  	|
| **Caso de Teste** 	| **CTU-07 – Tela Funcionalidades + Adiconar contato** 	|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Avaliar a tela cadastro de contatos	|
| **Passos** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Visualizar a página principal;<br>4. Clicar em Entrar;<br>5. Clicar em Contatos; <br>6. Clicar em adicionar; <br>7.Colocar dos dados solicitados; <br>8. verificar  na lista se contato foi adiconado com sucesso. 	|
|  	|  	|
| **Caso de Teste** 	| **CTU-08 – Tela Funcionalidades + Editar contato** 	|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Avaliar a tela edição  de contatos	|
| **Passos** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Visualizar a página principal;<br>4. Clicar em Entrar;<br>5. Clicar em Contatos; <br>6. visualizar lista de contatos; <br>7. Clicar em editar Contatos;<br>8. Alterar dados do Contato;<br>9. Visializar na lista se foi alterado com sucesso;|
|    |    |
| **Caso de Teste** 	| **CTU-09 – Tela Funcionalidades + Excluir Contatos** 	|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Avaliar a tela exclusão de contatos 	|
| **Passos** 	| 1. Acessar o Navegador;<br>2. Informar o endereço do Site;<br>3. Visualizar a página principal;<br>4. Clicar em Entrar;<br>5. Clicar em Contatos; <br>6. visualizar lista de contatos; <br>7. Clicar em exluir Contato;<br>8. Confirmar exlusão;<br>9. Visializar na lista se foi exluido com sucesso;|
|   |    |
| **Caso de Teste** 	| **CTU-10 – Verificar se o sistema é responsivo** 	|
| **Perfil** 	| Usuário 	|
| **Objetivo do Teste** 	| Avaliar se a aplicação é responsiva nos navegadores Chrome, Firefox, Edge, Safari e smartphones android e IOS 	|
| **Passos** 	| 1. Acessar o navegador;<br>2. Informar o endereço do Site;<br>3. Realizar o login;<br>4. Percorrer as páginas e funcionalidades da aplicação;<br>5. Verificar se as informações estão ordenadas de uma forma clara na tela. 	|


## Análise do teste e resultados

A análise do resultado do teste de usabilidade à distância deve ser igual ao de um teste presencial, para registro será utilizada uma planilha conforme exemplo abaixo:

| **Usuário** 	| **Artefato** 	| **Tempo** | **Clicks/Ações** | **Qtd. Erros** | **Se recuperou do erro** | **Comentários e observações** |
| --- 	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 1	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 2 | --- 	| --- | ---  | --- | --- | --- |
| Usuário 3	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 4	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 5	| --- 	| --- | ---  | --- | --- | --- |

| **Usuário** 	| **Artefato** 	| **Tempo** | **Clicks/Ações** | **Qtd. Erros** | **Se recuperou do erro** | **Comentários e observações** |
| --- 	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 1	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 2 | --- 	| --- | ---  | --- | --- | --- |
| Usuário 3	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 4	| --- 	| --- | ---  | --- | --- | --- |
| Usuário 5	| --- 	| --- | ---  | --- | --- | --- |


