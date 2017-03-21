using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoRoubaPouco
{
    public partial class Form1 : Form
    {
        public List<Conta> Contas { get; set; }

        public Form1()
        {
            InitializeComponent();
            Contas = new List<Conta>();
        }

        private void cONTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContaForm contaForm = new ContaForm(Contas);
            contaForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CarregaGrid(List<Conta> lista)
        {
            Contas = lista;
            dataGridView1.DataSource = Contas;

        }
    }
}
