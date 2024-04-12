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

namespace PDV.app
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Bem vindo {TBName.Text}");
            //MessageBox.Show($"Você digitou a senha: {TBPassword.Text}");

            Calculadora form = new Calculadora();
            
            form.ShowDialog();
            //form.Show();

        }

      
    }
}
