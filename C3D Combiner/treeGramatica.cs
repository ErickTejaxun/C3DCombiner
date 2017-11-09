using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace C3D_Combiner
{
    class treeGramatica : Grammar
    {
        public treeGramatica() : base(false)
        {
            CommentTerminal comentarioSimple = new CommentTerminal("comentarioSimple", "##", "\n", "\r\n");
            CommentTerminal comentarioMulti = new CommentTerminal("comentarioMulti", "{--", "--}");

            base.NonGrammarTerminals.Add(comentarioMulti);
            base.NonGrammarTerminals.Add(comentarioSimple);

            RegexBasedTerminal DosPuntos = new RegexBasedTerminal("DosPUntos", ":");


            //reservadas
            RegexBasedTerminal importar = new RegexBasedTerminal("importar", "importar ");
            //RegexBasedTerminal super = new RegexBasedTerminal("super", "super");
            var super = ToTerm("super");
            //RegexBasedTerminal sobreescribir = new RegexBasedTerminal("sobreescribir", "\\/\\*\\*Sobreescribir\\*\\*\\/");
            //var sobreescribir = ToTerm("\\/\\*\\*Sobreescribir\\*\\*\\/");
            var sobreescribir = ToTerm("/**Sobreescribir**/");
            var constructor = ToTerm("__constructor");
            RegexBasedTerminal metodo = new RegexBasedTerminal("metodo", "metodo");
            RegexBasedTerminal funcion = new RegexBasedTerminal("funcion", "funcion");
            RegexBasedTerminal clase = new RegexBasedTerminal("clase", "clase");
            RegexBasedTerminal retornar = new RegexBasedTerminal("retornar", "retornar ");
            RegexBasedTerminal imprimir = new RegexBasedTerminal("imprimir", "imprimir\\[");
            RegexBasedTerminal Rself = new RegexBasedTerminal("Rself", "self");
            //RegexBasedTerminal Rsi = new RegexBasedTerminal("Rsi", "SI ");
            var Rsi = ToTerm("SI");
            var nuevo = ToTerm("nuevo");
            //RegexBasedTerminal Rsino = new RegexBasedTerminal("Rsino", "SI_NO ");
            var Rsino = ToTerm("SI_NO");
            //RegexBasedTerminal Rsinosi = new RegexBasedTerminal("Rsinosi", "SI_NO_SI ");
            var Rsinosi = ToTerm("SI_NO_SI");
            //RegexBasedTerminal Rsalir = new RegexBasedTerminal("Rsalir", "salir ");
            var Rsalir = ToTerm("salir");
            //var Rsalir = ToTerm("salir ");
            RegexBasedTerminal Relegir = new RegexBasedTerminal("Relejir", "ELEGIR CASO ");
            RegexBasedTerminal Rcontinuar = new RegexBasedTerminal("Rcontinuar", "CONTINUAR ");
            //RegexBasedTerminal Rmientras = new RegexBasedTerminal("Rmientras", "MIENTRAS ");
            var Rmientras = ToTerm("mientras");
            //RegexBasedTerminal Rhacer = new RegexBasedTerminal("Rhacer", "HACER ");
            var Rhacer = ToTerm("hacer");
            RegexBasedTerminal Rrepetir = new RegexBasedTerminal("Rrepetir", "REPETIR ");
            RegexBasedTerminal Rhasta = new RegexBasedTerminal("Rhasta", "HASTA ");
            //RegexBasedTerminal RPara = new RegexBasedTerminal("Rpara", "Para");
            var RPara = ToTerm("Para");
            RegexBasedTerminal Rloop = new RegexBasedTerminal("Rloop", "loop ");
            RegexBasedTerminal metodoImprimir = new RegexBasedTerminal("metodoImprimir", "out_string\\[");
            RegexBasedTerminal RParseint = new RegexBasedTerminal("RParseint", "ParseInt\\[");
            RegexBasedTerminal RParseD = new RegexBasedTerminal("RParseD", "ParseDouble\\[");
            RegexBasedTerminal RintToSTR = new RegexBasedTerminal("RintToSTR", "intToSTR\\[");
            RegexBasedTerminal RdoubleToStr = new RegexBasedTerminal("RdoubleToStr", "doubleToStr\\[");
            RegexBasedTerminal RdoubleToInt = new RegexBasedTerminal("RdoubleToInt", "doubleToInt\\[");


            //Visibilidad 
            RegexBasedTerminal publico = new RegexBasedTerminal("publico", "publico ");
            RegexBasedTerminal privado = new RegexBasedTerminal("privado", "privado ");
            RegexBasedTerminal protegido = new RegexBasedTerminal("protegido", "protegido ");


            //Tipos de Datos
            IdentifierTerminal ID = new IdentifierTerminal("ID");

            RegexBasedTerminal REntero = new RegexBasedTerminal("REntero", "entero");
            NumberLiteral Entero = new NumberLiteral("entero");

            RegexBasedTerminal Rvoid = new RegexBasedTerminal("Rvoid", "void");

            RegexBasedTerminal RDoble = new RegexBasedTerminal("RDoble", "decimal");
            RegexBasedTerminal Doble = new RegexBasedTerminal("Doble", "[0-9]+\\.[0-9]{6}");

            RegexBasedTerminal Rboolean = new RegexBasedTerminal("Rboolean", "booleano");
            RegexBasedTerminal Verdadero = new RegexBasedTerminal("verdadero", "verdadero|true");
            RegexBasedTerminal Falso = new RegexBasedTerminal("falso", "falso|false");

            RegexBasedTerminal RCaracter = new RegexBasedTerminal("RCaracter", "caracter");
            RegexBasedTerminal Caracter = new RegexBasedTerminal("Caracter", "\'([a-zA-Z0-9]|#(n|f|t)|#|\\[|\\])\'");

            RegexBasedTerminal RCadena = new RegexBasedTerminal("RCadena", "cadena");
            StringLiteral Cadena = new StringLiteral("Cadena", "\"");

            RegexBasedTerminal ruta = new RegexBasedTerminal("ruta", "http://([a-zA-Z0-9]|#(n|f|t)|#|\\[|\\|.|_])+");
            //StringLiteral ruta = new StringLiteral("ruta", "http:");
            //CommentTerminal ruta = new CommentTerminal("ruta", "http",",");

            //Relaciones
            RegexBasedTerminal Igual = new RegexBasedTerminal("igual", "==");
            RegexBasedTerminal Diferente = new RegexBasedTerminal("Diferente", "!=");
            RegexBasedTerminal Menor = new RegexBasedTerminal("menor", "<");
            RegexBasedTerminal Mayor = new RegexBasedTerminal("mayor", ">");
            RegexBasedTerminal MenorQue = new RegexBasedTerminal("menor_que", "<=");
            RegexBasedTerminal MayorQue = new RegexBasedTerminal("mayor_que", ">=");

            //Logicos
            //RegexBasedTerminal Or = new RegexBasedTerminal("or", "or");
            var Or = ToTerm("or");
            //RegexBasedTerminal XOR = new RegexBasedTerminal("Xor", "xor");
            var XOR = ToTerm("xor");
            //RegexBasedTerminal and = new RegexBasedTerminal("and", "and");
            var and = ToTerm("and");
            //RegexBasedTerminal not = new RegexBasedTerminal("not", "NOT");
            var not = ToTerm("not");

            //Artimeticos
            RegexBasedTerminal suma = new RegexBasedTerminal("suma", "\\+");
            RegexBasedTerminal resta = new RegexBasedTerminal("resta", "-");
            RegexBasedTerminal multiplicacion = new RegexBasedTerminal("multi", "\\*");
            RegexBasedTerminal division = new RegexBasedTerminal("div", "\\/");
            RegexBasedTerminal potencia = new RegexBasedTerminal("power", "pow");

            RegexBasedTerminal aumentar = new RegexBasedTerminal("aumentar", "\\+\\+");
            RegexBasedTerminal disminuir = new RegexBasedTerminal("disminuir", "--");

            this.RegisterOperators(0, suma, resta);
            this.RegisterOperators(1, division, multiplicacion);
            this.RegisterOperators(2, potencia);
            this.RegisterOperators(3, aumentar, disminuir);
            this.RegisterOperators(4, Menor, Mayor, MenorQue, MayorQue, Igual, Diferente);
            this.RegisterOperators(5, Or, not, XOR, and);

            NonTerminal RAIZ = new NonTerminal("S"),
                    ENCABEZADO = new NonTerminal("Cabeza"),
                    CUERPO = new NonTerminal("Cuerpo"),
                    IMPORTACIONES = new NonTerminal("importaciones"),
                    IMPORTACION = new NonTerminal("importacion"),
                    Componentes = new NonTerminal("Componentes"),
                    Componente = new NonTerminal("Componente"),
                    Parametros = new NonTerminal("Parametros"),
                    Parametro = new NonTerminal("Parametro"),
                    Sentencias = new NonTerminal("Sentencias"),
                    SENTENCIA = new NonTerminal("Sentencia"),
                    DECLARACION = new NonTerminal("Declaracion"),
                    ASIGNACION = new NonTerminal("Asignacion"),
                    While = new NonTerminal("While"),
                    Do_While = new NonTerminal("Do_While"),
                    IF = new NonTerminal("If"),
                    For = new NonTerminal("for"),
                    Loop = new NonTerminal("Loop"),
                    ELEGIR = new NonTerminal("Elegir"),
                    Casos = new NonTerminal("Casos"),
                    Caso = new NonTerminal("Caso"),
                    SalidaC = new NonTerminal("SalidaC"),
                    aINT = new NonTerminal("aINT"),
                    aDou = new NonTerminal("aDou"),
                    intASt = new NonTerminal("intASt"),
                    douASt = new NonTerminal("douASt"),
                    douAINt = new NonTerminal("douAINt"),
                    Imprimir = new NonTerminal("Imprimir"),
                    VISIBILIDAD = new NonTerminal("Visibilidad"),
                    Contenido = new NonTerminal("Contenido"),
                    Globales = new NonTerminal("Globales"),
                    Global = new NonTerminal("Global"),
                    Tipo = new NonTerminal("Tipo"),
                    Retorno = new NonTerminal("Retorno"),
                    FUNCIONES = new NonTerminal("Funciones"),
                    Operacion = new NonTerminal("Operacion"),
                    Operaciones = new NonTerminal("Operaciones"),
                    Dimensiones = new NonTerminal("Dimensiones"),
                    Dimension = new NonTerminal("Dimension"),
                    Partes = new NonTerminal("Partes"),
                    AsignacionesArreglo = new NonTerminal("AsignacionesArreglo"),
                    AsignacionArreglo = new NonTerminal("AsignacionArreglo"),
                    Condicion = new NonTerminal("Condicion"),
                    Logica = new NonTerminal("Logica"),
                    Relacional = new NonTerminal("Relacional"),
                    Nombres = new NonTerminal("Nombres"),
                    VALOR = new NonTerminal("Valor"),
                    SINO = new NonTerminal("Sino"),
                    Salir = new NonTerminal("Salir"),
                    Repetir = new NonTerminal("Repetir"),
                    SINOSI = new NonTerminal("SinoS"),
                    LISTACUERPO = new NonTerminal("LISTACUERPO"),
                    LLAMAR_SUPER = new NonTerminal("LLAMAR_SUPER"),
                    LISTA_PARAMETROS = new NonTerminal("LISTA_PARAMETROS"),
                    PRAGMA_SOBREESCRIBIR = new NonTerminal("PRAGMA_SOBREESCRIBIR"),
                    OBJETO = new NonTerminal("OBJETO"),
                    PARAMETROS_INSTANCIA = new NonTerminal("PARAMETROS_INSTANCIA"),
                    AUMENTO_DECREMENTO = new NonTerminal("AUMENTO_DECREMENTO"),
                    ELSE = new NonTerminal("ELSE"),
                    CAD = new NonTerminal("CAD");

            RAIZ.Rule = ENCABEZADO + LISTACUERPO
                   | LISTACUERPO;

            ENCABEZADO.Rule = importar + IMPORTACIONES + Eos;

            IMPORTACIONES.Rule = IMPORTACIONES + "," + IMPORTACION
                            | IMPORTACION;

            IMPORTACION.Rule = ID + "." + ID
                            | Cadena
                            | ruta;

            //LISTACUERPO.Rule = MakePlusRule(LISTACUERPO, Cuerpo);
            LISTACUERPO.Rule = Indent + CUERPO + Dedent;

            CUERPO.Rule = MakeStarRule(LISTACUERPO, CUERPO);


            CUERPO.Rule = clase + ID + "[" + ID + "]:" + Eos + Indent + Partes + Dedent //6
                          | clase + ID + "[]:" + Eos + Indent + Partes + Dedent  //4
                          | VISIBILIDAD + clase + ID + "[]:" + Eos + Indent + Partes + Dedent //5
                          | VISIBILIDAD + clase + ID + "[" + ID + "]:" + Eos + Indent + Partes + Dedent;//7

            Partes.Rule = Globales + Componentes
                        | Componentes;

            Globales.Rule = Globales + Global
                            | Global;

            Global.Rule = Tipo + Nombres + Eos
                        | VISIBILIDAD + Tipo + Nombres + Eos
                        | Tipo + Nombres + "=>" + Operacion + Eos
                        | VISIBILIDAD + Tipo + Nombres + "=>" + Operacion + Eos
                        | Tipo + Nombres + Dimensiones + Eos
                        | VISIBILIDAD + Tipo + Nombres + Dimensiones + Eos
                        | Tipo + Nombres + "=>" + Operacion + Eos
                        | VISIBILIDAD + Tipo + Nombres + "=>" + Operacion + Eos; ;

            Nombres.Rule = Nombres + "," + ID
                        | ID;

            Componentes.Rule = Componentes + Componente
                            | Componente;
            //| sobreescribir + Eos + Componente ;
            PRAGMA_SOBREESCRIBIR.Rule = sobreescribir + Eos
                                        | Empty;

            Componente.Rule = PRAGMA_SOBREESCRIBIR + ID + "[]:" + Eos + Indent + Sentencias + Dedent//3
                            | PRAGMA_SOBREESCRIBIR + ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent//5
                            | PRAGMA_SOBREESCRIBIR + constructor + "[]:" + Eos + Indent + Sentencias + Dedent//3
                            | PRAGMA_SOBREESCRIBIR + constructor + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent//5
                            | PRAGMA_SOBREESCRIBIR + Tipo + ID + "[]:" + Eos + Indent + Sentencias + Dedent//4
                            | PRAGMA_SOBREESCRIBIR + Tipo + ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent//6
                            | PRAGMA_SOBREESCRIBIR + VISIBILIDAD + ID + "[]:" + Eos + Indent + Sentencias + Dedent//4
                            | PRAGMA_SOBREESCRIBIR + VISIBILIDAD + ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent//6
                            | PRAGMA_SOBREESCRIBIR + VISIBILIDAD + Tipo + ID + "[]:" + Eos + Indent + Sentencias + Dedent//5
                            | PRAGMA_SOBREESCRIBIR + VISIBILIDAD + Tipo + ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent;//7

            Sentencias.Rule = Sentencias + SENTENCIA
                            | SENTENCIA;

            SENTENCIA.Rule = Retorno
                           | Salir // Vamos a ver si la quitamos.
                           | FUNCIONES
                           | ASIGNACION
                           | DECLARACION
                           //| LLAMAR_SUPER                           
                           | IF
                           | For
                           | While
                           | Loop
                           | Do_While
                           | Imprimir
                           | ELEGIR
                           | Loop
                           | SalidaC
                           | aINT
                           | aDou
                           | douASt
                           | intASt
                           | douAINt
                           //| Salir
                           | AUMENTO_DECREMENTO
                           //| Operacion
                           ;

            //Poder hacer id++ o id -- en cuarquier lado prros :v .

            AUMENTO_DECREMENTO.Rule = ID + aumentar + Eos
                                     |ID + disminuir  + Eos;

            DECLARACION.Rule = Tipo + Nombres + Eos
                            | Tipo + Nombres + "=>" + Operacion + Eos
                            | Tipo + Nombres + "=>" + nuevo + ID + "[" + PARAMETROS_INSTANCIA +"]" + Eos
                            //objeto nombre => nuevo objeto[]
                            /*| Tipo + Nombres + "=>" + nuevo + Tipo +"["+ Nombres + "]" + Eos
                            | Tipo + Nombres + "=>" + nuevo + Tipo + "[" +  "]" + Eos
                            | Tipo + ID + Dimensiones + "=>" + nuevo + Tipo + "[" + "]" + Eos
                            | Tipo + ID + Dimensiones + "=>" + nuevo + Tipo + "[" + Nombres +"]" + Eos*/
                            | Tipo + ID + Dimensiones + Eos;

            LISTA_PARAMETROS.Rule =
                                    LISTA_PARAMETROS + "," + LISTA_PARAMETROS
                                  | Tipo + ID ;
                                    
            ASIGNACION.Rule = ID + "=>" + Operacion + Eos
                            | ID + Dimensiones + "=>" + Operacion + Eos
                            | ID + "." + ID + "=>" + Operacion + Eos
                            | ID + "=>"+ nuevo + ID + "[" + PARAMETROS_INSTANCIA+ "]" + Eos
                            | ID + Dimensiones + "=>" + nuevo + ID + "[" + PARAMETROS_INSTANCIA+ "]" + Eos
                            | ID + "." + ID + "=>" + nuevo + ID + "[" + PARAMETROS_INSTANCIA+"]" + Eos;

            PARAMETROS_INSTANCIA.Rule = PARAMETROS_INSTANCIA + "," + ID
                                        | ID
                                        | ID + "." + ID
                                        | Empty;

            IF.Rule = Rsi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent + ELSE//7
                      //| Rsi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent + Sino//6
                      //| Rsi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent + SinoS//6
                      ;//| Rsi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent;//5

            ELSE.Rule =  ELSE + ELSE
                        |SINO
                        | SINOSI
                        | Empty;

            SINOSI.Rule =  Rsinosi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//7
                         | Rsinosi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent;//6

            SINO.Rule = Rsino + DosPuntos + Eos + Indent + Sentencias + Dedent;

            For.Rule = RPara +"["+ ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + aumentar + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//12
                        | RPara + "["+ ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + disminuir + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//12
                        | RPara + "["+ Tipo + ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + aumentar + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//13
                        | RPara +"["+ Tipo + ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + disminuir + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent;//13

            While.Rule = Rmientras + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent;

            Do_While.Rule = Rhacer + DosPuntos + Eos + Indent + Sentencias + Dedent + Rmientras +"["+ Condicion + "]" + Eos;

            Repetir.Rule = Rrepetir + DosPuntos + Eos + Indent + Sentencias + Dedent + Rhasta + Condicion + "]";

            Loop.Rule = Rloop + DosPuntos + Eos + Indent + Sentencias + Dedent;

            SalidaC.Rule = metodoImprimir + Operacion + "]" + Eos;

            aINT.Rule = RParseint + Operacion + "]" + Eos;

            aDou.Rule = RParseD + Operacion + "]" + Eos;

            intASt.Rule = RintToSTR + Operacion + "]" + Eos;

            douASt.Rule = RdoubleToStr + Operacion + "]" + Eos;

            douAINt.Rule = RdoubleToInt + Operacion + "]" + Eos;

            Retorno.Rule = retornar + Operacion + Eos;

            Imprimir.Rule = imprimir + Operacion + "]" + Eos;

            Salir.Rule = Rsalir + Eos;

            LLAMAR_SUPER.Rule = Indent + super  + Nombres + "]" + Dedent
                               | Indent + super  + "]" + Dedent;

            Condicion.Rule = Logica;
            //Condicion.Rule = MakePlusRule(Condicion, Logica);

            Logica.Rule = 
                
                        /*"{" + Relacional + Relacional + Or + "}"
                        | "{" + Relacional + Relacional + and + "}"
                        | "{" + Relacional + Relacional + XOR + "}"                        
                        | "{" + Relacional + not + "}"*/

                           "{" + Logica + Logica + Or + "}"
                         | "{" + Logica + Logica + and + "}"
                         | "{" + Logica + Logica + XOR + "}"
                         | "{" + Logica + Logica + not + "}"
                         | "{" + Logica + not +"}"
                         | "{" + Relacional + not + "}"
                         | Relacional;

            Relacional.Rule = "[" + Relacional + Relacional + Igual + "]"
                            | "[" + Relacional + Relacional + Diferente + "]"
                            | "[" + Relacional + Relacional + Menor + "]"
                            | "[" + Relacional + Relacional + MenorQue + "]"
                            | "[" + Relacional + Relacional + Mayor + "]"
                            | "[" + Relacional + Relacional + MayorQue + "]"
                            | Operacion;

            Operacion.Rule = "(" + Operacion + Operacion + suma + ")"
                            | "(" + Operacion + Operacion + resta + ")"
                            | "(" + Operacion + Operacion + division + ")"
                            | "(" + Operacion + Operacion + multiplicacion + ")"
                            | "(" + Operacion + Operacion + potencia + ")"
                            | CAD;



            CAD.Rule = ID
                         | ID + "[" + Operacion + "]"
                         | ID + "." + ID
                         | ID + Dimensiones+"." + ID
                         | Rself + "." + ID
                         | VALOR
                         | SalidaC
                         | aINT
                         | aDou
                         | intASt
                         | douASt
                         | douAINt;

            Dimensiones.Rule = Dimensiones + Dimension
                              | Dimension;

            Dimension.Rule = "[" + Operacion + "]";

            OBJETO.Rule = ID;

            Tipo.Rule = 
                        OBJETO
                      | REntero
                      | Rboolean
                      | RCadena
                      | RDoble
                      | RCaracter
                      | Rvoid;
                      //| ID;

            VALOR.Rule = Entero
                 | Verdadero
                 | Falso
                 | Caracter
                 | Doble
                 | Cadena;

            VISIBILIDAD.Rule = publico
                       | privado
                       | protegido;

            FUNCIONES.Rule = super + "[" + Operaciones + "]" + Eos
                           | super + "[" + "]" + Eos
                           | ID + "[" + Operaciones + "]" + Eos
                           | ID + "[" + "]" + Eos;
                           //| LLAMAR_SUPER;

            Operaciones.Rule = Operaciones + "," + Operacion
                              | Operacion;

            ELEGIR.Rule = Relegir + "(" + Operacion + ")" + DosPuntos + Eos + Indent + Casos + Dedent;

            Casos.Rule = Caso + Casos
                        | Caso;

            Caso.Rule = Operacion + DosPuntos + Eos +Indent + Sentencias + Dedent
                       | "defecto" + DosPuntos +Eos +Indent + Sentencias + Dedent;

            Parametros.Rule = Parametros + "," + Parametro
                            | Parametro;

            Parametro.Rule = Tipo + ID;

            this.Root = RAIZ;

            RegisterOperators(1, FUNCIONES);
            RegisterOperators(2, ASIGNACION);

        }

       /* public override void CreateToCADenFilters(LanguageData language, ToCADenFilterList filters)
        {
            var outlineFilter = new CodeOutlineFilter(language.GrammarData,
            OutlineOptions.ProduceIndents | OutlineOptions.ChecCADBraces, ToTerm(@"\"));
            filters.Add(outlineFilter);
        }*/


        public override void CreateTokenFilters(LanguageData language, TokenFilterList filters)
        {
            var outlineFilter = new CodeOutlineFilter(language.GrammarData,
              OutlineOptions.ProduceIndents | OutlineOptions.CheckBraces, ToTerm(@"\")); // "\" is continuation symbol
            filters.Add(outlineFilter);
        }
    }
}
