// 10 - O que é um nullable type e qual a sua utilidade ?

// Resposta:
/*
É um tipo de dado criado para possibilitar a inserção de valores nulos dentro de uma variável.

Sua sintaxe é:
    Nullable<tipo de dado> nomeVariável = valor[null ou não];

Podemos simplificara  escrita com essa sintaxe:
    TipoDeDado? NomeVariável = valor[null ou não];
O sinal de ? faz essa simplificação

Os valores do tipo Nullable não podem ser passado para variáveis com tipos de dados comuns, apenas atráves de uma operação que em caso de haver valores em null ele será passado 
 
 */