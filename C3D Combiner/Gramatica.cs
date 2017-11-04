using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Parsing;
using Irony.Ast;

namespace C3D_Combiner
{
    [Language("Tree", "1.0", "Tree Gramatica , compiladores 2 :'v ")]
    class Gramatica : Grammar
    {

        public Gramatica()
            : base(false)
        {
            // Expresiones regulares se escribe de la siguiente forma
            //existe multiples formas de crear expresiones regulares puedes revisar la documentacion.

            //RegexBasedTerminal Id = new RegexBasedTerminal("Id", "[0-9]*[a-zA-Z][0-9a-zA-Z]*");
            Terminal
            id = new IdentifierTerminal("Id"),
            numDoble = new NumberLiteral("numDoble"),
            caracter = new StringLiteral("caracter", "'", StringOptions.IsChar),
            cadena = new StringLiteral("cadena", "\""),
            verdadero = ToTerm("true"),
            falso = ToTerm("false"),
            suma = ToTerm("+"),
            resta = ToTerm("-"),
            multi = ToTerm("*"),
            div = ToTerm("/"),
            power = ToTerm("pow"),
            abrirparentesis = ToTerm("("),
            cerrarparentesis = ToTerm(")"),
            //aumento = ToTerm("++"),
            //decremento = ToTerm("--"),
            numEntero = new NumberLiteral("numEntero", NumberOptions.IntOnly);


            //Comentarios.            
            CommentTerminal comentarioMulti = new CommentTerminal("comentarioMulti", "{--", "--}");
            CommentTerminal comentarioUni = new CommentTerminal("comentarioUni", "##");

            base.NonGrammarTerminals.Add(comentarioMulti);
            base.NonGrammarTerminals.Add(comentarioUni);


            //Precedencia de operadores

           // RegisterOperators(1,  suma, resta);
            //RegisterOperators(2, div, multi, power);


            //Declaracion de no terminales
            NonTerminal
                INICIO = new NonTerminal("INICIO"),
                VALOR = new NonTerminal("VALOR"),
                OPERADORA = new NonTerminal("OPERADORA"),
                OPARITMETICA = new NonTerminal("OPARITMETICA");

            //S.Rule para escribir el cuerpo de un no terminal con todas sus producciones.

            INICIO.Rule = OPARITMETICA;

            VALOR.Rule = id | numDoble | numEntero | caracter | cadena | verdadero | falso;

            OPERADORA.Rule = suma | resta | multi | div | power;

            OPARITMETICA.Rule = OPARITMETICA + OPARITMETICA + OPERADORA + Eof 
                               | "(" + OPARITMETICA + OPARITMETICA + OPERADORA + ")"  + Eof
                               | "(" + VALOR + ")" + Eof 
                               | VALOR;
                              
                                           

            //indicamos la produccion inicial con la siguiente linea

            this.Root = INICIO;

            
        }

        public override void CreateTokenFilters(LanguageData language, TokenFilterList filters)
        {
            var outlineFilter = new CodeOutlineFilter(language.GrammarData,
              OutlineOptions.ProduceIndents | OutlineOptions.CheckBraces, ToTerm(@"\")); // "\" is continuation symbol
            filters.Add(outlineFilter);
        }


    }
}