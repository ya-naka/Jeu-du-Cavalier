using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cavalier_V1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            menuStrip1.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Text = "Cavalier";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void buttonMJouer_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void règlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(
            "Programme réalisé par Yasmine Nait-Kaci et Simon Timmerman dans le cadre d'un projet pour la matiere IHM",
            "Crédits",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
