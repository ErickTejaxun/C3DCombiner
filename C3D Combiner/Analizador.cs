using Irony.Parsing;
using System;
using System.Drawing;
using System.IO;
using WINGRAPHVIZLib;

namespace C3D_Combiner
{
    public class Analizador
    {
        public bool esCadenaValida(string cadenaEntrada, Grammar gramatica)
        {
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser p = new Parser(lenguaje);
            ParseTree arbol = p.Parse(cadenaEntrada);
            ParseTreeNode raiz = arbol.Root;            
            if (raiz == null)
            {
                return false;
            }
            generarImagen(raiz);
            return true;
        }



        private static void generarImagen(ParseTreeNode raiz)
        {
            string grafoDOT = clases.diagramaDOT.getDOT(raiz);
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToPNG(grafoDOT);
            img.Save("AST.png");

        }

        public static Image dibujarGrafo(String grafo_en_DOT)
        {
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToPNG(grafo_en_DOT);
            byte[] imageBytes = Convert.FromBase64String(img.ToBase64String());
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = Image.FromStream(ms, true);
            return imagen;
        }
    }
}