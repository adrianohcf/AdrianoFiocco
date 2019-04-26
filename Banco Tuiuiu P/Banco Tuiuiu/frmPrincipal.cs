using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Banco_Tuiuiu
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();

            DriveInfo[] alldrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in alldrives)
            {
                if (item.IsReady & item.DriveType.ToString() == "Removable")
                {
                    Habilita();
                    txtNome.Text = item.VolumeLabel;
                    txtConta.Text = item.AvailableFreeSpace.ToString();
                    txtSaldo.Text = item.TotalFreeSpace.ToString();
                    return;
                }
                else
                {
                    Desabilita();
                }
            }
        }

        public void Habilita()
        {
            lblMsg.Text = "";
            pnlPrincipalMsg.BackColor = Color.AntiqueWhite;
            txtNome.Enabled = true;
            txtConta.Enabled = true;
            txtSaldo.Enabled = true;
            btnSaque.Enabled = true;
            btnDeposito.Enabled = true;
        }

        public void Desabilita()
        {
            lblMsg.Text = "INSIRA SEU CARTÃO";
                    btnSaque.Enabled = false;
                    btnDeposito.Enabled = false;
                    txtNome.Enabled = false;
                    txtConta.Enabled = false;
                    txtSaldo.Enabled = false;
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            frmSaque saque = new frmSaque();
            
            saque.ShowDialog();

        }
    }
}
