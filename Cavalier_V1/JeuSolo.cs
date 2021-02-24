using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier_V1
{
    class JeuSolo
    {
        static int[,] echec = new int[12, 12];
        static BoutonPlateau[,] echecB = new BoutonPlateau[12, 12];
        static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int caseDéparti, caseDépartj;
        static int caseActuellei, caseActuellej;
        static int avancement;
        static bool impasse;
        static BoutonPlateau[] historique;


        public JeuSolo(BoutonPlateau[,] btn)
        {
            echecB = btn;
            avancement = 0;
            impasse = false;
            historique = new BoutonPlateau[64];
        }


        public void initialiserGrille()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    echec[i, j] = ((i < 2 | i > 9 | j < 2 | j > 9) ? -1 : 0);
                }
            }
        }

        public void actualiserPlateau()
        {
            for (int i = 0; i < avancement; i++)
            {
                historique[i].Image = Image.FromFile(@"Image\chess_black_knight.png");
            }
        }

        static int fuite(int i, int j)
        {
            int n, l;

            for (l = 0, n = 8; l < 8; l++)
                if (echec[i + depi[l], j + depj[l]] != 0) n--;

            return (n == 0) ? 9 : n;
        }


        private void débutPartie()
        {
            impasse = false;
            effacerImage();

            afficherFuite();
            actualiserPlateau();
        }

        public bool termineSurUneImpasse()
        {
            return impasse;
        }

        public void jouer(BoutonPlateau btn)
        {

            historique[avancement] = btn;
            ++avancement;
            débutPartie();
        }

        public void afficherFuite()
        {
            int cpt = 0;
            for (int i = 0; i < depi.Length; i++)
            {
                int fuitei = historique[avancement - 1].getLigne() + depi[i];
                int fuitej = historique[avancement - 1].getColonne() + depj[i];
                if (fuitei >= 2 && fuitei < 10 && fuitej >= 2 && fuitej < 10)
                {
                    bool présent = false;
                    //foreach(BoutonPlateau btn in historique)
                    for (int j = 0; j < avancement; j++)
                    {
                        if (echecB[fuitei, fuitej].Equals(historique[j]))
                        {
                            présent = true;
                            break;
                        }
                    }
                    if (!présent)
                    {
                        echecB[fuitei, fuitej].Enabled = true;
                        echecB[fuitei, fuitej].Image = Image.FromFile(@"Image\chess_black_knight.png");
                        ++cpt;
                    }
                }
            }
            if (cpt == 0)
                impasse = true;
        }

        public BoutonPlateau getCaseDépart()
        {
            return historique[0];
        }

        public void marcheArriere()
        {
            if (avancement > 0)
            --avancement;
            débutPartie();

        }

        public int getAvancement()
        {
            return avancement;
        }

        public void effacerImage()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    echecB[i, j].Image = null;
                }
            }
        }
    }
}
