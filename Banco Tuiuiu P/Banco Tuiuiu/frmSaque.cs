using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Tuiuiu
{
    public partial class frmSaque : Form
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public frmSaque()
        {
            InitializeComponent();
        }

        private void frmSaque_Load(object sender, EventArgs e)
        {
            txtSaldoSaque.Text = 
        }

        private void btnCancelarSaque_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
