using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier_V1
{
    public partial class Aide : Form
    {
        String type; 

        public Aide(String type)
        {
            this.type = type;
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void Aide_Load(object sender, EventArgs e)
        {
            if (type == "simulation")
                label2.Visible = false;
            else if (type == "jouer")
                label1.Visible = false;
            this.Text = "Aide";
        }
    }
}
