using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosMaquina
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vMac.Text = "";
            vNomeComputador.Text = "";
            vProcessador.Text = "";
            vTipoSistema.Text = "";
            vPlacaMae.Text = "";
        }

        private void btInformar_Click(object sender, EventArgs e)
        {
            vMac.Text = Dados.getMacAddress();
            vNomeComputador.Text = Dados.getComputerName();
            vTipoSistema.Text = Dados.getTypeOfSystem();
            vProcessador.Text = Dados.getProcessador();
            vPlacaMae.Text = Dados.getMotherBoard();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
