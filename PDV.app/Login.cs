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
using PDV.app.DB;

namespace PDV.app
{
    public partial class Login : Form
    {
        Thread t1;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           bool isValid = DBAdapter.AttemptLogin(TBName.Text, TBPassword.Text);
            MessageBox.Show($"Bem vindo {TBName.Text}");
            if (TBName.Text == "Jonathan")
            {
                Program.IsLoged = true;
                this.Close();
            }
            //this.Close();
            //t1 = new Thread(janelaInício);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private void janelaInício(object obj)
        {
            Application.Run(new Main());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
