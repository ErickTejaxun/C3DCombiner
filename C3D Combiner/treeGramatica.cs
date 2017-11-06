﻿using Irony.Parsing;
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
            RegexBasedTerminal super = new RegexBasedTerminal("super", "super");
            RegexBasedTerminal sobreescribir = new RegexBasedTerminal("sobreescribir", "\\/\\*\\*Sobreescribir\\*\\*\\/");
            RegexBasedTerminal metodo = new RegexBasedTerminal("metodo", "metodo");
            RegexBasedTerminal funcion = new RegexBasedTerminal("funcion", "funcion");
            RegexBasedTerminal clase = new RegexBasedTerminal("clase", "clase");
            RegexBasedTerminal retornar = new RegexBasedTerminal("retornar", "retornar ");
            RegexBasedTerminal imprimir = new RegexBasedTerminal("imprimir", "imprimir\\[");
            RegexBasedTerminal Rself = new RegexBasedTerminal("Rself", "self");
            RegexBasedTerminal Rsi = new RegexBasedTerminal("Rsi", "SI ");
            RegexBasedTerminal Rsino = new RegexBasedTerminal("Rsino", "SI_NO ");
            RegexBasedTerminal Rsinosi = new RegexBasedTerminal("Rsinosi", "SI_NO_SI ");
            RegexBasedTerminal Rsalir = new RegexBasedTerminal("Rsalir", "salir ");
            RegexBasedTerminal Relegir = new RegexBasedTerminal("Relejir", "ELEGIR CASO ");
            RegexBasedTerminal Rcontinuar = new RegexBasedTerminal("Rcontinuar", "CONTINUAR ");
            RegexBasedTerminal Rmientras = new RegexBasedTerminal("Rmientras", "MIENTRAS ");
            RegexBasedTerminal Rhacer = new RegexBasedTerminal("Rhacer", "HACER ");
            RegexBasedTerminal Rrepetir = new RegexBasedTerminal("Rrepetir", "REPETIR ");
            RegexBasedTerminal Rhasta = new RegexBasedTerminal("Rhasta", "HASTA ");
            RegexBasedTerminal RPara = new RegexBasedTerminal("Rpara", "Para\\[");
            RegexBasedTerminal Rloop = new RegexBasedTerminal("Rloop", "loop ");
            RegexBasedTerminal RoutS = new RegexBasedTerminal("RoutS", "out_string\\[");
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
            RegexBasedTerminal Or = new RegexBasedTerminal("or", "\\|\\|");
            RegexBasedTerminal XOR = new RegexBasedTerminal("Xor", "\\?\\?");
            RegexBasedTerminal and = new RegexBasedTerminal("and", "&&");
            RegexBasedTerminal not = new RegexBasedTerminal("not", "NOT");

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

            NonTerminal S = new NonTerminal("S"),
                    Cabeza = new NonTerminal("Cabeza"),
                    Cuerpo = new NonTerminal("Cuerpo"),
                    importaciones = new NonTerminal("importaciones"),
                    importacion = new NonTerminal("importacion"),
                    Componentes = new NonTerminal("Componentes"),
                    Componente = new NonTerminal("Componente"),
                    Parametros = new NonTerminal("Parametros"),
                    Parametro = new NonTerminal("Parametro"),
                    Sentencias = new NonTerminal("Sentencias"),
                    Sentencia = new NonTerminal("Sentencia"),
                    Declaracion = new NonTerminal("Declaracion"),
                    Asignacion = new NonTerminal("Asignacion"),
                    While = new NonTerminal("While"),
                    Do_While = new NonTerminal("Do_While"),
                    IF = new NonTerminal("If"),
                    For = new NonTerminal("for"),
                    Loop = new NonTerminal("Loop"),
                    Elegir = new NonTerminal("Elegir"),
                    Casos = new NonTerminal("Casos"),
                    Caso = new NonTerminal("Caso"),
                    SalidaC = new NonTerminal("SalidaC"),
                    aINT = new NonTerminal("aINT"),
                    aDou = new NonTerminal("aDou"),
                    intASt = new NonTerminal("intASt"),
                    douASt = new NonTerminal("douASt"),
                    douAINt = new NonTerminal("douAINt"),
                    Imprimir = new NonTerminal("Imprimir"),
                    Visibilidad = new NonTerminal("Visibilidad"),
                    Contenido = new NonTerminal("Contenido"),
                    Globales = new NonTerminal("Globales"),
                    Global = new NonTerminal("Global"),
                    Tipo = new NonTerminal("Tipo"),
                    Retorno = new NonTerminal("Retorno"),
                    Funciones = new NonTerminal("Funciones"),
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
                    Valor = new NonTerminal("Valor"),
                    Sino = new NonTerminal("Sino"),
                    Salir = new NonTerminal("Salir"),
                    Repetir = new NonTerminal("Repetir"),
                    SinoS = new NonTerminal("SinoS"),
                    LISTACUERPO = new NonTerminal("LISTACUERPO"),
                    CAD = new NonTerminal("CAD");

            S.Rule = Cabeza + LISTACUERPO
                   | LISTACUERPO;

            Cabeza.Rule = importar + importaciones + Eos;

            importaciones.Rule = importaciones + "," + importacion
                            | importacion;

            importacion.Rule = ID + "." + ID
                            | Cadena
                            | ruta;

            //LISTACUERPO.Rule = MakePlusRule(LISTACUERPO, Cuerpo);
            LISTACUERPO.Rule = Indent + Cuerpo + Dedent;

            Cuerpo.Rule = MakeStarRule(LISTACUERPO, Cuerpo );
                                

            Cuerpo.Rule =  clase + ID + "[" + ID + "]:" + Eos + Indent + Partes + Dedent //6
                          | clase + ID + "[]:" + Eos + Indent + Partes + Dedent  //4
                          | Visibilidad + clase + ID + "[]:" + Eos + Indent + Partes + Dedent //5
                          | Visibilidad + clase + ID + "[" + ID + "]:" + Eos + Indent + Partes + Dedent ;//7

            Partes.Rule = Globales + Componentes
                        | Componentes;

            Globales.Rule = Globales + Global
                            | Global;

            Global.Rule = Tipo + Nombres + Eos
                        | Visibilidad + Tipo + Nombres + Eos
                        | Tipo + Nombres + "=>" + Operacion + Eos
                        | Visibilidad + Tipo + Nombres + "=>" + Operacion + Eos;

            Nombres.Rule = Nombres + "," + ID
                        | ID;

            Componentes.Rule = Componentes + Componente
                            | Componente;

            Componente.Rule = ID + "[]:" + Eos + Indent + Sentencias + Dedent//3
                            | ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent//5
                            | Tipo + ID + "[]:" + Eos + Indent + Sentencias + Dedent//4
                            | Tipo + ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent//6
                            | Visibilidad + ID + "[]:" + Eos + Indent + Sentencias + Dedent//4
                            | Visibilidad + ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent//6
                            | Visibilidad + Tipo + ID + "[]:" + Eos + Indent + Sentencias + Dedent//5
                            | Visibilidad + Tipo + ID + "[" + Parametros + "]:" + Eos + Indent + Sentencias + Dedent;//7

            Sentencias.Rule = Sentencias + Sentencia
                            | Sentencia;

            Sentencia.Rule = Retorno
                           | Asignacion
                           | Declaracion
                           | Funciones
                           | IF
                           | For
                           | While
                           | Loop
                           | Do_While
                           | Imprimir
                           | Elegir
                           | Loop
                           | SalidaC
                           | aINT
                           | aDou
                           | douASt
                           | intASt
                           | douAINt
                           | Salir;

            Declaracion.Rule = Tipo + Nombres + Eos
                            | Tipo + Nombres + "=>" + Operacion + Eos
                            | Tipo + ID + Dimensiones + Eos;

            Asignacion.Rule = ID + "=>" + Operacion + Eos
                            | ID + Dimensiones + "=>" + Operacion + Eos
                            | ID + "." + ID + "=>" + Operacion + Eos;

            IF.Rule = Rsi + Condicion + DosPuntos + Eos + Indent + Sentencias + Dedent + SinoS + Sino//7
                      | Rsi + Condicion + DosPuntos + Eos + Indent + Sentencias + Dedent + Sino//6
                      | Rsi + Condicion + DosPuntos + Eos + Indent + Sentencias + Dedent + SinoS//6
                      | Rsi + Condicion + DosPuntos + Eos + Indent + Sentencias + Dedent;//5

            SinoS.Rule = SinoS + Rsinosi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//7
                         | Rsinosi + "[" + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent;//6

            Sino.Rule = Rsino + DosPuntos + Eos + Indent + Sentencias + Dedent;

            For.Rule = RPara + ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + aumentar + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//12
                        | RPara + ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + disminuir + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//12
                        | RPara + Tipo + ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + aumentar + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent//13
                        | RPara + Tipo + ID + "=>" + Operacion + DosPuntos + Condicion + DosPuntos + ID + disminuir + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent;//13

            While.Rule = Rmientras + Condicion + "]" + DosPuntos + Eos + Indent + Sentencias + Dedent;

            Do_While.Rule = Rhacer + DosPuntos + Eos + Indent + Sentencias + Dedent + Rmientras + Condicion + "]";

            Repetir.Rule = Rrepetir + DosPuntos + Eos + Indent + Sentencias + Dedent + Rhasta + Condicion + "]";

            Loop.Rule = Rloop + DosPuntos + Eos + Indent + Sentencias + Dedent;

            SalidaC.Rule = RoutS + Operacion + "]" + Eos;

            aINT.Rule = RParseint + Operacion + "]" + Eos;

            aDou.Rule = RParseD + Operacion + "]" + Eos;

            intASt.Rule = RintToSTR + Operacion + "]" + Eos;

            douASt.Rule = RdoubleToStr + Operacion + "]" + Eos;

            douAINt.Rule = RdoubleToInt + Operacion + "]" + Eos;

            Retorno.Rule = retornar + Operacion + Eos;

            Imprimir.Rule = imprimir + Operacion + "]" + Eos;

            Salir.Rule = Rsalir + Eos;

            Condicion.Rule = Logica;

            Logica.Rule = "{" + Logica + Logica + Or + "}"
                        | "{" + Logica + Logica + and + "}"
                        | "{" + Logica + Logica + XOR + "}"
                        | "{" + not + Logica + "}"
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
                         | Rself + "." + ID
                         | Valor
                         | SalidaC
                         | aINT
                         | aDou
                         | intASt
                         | douASt
                         | douAINt;

            Dimensiones.Rule = Dimensiones + Dimension
                              | Dimension;

            Dimension.Rule = "[" + Operacion + "]";

            Tipo.Rule = REntero
                      | Rboolean
                      | RCadena
                      | RDoble
                      | RCaracter
                      | Rvoid;

            Valor.Rule = Entero
                 | Verdadero
                 | Falso
                 | Caracter
                 | Doble
                 | Cadena;

            Visibilidad.Rule = publico
                       | privado
                       | protegido;

            Funciones.Rule = ID + "[" + Operaciones + "]" + Eos
                           | ID + "[" + "]" + Eos;

            Operaciones.Rule = Operaciones + "," + Operacion
                              | Operacion;

            Elegir.Rule = Relegir + "(" + Operacion + ")" + DosPuntos + Eos + Casos;

            Casos.Rule = Caso + Casos
                        | Caso;

            Caso.Rule = Operacion + DosPuntos + Indent + Sentencias + Dedent
                       | "defecto" + DosPuntos + Indent + Sentencias + Dedent;

            Parametros.Rule = Parametros + "," + Parametro
                            | Parametro;

            Parametro.Rule = Tipo + ID;

            this.Root = S;
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
