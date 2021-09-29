using System;
using System.Collections.Generic;
using Curso_Csharp.EstruturaDeControle;
using Curso_Csharp.fundamentos;
using Curso_Csharp.classes_e_metodos;
using Curso_Csharp;
using Curso_Csharp.Colecao;
using Curso_Csharp.Poo;
using Curso_Csharp.MetodoEfuncao;
using Curso_Csharp.Excecoes;
using Curso_Csharp.API;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"comentariosDeCodigos - Fundamentos", comentatiosDeCodigo.Exetutar},
                {"variaveisEConstantes - Fundamentos", variaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"interpolacao - Fundamentos", interpolacao.Executar},
                {"notacaoPonto - Fundamentos", notacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"conversoes - Fundamentos", Conversoes.Executar},
                {"operadores Aritmeticos - Fundamentos", operadoresAritmeticos .Executar},
                {"operadores Relacionais - Fundamentos", operadoresRelacionais .Executar},
                {"Operadores logicos - Fundamentos", Operadores_logicos .Executar},
                {"Operador Atribuicao - Fundamentos", OperadorAtribuicao .Executar},
                {"Operadores Unarios - Fundamentos",OperadoresUnarios .Executar},
                {"Operador Tenario - Fundamentos",OperadorTenario .Executar},
               
                // Estrutura de controles
                {"Estrutura If- Fundamentos",EstruturaIf .Executar},
                {"Estrutura If Else- Fundamentos",EstruturaIfElse .Executar},
                {"Estrutura If Else If- Fundamentos",EstruturasIfElseIf.Executar},
                {" Estrutura Swich - Fundamentos", EstruturaSwich .Executar},
                {" Estrutura While - Fundamentos", EstruturaWhile .Executar},
                {" estrutura Do While - Fundamentos", estruturaDoWhile .Executar},
                {"estruturaFor - Fundamentos",  estruturaFor .Executar},
                {"Estrutura For Each - Fundamentos",  EstruturaForEach .Executar},
                {"UsandoBreak- Fundamentos",  UsandoBreak .Executar},
                {"UsandoContinue- Fundamentos",  UsandoContinue .Executar}, 
               
                // classes e metodos
                {"membros- Classes e Metodos",  membros .Executar},
                {"construtores-Classes e Metodos",  construtores.Executar},
                {"metodos Com Retorno", metodosComRetorno.Executar},
                {"Metodo Estatico", MetodoEstatico.Executar},
                {"Atributo Estatico", AtributosEStaticos.Executar},
                {"Desafio Atributo", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", @params.Executar},
                {"Paramestros Nomeados - Classes e Metodos",parametrosNomeados.Executar},
                {"Getters and Setters Nomeados - Classes e Metodos",  GetSet.Executar},
                {"props - Classes e Metodos", props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"exemplo Enum - Classes e Metodos", exemploEnum.Executar},
                {"Exemplo Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Classe VS struct - Classes e Metodos", StructVSClasse.Executar},
                {"Valor VS Referencia - Classes e Metodos", ValorVSReferencia.Executar},
                {"Parametros por Referencia - Classes e Metodos",  ParametrosPorReferencia.Executar},
                {"Parametros com Valor padrão - Classes e Metodos",  ParametroComValorPadrao.Executar},
                //Colecão
                {"Array - colecao",  Curso_Csharp.Colecão.Array.Executar},
                {"list - colecao",    ColecoesList.Executar},
                {"Colecao Array List - colecao",   ColecaoArrayList.Executar},
                {" Set - colecao",    ColecoesSet.Executar},
                {" Colecao Queue - colecao",    ColecoesQueue.Executar},
                {" Igualdade - colecao",    igualdade.Executar},
                {" stak  -colecao",    colecaoStack.Executar},
                {" Dictionary -colecao",    ColecoesDictionary.Executar},
                    // OO
                {" Heranca - OO",    Heranca.Executar},
                {" construtor THIS() - OO",    ConstrutorThis.Executar},
                {" Encapsulamento - OO",   Curso_Csharp.Poo.Encapsulamento.Executar},
                {" Polimorfismo - OO",   Curso_Csharp.Poo.Polimorfismo.Executar},
                {" Abstract - OO",   Curso_Csharp.Poo.Abstract.Executar},
                {" Interface - OO",   Curso_Csharp.Poo.Interface.Executar},
                {"Selead - OO",   Curso_Csharp.Poo.Selead.Executar},
               // Metodo E funcoes
                {"Exemplo Lambida - Metodos e funcoes",    ExemploLambda.Executar},
                {"Lambda como Delegantes - Metodos e funcoes",    lambdaDelegates.Executar},
                {"Usando Delegantes - Metodos e funcoes",    UsandoDelegates.Executar},
                {" Delegante com funcao anonima - Metodos e funcoes",    DelegateFunAnonima.Executar},
                {" Delegante como parametros- Metodos e funcoes",     DelegatesComoParametros.Executar},
                {" Estudos - Metodos e funcoes",     Estudos.Executar},
                {" Metodos de Extensao",     MetodosDeExtensao.Executar},
                // Excecoes
                {" Primeria Execao - Execoes",   PrimeiraExcecao.Executar},
                {" Execaoes Personalizadas - Execoes",   ExcecoesPersonalizadas.Executar},
                //API
                 {" Primeiro Arquivo - Usando API",   PrimeiroArquivo.Executar},
                 {" Lendo Arquivo - Usando API",  LendoArquivos.Executar},



            }); ;

            central.SelecionarEExecutar();
        }
    }
}