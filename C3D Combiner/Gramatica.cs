using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace C3D_Combiner
{
    class Gramatica : Grammar
    {

        public Gramatica()
            : base(false)
        {


            // Expresiones regulares se escribe de la siguiente forma
            //existe multiples formas de crear expresiones regulares puedes revisar la documentacion.

            RegexBasedTerminal palabra = new RegexBasedTerminal("palabra", "[0-9]*[a-zA-Z][0-9a-zA-Z]*");
            RegexBasedTerminal numero = new RegexBasedTerminal("numero", "[0-9]+");
            CommentTerminal comm = new CommentTerminal("comm", "\n", "\r");

            base.NonGrammarTerminals.Add(comm);

            //la gramatica siguiente acepta cadenas de entradas de la forma : esto-es-una-lista-de-555-numeros-y-letras-55-61-12-32

            //Declaracion de no terminales

            NonTerminal
                S = new NonTerminal("S"),
                L = new NonTerminal("L");

            //S.Rule para escribir el cuerpo de un no terminal con todas sus producciones.

            S.Rule = L;

            L.Rule = L + "-" + numero
                    | numero
                    | L + "-" + palabra
                    | palabra;


            //indicamos la produccion inicial con la siguiente linea

            this.Root = S;

            MarkPunctuation("-");
        }
    }
}
