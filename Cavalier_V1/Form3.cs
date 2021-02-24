using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cavalier_V1
{
    public partial class Form3 : Form
    {

        static BoutonPlateau[,] echecB = new BoutonPlateau[12, 12];
        JeuSolo jeusolo;

        static int[,] echec = new int[12, 12];
        static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };


        public Form3()
        {
            InitializeComponent();
            initialiserPlateau();
            label2.Visible = true;
            label3.Visible = false;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.ClientSize = new System.Drawing.Size(650, 575); ;
            jeusolo = new JeuSolo(echecB);

        }

        void initialiserPlateau()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    echecB[i, j] = new BoutonPlateau(i, j);
                    echecB[i, j].Click += new System.EventHandler(this.jouer);
                    Controls.Add(echecB[i, j]);
                }
            }
        }

        private void jouer(object sender, EventArgs e)
        {
            désactiveBoutons();
            label2.Visible = false;
            //btnRejouer.Visible = false;
            //jeusolo = new JeuSolo (echecB);

            if (sender is BoutonPlateau)
            {
                BoutonPlateau btn = (BoutonPlateau)sender;
                désactiveBoutons();
                jeusolo.jouer(btn);
            }
            if (jeusolo.getAvancement() > 1)
            {
                buttonMarcheArriere.Enabled = true;
            }
            else buttonMarcheArriere.Enabled = false;

            buttonAbandoner.Visible = true;
            buttonMarcheArriere.Visible = true;

            if (jeusolo.termineSurUneImpasse())
            {
                label3.Visible = true;
            }


        }

        void désactiveBoutons()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    echecB[i, j].Enabled = false;
                }
            }
        }

        void activeBoutons()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    echecB[i, j].Enabled = true;
                }
            }
        }

        public void solution()
        {
            jeusolo.effacerImage();
            Euler euler = new Euler(echecB, 64);
            euler.initialisationManuelle(jeusolo.getCaseDépart().getLigne(), jeusolo.getCaseDépart().getColonne());
            euler.tour();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(
                "Voulez-vous afficher la solution ?",
                "Donner votre langue au chat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (reponse == DialogResult.Yes) { 
                solution();
            buttonAbandoner.Visible = false;
            }
            else
                nouvellePartie();
            buttonAbandoner.Visible = false;
            buttonMarcheArriere.Visible = false;
        }

        public void reinitialiserPlateau()
        {
            for (int i = 2; i < 10; ++i)
            {
                for (int j = 2; j < 10; ++j)
                {
                    echecB[i, j].Enabled = true;
                    echecB[i, j].Image = null;
                    echecB[i, j].Text = "";

                }
            }
        }

        public void nouvellePartie()
        {

            reinitialiserPlateau();
            jeusolo = new JeuSolo(echecB);
            label2.Visible = true;
            label3.Visible = false;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonAbandoner.Visible = false;
            buttonMarcheArriere.Visible = false;
            nouvellePartie();


        }

        private void buttonMarcheArriere_Click(object sender, EventArgs e)
        {
            if (jeusolo.getAvancement() <= 2)
            {
                buttonMarcheArriere.Enabled = false;
            }
            jeusolo.marcheArriere();
            label3.Visible = false;
        }

        private void règleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void commentçaMarcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aide f5 = new Aide("jouer");
            f5.ShowDialog();
        }
    }
}



