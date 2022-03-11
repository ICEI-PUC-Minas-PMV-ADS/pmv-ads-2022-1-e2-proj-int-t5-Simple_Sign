# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição do problema e os pontos mais relevantes a serem tratados neste projeto foi sugerido necessidade do público-alvo em agilizar suas assinaturas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

 ### Amanda Pinheiro

![Amanda](img/AmandaPinheiro.png)


 ### Rodrigo Souza Lima

![Rodrigo](img/RodrigoSouza.png)


 ### Patricia Gonçalves

![Patricia](img/PatriciaGolcalves.png)


 ### Leticia Prado

![Leticia](img/LeticiaPrado.png)


 ### Julia Takahashi

![Julia](img/JuliaTakahashi.png)




## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Amanda              | Visualizar documentos pendentes de assinatura          | Otimizar meu tempo |
|Amanda              | Visualizar os documentos já assinados                 | Para gerenciar as demanda |
|Rodrigo             | Enviar os documentos a serem assinados para vários clientes                 | economizar tempo e dinheiro |
|Rodrigo             | Receber alerta de documentos pendentes           | Controlar a o processo               |
|Rodrigo             | Poder arquivar os documentos assinados                  | Economizar papéis |
|Patricia            | Assinar vários documentos online                | Não precisar me locomover |
|Leticia             | Baixar os documentos assinados           | Facilitar o trabalho               |
|Julia               | Postar vários documentos                 | Melhorar qualidade na demanda |
|Julia               | Enviar os documentos através de emails                  | Facilitar o processo |



## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

![caso_de_uso_ss](https://user-images.githubusercontent.com/82836965/157964087-ee8bf36d-0938-475c-8d3e-5a5b9784f934.png)
