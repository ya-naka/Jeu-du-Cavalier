using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier_V1
{
    class Euler
    {
        static int[,] echec = new int[12, 12];
        static Button[,] echecB = new Button[12, 12];
        static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int caseDéparti, caseDépartj;
        static int caseActuellei, caseActuellej;
        static int avancement, pas;
        static bool impasse;

        public Euler(Button[,] btn, int enjambée)
        {
            echecB = btn;
            pas = enjambée;
            initialiserGrille();
            avancement = 0;
            impasse = false;
        }

        public void tour()
        {
            int nb_fuite, min_fuite, lmin_fuite = 0;
            int caseSuivantei, caseSuivantej, l;

            for (int k = avancement; k < avancement + pas && k <= 64; k++)
            {
                for (l = 0, min_fuite = 11; l < 8; l++)
                {
                    caseSuivantei = caseActuellei + depi[l]; caseSuivantej = caseActuellej + depj[l];

                    nb_fuite = ((echec[caseSuivantei, caseSuivantej] != 0) ? 10 : fuite(caseSuivantei, caseSuivantej));

                    if (nb_fuite < min_fuite)
                    {
                        min_fuite = nb_fuite; lmin_fuite = l;
                    }
                }
                if (min_fuite == 9 & k != 64)
                {
                    impasse = true;
                    break;
                }
                caseActuellei += depi[lmin_fuite]; caseActuellej += depj[lmin_fuite];
                echec[caseActuellei, caseActuellej] = k;
            }

            actualiserPlateau();

            avancement += pas;
        }

        public bool termineSurUneImpasse()
        {
            return impasse;
        }

        public bool estPartieFinie()
        {
            return avancement >= 64;
        }

        static int fuite(int i, int j)
        {
            int n, l;

            for (l = 0, n = 8; l < 8; l++)
                if (echec[i + depi[l], j + depj[l]] != 0) n--;

            return (n == 0) ? 9 : n;
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
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    if (echec[i, j] >= avancement)
                    {
                        echecB[i, j].Text = "" + echec[i, j] + " ";
                        echecB[i, j].Enabled = false;
                    }
                }
            }
        }

        private void débutPartie()
        {
            impasse = false;
            echec[caseDéparti, caseDépartj] = 1;
            caseActuellei = caseDéparti; caseActuellej = caseDépartj;
            actualiserPlateau();
            ++avancement;
        }

        public void initialisationAleatoire()
        {
            avancement = 1;
            Random random = new Random();
            caseDéparti = random.Next(1, 8) + 1;
            caseDépartj = random.Next(1, 8) + 1;
            débutPartie();
        }

        public void initialisationManuelle(int ligne, int colonne)
        {
            avancement = 1;
            caseDéparti = ligne;
            caseDépartj = colonne;
            débutPartie();
        }

        public void rejouer()
        {
            initialiserGrille();
            initialisationManuelle(caseDéparti, caseDépartj);
        }
    }
}
