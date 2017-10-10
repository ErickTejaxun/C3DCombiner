using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3D_Combiner
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Sleep for 2 seconds.");
                Thread.Sleep(1000);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = nombreArchivo.Text;
            if (nombre.Equals(""))
            {
                MessageBox.Show("Error","Debe Ingresar un nombre.");
            }
            else
            {
                formPrincipal.nombreNuevoArchivo = nombreArchivo.Text;                
                this.Close();
            }
        }
    }
}
