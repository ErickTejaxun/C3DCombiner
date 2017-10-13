namespace C3D_Combiner
{
    partial class formUML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUML));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richLineas = new System.Windows.Forms.RichTextBox();
            this.richCodigoClase = new System.Windows.Forms.RichTextBox();
            this.comboBoxLenguajes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonDependencia = new System.Windows.Forms.Button();
            this.botonAsociacion = new System.Windows.Forms.Button();
            this.botonAgregacion = new System.Windows.Forms.Button();
            this.botonHerencia = new System.Windows.Forms.Button();
            this.botonClase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.comboBoxLenguajes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelDibujo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 665);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richLineas);
            this.panel4.Controls.Add(this.richCodigoClase);
            this.panel4.Location = new System.Drawing.Point(721, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 614);
            this.panel4.TabIndex = 6;
            // 
            // richLineas
            // 
            this.richLineas.Enabled = false;
            this.richLineas.Location = new System.Drawing.Point(18, 20);
            this.richLineas.Name = "richLineas";
            this.richLineas.Size = new System.Drawing.Size(30, 591);
            this.richLineas.TabIndex = 1;
            this.richLineas.Text = "";
            // 
            // richCodigoClase
            // 
            this.richCodigoClase.Location = new System.Drawing.Point(54, 20);
            this.richCodigoClase.Name = "richCodigoClase";
            this.richCodigoClase.Size = new System.Drawing.Size(379, 581);
            this.richCodigoClase.TabIndex = 2;
            this.richCodigoClase.Text = "";
            this.richCodigoClase.TextChanged += new System.EventHandler(this.richCodigoClase_TextChanged);
            // 
            // comboBoxLenguajes
            // 
            this.comboBoxLenguajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLenguajes.FormattingEnabled = true;
            this.comboBoxLenguajes.Items.AddRange(new object[] {
            "Lenguaje Tree",
            "Lenguaje OLC++"});
            this.comboBoxLenguajes.Location = new System.Drawing.Point(841, 8);
            this.comboBoxLenguajes.Name = "comboBoxLenguajes";
            this.comboBoxLenguajes.Size = new System.Drawing.Size(240, 21);
            this.comboBoxLenguajes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Area de diseño de clases";
            // 
            // panelDibujo
            // 
            this.panelDibujo.AutoScroll = true;
            this.panelDibujo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDibujo.Location = new System.Drawing.Point(243, 32);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(472, 611);
            this.panelDibujo.TabIndex = 3;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.botonDependencia);
            this.panel2.Controls.Add(this.botonAsociacion);
            this.panel2.Controls.Add(this.botonAgregacion);
            this.panel2.Controls.Add(this.botonHerencia);
            this.panel2.Controls.Add(this.botonClase);
            this.panel2.Location = new System.Drawing.Point(10, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 611);
            this.panel2.TabIndex = 2;
            // 
            // botonDependencia
            // 
            this.botonDependencia.Image = ((System.Drawing.Image)(resources.GetObject("botonDependencia.Image")));
            this.botonDependencia.Location = new System.Drawing.Point(15, 414);
            this.botonDependencia.Name = "botonDependencia";
            this.botonDependencia.Size = new System.Drawing.Size(193, 50);
            this.botonDependencia.TabIndex = 4;
            this.botonDependencia.UseVisualStyleBackColor = true;
            this.botonDependencia.Click += new System.EventHandler(this.botonDependencia_Click);
            // 
            // botonAsociacion
            // 
            this.botonAsociacion.Image = ((System.Drawing.Image)(resources.GetObject("botonAsociacion.Image")));
            this.botonAsociacion.Location = new System.Drawing.Point(15, 324);
            this.botonAsociacion.Name = "botonAsociacion";
            this.botonAsociacion.Size = new System.Drawing.Size(193, 62);
            this.botonAsociacion.TabIndex = 3;
            this.botonAsociacion.UseVisualStyleBackColor = true;
            this.botonAsociacion.Click += new System.EventHandler(this.botonAsociacion_Click);
            // 
            // botonAgregacion
            // 
            this.botonAgregacion.Image = ((System.Drawing.Image)(resources.GetObject("botonAgregacion.Image")));
            this.botonAgregacion.Location = new System.Drawing.Point(3, 240);
            this.botonAgregacion.Name = "botonAgregacion";
            this.botonAgregacion.Size = new System.Drawing.Size(193, 55);
            this.botonAgregacion.TabIndex = 2;
            this.botonAgregacion.UseVisualStyleBackColor = true;
            this.botonAgregacion.Click += new System.EventHandler(this.botonAgregacion_Click);
            // 
            // botonHerencia
            // 
            this.botonHerencia.Image = ((System.Drawing.Image)(resources.GetObject("botonHerencia.Image")));
            this.botonHerencia.Location = new System.Drawing.Point(3, 148);
            this.botonHerencia.Name = "botonHerencia";
            this.botonHerencia.Size = new System.Drawing.Size(205, 72);
            this.botonHerencia.TabIndex = 1;
            this.botonHerencia.UseVisualStyleBackColor = true;
            this.botonHerencia.Click += new System.EventHandler(this.botonHerencia_Click);
            // 
            // botonClase
            // 
            this.botonClase.Image = ((System.Drawing.Image)(resources.GetObject("botonClase.Image")));
            this.botonClase.Location = new System.Drawing.Point(29, -2);
            this.botonClase.Name = "botonClase";
            this.botonClase.Size = new System.Drawing.Size(149, 133);
            this.botonClase.TabIndex = 0;
            this.botonClase.UseVisualStyleBackColor = true;
            this.botonClase.Click += new System.EventHandler(this.botonClase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elementos UML";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // formUML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formUML";
            this.Text = "C3D Combiner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richCodigoClase;
        private System.Windows.Forms.ComboBox comboBoxLenguajes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button botonClase;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button botonHerencia;
        private System.Windows.Forms.Button botonDependencia;
        private System.Windows.Forms.Button botonAsociacion;
        private System.Windows.Forms.Button botonAgregacion;
        private System.Windows.Forms.RichTextBox richLineas;
    }
}