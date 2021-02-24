using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cavalier_V1
{
    public partial class Form2 : Form
    {
        static Button[,] echecB = new Button[12, 12];
        Euler euler;

        static int pas;
        private System.Windows.Forms.Timer timer;

        public Form2()
        {
            InitializeComponent();
            initialiserPlateau();
            numericUpDown1.Value = 1;
            démarreTimer();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.ClientSize = new System.Drawing.Size(10 * 65, 10 * 60);
            label1.Text = "Simulation";
            lblImpasse.ForeColor = Color.Red;
            lblImpasse.Visible = false;
            btnPause.Visible = false;
            pas = 1;
        }

        void démarreTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }

        void initialiserPlateau()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    echecB[i, j] = new BoutonPlateau(i, j);
                    echecB[i, j].Click += new System.EventHandler(this.commencerPartie);
                    Controls.Add(echecB[i, j]);
                }
            }
        }

        void réinitialisePlateau()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    echecB[i, j].Text = "";
                }
            }
        }

        private void paramétrage()
        {
            int tpsPause;

            if (numericUpDown1.Value <= 0)
            {
                tpsPause = 1;
                numericUpDown1.Value = 1;
            }
            else
            {
                tpsPause = (int)numericUpDown1.Value;
            }
            timer.Interval = 1000 * tpsPause;

            if (rb1.Checked)
                pas = 1;
            else if (rb5.Checked)
                pas = 5;
            else
                pas = 64;
        }

        private void commencerPartie(object sender, EventArgs e)
        {
            désactiveBoutons();
            activerBtnPause();
            btnAléatoire.Enabled = false;
            btnRejouer.Visible = false;

            paramétrage();

            euler = new Euler(echecB, pas);

            if(sender is BoutonPlateau)
            {
                BoutonPlateau btn = (BoutonPlateau)sender;
                euler.initialisationManuelle(btn.getLigne(), btn.getColonne());
            }
            else
            {
                euler.initialisationAleatoire();
            }
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            euler.tour();

            if (euler.estPartieFinie())
            {
                timer.Enabled = false;
                btnNouvellePartie.Enabled = true;
                btnRejouer.Visible = true;
                btnRejouer.Enabled = true;
                btnPause.Visible = false;
                if (euler.termineSurUneImpasse())
                {
                    lblImpasse.Visible = true;
                }
            }
        }

        private void rejouer(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
            }
            lblImpasse.Visible = false;
            paramétrage();
            activerBtnPause();
            réinitialisePlateau();
            euler.rejouer();
            timer.Enabled = true;
        }

        private void nouvellePartie(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
            }
            lblImpasse.Visible = false;
            btnPause.Visible = false;
            btnRejouer.Visible = false;
            réinitialisePlateau();
            activeBoutons();
            btnAléatoire.Enabled = true;
        }

        private void pause(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                btnPause.Text = "Reprendre";
            }
            else
            {
                timer.Enabled = true;
                btnPause.Text = "Pause";
            }
        }

        private void activerBtnPause()
        {
            btnPause.Visible = true;
            btnPause.Enabled = true;
            btnPause.Text = "Pause";
        }

        void activeBoutons()
        {
            for(int i = 2; i < 10; i++)
            {
                for(int j = 2; j < 10; j++)
                {
                    echecB[i, j].Enabled = true;
                }
            }
        }

        void désactiveBoutons()
        {
            for(int i = 2; i < 10; i++)
            {
                for(int j = 2; j < 10; j++)
                {
                    echecB[i, j].Enabled = false;
                }
            }
        }

        private void règleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void commentçaMarcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aide f5 = new Aide("simulation");
            f5.ShowDialog();
        }
    }
}
