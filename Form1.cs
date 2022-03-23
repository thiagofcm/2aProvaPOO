using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1aQuestaoP2
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }
        Lista l1 = new Lista();

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }
        //BUSCAR
        private void button2_Click(object sender, EventArgs e) {
            //ler a txt box codigo
            int codigo = Convert.ToInt32(textBox1.Text);
            Contato contatofound = new Contato();
            //MessageBox.Show(Convert.ToString(codigo));

            textBox2.Text = Convert.ToString(l1.buscar(codigo).getNome());
            textBox3.Text = Convert.ToString(l1.buscar(codigo).getCel());
            textBox4.Text = Convert.ToString(l1.buscar(codigo).getEmail());
            textBox5.Text = Convert.ToString(l1.buscar(codigo).getCel());
            textBox6.Text = Convert.ToString(l1.buscar(codigo).getData());
            MessageBox.Show("Contato Encontrado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) {

        }
        //REMOVE
        private void button3_Click(object sender, EventArgs e) {
            String nome = textBox2.Text;
            l1.Remove(nome);
            MessageBox.Show("Contato Removido");
        }

        private void button5_Click(object sender, EventArgs e) {
            if (l1.estaVazia() == true) {
                MessageBox.Show("A lista de contatos esta vazia");
            }
            else {
                l1.ImprimeDireitaEsq();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            int codigo = Convert.ToInt32(textBox1.Text);
            String nome = textBox2.Text;
            String tel = textBox3.Text;
            String email = textBox4.Text;
            String celular = textBox5.Text;
            //Data1 dataaniv = Convert.(textBox6.Text);
            l1.Insere(codigo, nome, tel, email, celular);
            MessageBox.Show("Contato adicionado");
        }
    }
}
