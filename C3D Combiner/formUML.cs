using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3D_Combiner
{
    public partial class formUML : Form
    {
        public int artefactoFlag = 0; // 0 Clase, 1 Herencia, 2 Agregación, 3 Asociación, 4 dependencia.
        public int flag = 0;            // Flag de dibujo .
        public int contadorClases = 0;
        public formUML()
        {
            InitializeComponent();
        }


        private void richCodigoClase_TextChanged(object sender, EventArgs e)
        {
            String tmp = richCodigoClase.Text;
            String[] vtmp = tmp.Split('\n');

            richLineas.Text = "";
            int i = 0;
            tmp = "";
            for (i = 0; i < vtmp.Length; i++)
            {
                if (richCodigoClase.GetFirstCharIndexOfCurrentLine() == i)
                {
                                    
                    tmp += i + "\n";
                }
                else
                {
                    tmp += i + "\n";
                }
                
            }
            richLineas.Text = tmp;

            // = richCodigoClase.GetFirstCharIndexOfCurrentLine();

        }

        private void botonClase_Click(object sender, EventArgs e)
        {
            artefactoFlag = 0;
            flag = 1;
        }

        private void botonHerencia_Click(object sender, EventArgs e)
        {
            artefactoFlag = 1;
            flag = 1;
        }

        private void botonAgregacion_Click(object sender, EventArgs e)
        {
            artefactoFlag = 2;
            flag = 1;
        }

        private void botonAsociacion_Click(object sender, EventArgs e)
        {
            artefactoFlag = 3;
            flag = 1;
        }

        private void botonDependencia_Click(object sender, EventArgs e)
        {
            artefactoFlag = 4;
            flag = 1;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (flag == 1)
            {
                if (artefactoFlag > 0)
                {
                    if (contadorClases == 0)
                    {
                        MessageBox.Show("Debe agregar al menos una clase.", "Advertencia.");
                    }

                }


            }
        }
    }
}
