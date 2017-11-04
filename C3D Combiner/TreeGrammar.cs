using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;
using Irony.Ast;

namespace C3D_Combiner
{
    [Language("Tree", "1.0", "Tree Gramatica , compiladores 2 :'v ")]
    class TreeGrammar : Grammar
    {

        //private readonly TerminalSet mSkipTokensInPreview = new TerminalSet(); //used in token preview for conflict resolution

        public TreeGrammar() : base(caseSensitive: false)
        {

            //Comentarios
            CommentTerminal DelimitedComment = new CommentTerminal("DelimitedComment", "{--", "--}");
            CommentTerminal SingleLineComment = new CommentTerminal("SingleLineComment", "##", "\r", "\n", "\u2085", "\u2028", "\u2029");


            NonGrammarTerminals.Add(DelimitedComment);
            NonGrammarTerminals.Add(SingleLineComment);

            //Expresiones Regulares y Datos 
            RegexBasedTerminal Entero = new RegexBasedTerminal("Entero", "[0-9]+");
            Terminal
            
            //Entero = new NumberLiteral(Constante.Entero, NumberOptions.IntOnly),
            Decimal = new NumberLiteral(Constante.Decimal),
            Caracter = new StringLiteral(Constante.Caracter, "'", StringOptions.IsChar),
            Cadena = new StringLiteral(Constante.Cadena, "\""),
            TTrue = ToTerm(Constante.TTrue),
            TFalse = ToTerm(Constante.TFalse),
            //Id = new IdentifierTerminal(Constante.Id),
            Id = new IdentifierTerminal("Id"),

            //Terminales                        
            //Tipo de datos
            TEntero = ToTerm(Constante.TEntero),
            TDecimal = ToTerm(Constante.TDecimal),
            TCaracter = ToTerm(Constante.TCaracter),
            TCadena = ToTerm(Constante.TCadena),
            TBooleano = ToTerm(Constante.TBooleano),
            TVoid = ToTerm(Constante.TVoid),

            TPublico = ToTerm(Constante.TPublico),
            TPrivado = ToTerm(Constante.TPrivado),
            TProtegido = ToTerm(Constante.TProtegido),

            TMas = ToTerm(Constante.TMas),
            TMenos = ToTerm(Constante.TMenos),
            TPor = ToTerm(Constante.TPor),
            TDivision = ToTerm(Constante.TDivision),
            TPotencia = ToTerm(Constante.TPotencia),
            TAumento = ToTerm(Constante.TAumento),
            TDecremento = ToTerm(Constante.TDecremento),
            TMayor = ToTerm(Constante.TMayor),
            TMenor = ToTerm(Constante.TMenor),
            TMayorIgual = ToTerm(Constante.TMayorIgual),
            TMenorIgual = ToTerm(Constante.TMenorIgual),
            TIgualacion = ToTerm(Constante.TIgualacion),
            TDiferenciacion = ToTerm(Constante.TDiferenciacion),
            TAnd = ToTerm(Constante.TAnd),
            TOr = ToTerm(Constante.TOr),
            TXor = ToTerm(Constante.TXor),
            TNot = ToTerm(Constante.TNot),

            TParentesis_Izq = ToTerm(Constante.TParetesis_Izq),
            TParentesis_Der = ToTerm(Constante.TParentesis_Der),
            TCorchete_Izq = ToTerm(Constante.TCorchete_Izq),
            TCorchete_Der = ToTerm(Constante.TCorchete_Der),
            TLlave_Izq = ToTerm(Constante.TLlave_Izq),
            TLlave_Der = ToTerm(Constante.TLlave_Der),
            TDosPuntos = ToTerm(Constante.TDosPuntos),
            TComa = ToTerm(Constante.TComa),
            TPuntoComa = ToTerm(Constante.TPuntoComa),
            TPunto = ToTerm(Constante.TPunto),
            TIgual = ToTerm(Constante.TIgual),
            TAsignacion = ToTerm(Constante.TAsignacion),

            TImportar = ToTerm(Constante.TImportar),
            TClase = ToTerm(Constante.TClase),
            TConstructor = ToTerm(Constante.TConstructor),
            TMetodo = ToTerm(Constante.TMetodo),
            TFuncion = ToTerm(Constante.TFuncion),
            TRetorno = ToTerm(Constante.TRetorno),
            TNuevo = ToTerm(Constante.TNuevo),
            TSuper = ToTerm(Constante.TSuper),
            TSobrescribirTree = ToTerm(Constante.TSobrescribirTree),
            TSelf = ToTerm(Constante.TSelf),
            TSi = ToTerm(Constante.TSi),
            TSino = ToTerm(Constante.TSino),
            TSinoSi = ToTerm(Constante.TSinoSi),
            TSalir = ToTerm(Constante.TSalir),
            TElegir = ToTerm(Constante.TElegir),
            TDefecto = ToTerm(Constante.TDefecto),
            TContinuar = ToTerm(Constante.TContinuar),
            TMientras = ToTerm(Constante.TMientras),
            THacer = ToTerm(Constante.THacer),
            TRepetir = ToTerm(Constante.TRepetir),
            THasta = ToTerm(Constante.THasta),
            TPara = ToTerm(Constante.TPara),
            TLoop = ToTerm(Constante.TLoop),
            TOutString = ToTerm(Constante.TOutString),
            TParseInt = ToTerm(Constante.TParseInt),
            TParseDouble = ToTerm(Constante.TParseDouble),
            TIntToStr = ToTerm(Constante.TIntToStr),
            TDoubleToStr = ToTerm(Constante.TDoubleToStr),
            TDoubleToInt = ToTerm(Constante.TDoubleToInt);



            MarkReservedWords(Constante.TEntero);
            MarkReservedWords(Constante.TDecimal);
            MarkReservedWords(Constante.TCaracter);
            MarkReservedWords(Constante.TCadena);
            MarkReservedWords(Constante.TBooleano);
            MarkReservedWords(Constante.TVoid);

            MarkReservedWords(Constante.TPublico);
            MarkReservedWords(Constante.TPrivado);
            MarkReservedWords(Constante.TProtegido);

            MarkReservedWords(Constante.TImportar);
            MarkReservedWords(Constante.TClase);
            MarkReservedWords(Constante.TConstructor);
            MarkReservedWords(Constante.TMetodo);
            MarkReservedWords(Constante.TFuncion);
            MarkReservedWords(Constante.TRetorno);
            MarkReservedWords(Constante.TNuevo);
            MarkReservedWords(Constante.TSuper);
            MarkReservedWords(Constante.TSobrescribirTree);
            MarkReservedWords(Constante.TSelf);
            MarkReservedWords(Constante.TSi);
            MarkReservedWords(Constante.TSino);
            MarkReservedWords(Constante.TSinoSi);
            MarkReservedWords(Constante.TSalir);
            MarkReservedWords(Constante.TElegir);
            MarkReservedWords(Constante.TDefecto);
            MarkReservedWords(Constante.TContinuar);
            MarkReservedWords(Constante.TMientras);
            MarkReservedWords(Constante.THacer);
            MarkReservedWords(Constante.TRepetir);
            MarkReservedWords(Constante.THasta);
            MarkReservedWords(Constante.TPara);
            MarkReservedWords(Constante.TLoop);
            MarkReservedWords(Constante.TOutString);
            MarkReservedWords(Constante.TParseInt);
            MarkReservedWords(Constante.TParseDouble);
            MarkReservedWords(Constante.TIntToStr);
            MarkReservedWords(Constante.TDoubleToStr);
            MarkReservedWords(Constante.TDoubleToInt);

            //No terminales
            NonTerminal
            INICIO = new NonTerminal(Constante.INICIO),
            LISTA_CLASE = new NonTerminal(Constante.LISTA_CLASE),
            CLASE = new NonTerminal(Constante.CLASE),
            LISTA_SENTENCIAS = new NonTerminal(Constante.LISTA_SENTENCIAS),
            LISTA_SENTENCIA = new NonTerminal(Constante.LISTA_SENTENCIA),
            SENTENCIA = new NonTerminal(Constante.SENTENCIA),
            FUNCION = new NonTerminal(Constante.FUNCION),
            DECLARACION = new NonTerminal(Constante.DECLARACION),
            ASIGNACION = new NonTerminal(Constante.ASIGNACION),
            TIPO = new NonTerminal(Constante.TIPO),
            LISTA_DIMENSIONES = new NonTerminal(Constante.LISTA_DIMENSIONES),
            LISTA_EXPS = new NonTerminal(Constante.LISTA_EXPS),
            LISTA_EXP = new NonTerminal(Constante.LISTA_EXP),
            EXP = new NonTerminal(Constante.EXP),
            LISTA_ID = new NonTerminal(Constante.LISTA_ID),
            DIMENSION = new NonTerminal(Constante.DIMENSION),
            OBJETO = new NonTerminal(Constante.OBJETO),
            HIJO = new NonTerminal(Constante.HIJO),
            LLAMAD_FUNCION = new NonTerminal(Constante.LLAMADA_FUNCION),
            VISIBILIDAD = new NonTerminal(Constante.VISIBILIDAD),
            LISTA_PARAMETROS = new NonTerminal(Constante.LISTA_PARAMETROS),
            LISTA_PARAMETRO = new NonTerminal(Constante.LISTA_PARAMETRO),
            PARAMETRO = new NonTerminal(Constante.PARAMETRO),
            LISTA_INSTRUCCIONES = new NonTerminal(Constante.LISTA_INSTRUCCIONES),
            LISTA_INSTRUCCION = new NonTerminal(Constante.LISTA_INSTRUCCION),
            INSTRUCCION = new NonTerminal(Constante.INSTRUCCION),
            DIMENSIONES_METODO = new NonTerminal(Constante.DIMENSIONES_METODO),
            LISTA_DIMENSION_METODO = new NonTerminal(Constante.LISTA_DIMENSION_METODO),
            DIMENSION_METODO = new NonTerminal(Constante.DIMENSION_METODO),
            LLAMADA = new NonTerminal(Constante.LLAMADA),
            SI = new NonTerminal(Constante.SI),
            SINO = new NonTerminal(Constante.SINO),
            LISTA_SINOSIS = new NonTerminal(Constante.LISTA_SINOSIS),
            LISTA_SINOSI = new NonTerminal(Constante.LISTA_SINOSI),
            SINOSI = new NonTerminal(Constante.SINOSI),
            ELEGIR = new NonTerminal(Constante.ELEGIR),
            LISTA_CASOS = new NonTerminal(Constante.LISTA_CASOS),
            CASO = new NonTerminal(Constante.CASO),
            DEFECTO = new NonTerminal(Constante.DEFECTO),
            MIENTRAS = new NonTerminal(Constante.MIENTRAS),
            HACER = new NonTerminal(Constante.HACER),
            REPETIR = new NonTerminal(Constante.REPETIR),
            PARA = new NonTerminal(Constante.PARA),
            LOOP = new NonTerminal(Constante.LOOP),
            LITERALES = new NonTerminal(Constante.LITERALES),
            LISTA_IMPORTAR = new NonTerminal(Constante.LISTA_IMPORTAR),
            IMPORTAR = new NonTerminal(Constante.IMPORTAR),
            LISTA_ARCHIVO = new NonTerminal(Constante.LISTA_ARCHIVO),
            ARCHIVO = new NonTerminal(Constante.ARCHIVO),
            LLAMADA_EXP = new NonTerminal(Constante.LLAMADA_EXP),
            AUXILIAR = new NonTerminal("AUXILIAR");



            AUXILIAR.Rule = Entero 
                            | Decimal;

            INICIO.Rule = LISTA_IMPORTAR + LISTA_CLASE;

            LISTA_IMPORTAR.Rule = MakePlusRule(LISTA_IMPORTAR, IMPORTAR);

            IMPORTAR.Rule = TImportar + LISTA_ARCHIVO + Eos
                | Empty;

            LISTA_ARCHIVO.Rule = MakeListRule(LISTA_ARCHIVO, TComa, ARCHIVO);

            ARCHIVO.Rule = Id + ".tree"
                | Id + ".olc"
                | Cadena
                ;

            LISTA_CLASE.Rule = MakePlusRule(LISTA_CLASE, CLASE);

            CLASE.Rule = TClase + Id + TCorchete_Izq + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_SENTENCIAS + Dedent
                | TClase + Id + TCorchete_Izq + Id + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_SENTENCIAS + Dedent
                ;

            LISTA_SENTENCIAS.Rule = LISTA_SENTENCIA
                | Empty
                ;

            LISTA_SENTENCIA.Rule = this.MakePlusRule(LISTA_SENTENCIA, SENTENCIA);

            SENTENCIA.Rule = FUNCION
                | VISIBILIDAD + DECLARACION + Eos;

            FUNCION.Rule = TSobrescribirTree + Eos + VISIBILIDAD + TMetodo + Id + TCorchete_Izq + LISTA_PARAMETROS + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                  | VISIBILIDAD + TMetodo + Id + TCorchete_Izq + LISTA_PARAMETROS + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                  | TSobrescribirTree + Eos + VISIBILIDAD + TFuncion + TIPO + DIMENSIONES_METODO + Id + TCorchete_Izq + LISTA_PARAMETROS + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                  | VISIBILIDAD + TFuncion + TIPO + DIMENSIONES_METODO + Id + TCorchete_Izq + LISTA_PARAMETROS + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                  | TConstructor + TCorchete_Izq + LISTA_PARAMETROS + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                  ;


            VISIBILIDAD.Rule = TPublico
                | TPrivado
                | TProtegido
                | Empty;

            DIMENSIONES_METODO.Rule = LISTA_DIMENSION_METODO
                | Empty
                ;

            LISTA_DIMENSION_METODO.Rule = MakePlusRule(LISTA_DIMENSION_METODO, DIMENSION_METODO);

            DIMENSION_METODO.Rule = TCorchete_Izq + TCorchete_Der;

            LISTA_PARAMETROS.Rule = LISTA_PARAMETRO
                | Empty
                ;

            LISTA_PARAMETRO.Rule = MakeListRule(LISTA_PARAMETRO, TComa, PARAMETRO);

            PARAMETRO.Rule = TIPO + DIMENSIONES_METODO + Id;


            LISTA_INSTRUCCIONES.Rule = LISTA_INSTRUCCION
                | Empty
                ;

            LISTA_INSTRUCCION.Rule = MakePlusRule(LISTA_INSTRUCCION, INSTRUCCION);

            INSTRUCCION.Rule = LLAMADA + Eos
                | DECLARACION + Eos
                | ASIGNACION + Eos
                | TRetorno + EXP + Eos
                | TSalir + Eos
                | TContinuar + Eos
                | SI
                | ELEGIR
                | MIENTRAS
                | HACER
                | REPETIR
                | PARA
                | LOOP
                ;


            TIPO.Rule = TEntero
                | TDecimal
                | TCaracter
                | TCadena
                | TBooleano
                | Id
                ;

            LISTA_ID.Rule = this.MakeListRule(LISTA_ID, TComa, Id);

            LISTA_DIMENSIONES.Rule = this.MakePlusRule(LISTA_DIMENSIONES, DIMENSION);

            DIMENSION.Rule = TCorchete_Izq + EXP + TCorchete_Der;

            DECLARACION.Rule = TIPO + LISTA_ID + TAsignacion + EXP
                | TIPO + LISTA_ID
                | TIPO + Id + LISTA_DIMENSIONES;


            ASIGNACION.Rule = OBJETO + Id + LISTA_DIMENSIONES + TAsignacion + EXP
                | Id + LISTA_DIMENSIONES + TAsignacion + EXP
                | OBJETO + Id + TAsignacion + EXP
                | Id + TAsignacion + EXP
                | TParentesis_Izq + EXP + TAumento + TParentesis_Der
                | TParentesis_Izq + EXP + TDecremento + TParentesis_Der
                ;

            LLAMADA.Rule = OBJETO + Id + TCorchete_Izq + LISTA_EXPS + TCorchete_Der//3
                | Id + TCorchete_Izq + LISTA_EXPS + TCorchete_Der//2
                | OBJETO + Id + LISTA_DIMENSIONES//3
                | Id + LISTA_DIMENSIONES//2
                | TOutString + TCorchete_Izq + EXP + TCorchete_Der//2
                | TSuper + TCorchete_Izq + LISTA_EXPS + TCorchete_Der//2
                ;

            SI.Rule = TSi + EXP + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent + LISTA_SINOSIS + SINO;

            LISTA_SINOSIS.Rule = LISTA_SINOSI
                | Empty
                ;

            LISTA_SINOSI.Rule = MakePlusRule(LISTA_SINOSI, SINOSI);

            SINOSI.Rule = TSinoSi + EXP + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent;

            SINO.Rule = TSino + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                | Empty
                ;

            ELEGIR.Rule = TElegir + EXP + TDosPuntos + Eos + Indent + LISTA_CASOS + DEFECTO + Dedent;

            LISTA_CASOS.Rule = MakePlusRule(LISTA_CASOS, CASO);

            CASO.Rule = LITERALES + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent;

            DEFECTO.Rule = TDefecto + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                | Empty;

            MIENTRAS.Rule = TMientras + EXP + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent;

            HACER.Rule = THacer + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent + TMientras + EXP + Eos;

            REPETIR.Rule = TRepetir + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent + THasta + EXP + Eos;

            PARA.Rule = TPara + TCorchete_Izq + ASIGNACION + TDosPuntos + EXP + TDosPuntos + ASIGNACION + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                | TPara + TCorchete_Izq + DECLARACION + TDosPuntos + EXP + TDosPuntos + ASIGNACION + TCorchete_Der + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent
                ;

            LOOP.Rule = TLoop + TDosPuntos + Eos + Indent + LISTA_INSTRUCCIONES + Dedent;

            LITERALES.Rule = Entero
                | Decimal
                | Caracter
                | Cadena
                | TTrue
                | TFalse
                ;

            LISTA_EXPS.Rule = LISTA_EXP
                | Empty;

            LISTA_EXP.Rule = MakeListRule(LISTA_EXP, TComa, EXP);

            EXP.Rule = TParentesis_Izq + EXP + EXP + TMas + TParentesis_Der
                | TParentesis_Izq + EXP + EXP + TMenos + TParentesis_Der
                | TParentesis_Izq + EXP + TMenos + TParentesis_Der
                | TParentesis_Izq + EXP + TAumento + TParentesis_Der
                | TParentesis_Izq + EXP + TDecremento + TParentesis_Der
                | TParentesis_Izq + EXP + EXP + TPor + TParentesis_Der
                | TParentesis_Izq + EXP + EXP + TDivision + TParentesis_Der
                | TParentesis_Izq + EXP + EXP + TPotencia + TParentesis_Der
                | TCorchete_Izq + EXP + EXP + TMayor + TCorchete_Der
                | TCorchete_Izq + EXP + EXP + TMenor + TCorchete_Der
                | TCorchete_Izq + EXP + EXP + TMayorIgual + TCorchete_Der
                | TCorchete_Izq + EXP + EXP + TMenorIgual + TCorchete_Der
                | TCorchete_Izq + EXP + EXP + TIgualacion + TCorchete_Der
                | TCorchete_Izq + EXP + EXP + TDiferenciacion + TCorchete_Der
                | TLlave_Izq + EXP + EXP + TOr + TLlave_Der
                | TLlave_Izq + EXP + EXP + TAnd + TLlave_Der
                | TLlave_Izq + EXP + EXP + TXor + TLlave_Der
                | TLlave_Izq + EXP + TNot + TLlave_Der
                | Decimal
                | Entero
                | Caracter
                | Cadena
                | TTrue
                | TFalse
                | TSelf
                | LLAMADA_EXP
                | TNuevo + Id + TCorchete_Izq + LISTA_EXPS + TCorchete_Der
                | TParseInt + TCorchete_Izq + EXP + TCorchete_Der
                | TParseDouble + TCorchete_Izq + EXP + TCorchete_Der
                | TIntToStr + TCorchete_Izq + EXP + TCorchete_Der
                | TDoubleToStr + TCorchete_Izq + EXP + TCorchete_Der
                | TDoubleToInt + TCorchete_Izq + EXP + TCorchete_Der
                ;

            LLAMADA_EXP.Rule = OBJETO + Id
                | OBJETO + Id + TCorchete_Izq + LISTA_EXPS + TCorchete_Der
                | OBJETO + Id + LISTA_DIMENSIONES
                | Id
                | Id + TCorchete_Izq + LISTA_EXPS + TCorchete_Der
                | Id + LISTA_DIMENSIONES
                ;

            OBJETO.Rule = MakePlusRule(OBJETO, HIJO);

            HIJO.Rule = Id + TPunto
                | Id + TCorchete_Izq + LISTA_EXPS + TCorchete_Der + TPunto
                | Id + LISTA_DIMENSIONES + TPunto
                | TSelf + TPunto
                | TSuper + TPunto
                ;


            RegisterOperators(1, Associativity.Left, TOr.ToString());
            RegisterOperators(2, Associativity.Left, TXor.ToString());
            RegisterOperators(3, Associativity.Left, TAnd.ToString());
            RegisterOperators(4, Associativity.Left, TNot.ToString());
            RegisterOperators(5, TIgualacion.ToString(), TDiferenciacion.ToString(), TMenor.ToString(), TMayor.ToString(), TMenorIgual.ToString(), TMayorIgual.ToString());
            RegisterOperators(6, Associativity.Left, TMas.ToString(), TMenos.ToString());
            RegisterOperators(7, Associativity.Left, TPor.ToString(), TDivision.ToString());
            RegisterOperators(8, Associativity.Right, TPotencia.ToString());
            RegisterOperators(9, Associativity.Left, TAumento.ToString(), TDecremento.ToString());


            MarkPunctuation(TParentesis_Izq, TParentesis_Der, TCorchete_Izq, TCorchete_Der, TLlave_Izq, TLlave_Der, TDosPuntos, TComa, TPuntoComa, TPunto, TIgual, TAsignacion);
            //MarkTransient(TIPO, SIMPLIFICADA);
            //No terminal de inicio
            //this.Root = INICIO;
            this.Root = AUXILIAR;

            //Para generar el AST
            //LanguageFlags = LanguageFlags.CreateAst;
        }

        public override void CreateTokenFilters(LanguageData language, TokenFilterList filters)
        {
            var outlineFilter = new CodeOutlineFilter(language.GrammarData,
              OutlineOptions.ProduceIndents | OutlineOptions.CheckBraces, ToTerm(@"\")); // "\" is continuation symbol
            filters.Add(outlineFilter);
        }
    }
}
