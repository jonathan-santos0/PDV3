using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.app
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BTSomar_Click(object sender, EventArgs e)
        {
            decimal total = NUDValor1.Value + NUDValor2.Value;
            LBResultado.Text = $"resultado: {total}";
        }
    }
}
