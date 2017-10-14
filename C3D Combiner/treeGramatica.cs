using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace C3D_Combiner
{
    class treeGramatica : Grammar
    {

        public treeGramatica()
            : base(false)
        {


            // Expresiones regulares se escribe de la siguiente forma
            //existe multiples formas de crear expresiones regulares puedes revisar la documentacion.
            //Valores
            RegexBasedTerminal id = new RegexBasedTerminal("id", "[0-9]*[a-zA-Z][0-9a-zA-Z]*");
            //RegexBasedTerminal numEntero = new RegexBasedTerminal("numEntero", "[0-9]+");
            //RegexBasedTerminal numDouble = new RegexBasedTerminal("numDouble", "[0-9]+.[0-9]*");
            NumberLiteral numero = new NumberLiteral("NUMBER");
            //RegexBasedTerminal cadenaComillas = new RegexBasedTerminal("cadenaComillas", "\"", "\"");
            //RegexBasedTerminal caracterComillas = new RegexBasedTerminal("caracterComillas", "'", "'");
            StringLiteral cadenaComillas = new StringLiteral("cadenaComillas", "\"");
            StringLiteral caracterComillas = new StringLiteral("caracterComillas", "'");
            

            RegexBasedTerminal abrirParentesis = new RegexBasedTerminal("abrirParentesis","(");
            RegexBasedTerminal cerrarParentesis = new RegexBasedTerminal("cerrarParentesis", ")");
            RegexBasedTerminal coma = new RegexBasedTerminal("coma", ",");
            RegexBasedTerminal suma = new RegexBasedTerminal("suma", "+");
            RegexBasedTerminal resta = new RegexBasedTerminal("resta", "-");
            RegexBasedTerminal multi = new RegexBasedTerminal("multi", "*");
            RegexBasedTerminal div = new RegexBasedTerminal("div", "/");
            RegexBasedTerminal potencia = new RegexBasedTerminal("potencia", "pow");
            RegexBasedTerminal tipoEntero = new RegexBasedTerminal("tipoInt", "entero");
            RegexBasedTerminal tipoDoble = new RegexBasedTerminal("tipoDouble", "doble");
            RegexBasedTerminal tipoCaracter = new RegexBasedTerminal("tipoChar", "caracter");
            RegexBasedTerminal tipoBool = new RegexBasedTerminal("tipoBool", "bool");
            RegexBasedTerminal tipoCadena = new RegexBasedTerminal("tipoString", "cadena");
            RegexBasedTerminal verdadero = new RegexBasedTerminal("verdadero", "true");
            RegexBasedTerminal falso = new RegexBasedTerminal("falso", "false");
            //Verificar si estos deben de ir antes por la precedencia.
            RegexBasedTerminal aumento = new RegexBasedTerminal("aumento", "++");
            RegexBasedTerminal decremento = new RegexBasedTerminal("decremento", "--");
            //Corchets
            RegexBasedTerminal abrirCorchete = new RegexBasedTerminal("abrirCorchete", "[");
            RegexBasedTerminal cerrarCorchete = new RegexBasedTerminal("cerrarCorchete", "]");
            RegexBasedTerminal abrirLlave = new RegexBasedTerminal("abrirLlave", "{");
            RegexBasedTerminal cerrarLlave = new RegexBasedTerminal("cerrarLlave", "}");
            RegexBasedTerminal tabulacion = new RegexBasedTerminal("tabulacion", "\t");
            RegexBasedTerminal salto = new RegexBasedTerminal("salto", "\n");

            //Operaciones relacionales.
            RegexBasedTerminal mayorIgualQue = new RegexBasedTerminal("mayorIgualQue", ">=");
            RegexBasedTerminal menorIgualQue = new RegexBasedTerminal("menorIgualQue", "<=");
            RegexBasedTerminal igualQue = new RegexBasedTerminal("igualQue", "==");
            //RegexBasedTerminal asignacion = new RegexBasedTerminal("asignacion", "==");
            RegexBasedTerminal diferente = new RegexBasedTerminal("diferente", "!=");
            RegexBasedTerminal mayorQue = new RegexBasedTerminal("mayorQue", ">");
            RegexBasedTerminal menorQue = new RegexBasedTerminal("menorQue", "<");
            RegexBasedTerminal asignacion = new RegexBasedTerminal("asignacion", "=>");

            //Operaciones Lógicas
            RegexBasedTerminal and = new RegexBasedTerminal("and", "and");
            RegexBasedTerminal or = new RegexBasedTerminal("or", "or");
            RegexBasedTerminal xor = new RegexBasedTerminal("xor", "xor");
            RegexBasedTerminal not = new RegexBasedTerminal("not", "not");
            //RegexBasedTerminal vector = new RegexBasedTerminal("vector", "vector");


            CommentTerminal comentarioUniLinea = new CommentTerminal("comentarioUniLinea", "##","\n");
            CommentTerminal comentarioMultiLinea = new CommentTerminal("comentarioMultiLinea", "<--", "-->");

            NonGrammarTerminals.Add(comentarioUniLinea);
            NonGrammarTerminals.Add(comentarioMultiLinea);

            //la gramatica siguiente acepta cadenas de entradas de la forma : esto-es-una-lista-de-555-numeros-y-letras-55-61-12-32

            //Declaracion de no terminales

            NonTerminal
                S = new NonTerminal("S"),
                L = new NonTerminal("L"),
                DECLARACION = new NonTerminal("DECLARACION"),
                LISTA_VARIABLES = new NonTerminal("LISTA_VARIABLES"),
                TIPO = new NonTerminal("TIPO"),
                DIMENSION = new NonTerminal("DIMENSION"),
                EXPRESION = new NonTerminal("EXPRESION"),
                VALOR = new NonTerminal("VALOR"),
                OPERACION = new NonTerminal("OPERACION");          
            //S.Rule para escribir el cuerpo de un no terminal con todas sus producciones.
            S.Rule = L;

            OPERACION.Rule = OPERACION + multi + OPERACION
                            | OPERACION + div + OPERACION
                            | OPERACION + potencia + OPERACION
                            | OPERACION + suma + OPERACION
                            | OPERACION + resta + OPERACION
                            | abrirParentesis + OPERACION + cerrarParentesis
                            | VALOR;                            
           /* EXPRESION.Rule = EXPRESION
                             | VALOR;*/

            VALOR.Rule = numero
                         | id
                         |cadenaComillas
                         |caracterComillas;

            DIMENSION.Rule =
                             //DIMENSION 
                             //           |DIMENSION + abrirCorchete + numEntero + cerrarCorchete numEntero +
                             abrirCorchete;

            DECLARACION.Rule = TIPO + LISTA_VARIABLES
                               |TIPO + LISTA_VARIABLES + DIMENSION;

            TIPO.Rule = tipoBool | tipoCaracter | tipoDoble | tipoEntero | tipoCadena;

            LISTA_VARIABLES.Rule =LISTA_VARIABLES 
                                  |LISTA_VARIABLES + coma + id
                                  |id;

            //indicamos la produccion inicial con la siguiente linea
            this.Root = DIMENSION;

            MarkPunctuation("-");
        }
    }
}
