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
    }
}
