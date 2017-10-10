namespace C3D_Combiner
{
    partial class formPrincipal
    {

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiagramaUML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompartido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.botonNuevoArchivo = new System.Windows.Forms.Button();
            this.lista2 = new System.Windows.Forms.ImageList(this.components);
            this.botonGuardarArchivo = new System.Windows.Forms.Button();
            this.botonAbrir = new System.Windows.Forms.Button();
            this.botonCrearCarpeta = new System.Windows.Forms.Button();
            this.botonCompilar = new System.Windows.Forms.Button();
            this.vistaArbol = new System.Windows.Forms.TreeView();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.tabControlArchivos = new System.Windows.Forms.TabControl();
            this.tabArchivo1 = new System.Windows.Forms.TabPage();
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.rich = new System.Windows.Forms.RichTextBox();
            this.tabControlSalida = new System.Windows.Forms.TabControl();
            this.tabSalida = new System.Windows.Forms.TabPage();
            this.tabErrores = new System.Windows.Forms.TabPage();
            this.tabOptimizacion = new System.Windows.Forms.TabPage();
            this.tab3d = new System.Windows.Forms.TabPage();
            this.tab3dOptimizacion = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.botonCerrarArchivo = new System.Windows.Forms.Button();
            this.listaArchivo = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControlArchivos.SuspendLayout();
            this.tabArchivo1.SuspendLayout();
            this.tabControlSalida.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUML,
            this.menuDepurar,
            this.menuCompartido,
            this.menuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUML
            // 
            this.menuUML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDiagramaUML});
            this.menuUML.Name = "menuUML";
            this.menuUML.Size = new System.Drawing.Size(44, 20);
            this.menuUML.Text = "UML";
            this.menuUML.Click += new System.EventHandler(this.menuUML_Click);
            // 
            // menuDiagramaUML
            // 
            this.menuDiagramaUML.Name = "menuDiagramaUML";
            this.menuDiagramaUML.Size = new System.Drawing.Size(213, 22);
            this.menuDiagramaUML.Text = "Módulo de diagrama UML";
            this.menuDiagramaUML.Click += new System.EventHandler(this.menuDiagramaUML_Click);
            // 
            // menuDepurar
            // 
            this.menuDepurar.Name = "menuDepurar";
            this.menuDepurar.Size = new System.Drawing.Size(61, 20);
            this.menuDepurar.Text = "Depurar";
            // 
            // menuCompartido
            // 
            this.menuCompartido.Name = "menuCompartido";
            this.menuCompartido.Size = new System.Drawing.Size(125, 20);
            this.menuCompartido.Text = "Código Compartido";
            // 
            // menuReportes
            // 
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 20);
            this.menuReportes.Text = "Reportes";
            // 
            // botonNuevoArchivo
            // 
            this.botonNuevoArchivo.ImageIndex = 1;
            this.botonNuevoArchivo.ImageList = this.lista2;
            this.botonNuevoArchivo.Location = new System.Drawing.Point(15, 27);
            this.botonNuevoArchivo.Name = "botonNuevoArchivo";
            this.botonNuevoArchivo.Size = new System.Drawing.Size(56, 56);
            this.botonNuevoArchivo.TabIndex = 1;
            this.botonNuevoArchivo.UseVisualStyleBackColor = true;
            this.botonNuevoArchivo.Click += new System.EventHandler(this.botonNuevoArchivo_Click);
            // 
            // lista2
            // 
            this.lista2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lista2.ImageStream")));
            this.lista2.TransparentColor = System.Drawing.Color.Transparent;
            this.lista2.Images.SetKeyName(0, "folder.png");
            this.lista2.Images.SetKeyName(1, "nuevo.jpg");
            this.lista2.Images.SetKeyName(2, "open.ico");
            this.lista2.Images.SetKeyName(3, "open.png");
            this.lista2.Images.SetKeyName(4, "run.png");
            this.lista2.Images.SetKeyName(5, "save.png");
            this.lista2.Images.SetKeyName(6, "close.png");
            // 
            // botonGuardarArchivo
            // 
            this.botonGuardarArchivo.ImageIndex = 5;
            this.botonGuardarArchivo.ImageList = this.lista2;
            this.botonGuardarArchivo.Location = new System.Drawing.Point(77, 27);
            this.botonGuardarArchivo.Name = "botonGuardarArchivo";
            this.botonGuardarArchivo.Size = new System.Drawing.Size(61, 56);
            this.botonGuardarArchivo.TabIndex = 2;
            this.botonGuardarArchivo.UseVisualStyleBackColor = true;
            this.botonGuardarArchivo.Click += new System.EventHandler(this.botonGuardarArchivo_Click);
            // 
            // botonAbrir
            // 
            this.botonAbrir.ImageIndex = 3;
            this.botonAbrir.ImageList = this.lista2;
            this.botonAbrir.Location = new System.Drawing.Point(144, 27);
            this.botonAbrir.Name = "botonAbrir";
            this.botonAbrir.Size = new System.Drawing.Size(62, 61);
            this.botonAbrir.TabIndex = 3;
            this.botonAbrir.UseVisualStyleBackColor = true;
            this.botonAbrir.Click += new System.EventHandler(this.botonAbrir_Click);
            // 
            // botonCrearCarpeta
            // 
            this.botonCrearCarpeta.ImageIndex = 2;
            this.botonCrearCarpeta.ImageList = this.lista2;
            this.botonCrearCarpeta.Location = new System.Drawing.Point(212, 27);
            this.botonCrearCarpeta.Name = "botonCrearCarpeta";
            this.botonCrearCarpeta.Size = new System.Drawing.Size(78, 61);
            this.botonCrearCarpeta.TabIndex = 4;
            this.botonCrearCarpeta.UseVisualStyleBackColor = true;
            this.botonCrearCarpeta.Click += new System.EventHandler(this.botonCrearCarpeta_Click);
            // 
            // botonCompilar
            // 
            this.botonCompilar.ImageIndex = 4;
            this.botonCompilar.ImageList = this.lista2;
            this.botonCompilar.Location = new System.Drawing.Point(296, 27);
            this.botonCompilar.Name = "botonCompilar";
            this.botonCompilar.Size = new System.Drawing.Size(65, 57);
            this.botonCompilar.TabIndex = 5;
            this.botonCompilar.UseVisualStyleBackColor = true;
            this.botonCompilar.Click += new System.EventHandler(this.botonCompilar_Click);
            // 
            // vistaArbol
            // 
            this.vistaArbol.ImageIndex = 0;
            this.vistaArbol.ImageList = this.listaImagenes;
            this.vistaArbol.Location = new System.Drawing.Point(3, 3);
            this.vistaArbol.Name = "vistaArbol";
            this.vistaArbol.SelectedImageIndex = 6;
            this.vistaArbol.Size = new System.Drawing.Size(324, 275);
            this.vistaArbol.StateImageList = this.listaImagenes;
            this.vistaArbol.TabIndex = 6;
            this.vistaArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.vistaArbol_AfterSelect);
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "carpeta.png");
            this.listaImagenes.Images.SetKeyName(1, "olc.png");
            this.listaImagenes.Images.SetKeyName(2, "tree.png");
            this.listaImagenes.Images.SetKeyName(3, "folder.png");
            this.listaImagenes.Images.SetKeyName(4, "nuevo.jpg");
            this.listaImagenes.Images.SetKeyName(5, "open.png");
            this.listaImagenes.Images.SetKeyName(6, "run.png");
            this.listaImagenes.Images.SetKeyName(7, "save.png");
            // 
            // tabControlArchivos
            // 
            this.tabControlArchivos.Controls.Add(this.tabArchivo1);
            this.tabControlArchivos.Location = new System.Drawing.Point(334, 3);
            this.tabControlArchivos.Name = "tabControlArchivos";
            this.tabControlArchivos.SelectedIndex = 0;
            this.tabControlArchivos.Size = new System.Drawing.Size(701, 275);
            this.tabControlArchivos.TabIndex = 8;
            // 
            // tabArchivo1
            // 
            this.tabArchivo1.Controls.Add(this.LineNumberTextBox);
            this.tabArchivo1.Controls.Add(this.rich);
            this.tabArchivo1.Location = new System.Drawing.Point(4, 22);
            this.tabArchivo1.Name = "tabArchivo1";
            this.tabArchivo1.Padding = new System.Windows.Forms.Padding(3);
            this.tabArchivo1.Size = new System.Drawing.Size(693, 249);
            this.tabArchivo1.TabIndex = 0;
            this.tabArchivo1.Text = "Nuevo";
            this.tabArchivo1.UseVisualStyleBackColor = true;
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.Location = new System.Drawing.Point(3, 3);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ReadOnly = true;
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(42, 243);
            this.LineNumberTextBox.TabIndex = 1;
            this.LineNumberTextBox.Text = "";
            // 
            // rich
            // 
            this.rich.AutoWordSelection = true;
            this.rich.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.rich.Location = new System.Drawing.Point(44, 0);
            this.rich.Name = "rich";
            this.rich.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rich.Size = new System.Drawing.Size(656, 243);
            this.rich.TabIndex = 0;
            this.rich.Text = "";
            this.rich.TextChanged += new System.EventHandler(this.rich_TextChanged);
            // 
            // tabControlSalida
            // 
            this.tabControlSalida.Controls.Add(this.tabSalida);
            this.tabControlSalida.Controls.Add(this.tabErrores);
            this.tabControlSalida.Controls.Add(this.tabOptimizacion);
            this.tabControlSalida.Controls.Add(this.tab3d);
            this.tabControlSalida.Controls.Add(this.tab3dOptimizacion);
            this.tabControlSalida.Location = new System.Drawing.Point(3, 3);
            this.tabControlSalida.Name = "tabControlSalida";
            this.tabControlSalida.SelectedIndex = 0;
            this.tabControlSalida.Size = new System.Drawing.Size(1026, 203);
            this.tabControlSalida.TabIndex = 9;
            // 
            // tabSalida
            // 
            this.tabSalida.AutoScroll = true;
            this.tabSalida.Location = new System.Drawing.Point(4, 22);
            this.tabSalida.Name = "tabSalida";
            this.tabSalida.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalida.Size = new System.Drawing.Size(1018, 177);
            this.tabSalida.TabIndex = 0;
            this.tabSalida.Text = "Consola de Salida";
            this.tabSalida.UseVisualStyleBackColor = true;
            // 
            // tabErrores
            // 
            this.tabErrores.Location = new System.Drawing.Point(4, 22);
            this.tabErrores.Name = "tabErrores";
            this.tabErrores.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrores.Size = new System.Drawing.Size(1018, 177);
            this.tabErrores.TabIndex = 1;
            this.tabErrores.Text = "Errores";
            this.tabErrores.UseVisualStyleBackColor = true;
            // 
            // tabOptimizacion
            // 
            this.tabOptimizacion.Location = new System.Drawing.Point(4, 22);
            this.tabOptimizacion.Name = "tabOptimizacion";
            this.tabOptimizacion.Size = new System.Drawing.Size(1018, 177);
            this.tabOptimizacion.TabIndex = 2;
            this.tabOptimizacion.Text = "Salida proceso de optimización";
            this.tabOptimizacion.UseVisualStyleBackColor = true;
            // 
            // tab3d
            // 
            this.tab3d.Location = new System.Drawing.Point(4, 22);
            this.tab3d.Name = "tab3d";
            this.tab3d.Size = new System.Drawing.Size(1018, 177);
            this.tab3d.TabIndex = 3;
            this.tab3d.Text = "Código 3D";
            this.tab3d.UseVisualStyleBackColor = true;
            // 
            // tab3dOptimizacion
            // 
            this.tab3dOptimizacion.Location = new System.Drawing.Point(4, 22);
            this.tab3dOptimizacion.Name = "tab3dOptimizacion";
            this.tab3dOptimizacion.Size = new System.Drawing.Size(1018, 177);
            this.tab3dOptimizacion.TabIndex = 4;
            this.tab3dOptimizacion.Text = "Código 3D Optimizado";
            this.tab3dOptimizacion.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.9403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.0597F));
            this.tableLayoutPanel1.Controls.Add(this.vistaArbol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControlArchivos, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 281);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabControlSalida, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 391);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1032, 209);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Guardar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nuevo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Abrir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Crear Carpeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Compilar";
            // 
            // botonCerrarArchivo
            // 
            this.botonCerrarArchivo.ImageIndex = 0;
            this.botonCerrarArchivo.ImageList = this.listaArchivo;
            this.botonCerrarArchivo.Location = new System.Drawing.Point(1006, 78);
            this.botonCerrarArchivo.Name = "botonCerrarArchivo";
            this.botonCerrarArchivo.Size = new System.Drawing.Size(41, 26);
            this.botonCerrarArchivo.TabIndex = 17;
            this.botonCerrarArchivo.UseVisualStyleBackColor = true;
            this.botonCerrarArchivo.Click += new System.EventHandler(this.botonCerrarArchivo_Click);
            // 
            // listaArchivo
            // 
            this.listaArchivo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaArchivo.ImageStream")));
            this.listaArchivo.TransparentColor = System.Drawing.Color.Transparent;
            this.listaArchivo.Images.SetKeyName(0, "close.png");
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1063, 617);
            this.Controls.Add(this.botonCerrarArchivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.botonCompilar);
            this.Controls.Add(this.botonCrearCarpeta);
            this.Controls.Add(this.botonAbrir);
            this.Controls.Add(this.botonGuardarArchivo);
            this.Controls.Add(this.botonNuevoArchivo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.Text = "C3D Combines";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlArchivos.ResumeLayout(false);
            this.tabArchivo1.ResumeLayout(false);
            this.tabControlSalida.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUML;
        private System.Windows.Forms.ToolStripMenuItem menuDepurar;
        private System.Windows.Forms.ToolStripMenuItem menuCompartido;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.Button botonNuevoArchivo;
        private System.Windows.Forms.Button botonGuardarArchivo;
        private System.Windows.Forms.Button botonAbrir;
        private System.Windows.Forms.Button botonCrearCarpeta;
        private System.Windows.Forms.Button botonCompilar;
        private System.Windows.Forms.TreeView vistaArbol;
        private System.Windows.Forms.TabControl tabControlArchivos;
        private System.Windows.Forms.TabPage tabArchivo1;
        private System.Windows.Forms.TabControl tabControlSalida;
        private System.Windows.Forms.TabPage tabSalida;
        private System.Windows.Forms.TabPage tabErrores;
        private System.Windows.Forms.TabPage tabOptimizacion;
        private System.Windows.Forms.TabPage tab3d;
        private System.Windows.Forms.TabPage tab3dOptimizacion;
        private System.Windows.Forms.ToolStripMenuItem menuDiagramaUML;
        private System.Windows.Forms.RichTextBox rich;
        private System.Windows.Forms.ImageList listaImagenes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ImageList lista2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonCerrarArchivo;
        private System.Windows.Forms.ImageList listaArchivo;
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
    }
}

