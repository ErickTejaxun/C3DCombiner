using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using Irony.Parsing;
using Irony.Ast;
using ScintillaNET;




namespace C3D_Combiner
{
    public partial class formPrincipal : Form
    {

        //Lista de path de carpetas, ya que en el árbol sólo se mostrará el nombre.
        private ArrayList paths_carpetas = new ArrayList();
        public static String nombreNuevoArchivo = "";
        public static int nuevoFlag = 0;
        public int contador = 0;
        public String pathArchivoActual = "";




        public formPrincipal()
        {
            InitializeComponent();

        }
        public bool esCadenaValida(string cadenaEntrada, Grammar gramatica)
        {
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser p = new Parser(lenguaje);
            ParseTree arbol = p.Parse(cadenaEntrada);
            if (arbol.Root==null)
            {
                return false;

            }
            //return arbol.Root != null;
            return true;
        }

        private void menuUML_Click(object sender, EventArgs e)
        {


        }

        private void menuDiagramaUML_Click(object sender, EventArgs e)
        {
            formUML formulario = new formUML();
            formulario.Show();
        }

        private void botonAbrir_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void botonNuevoArchivo_Click(object sender, EventArgs e)
        {
            String nombre = "Nuevo" + contador;
            AbrirArchivo(nombre, "");
            contador++;
        }

        private void botonCrearCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog navegadorCarpetas = new FolderBrowserDialog();
            if (navegadorCarpetas.ShowDialog() == DialogResult.OK)
            {
                string nombreNodo = navegadorCarpetas.SelectedPath;
                nombreNodo = nombreNodo.Trim();
                clases.carpeta nuevaCarpeta = new clases.carpeta(nombreNodo);
                paths_carpetas.Add(nuevaCarpeta);
                char delimiter = '\\';
                String[] substrings = nombreNodo.Split(delimiter);
                String nombreCarpeta = "";
                foreach (var substring in substrings)
                    nombreCarpeta = substring;
                vistaArbol.Nodes.Add(nombreCarpeta);
                //Console.WriteLine(navegadorCarpetas.SelectedPath);
            }




        }

        private void botonCompilar_Click(object sender, EventArgs e)
        {
            lanzarAnalisis();


        }

        public void lanzarAnalisis()
        {
            if (tabControlArchivos.TabCount > 0)
            {
                //Limpiamos lo de errores.
                this.richErrores.Text = "";
                String contenidoArchivo = ""; // Contenido del archivo.
                int panelSeleccionado = tabControlArchivos.SelectedIndex;
                String nombreArchivo = tabControlArchivos.TabPages[panelSeleccionado].Text;
                Control[] richActual = tabControlArchivos.TabPages[panelSeleccionado].Controls.Find("rich", false);
                if (richActual.Length > 0)
                {
                    contenidoArchivo = richActual[0].Text;
                }
                if (contenidoArchivo.Length > 0)
                {
                    Console.WriteLine("Texto encontrado --- \n" + contenidoArchivo);
                    Analizador analizador = new Analizador();
                    treeGramatica grammatica = new treeGramatica();
                    string respuesta = analizador.esCadenaValida(contenidoArchivo, grammatica);
                    if (respuesta.Equals("1"))
                    {
                        MessageBox.Show("Se ha construido el AST.");
                    }
                    else
                    {
                        MessageBox.Show("Errores en la cadena de entrada");
                        richErrores.Text = respuesta;
                    }
                }
                else
                {
                    MessageBox.Show("Error", "Archivo vacío.");
                }
            }
        }
        public void comenzarAnalisis()
        {
            String contenidoArchivo = ""; // Contenido del archivo.
            treeGramatica nuevoAnazilador = new treeGramatica();
            //Obtenemos el codigo.
            int panelSeleccionado = tabControlArchivos.SelectedIndex;
            String nombreArchivo = tabControlArchivos.TabPages[panelSeleccionado].Text;
            Control[] richActual = tabControlArchivos.TabPages[panelSeleccionado].Controls.Find("rich", false);
            if (richActual.Length > 0)
            {
                contenidoArchivo = richActual[0].Text;
            }
            

        }

        private void vistaArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String nombreArchivoSeleccionado = vistaArbol.SelectedNode.Text;
            char delimiter = '.';
            String[] substrings = nombreArchivoSeleccionado.Split(delimiter);

            if (substrings.Length > 1) // Verificamos si se ha seleccionado un archivo o una carpeta.
            {
                //Console.WriteLine("Has seleccionado el archivo "+ vistaArbol.SelectedNode.Text);
                //Console.WriteLine("Que se encuentra en la carpeta "+vistaArbol.SelectedNode.Parent.Text);
                //String nombreArchivoSeleccionado = vistaArbol.SelectedNode.Text;
                String nombrePadreArchivoSeleccionado = vistaArbol.SelectedNode.Parent.Text;
                String ruta = "";
                foreach (clases.carpeta tmpCarpeta in paths_carpetas)
                {
                    if (tmpCarpeta.nombre.Equals(nombrePadreArchivoSeleccionado))
                    {
                        ruta = tmpCarpeta.path;
                    }
                }
                // Ahora que ya tenemos la ruta absoluta del archivo, lo leemos y mostramos en un RichText.
                pathArchivoActual = ruta; // Almacenamos el path del archivo por si lo necesitamos guardar.
                ruta = ruta + nombreArchivoSeleccionado;
                string textoArchivo = System.IO.File.ReadAllText(@ruta);
                //System.Console.WriteLine("El contendio del archivo es: = {0}", text);

                //Ahora lo mostramos en pantalla.
                AbrirArchivo(nombreArchivoSeleccionado, textoArchivo);
            }
            else //Solo almacenamos el path de la carpeta.
            {
                pathArchivoActual = nombreArchivoSeleccionado;
            }
        }




        public void FormularioNombre()
        {
            MessageForm testDialog = new MessageForm();
            testDialog.Show();

            AbrirArchivo(nombreNuevoArchivo, "");




        }


        /*private void scintilla_TextChanged(object sender, EventArgs e)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }*/

        public void AbrirArchivo(String nombre, String texto)
        {


            //string title = "Documento " + (tabControlArchivos.TabCount).ToString();
            String title = nombre;
            ScintillaNET.Scintilla editor = new ScintillaNET.Scintilla();           
            editor.Margins[0].Width = 30;
            editor.Margins[0].Type = MarginType.Number;
            editor.Size = new System.Drawing.Size(500, 300);
            editor.Dock = DockStyle.Fill;
            editor.Text = texto;
            editor.Styles[Style.LineNumber].Font = "Calibri";
            editor.Name = "rich";            
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(editor);
            tabControlArchivos.TabPages.Add(myTabPage);

            /* 
            TabPage tmpTabpage = new TabPage();
            Scintilla editor = new Scintilla();
            editor.Name = nombre;
            tmpTabpage.Text = nombre;
            RichTextBox tmpTextBox = new RichTextBox();
            tmpTextBox.Text = texto;
            tmpTextBox.AutoWordSelection = true;
            tmpTextBox.Location = new System.Drawing.Point(3, 0);
            tmpTextBox.Name = "rich";
            //tmpTextBox.TextChanged += new System.EventHandler(this.tmpTextBox);
            tmpTextBox.Size = new System.Drawing.Size(697, 253);
            // tmpTabpage.Controls.Add(tmpTextBox);
            tmpTabpage.Controls.Add(editor);

            
            tabControlArchivos.Controls.Add(tmpTabpage);*/
        }

        private void formPrincipal_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void formPrincipal_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Iniciando hilo.");
            //iniciarHilos();
           // Thread.Sleep(200);
        }

        public void iniciarHilos()
        {
            Thread hiloPosicion = new Thread(new ThreadStart(getPosicionActual));
            hiloPosicion.Start();
            //getPosicionActual();
        }

        public void getPosicionActual()
        {
            while (true)
            {
                Console.WriteLine("Iniciando hilo. " + tabControlArchivos.TabCount);
                if (tabControlArchivos.TabCount > 0)
                {
                    try
                    {
                        int panelSeleccionado = tabControlArchivos.SelectedIndex;
                        String nombreArchivo = tabControlArchivos.TabPages[panelSeleccionado].Text;
                        Control[] richActual = tabControlArchivos.TabPages[panelSeleccionado].Controls.Find("rich", false);
                        if (richActual.Length > 0)
                        {
                            //contenidoArchivo = richActual[0].Text;
                            ScintillaNET.Scintilla editor = (ScintillaNET.Scintilla)richActual[0];
                            labelFila.Text = editor.CurrentLine.ToString();
                            labelColumna.Text = editor.CurrentPosition.ToString();
                            Console.WriteLine("----------------------" + labelFila.Text + labelColumna.Text);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);                        
                    }
                }
            }
        }

        private void botonGuardarArchivo_Click(object sender, EventArgs e)
        {
            guardarArchivo();
        }

        public void guardarArchivo()
        {
            if (tabControlArchivos.TabCount>0)
            {
                String nombreNuevoArchivo = ""; //Nombre del Archivo.
                String contenidoArchivo = ""; // Contenido del archivo.
                int panelSeleccionado = tabControlArchivos.SelectedIndex;
                String nombreArchivo = tabControlArchivos.TabPages[panelSeleccionado].Text;
                Control[] richActual = tabControlArchivos.TabPages[panelSeleccionado].Controls.Find("rich", false);
                if (richActual.Length > 0)
                {
                    contenidoArchivo = richActual[0].Text;
                }
                //nombreNuevoArchivo = tabControlArchivos
                //Console.WriteLine("Posicion selected {0} con nombre : {1}",panelSeleccionado,nombreArchivo);
                char delimitador = '.';
                String[] partesArchivo = nombreArchivo.Split(delimitador);
                if (partesArchivo.Length == 1) // Esto quiere decir que es un archivo nuevo.
                {
                    SaveFileDialog dialogoDeUbicacion = new SaveFileDialog();
                    dialogoDeUbicacion.Filter = "Archivos Tree (.tree)|*.tree|Archivos OLC++ (.olc)|*.olc";
                    if (dialogoDeUbicacion.ShowDialog() == DialogResult.OK) // El usuario ha seleccionado la ubicación.
                    {
                        nombreNuevoArchivo = dialogoDeUbicacion.FileName; // Esto devuelve todo el path :v
                        String pathNuevoArchivo = nombreNuevoArchivo;
                        Console.WriteLine("Path {0} contendio : {1}", nombreNuevoArchivo, contenidoArchivo);
                        System.IO.File.WriteAllText(nombreNuevoArchivo, contenidoArchivo); // Almacenamos el archivo

                        //Obtenemos el nombre del archivo ya que en la variable pathNuevoArchivo tenemos la direccion total.
                        delimitador = '\\';
                        String[] partesPath = pathNuevoArchivo.Split(delimitador);
                        foreach (String parte in partesPath)
                        {
                            nombreNuevoArchivo = parte;
                        }

                        cambiarNombrePanel(nombreNuevoArchivo); // Cambiamos el título al panel
                        dibujarNodo(pathNuevoArchivo); // Dibujamos el nodo.
                    }

                }
                else // Esto quiere decir que es un archivo nuevo.
                {
                    pathArchivoActual += nombreArchivo;
                    //Tenemos que encontrar el path del archivo
                    System.IO.File.WriteAllText(pathArchivoActual, contenidoArchivo); // Almacenamos el archivo
                }



            }
        }
        public void cambiarNombrePanel(String texto)
        {
            tabControlArchivos.TabPages[tabControlArchivos.SelectedIndex].Text = texto;
        }


        public void AbrirArchivo()
        {
            OpenFileDialog navegadorArchivos = new OpenFileDialog();
            navegadorArchivos.Filter = "Archivos Tree (.tree)|*.tree|Archivos OLC++ (.olc)|*.olc";
            navegadorArchivos.FilterIndex = 1;
            if (navegadorArchivos.ShowDialog() == DialogResult.OK)
            {
                string nombreNodo = navegadorArchivos.FileName;
                nombreNodo = nombreNodo.Trim();
                //clases.carpeta nuevaCarpeta = new clases.carpeta(nombreNodo);                
                char delimiter = '\\';
                String[] substrings = nombreNodo.Split(delimiter);
                String nombreArchivo = "";
                foreach (var substring in substrings)
                    nombreArchivo = substring;
                //Obtenemos la carpeta.
                substrings = nombreNodo.Split(delimiter);
                String nombreCarpeta = "";
                String path_carpeta = "";
                for (int c = 0; c < substrings.Length - 1; c++)
                {
                    nombreCarpeta = substrings[c];
                    path_carpeta += substrings[c] + "\\";
                }
                clases.carpeta tmpCarpeta = new clases.carpeta(nombreCarpeta);
                clases.carpeta nuevaCarpeta = new clases.carpeta(nombreCarpeta);
                nuevaCarpeta.path = path_carpeta;


                //Buscamos si la carpeta ya está en el arbol.
                int i = 0;
                int posicion = -1;
                foreach (clases.carpeta obj in paths_carpetas)
                {
                    //Console.WriteLine("{0}",obj.nombre);
                    //Console.WriteLine("{0}",nombreCarpeta);
                    if (obj.nombre.Equals(nombreCarpeta))
                    {
                        posicion = i;
                        Console.WriteLine("Carpeta Montada en el sistemas.");
                    }
                    i++;
                }



                if (posicion == -1) // Significa que no está la carpeta en el sistema de archivos (Arbol :v).
                {
                    TreeNode carpeta = new TreeNode();
                    carpeta.Name = nombreCarpeta;
                    carpeta.Text = nombreCarpeta;
                    carpeta.ImageIndex = 0;
                    TreeNode archivo = new TreeNode();
                    archivo.Name = nombreArchivo;
                    archivo.Text = nombreArchivo;

                    //Verificamos qué icono le agregamos
                    delimiter = '.';
                    substrings = nombreNodo.Split(delimiter);
                    if (substrings[1].Equals("tree"))
                    {
                        archivo.ImageIndex = 2;
                    }
                    else
                    {
                        archivo.ImageIndex = 1;
                    }

                    carpeta.Nodes.Add(archivo);
                    vistaArbol.Nodes.Add(carpeta);
                    nuevaCarpeta.nombre = carpeta.Name;
                    paths_carpetas.Add(nuevaCarpeta);
                }
                else // Significa que si está la carpeta en el sistema de archivos (Arbol :v).
                {
                    //Primero obtenemos una copia del nodo actual.
                    TreeNode[] carpetas = vistaArbol.Nodes.Find(nombreCarpeta, false);
                    TreeNode tmp = carpetas[0];

                    //Ahora verificamos que el archivo no esté ya en el sistema de archivos.
                    int Archivo_posicion = -1;
                    i = 0;
                    foreach (TreeNode archivotmp in tmp.Nodes)
                    {
                        if (archivotmp.Name.Equals(nombreArchivo))
                        {
                            Archivo_posicion = i;
                        }
                        i++;
                    }

                    if (Archivo_posicion == -1)
                    {


                        TreeNode archivo = new TreeNode();
                        archivo.Name = nombreArchivo;
                        archivo.Text = nombreArchivo;
                        //Obtenemos el icono que se le agrega al anodo segun el archivo que sea.
                        delimiter = '.';
                        substrings = nombreNodo.Split(delimiter);
                        if (substrings[1].Equals("tree"))
                        {
                            archivo.ImageIndex = 2;
                        }
                        else
                        {
                            archivo.ImageIndex = 1;
                        }
                        //archivo.ImageIndex = 2;
                        tmp.ImageIndex = 0;
                        tmp.Nodes.Add(archivo);
                        tmp.ImageIndex = 0;
                        vistaArbol.Nodes.RemoveAt(posicion);
                        vistaArbol.Nodes.Add(tmp);
                        nuevaCarpeta.nombre = tmp.Name;
                        paths_carpetas.RemoveAt(posicion);
                        paths_carpetas.Insert(posicion, nuevaCarpeta);
                    }
                    else
                    {
                        MessageBox.Show("El archivo seleccionado ya se encuentra cargado en el sistema.");
                    }
                    //TreeNode carpeta = new TreeNode();
                }
            }
        }


        public void dibujarNodo(String path)
        {
            string nombreNodo = path;
            nombreNodo = nombreNodo.Trim();
            //clases.carpeta nuevaCarpeta = new clases.carpeta(nombreNodo);                
            char delimiter = '\\';
            String[] substrings = nombreNodo.Split(delimiter);
            String nombreArchivo = "";
            foreach (var substring in substrings)
                nombreArchivo = substring;
            //Obtenemos la carpeta.
            substrings = nombreNodo.Split(delimiter);
            String nombreCarpeta = "";
            String path_carpeta = "";
            for (int c = 0; c < substrings.Length - 1; c++)
            {
                nombreCarpeta = substrings[c];
                path_carpeta += substrings[c] + "\\";
            }
            clases.carpeta tmpCarpeta = new clases.carpeta(nombreCarpeta);
            clases.carpeta nuevaCarpeta = new clases.carpeta(nombreCarpeta);
            nuevaCarpeta.path = path_carpeta;


            //Buscamos si la carpeta ya está en el arbol.
            int i = 0;
            int posicion = -1;
            foreach (clases.carpeta obj in paths_carpetas)
            {
                //Console.WriteLine("{0}",obj.nombre);
                //Console.WriteLine("{0}",nombreCarpeta);
                if (obj.nombre.Equals(nombreCarpeta))
                {
                    posicion = i;
                    Console.WriteLine("Carpeta Montada en el sistemas.");
                }
                i++;
            }



            if (posicion == -1) // Significa que no está la carpeta en el sistema de archivos (Arbol :v).
            {
                TreeNode carpeta = new TreeNode();
                carpeta.Name = nombreCarpeta;
                carpeta.Text = nombreCarpeta;
                carpeta.ImageIndex = 0;
                TreeNode archivo = new TreeNode();
                archivo.Name = nombreArchivo;
                archivo.Text = nombreArchivo;

                //Verificamos qué icono le agregamos
                delimiter = '.';
                substrings = nombreNodo.Split(delimiter);
                if (substrings[1].Equals("tree"))
                {
                    archivo.ImageIndex = 2;
                }
                else
                {
                    archivo.ImageIndex = 1;
                }

                carpeta.Nodes.Add(archivo);
                vistaArbol.Nodes.Add(carpeta);
                nuevaCarpeta.nombre = carpeta.Name;
                paths_carpetas.Add(nuevaCarpeta);
            }
            else // Significa que si está la carpeta en el sistema de archivos (Arbol :v).
            {
                //Primero obtenemos una copia del nodo actual.
                TreeNode[] carpetas = vistaArbol.Nodes.Find(nombreCarpeta, false);
                TreeNode tmp = carpetas[0];

                //Ahora verificamos que el archivo no esté ya en el sistema de archivos.
                int Archivo_posicion = -1;
                i = 0;
                foreach (TreeNode archivotmp in tmp.Nodes)
                {
                    if (archivotmp.Name.Equals(nombreArchivo))
                    {
                        Archivo_posicion = i;
                    }
                    i++;
                }

                if (Archivo_posicion == -1)
                {


                    TreeNode archivo = new TreeNode();
                    archivo.Name = nombreArchivo;
                    archivo.Text = nombreArchivo;
                    //Obtenemos el icono que se le agrega al anodo segun el archivo que sea.
                    delimiter = '.';
                    substrings = nombreNodo.Split(delimiter);
                    if (substrings[1].Equals("tree"))
                    {
                        archivo.ImageIndex = 2;
                    }
                    else
                    {
                        archivo.ImageIndex = 1;
                    }
                    //archivo.ImageIndex = 2;
                    tmp.ImageIndex = 0;
                    tmp.Nodes.Add(archivo);
                    tmp.ImageIndex = 0;
                    vistaArbol.Nodes.RemoveAt(posicion);
                    vistaArbol.Nodes.Add(tmp);
                    nuevaCarpeta.nombre = tmp.Name;
                    paths_carpetas.RemoveAt(posicion);
                    paths_carpetas.Insert(posicion, nuevaCarpeta);
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado ya se encuentra cargado en el sistema.");
                }
                //TreeNode carpeta = new TreeNode();
            }

        }

        private void botonCerrarArchivo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los últimos cambios?", "Aviso",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                guardarArchivo();
            }
            tabControlArchivos.Controls.RemoveAt(tabControlArchivos.SelectedIndex);
            //tabControlArchivos.TabPages[tabControlArchivos.SelectedIndex].Text = texto;
        }

        private void rich_TextChanged(object sender, EventArgs e)
        {
            int panelSeleccionado = tabControlArchivos.SelectedIndex;
            String nombreArchivo = tabControlArchivos.TabPages[panelSeleccionado].Text;
            Control[] richActual = tabControlArchivos.TabPages[panelSeleccionado].Controls.Find("rich", false);
            if (richActual.Length > 0)
            {
                //contenidoArchivo = richActual[0].Text;
                ScintillaNET.Scintilla editor = (ScintillaNET.Scintilla)richActual[0];
                labelFila.Text = editor.CurrentLine.ToString();
                labelColumna.Text = editor.CurrentPosition.ToString();
                Console.WriteLine("----------------------" + labelFila.Text + labelColumna.Text);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControlArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }  
    }


   


}
