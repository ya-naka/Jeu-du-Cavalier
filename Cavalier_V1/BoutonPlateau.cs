using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier_V1
{
    class BoutonPlateau : Button
    {
        int ligne, colonne;

        public BoutonPlateau(int ligne, int colonne)
        {
            this.ligne = ligne;
            this.colonne = colonne;
            this.Location = new System.Drawing.Point(ligne * 45, colonne * 45);
            this.Size = new System.Drawing.Size(45, 45);
            this.Font = new Font(this.Font.FontFamily, 10);

            if ((ligne % 2 == 0 && colonne % 2 == 1) || (ligne % 2 == 1 && colonne % 2 == 0))
            {
                this.BackColor = Color.FromArgb(255, 255, 212);
            }
            else
            {
                this.BackColor = Color.FromArgb(222, 184, 135);
            }
        }

        public int getLigne()
        {
            return this.ligne;
        }

        public int getColonne()
        {
            return this.colonne;
        }
    }
}
