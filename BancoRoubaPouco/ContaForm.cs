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
    public partial class ContaForm : Form
    {
        public List<Conta> listaContas { get; set; }

        public ContaForm()
        {
            InitializeComponent();
        }

        public ContaForm(List<Conta> lista)
        {
            InitializeComponent();
            listaContas = new List<Conta>();
            listaContas.AddRange(lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Conta conta = new ContaCorrente();
                conta.Agencia = Convert.ToInt32(textBox1.Text);
                conta.Numero = textBox2.Text;
                conta.Saldo = Convert.ToDecimal(textBox4.Text);
                listaContas.Add(conta);
                this.Close();

            }
            else
            {
                //TODO: Desenvolver conta poupanca
                //Conta conta = new Conta();
                //conta.Agencia = Convert.ToInt32(textBox1.Text);
                //conta.Numero = textBox2.Text;
                //conta.Saldo = Convert.ToDecimal(textBox4.Text);

            }
            
        }

        private void ContaForm_Load(object sender, EventArgs e)
        {

        }

        private void ContaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.CarregaGrid(listaContas);
        }
    }
}
