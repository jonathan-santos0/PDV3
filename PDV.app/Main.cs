using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PDV.app
{
    public partial class Main : Form
    {
        Thread t1;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bem vindo {TBName.Text}");
            this.Close();
            t1 = new Thread(janelaInício);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void janelaInício(object obj)
        {
            Application.Run(new janelaInício());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
